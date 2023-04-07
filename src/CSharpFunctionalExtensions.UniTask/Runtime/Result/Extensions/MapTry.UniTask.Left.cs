using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
        /// <summary>
        ///     Creates a new result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        public static async UniTask<Result<K, E>> MapTry<T, K, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, K> valueUniTask,
            Func<Exception, E> errorHandler)
        {
            Result<T, E> result = await resultUniTask;
            return result.MapTry(valueUniTask, errorHandler);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        public static async UniTask<Result<K, E>> MapTry<K, E>(this UniTask<UnitResult<E>> resultUniTask, Func<K> valueUniTask,
            Func<Exception, E> errorHandler)
        {
            UnitResult<E> result = await resultUniTask;
            return result.MapTry(valueUniTask, errorHandler);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        public static async UniTask<Result<K>> MapTry<T, K>(this UniTask<Result<T>> resultUniTask, Func<T, K> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            Result<T> result = await resultUniTask;
            return result.MapTry(valueUniTask, errorHandler);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        public static async UniTask<Result<K>> MapTry<K>(this UniTask<Result> resultUniTask, Func<K> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            Result result = await resultUniTask;
            return result.MapTry(valueUniTask, errorHandler);
        }
    }
}
