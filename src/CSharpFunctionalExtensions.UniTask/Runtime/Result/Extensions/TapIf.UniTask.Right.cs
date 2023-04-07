using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result> TapIf(this Result result, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapIf<T>(this Result<T> result, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapIf<T>(this Result<T> result, bool condition, Func<T, UniTask> valueUniTask)
        {
            if (condition)
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapIf<T, E>(this Result<T, E> result, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapIf<T, E>(this Result<T, E> result, bool condition, Func<T, UniTask> valueUniTask)
        {
            if (condition)
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapIf<E>(this UnitResult<E> result, bool condition, Func<UniTask> valueUniTask)
        {
            if (condition)
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapIf<T>(this Result<T> result, Func<T, bool> predicate, Func<UniTask> valueUniTask)
        {
            if (result.IsSuccess && predicate(result.Value))
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T>> TapIf<T>(this Result<T> result, Func<T, bool> predicate, Func<T, UniTask> valueUniTask)
        {
            if (result.IsSuccess && predicate(result.Value))
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapIf<T, E>(this Result<T, E> result, Func<T, bool> predicate, Func<UniTask> valueUniTask)
        {
            if (result.IsSuccess && predicate(result.Value))
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<Result<T, E>> TapIf<T, E>(this Result<T, E> result, Func<T, bool> predicate, Func<T, UniTask> valueUniTask)
        {
            if (result.IsSuccess && predicate(result.Value))
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        /// <summary>
        ///     Executes the given action if the calling result is a success and condition is true. Returns the calling result.
        /// </summary>
        public static UniTask<UnitResult<E>> TapIf<E>(this UnitResult<E> result, Func<bool> predicate, Func<UniTask> valueUniTask)
        {
            if (result.IsSuccess && predicate())
                return result.Tap(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }
    }
}
