using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static class ResultUniTask
    {
        /// <summary>
        ///     Attempts to execute the supplied action. Returns a Result indicating whether the action executed successfully.
        /// </summary>
        public static async UniTask<Result> Try(Func<UniTask> action, Func<Exception, string> errorHandler = null)
        {
            errorHandler ??= Result.Configuration.DefaultTryErrorHandler;

            try
            {
                await action();
                return Result.Success();
            }
            catch (Exception exc)
            {
                string message = errorHandler(exc);
                return Result.Failure(message);
            }
        }
        
        /// <summary>
        ///     Attempts to execute the supplied function. Returns a Result indicating whether the function executed successfully.
        ///     If the function executed successfully, the result contains its return value.
        /// </summary>
        public static async UniTask<Result<T>> Try<T>(Func<UniTask<T>> func, Func<Exception, string> errorHandler = null)
        {
            errorHandler ??= Result.Configuration.DefaultTryErrorHandler;

            try
            {
                var result = await func();
                return Result.Success(result);
            }
            catch (Exception exc)
            {
                string message = errorHandler(exc);
                return Result.Failure<T>(message);
            }
        }
        
        /// <summary>
        ///     Attempts to execute the supplied function. Returns a Result indicating whether the function executed successfully.
        ///     If the function executed successfully, the result contains its return value.
        /// </summary>
        public static async UniTask<Result<T, E>> Try<T, E>(Func<UniTask<T>> func, Func<Exception, E> errorHandler)
        {
            try
            {
                var result = await func();
                return Result.Success<T, E>(result);
            }
            catch (Exception exc)
            {
                E error = errorHandler(exc);
                return Result.Failure<T, E>(error);
            }
        }
        
    }
}
