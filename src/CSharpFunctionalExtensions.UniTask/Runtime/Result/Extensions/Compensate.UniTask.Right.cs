using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static UniTask<Result> Compensate(this Result result, Func<string, UniTask<Result>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return Result.Success().AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }

        public static UniTask<UnitResult<E>> Compensate<E>(this Result result, Func<string, UniTask<UnitResult<E>>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return UnitResult.Success<E>().AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }

        public static UniTask<Result> Compensate<T>(this Result<T> result, Func<string, UniTask<Result>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return Result.Success().AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }

        public static UniTask<Result<T>> Compensate<T>(this Result<T> result, Func<string, UniTask<Result<T>>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return Result.Success(result.Value).AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }

        public static UniTask<Result<T, E>> Compensate<T, E>(this Result<T> result, Func<string, UniTask<Result<T, E>>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return Result.Success<T, E>(result.Value).AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }

        public static UniTask<Result> Compensate<E>(this UnitResult<E> result, Func<E, UniTask<Result>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return Result.Success().AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }

        public static UniTask<UnitResult<E2>> Compensate<E, E2>(this UnitResult<E> result, Func<E, UniTask<UnitResult<E2>>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return UnitResult.Success<E2>().AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }

        public static UniTask<Result> Compensate<T, E>(this Result<T, E> result, Func<E, UniTask<Result>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return Result.Success().AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }

        public static UniTask<UnitResult<E2>> Compensate<T, E, E2>(this Result<T, E> result, Func<E, UniTask<UnitResult<E2>>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return UnitResult.Success<E2>().AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }

        public static UniTask<Result<T, E2>> Compensate<T, E, E2>(this Result<T, E> result, Func<E, UniTask<Result<T, E2>>> valueUniTask)
        {
            if (result.IsSuccess)
            {
                return Result.Success<T, E2>(result.Value).AsCompletedUniTask();
            }

            return valueUniTask(result.Error);
        }
    }
}
