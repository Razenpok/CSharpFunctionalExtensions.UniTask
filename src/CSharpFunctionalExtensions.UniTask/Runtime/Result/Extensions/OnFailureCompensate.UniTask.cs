using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsBothOperands
    {
       public static async UniTask<Result<T, E>> OnFailureCompensate<T, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<UniTask<Result<T, E>>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure)
                return await valueUniTask();

            return result;
        }

        public static async UniTask<Result<T>> OnFailureCompensate<T>(this UniTask<Result<T>> resultUniTask, Func<UniTask<Result<T>>> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
                return await valueUniTask();

            return result;
        }

        public static async UniTask<Result> OnFailureCompensate(this UniTask<Result> resultUniTask, Func<UniTask<Result>> valueUniTask)
        {
            Result result = await resultUniTask;

            if (result.IsFailure)
                return await valueUniTask();

            return result;
        }
        
        
        public static async UniTask<Result<T>> OnFailureCompensate<T>(this UniTask<Result<T>> resultUniTask, Func<string, UniTask<Result<T>>> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsFailure)
                return await valueUniTask(result.Error);

            return result;
        }

        public static async UniTask<Result<T, E>> OnFailureCompensate<T, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<E, UniTask<Result<T, E>>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsFailure)
                return await valueUniTask(result.Error);

            return result;
        }

        public static async UniTask<Result> OnFailureCompensate(this UniTask<Result> resultUniTask, Func<string, UniTask<Result>> valueUniTask)
        {
            Result result = await resultUniTask;
            
            if (result.IsFailure)
                return await valueUniTask(result.Error);

            return result;
        }
    }
}
