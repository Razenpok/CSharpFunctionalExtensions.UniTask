using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> Tap(this Result result, Func<UniTask> valueUniTask)
        {
            if (result.IsSuccess)
                await valueUniTask();

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> Tap<T>(this Result<T> result, Func<UniTask> valueUniTask)
        {
            if (result.IsSuccess)
                await valueUniTask();

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> Tap<T>(this Result<T> result, Func<T, UniTask> valueUniTask)
        {
            if (result.IsSuccess)
                await valueUniTask(result.Value);

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> Tap<E>(this UnitResult<E> result, Func<UniTask> valueUniTask)
        {
            if (result.IsSuccess)
                await valueUniTask();

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> Tap<T, E>(this Result<T, E> result, Func<UniTask> valueUniTask)
        {
            if (result.IsSuccess)
                await valueUniTask();

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> Tap<T, E>(this Result<T, E> result, Func<T, UniTask> valueUniTask)
        {
            if (result.IsSuccess)
                await valueUniTask(result.Value);

            return result;
        }
    }
}
