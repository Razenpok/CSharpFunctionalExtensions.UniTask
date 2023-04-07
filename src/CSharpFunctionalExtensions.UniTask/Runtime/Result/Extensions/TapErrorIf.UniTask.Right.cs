using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapErrorIf(this Result result, bool condition, Func<UniTask> func)
        {
            if (condition)
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapErrorIf(this Result result, bool condition, Func<string, UniTask> func)
        {
            if (condition)
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapErrorIf<T>(this Result<T> result, bool condition, Func<UniTask> func)
        {
            if (condition)
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapErrorIf<T>(this Result<T> result, bool condition, Func<string, UniTask> func)
        {
            if (condition)
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapErrorIf<T, E>(this Result<T, E> result, bool condition, Func<UniTask> func)
        {
            if (condition)
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapErrorIf<T, E>(this Result<T, E> result, bool condition, Func<E, UniTask> func)
        {
            if (condition)
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapErrorIf<E>(this UnitResult<E> result, bool condition, Func<UniTask> func)
        {
            if (condition)
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapErrorIf<E>(this UnitResult<E> result, bool condition, Func<E, UniTask> func)
        {
            if (condition)
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapErrorIf(this Result result, Func<string, bool> predicate, Func<UniTask> func)
        {
            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapErrorIf(this Result result, Func<string, bool> predicate, Func<string, UniTask> func)
        {
            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapErrorIf<T>(this Result<T> result, Func<string, bool> predicate, Func<UniTask> func)
        {
            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapErrorIf<T>(this Result<T> result, Func<string, bool> predicate, Func<string, UniTask> func)
        {
            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapErrorIf<T, E>(this Result<T, E> result, Func<E, bool> predicate, Func<UniTask> func)
        {
            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapErrorIf<T, E>(this Result<T, E> result, Func<E, bool> predicate, Func<E, UniTask> func)
        {
            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapErrorIf<E>(this UnitResult<E> result, Func<E, bool> predicate, Func<UniTask> func)
        {
            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapErrorIf<E>(this UnitResult<E> result, Func<E, bool> predicate, Func<E, UniTask> func)
        {
            if (result.IsFailure && predicate(result.Error))
            {
                return result.TapError(func);
            }

            return result.AsCompletedUniTask();
        }
    }
}
