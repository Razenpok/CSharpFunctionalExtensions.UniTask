using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsBothOperands
    {
        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K, E>> Map<T, K, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask<K>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure)
                return Result.Failure<K, E>(result.Error);

            K value = await valueUniTask(result.Value);

            return Result.Success<K, E>(value);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K, E>> Map<K, E>(this UniTask<UnitResult<E>> resultUniTask, Func<UniTask<K>> valueUniTask) 
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsFailure)
                return Result.Failure<K, E>(result.Error);

            K value = await valueUniTask();

            return Result.Success<K, E>(value);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Map<T, K>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask<K>> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
                return Result.Failure<K>(result.Error);

            K value = await valueUniTask(result.Value);

            return Result.Success(value);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Map<K>(this UniTask<Result> resultUniTask, Func<UniTask<K>> valueUniTask)
        {
            Result result = await resultUniTask;

            if (result.IsFailure)
                return Result.Failure<K>(result.Error);

            K value = await valueUniTask();

            return Result.Success(value);
        }
    }
}
