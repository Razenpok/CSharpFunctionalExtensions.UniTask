using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapError<T>(this Result<T> result, Func<UniTask> valueUniTask)
        {
            if (result.IsFailure)
            {
                await valueUniTask();
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapError<T, E>(this Result<T, E> result, Func<UniTask> valueUniTask)
        {
            if (result.IsFailure)
            {
                await valueUniTask();
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapError(this Result result, Func<UniTask> valueUniTask)
        {
            if (result.IsFailure)
            {
                await valueUniTask();
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapError(this Result result, Func<string, UniTask> valueUniTask)
        {
            if (result.IsFailure)
            {
                await valueUniTask(result.Error);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapError<E>(this UnitResult<E> result, Func<UniTask> valueUniTask)
        {
            if (result.IsFailure)
            {
                await valueUniTask();
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapError<E>(this UnitResult<E> result, Func<E, UniTask> valueUniTask)
        {
            if (result.IsFailure)
            {
                await valueUniTask(result.Error);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapError<T>(this Result<T> result, Func<string, UniTask> valueUniTask)
        {
            if (result.IsFailure)
            {
                await valueUniTask(result.Error);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapError<T, E>(this Result<T, E> result, Func<E, UniTask> valueUniTask)
        {
            if (result.IsFailure)
            {
                await valueUniTask(result.Error);
            }

            return result;
        }
    }
}
