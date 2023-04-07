using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapError<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<UniTask> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure)
            {
                await valueUniTask();
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapError<T>(this UniTask<Result<T>> resultUniTask, Func<UniTask> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
            {
                await valueUniTask();
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapError(this UniTask<Result> resultUniTask, Func<UniTask> valueUniTask)
        {
            Result result = await resultUniTask;

            if (result.IsFailure)
            {
                await valueUniTask();
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapError(this UniTask<Result> resultUniTask, Func<string, UniTask> valueUniTask)
        {
            Result result = await resultUniTask;

            if (result.IsFailure)
            {
                await valueUniTask(result.Error);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapError<E>(this UniTask<UnitResult<E>> resultUniTask, Func<E, UniTask> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsFailure)
            {
                await valueUniTask(result.Error);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapError<E>(this UniTask<UnitResult<E>> resultUniTask, Func<UniTask> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsFailure)
            {
                await valueUniTask();
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapError<T>(this UniTask<Result<T>> resultUniTask, Func<string, UniTask> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
            {
                await valueUniTask(result.Error);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapError<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<E, UniTask> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure)
            {
                await valueUniTask(result.Error);
            }

            return result;
        }
    }
}
