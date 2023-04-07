using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapErrorIf(this UniTask<Result> resultUniTask, bool condition, Action action)
        {
            if (condition)
            {
                return resultUniTask.TapError(action);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapErrorIf(this UniTask<Result> resultUniTask, bool condition, Action<string> action)
        {
            if (condition)
            {
                return resultUniTask.TapError(action);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapErrorIf<T>(this UniTask<Result<T>> resultUniTask, bool condition, Action action)
        {
            if (condition)
            {
                return resultUniTask.TapError(action);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapErrorIf<T>(this UniTask<Result<T>> resultUniTask, bool condition, Action<string> action)
        {
            if (condition)
            {
                return resultUniTask.TapError(action);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapErrorIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition, Action action)
        {
            if (condition)
            {
                return resultUniTask.TapError(action);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapErrorIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition, Action<E> action)
        {
            if (condition)
            {
                return resultUniTask.TapError(action);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapErrorIf<E>(this UniTask<UnitResult<E>> resultUniTask, bool condition, Action action)
        {
            if (condition)
            {
                return resultUniTask.TapError(action);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapErrorIf<E>(this UniTask<UnitResult<E>> resultUniTask, bool condition, Action<E> action)
        {
            if (condition)
            {
                return resultUniTask.TapError(action);
            }

            return resultUniTask;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapErrorIf(this UniTask<Result> resultUniTask, Func<string, bool> predicate, Action action)
        {
            Result result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(action);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapErrorIf(this UniTask<Result> resultUniTask, Func<string, bool> predicate, Action<string> action)
        {
            Result result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(action);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapErrorIf<T>(this UniTask<Result<T>> resultUniTask, Func<string, bool> predicate, Action action)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(action);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapErrorIf<T>(this UniTask<Result<T>> resultUniTask, Func<string, bool> predicate, Action<string> action)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(action);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapErrorIf<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<E, bool> predicate, Action action)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(action);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapErrorIf<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<E, bool> predicate, Action<E> action)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(action);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapErrorIf<E>(this UniTask<UnitResult<E>> resultUniTask, Func<E, bool> predicate, Action action)
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(action);
            }

            return result;
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapErrorIf<E>(this UniTask<UnitResult<E>> resultUniTask, Func<E, bool> predicate, Action<E> action)
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(action);
            }

            return result;
        }
    }
}
