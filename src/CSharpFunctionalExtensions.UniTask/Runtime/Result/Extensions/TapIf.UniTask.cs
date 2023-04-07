using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsBothOperands
    {
        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapIf(this UniTask<Result> resultUniTask, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
                return resultUniTask.Tap(valueUniTask);
            else
                return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapIf<T>(this UniTask<Result<T>> resultUniTask, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
                return resultUniTask.Tap(valueUniTask);
            else
                return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapIf<T>(this UniTask<Result<T>> resultUniTask, bool condition, Func<T, UniTask> valueUniTask)
        {
            if (condition)
                return resultUniTask.Tap(valueUniTask);
            else
                return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
                return resultUniTask.Tap(valueUniTask);
            else
                return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition, Func<T, UniTask> valueUniTask)
        {
            if (condition)
                return resultUniTask.Tap(valueUniTask);
            else
                return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapIf<E>(this UniTask<UnitResult<E>> resultUniTask, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
                return resultUniTask.Tap(valueUniTask);
            else
                return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapIf<T>(this UniTask<Result<T>> resultUniTask, Func<T, bool> predicate, Func<UniTask> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsSuccess && predicate(result.Value))
                return await result.Tap(valueUniTask);
            else
                return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapIf<T>(this UniTask<Result<T>> resultUniTask, Func<T, bool> predicate, Func<T, UniTask> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsSuccess && predicate(result.Value))
                return await result.Tap(valueUniTask);
            else
                return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapIf<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, bool> predicate, Func<UniTask> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsSuccess && predicate(result.Value))
                return await result.Tap(valueUniTask);
            else
                return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapIf<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, bool> predicate, Func<T, UniTask> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsSuccess && predicate(result.Value))
                return await result.Tap(valueUniTask);
            else
                return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapIf<E>(this UniTask<UnitResult<E>> resultUniTask, Func<bool> predicate, Func<UniTask> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsSuccess && predicate())
                return await result.Tap(valueUniTask);
            else
                return result;
        }
    }
}
