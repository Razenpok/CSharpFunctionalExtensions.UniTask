using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result> MapError(this UniTask<Result> resultUniTask, Func<string, string> errorFactory)
        {
            var result = await resultUniTask;
            if (result.IsSuccess)
            {
                return Result.Success();
            }

            var error = errorFactory(result.Error);
            return Result.Failure(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<UnitResult<E>> MapError<E>(this UniTask<Result> resultUniTask, Func<string, E> errorFactory)
        {
            var result = await resultUniTask;
            if (result.IsSuccess)
            {
                return UnitResult.Success<E>();
            }

            var error = errorFactory(result.Error);
            return UnitResult.Failure(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T>> MapError<T>(this UniTask<Result<T>> resultUniTask, Func<string, string> errorFactory)
        {
            var result = await resultUniTask;
            if (result.IsSuccess)
            {
                return Result.Success(result.Value);
            }

            var error = errorFactory(result.Error);
            return Result.Failure<T>(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T, E>> MapError<T, E>(this UniTask<Result<T>> resultUniTask, Func<string, E> errorFactory)
        {
            var result = await resultUniTask;
            if (result.IsSuccess)
            {
                return Result.Success<T, E>(result.Value);
            }

            var error = errorFactory(result.Error);
            return Result.Failure<T, E>(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result> MapError<E>(this UniTask<UnitResult<E>> resultUniTask, Func<E, string> errorFactory)
        {
            var result = await resultUniTask;
            if (result.IsSuccess)
            {
                return Result.Success();
            }

            var error = errorFactory(result.Error);
            return Result.Failure(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<UnitResult<E2>> MapError<E, E2>(this UniTask<UnitResult<E>> resultUniTask, Func<E, E2> errorFactory)
        {
            var result = await resultUniTask;
            if (result.IsSuccess)
            {
                return UnitResult.Success<E2>();
            }

            var error = errorFactory(result.Error);
            return UnitResult.Failure(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T>> MapError<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<E, string> errorFactory)
        {
            var result = await resultUniTask;
            if (result.IsSuccess)
            {
                return Result.Success(result.Value);
            }

            var error = errorFactory(result.Error);
            return Result.Failure<T>(error);
        }

        /// <summary>
        ///     If the calling Result is a success, a new success result is returned. Otherwise, creates a new failure result from the return value of a given valueUniTask action.
        /// </summary>
        public static async UniTask<Result<T, E2>> MapError<T, E, E2>(this UniTask<Result<T, E>> resultUniTask, Func<E, E2> errorFactory)
        {
            var result = await resultUniTask;
            if (result.IsSuccess)
            {
                return Result.Success<T, E2>(result.Value);
            }

            var error = errorFactory(result.Error);
            return Result.Failure<T, E2>(error);
        }
    }
}
