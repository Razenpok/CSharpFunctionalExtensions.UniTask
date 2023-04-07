using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result> MapError(this UniTask<Result> resultUniTask, Func<string, UniTask<string>> errorFactory)
        {
            var result = await resultUniTask;
            return await result.MapError(errorFactory);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<UnitResult<E>> MapError<E>(this UniTask<Result> resultUniTask, Func<string, UniTask<E>> errorFactory)
        {
            var result = await resultUniTask;
            return await result.MapError(errorFactory);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T>> MapError<T>(this UniTask<Result<T>> resultUniTask, Func<string, UniTask<string>> errorFactory)
        {
            var result = await resultUniTask;
            return await result.MapError(errorFactory);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T, E>> MapError<T, E>(this UniTask<Result<T>> resultUniTask, Func<string, UniTask<E>> errorFactory)
        {
            var result = await resultUniTask;
            return await result.MapError(errorFactory);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result> MapError<E>(this UniTask<UnitResult<E>> resultUniTask, Func<E, UniTask<string>> errorFactory)
        {
            var result = await resultUniTask;
            return await result.MapError(errorFactory);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<UnitResult<E2>> MapError<E, E2>(this UniTask<UnitResult<E>> resultUniTask, Func<E, UniTask<E2>> errorFactory)
        {
            var result = await resultUniTask;
            return await result.MapError(errorFactory);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T>> MapError<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<E, UniTask<string>> errorFactory)
        {
            var result = await resultUniTask;
            return await result.MapError(errorFactory);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T, E2>> MapError<T, E, E2>(this UniTask<Result<T, E>> resultUniTask, Func<E, UniTask<E2>> errorFactory)
        {
            var result = await resultUniTask;
            return await result.MapError(errorFactory);
        }
    }
}
