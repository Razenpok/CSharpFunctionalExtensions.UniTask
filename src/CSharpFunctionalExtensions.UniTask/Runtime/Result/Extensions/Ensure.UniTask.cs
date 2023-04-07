using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsBothOperands
    {
        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask<bool>> valueUniTaskPredicate, string errorMessage)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
                return result;

            if (!await valueUniTaskPredicate(result.Value))
                return Result.Failure<T>(errorMessage);

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T, E>> Ensure<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask<bool>> valueUniTaskPredicate, E error)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure)
                return result;

            if (!await valueUniTaskPredicate(result.Value))
                return Result.Failure<T, E>(error);

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T, E>> Ensure<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask<bool>> valueUniTaskPredicate, Func<T, E> valueUniTaskErrorPredicate)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure)
                return result;

            if (!await valueUniTaskPredicate(result.Value))
                return Result.Failure<T, E>(valueUniTaskErrorPredicate(result.Value));

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T, E>> Ensure<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask<bool>> valueUniTaskPredicate, Func<T, UniTask<E>> valueUniTaskErrorPredicate)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure)
                return result;

            if (!await valueUniTaskPredicate(result.Value))
                return Result.Failure<T, E>(await valueUniTaskErrorPredicate(result.Value));

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask<bool>> predicateUniTask, Func<T, string> valueUniTaskErrorPredicate)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
                return result;

            if (!await predicateUniTask(result.Value))
                return Result.Failure<T>(valueUniTaskErrorPredicate(result.Value));

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask<bool>> valueUniTaskPredicate, Func<T, UniTask<string>> valueUniTaskErrorPredicate)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
                return result;

            if (!await valueUniTaskPredicate(result.Value))
                return Result.Failure<T>(await valueUniTaskErrorPredicate(result.Value));

            return result;
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result> Ensure(this UniTask<Result> resultUniTask, Func<UniTask<bool>> valueUniTaskPredicate, string errorMessage)
        {
            Result result = await resultUniTask;

            if (result.IsFailure)
                return result;

            if (!await valueUniTaskPredicate())
                return Result.Failure(errorMessage);

            return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result> Ensure(this UniTask<Result> resultUniTask, Func<UniTask<Result>> valueUniTaskPredicate)
        {
          Result result = await resultUniTask;
          
          if (result.IsFailure)
            return result;

          var predicateResult = await valueUniTaskPredicate();
          
          if (predicateResult.IsFailure)
            return Result.Failure(predicateResult.Error);

          return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<UniTask<Result>> valueUniTaskPredicate)
        {
          Result<T> result = await resultUniTask;
          
          if (result.IsFailure)
            return result;

          var predicateResult = await valueUniTaskPredicate();
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);

          return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result> Ensure<T>(this UniTask<Result> resultUniTask, Func<UniTask<Result<T>>> valueUniTaskPredicate)
        {
          Result result = await resultUniTask;
          
          if (result.IsFailure)
            return result;

          var predicateResult = await valueUniTaskPredicate();
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);

          return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<UniTask<Result<T>>> valueUniTaskPredicate)
        {
          Result<T> result = await resultUniTask;
          
          if (result.IsFailure)
            return result;
        
          var predicateResult = await valueUniTaskPredicate();
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);
        
          return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T,UniTask<Result>> valueUniTaskPredicate)
        {
          Result<T> result = await resultUniTask;
          
          if (result.IsFailure)
            return result;

          var predicateResult = await valueUniTaskPredicate(result.Value);
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);

          return result;
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T,UniTask<Result<T>>> valueUniTaskPredicate)
        {
          Result<T> result = await resultUniTask;
          
          if (result.IsFailure)
            return result;

          var predicateResult = await valueUniTaskPredicate(result.Value);
          
          if (predicateResult.IsFailure)
            return Result.Failure<T>(predicateResult.Error);

          return result;
        }
    }
}
