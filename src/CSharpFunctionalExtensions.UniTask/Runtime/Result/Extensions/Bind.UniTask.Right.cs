using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static UniTask<Result<K, E>> Bind<T, K, E>(this Result<T, E> result, Func<T, UniTask<Result<K, E>>> valueUniTask)
        {
            if (result.IsFailure)
                return Result.Failure<K, E>(result.Error).AsCompletedUniTask();

            return valueUniTask(result.Value);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static UniTask<Result<K>> Bind<T, K>(this Result<T> result, Func<T, UniTask<Result<K>>> valueUniTask)
        {
            if (result.IsFailure)
                return Result.Failure<K>(result.Error).AsCompletedUniTask();

            return valueUniTask(result.Value);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static UniTask<Result<K>> Bind<K>(this Result result, Func<UniTask<Result<K>>> valueUniTask)
        {
            if (result.IsFailure)
                return Result.Failure<K>(result.Error).AsCompletedUniTask();

            return valueUniTask();
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static UniTask<Result> Bind<T>(this Result<T> result, Func<T, UniTask<Result>> valueUniTask)
        {
            if (result.IsFailure)
                return Result.Failure(result.Error).AsCompletedUniTask();

            return valueUniTask(result.Value);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static UniTask<Result> Bind(this Result result, Func<UniTask<Result>> valueUniTask)
        {
            if (result.IsFailure)
                return result.AsCompletedUniTask();

            return valueUniTask();
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static UniTask<UnitResult<E>> Bind<E>(this UnitResult<E> result, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            if (result.IsFailure)
                return UnitResult.Failure(result.Error).AsCompletedUniTask();

            return valueUniTask();
        }
        
        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static UniTask<Result<T, E>> Bind<T, E>(this UnitResult<E> result, Func<UniTask<Result<T, E>>> valueUniTask)
        {
            if (result.IsFailure)
                return Result.Failure<T, E>(result.Error).AsCompletedUniTask();

            return valueUniTask();
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static UniTask<UnitResult<E>> Bind<T, E>(this Result<T, E> result, Func<T, UniTask<UnitResult<E>>> valueUniTask)
        {
            if (result.IsFailure)
                return UnitResult.Failure(result.Error).AsCompletedUniTask();

            return valueUniTask(result.Value);
        }
    }
}
