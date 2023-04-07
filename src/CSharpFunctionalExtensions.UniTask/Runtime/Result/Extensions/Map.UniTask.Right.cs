using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K, E>> Map<T, K, E>(this Result<T, E> result, Func<T, UniTask<K>> valueUniTask)
        {
            if (result.IsFailure)
                return Result.Failure<K, E>(result.Error);

            K value = await valueUniTask(result.Value);

            return Result.Success<K, E>(value);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K, E>> Map<K, E>(this UnitResult<E> result, Func<UniTask<K>> valueUniTask) 
        {
            if (result.IsFailure)
                return Result.Failure<K, E>(result.Error);

            K value = await valueUniTask();

            return Result.Success<K, E>(value);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Map<T, K>(this Result<T> result, Func<T, UniTask<K>> valueUniTask)
        {
            if (result.IsFailure)
                return Result.Failure<K>(result.Error);

            K value = await valueUniTask(result.Value);

            return Result.Success(value);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Map<T, K>(this Result<T> result, Func<T, UniTask<Result<K>>> valueUniTask)
        {
            if (result.IsFailure)
                return Result.Failure<K>(result.Error);

            Result<K> value = await valueUniTask(result.Value);
            return value;
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Map<K>(this Result result, Func<UniTask<K>> valueUniTask)
        {
            if (result.IsFailure)
                return Result.Failure<K>(result.Error);

            K value = await valueUniTask();

            return Result.Success(value);
        }
    }
}
