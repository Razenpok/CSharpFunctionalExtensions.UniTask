using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapErrorIf(this UniTask<Result> resultUniTask, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
            {
                return resultUniTask.TapError(valueUniTask);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapErrorIf(this UniTask<Result> resultUniTask, bool condition, Func<string, UniTask> valueUniTask)
        {
            if (condition)
            {
                return resultUniTask.TapError(valueUniTask);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapErrorIf<T>(this UniTask<Result<T>> resultUniTask, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
            {
                return resultUniTask.TapError(valueUniTask);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapErrorIf<T>(this UniTask<Result<T>> resultUniTask, bool condition, Func<string, UniTask> valueUniTask)
        {
            if (condition)
            {
                return resultUniTask.TapError(valueUniTask);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapErrorIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
            {
                return resultUniTask.TapError(valueUniTask);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapErrorIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition, Func<E, UniTask> valueUniTask)
        {
            if (condition)
            {
                return resultUniTask.TapError(valueUniTask);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapErrorIf<E>(this UniTask<UnitResult<E>> resultUniTask, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
            {
                return resultUniTask.TapError(valueUniTask);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapErrorIf<E>(this UniTask<UnitResult<E>> resultUniTask, bool condition, Func<E, UniTask> valueUniTask)
        {
            if (condition)
            {
                return resultUniTask.TapError(valueUniTask);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapErrorIf(this UniTask<Result> resultUniTask, Func<string, bool> predicate, Func<UniTask> valueUniTask)
        {
            Result result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return await result.TapError(valueUniTask);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapErrorIf(this UniTask<Result> resultUniTask, Func<string, bool> predicate, Func<string, UniTask> valueUniTask)
        {
            Result result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return await result.TapError(valueUniTask);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapErrorIf<T>(this UniTask<Result<T>> resultUniTask, Func<string, bool> predicate, Func<UniTask> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return await result.TapError(valueUniTask);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapErrorIf<T>(this UniTask<Result<T>> resultUniTask, Func<string, bool> predicate, Func<string, UniTask> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return await result.TapError(valueUniTask);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapErrorIf<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<E, bool> predicate, Func<UniTask> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return await result.TapError(valueUniTask);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapErrorIf<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<E, bool> predicate, Func<E, UniTask> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return await result.TapError(valueUniTask);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapErrorIf<E>(this UniTask<UnitResult<E>> resultUniTask, Func<E, bool> predicate, Func<UniTask> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return await result.TapError(valueUniTask);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapErrorIf<E>(this UniTask<UnitResult<E>> resultUniTask, Func<E, bool> predicate, Func<E, UniTask> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return await result.TapError(valueUniTask);
            }

            return result;
        }
    }
}
