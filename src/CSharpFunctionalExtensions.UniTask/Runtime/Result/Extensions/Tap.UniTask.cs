using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsBothOperands
    {
        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> Tap(this UniTask<Result> resultUniTask, Func<UniTask> valueUniTask)
        {
            Result result = await resultUniTask;

            if (result.IsSuccess)
                await valueUniTask();

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> Tap<T>(this UniTask<Result<T>> resultUniTask, Func<UniTask> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsSuccess)
                await valueUniTask();

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> Tap<T>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsSuccess)
                await valueUniTask(result.Value);

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> Tap<E>(this UniTask<UnitResult<E>> resultUniTask, Func<UniTask> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsSuccess)
                await valueUniTask();

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> Tap<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<UniTask> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsSuccess)
                await valueUniTask();

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> Tap<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsSuccess)
                await valueUniTask(result.Value);

            return result;
        }
    }
}
