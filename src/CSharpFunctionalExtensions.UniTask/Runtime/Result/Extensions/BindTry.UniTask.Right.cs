using Cysharp.Threading.Tasks;
using System;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        /// <typeparam name="T">Result Type parameter</typeparam>
        /// <typeparam name="K"><paramref name="valueUniTask" /> Result Type parameter</typeparam>
        /// <typeparam name="E">Error Type parameter</typeparam>
        /// <param name="result">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result<K, E>> BindTry<T, K, E>(this Result<T, E> result, Func<T, UniTask<Result<K, E>>> valueUniTask,
            Func<Exception, E> errorHandler)
        {
            return result.IsFailure
                ? Result.Failure<K, E>(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(result.Value),errorHandler).Bind(r => r);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        /// <typeparam name="T">Result Type parameter</typeparam>
        /// <typeparam name="K"><paramref name="valueUniTask" /> Result Type parameter</typeparam>        
        /// <param name="result">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result<K>> BindTry<T, K>(this Result<T> result, Func<T, UniTask<Result<K>>> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            return result.IsFailure
                ? Result.Failure<K>(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(result.Value), errorHandler).Bind(r => r);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>        
        /// <typeparam name="K"><paramref name="valueUniTask" /> Result Type parameter</typeparam>        
        /// <param name="result">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result<K>> BindTry<K>(this Result result, Func<UniTask<Result<K>>> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            return result.IsFailure
                ? Result.Failure<K>(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(), errorHandler).Bind(r => r);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        /// <typeparam name="T">Result Type parameter</typeparam>        
        /// <param name="result">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result> BindTry<T>(this Result<T> result, Func<T, UniTask<Result>> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            return result.IsFailure
                ? Result.Failure(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(result.Value), errorHandler).Bind(r => r);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>        
        /// <param name="result">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result> BindTry(this Result result, Func<UniTask<Result>> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            return result.IsFailure
                ? Result.Failure(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(), errorHandler).Bind(r => r);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>        
        /// <typeparam name="E">Error Type parameter</typeparam>
        /// <param name="result">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<UnitResult<E>> BindTry<E>(this UnitResult<E> result, Func<UniTask<UnitResult<E>>> valueUniTask,
            Func<Exception, E> errorHandler)
        {            
            return result.IsFailure
                ? UnitResult.Failure(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(), errorHandler).Bind(r => r);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        /// <typeparam name="T">Result Type parameter</typeparam>        
        /// <typeparam name="E">Error Type parameter</typeparam>
        /// <param name="result">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result<T, E>> BindTry<T, E>(this UnitResult<E> result, Func<UniTask<Result<T, E>>> valueUniTask,
            Func<Exception, E> errorHandler)
        {
            return result.IsFailure
                ? Result.Failure<T,E>(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(), errorHandler).Bind(r => r);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        /// <typeparam name="T">Result Type parameter</typeparam>        
        /// <typeparam name="E">Error Type parameter</typeparam>
        /// <param name="result">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<UnitResult<E>> BindTry<T, E>(this Result<T, E> result, Func<T, UniTask<UnitResult<E>>> valueUniTask,
            Func<Exception, E> errorHandler)
        {
            return result.IsFailure
                ? UnitResult.Failure(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(result.Value), errorHandler).Bind(r => r);           
        }
    }
}
