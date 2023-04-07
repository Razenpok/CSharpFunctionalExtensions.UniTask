using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapError<T>(this UniTask<Result<T>> resultUniTask, Action action)
        {
            Result<T> result = await resultUniTask;
            return result.TapError(action);
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapError(this UniTask<Result> resultUniTask, Action action)
        {
            Result result = await resultUniTask;
            return result.TapError(action);
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapError<T, E>(this UniTask<Result<T, E>> resultUniTask, Action action)
        {
            Result<T, E> result = await resultUniTask;
            return result.TapError(action);
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapError<E>(this UniTask<UnitResult<E>> resultUniTask, Action action)
        {
            UnitResult<E> result = await resultUniTask;
            return result.TapError(action);
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<UnitResult<E>> TapError<E>(this UniTask<UnitResult<E>> resultUniTask, Action<E> action)
        {
            UnitResult<E> result = await resultUniTask;
            return result.TapError(action);
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T>> TapError<T>(this UniTask<Result<T>> resultUniTask, Action<string> action)
        {
            Result<T> result = await resultUniTask;
            return result.TapError(action);
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result<T, E>> TapError<T, E>(this UniTask<Result<T, E>> resultUniTask, Action<E> action)
        {
            Result<T, E> result = await resultUniTask;
            return result.TapError(action);
        }

        /// <summary>
        ///     Executes the given action if the calling result is a failure. Returns the calling result.
        /// </summary>
        public static async UniTask<Result> TapError(this UniTask<Result> resultUniTask, Action<string> action)
        {
            Result result = await resultUniTask;
            return result.TapError(action);
        }
    }
}
