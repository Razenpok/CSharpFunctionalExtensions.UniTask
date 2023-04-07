using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        /// <summary>
        ///     Creates a new result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        public static async UniTask<Result<K, E>> MapTry<T, K, E>(this Result<T, E> result, Func<T, UniTask<K>> valueUniTask,
            Func<Exception, E> errorHandler)
        {
            return result.IsFailure
                ? Result.Failure<K, E>(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(result.Value), errorHandler);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        public static async UniTask<Result<K, E>> MapTry<K, E>(this UnitResult<E> result, Func<UniTask<K>> valueUniTask,
            Func<Exception, E> errorHandler)
        {
            return result.IsFailure
                ? Result.Failure<K, E>(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(), errorHandler);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        public static async UniTask<Result<K>> MapTry<T, K>(this Result<T> result, Func<T, UniTask<K>> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            return result.IsFailure
                ? Result.Failure<K>(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(result.Value), errorHandler);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        public static async UniTask<Result<K>> MapTry<K>(this Result result, Func<UniTask<K>> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            return result.IsFailure
                ? Result.Failure<K>(result.Error)
                : await ResultUniTask.Try(async () => await valueUniTask(), errorHandler);
        }
    }
}
