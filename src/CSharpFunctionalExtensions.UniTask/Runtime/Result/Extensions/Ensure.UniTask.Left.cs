using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T, bool> predicate, string errorMessage)
        {
            Result<T> result = await resultUniTask;
            return result.Ensure(predicate, errorMessage);
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T, E>> Ensure<T, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<T, bool> predicate, E error)
        {
            Result<T, E> result = await resultUniTask;
            return result.Ensure(predicate, error);
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T, E>> Ensure<T, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<T, bool> predicate, Func<T, E> errorPredicate)
        {
            Result<T, E> result = await resultUniTask;
            return result.Ensure(predicate, errorPredicate);
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T, bool> predicate, Func<T, string> errorPredicate)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
                return result;

            return result.Ensure(predicate, errorPredicate);
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T, bool> predicate, Func<T, UniTask<string>> errorPredicate)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
                return result;

            if (predicate(result.Value))
                return result;

            return Result.Failure<T>(await errorPredicate(result.Value));
        }

        /// <summary>
        ///     Returns a new failure result if the predicate is false. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result> Ensure(this UniTask<Result> resultUniTask, Func<bool> predicate, string errorMessage)
        {
            Result result = await resultUniTask;
            return result.Ensure(predicate, errorMessage);
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result> Ensure(this UniTask<Result> resultUniTask, Func<Result> predicate)
        {
          Result result = await resultUniTask;
          return result.Ensure(predicate);
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<Result> predicate)
        {
          Result<T> result = await resultUniTask;
          return result.Ensure(predicate);
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result> Ensure<T>(this UniTask<Result> resultUniTask, Func<Result<T>> predicate)
        {
          Result result = await resultUniTask;
          return result.Ensure(predicate);
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<Result<T>> predicate)
        {
          Result<T> result = await resultUniTask;
          return result.Ensure(predicate);
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T,Result> predicate)
        {
          Result<T> result = await resultUniTask;
          return result.Ensure(predicate);
        }
        
        /// <summary>
        ///     Returns a new failure result if the predicate is a failure result. Otherwise returns the starting result.
        /// </summary>
        public static async UniTask<Result<T>> Ensure<T>(this UniTask<Result<T>> resultUniTask, Func<T,Result<T>> predicate)
        {
          Result<T> result = await resultUniTask;
          return result.Ensure(predicate);
        }
    }
}
