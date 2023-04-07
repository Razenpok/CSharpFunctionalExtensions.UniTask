using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result> MapError(this Result result, Func<string, UniTask<string>> errorFactory)
        {
            if (result.IsSuccess)
            {
                return Result.Success();
            }

            var error = await errorFactory(result.Error);
            return Result.Failure(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<UnitResult<E>> MapError<E>(this Result result, Func<string, UniTask<E>> errorFactory)
        {
            if (result.IsSuccess)
            {
                return UnitResult.Success<E>();
            }

            var error = await errorFactory(result.Error);
            return UnitResult.Failure(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T>> MapError<T>(this Result<T> result, Func<string, UniTask<string>> errorFactory)
        {
            if (result.IsSuccess)
            {
                return Result.Success(result.Value);
            }

            var error = await errorFactory(result.Error);
            return Result.Failure<T>(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T, E>> MapError<T, E>(this Result<T> result, Func<string, UniTask<E>> errorFactory)
        {
            if (result.IsSuccess)
            {
                return Result.Success<T, E>(result.Value);
            }

            var error = await errorFactory(result.Error);
            return Result.Failure<T, E>(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result> MapError<E>(this UnitResult<E> result, Func<E, UniTask<string>> errorFactory)
        {
            if (result.IsSuccess)
            {
                return Result.Success();
            }

            var error = await errorFactory(result.Error);
            return Result.Failure(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<UnitResult<E2>> MapError<E, E2>(this UnitResult<E> result, Func<E, UniTask<E2>> errorFactory)
        {
            if (result.IsSuccess)
            {
                return UnitResult.Success<E2>();
            }

            var error = await errorFactory(result.Error);
            return UnitResult.Failure(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T>> MapError<T, E>(this Result<T, E> result, Func<E, UniTask<string>> errorFactory)
        {
            if (result.IsSuccess)
            {
                return Result.Success(result.Value);
            }

            var error = await errorFactory(result.Error);
            return Result.Failure<T>(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T, E2>> MapError<T, E, E2>(this Result<T, E> result, Func<E, UniTask<E2>> errorFactory)
        {
            if (result.IsSuccess)
            {
                return Result.Success<T, E2>(result.Value);
            }

            var error = await errorFactory(result.Error);
            return Result.Failure<T, E2>(error);
        }
    }
}
