using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this Result<T> result, Func<T, UniTask<bool>> predicate, string errorMessage)
        {
            if (result.IsFailure)
                return result;

            if (!await predicate(result.Value))
                return Result.Failure<T>(errorMessage);

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T, E>> Ensure<T, E>(this Result<T, E> result,
            Func<T, UniTask<bool>> predicate, E error)
        {
            if (result.IsFailure)
                return result;

            if (!await predicate(result.Value))
                return Result.Failure<T, E>(error);

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T, E>> Ensure<T, E>(this Result<T, E> result,
            Func<T, UniTask<bool>> predicate, Func<T, E> errorPredicate)
        {
            if (result.IsFailure)
                return result;

            if (!await predicate(result.Value))
                return Result.Failure<T, E>(errorPredicate(result.Value));

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T, E>> Ensure<T, E>(this Result<T, E> result,
            Func<T, UniTask<bool>> predicate, Func<T, UniTask<E>> errorPredicate)
        {
            if (result.IsFailure)
                return result;

            if (!await predicate(result.Value))
                return Result.Failure<T, E>(await errorPredicate(result.Value));

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this Result<T> result, Func<T, UniTask<bool>> predicate, Func<T, string> errorPredicate)
        {
            if (result.IsFailure)
                return result;

            if (!await predicate(result.Value))
                return Result.Failure<T>(errorPredicate(result.Value));

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this Result<T> result, Func<T, UniTask<bool>> predicate, Func<T, UniTask<string>> errorPredicate)
        {
            if (result.IsFailure)
                return result;

            if (!await predicate(result.Value))
                return Result.Failure<T>(await errorPredicate(result.Value));

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result> Ensure(this Result result, Func<UniTask<bool>> predicate, string errorMessage)
        {
            if (result.IsFailure)
                return result;

            if (!await predicate())
                return Result.Failure(errorMessage);

            return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result> Ensure(this Result result, Func<UniTask<Result>> predicate)
        {
          if (result.IsFailure)
            return result;

          var predicateResult = await predicate();
          
          if (predicateResult.IsFailure)
            return Result.Failure(predicateResult.Error);

          return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this Result<T> result, Func<UniTask<Result>> predicate)
        {
          if (result.IsFailure)
            return result;

          var predicateResult = await predicate();
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);

          return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result> Ensure<T>(this Result result, Func<UniTask<Result<T>>> predicate)
        {
          if (result.IsFailure)
            return result;

          var predicateResult = await predicate();
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);

          return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this Result<T> result, Func<UniTask<Result<T>>> predicate)
        {
          if (result.IsFailure)
            return result;

          var predicateResult = await predicate();
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);

          return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this Result<T> result, Func<T,UniTask<Result>> predicate)
        {
          if (result.IsFailure)
            return result;

          var predicateResult = await predicate(result.Value);
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);

          return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this Result<T> result, Func<T,UniTask<Result<T>>> predicate)
        {
          if (result.IsFailure)
            return result;

          var predicateResult = await predicate(result.Value);
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);

          return result;
        }
    }
}
