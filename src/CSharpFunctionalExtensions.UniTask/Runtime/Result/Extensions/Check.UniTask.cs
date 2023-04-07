using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsBothOperands
    {
        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<Result<T>> Check<T>(this UniTask<Result<T>> resultUniTask,
            Func<T, UniTask<Result>> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return await result.Bind(valueUniTask).Map(() => result.Value);
        }

        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<Result<T>> Check<T, K>(this UniTask<Result<T>> resultUniTask,
            Func<T, UniTask<Result<K>>> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return await result.Bind(valueUniTask).Map(_ => result.Value);
        }

        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<Result<T, E>> Check<T, K, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<T, UniTask<Result<K, E>>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return await result.Bind(valueUniTask).Map(_ => result.Value);
        }

        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<Result<T, E>> Check<T, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<T, UniTask<UnitResult<E>>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return await result.Bind(valueUniTask).Map(() => result.Value);
        }

        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<UnitResult<E>> Check<E>(this UniTask<UnitResult<E>> resultUniTask,
            Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;
            return await result.Bind(valueUniTask).Map(() => result);
        }
    }
}
