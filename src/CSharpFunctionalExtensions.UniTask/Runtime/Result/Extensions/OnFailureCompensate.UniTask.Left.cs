using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
      public static async UniTask<Result<T, E>> OnFailureCompensate<T, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<Result<T, E>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return result.OnFailureCompensate(valueUniTask);
        }
        
        public static async UniTask<Result<T>> OnFailureCompensate<T>(this UniTask<Result<T>> resultUniTask, Func<Result<T>> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return result.OnFailureCompensate(valueUniTask);
        }

        public static async UniTask<Result> OnFailureCompensate(this UniTask<Result> resultUniTask, Func<Result> valueUniTask)
        {
            Result result = await resultUniTask;
            return result.OnFailureCompensate(valueUniTask);
        }

        public static async UniTask<Result<T>> OnFailureCompensate<T>(this UniTask<Result<T>> resultUniTask, Func<string, Result<T>> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return result.OnFailureCompensate(valueUniTask);
        }

        public static async UniTask<Result<T, E>> OnFailureCompensate<T, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<E, Result<T, E>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return result.OnFailureCompensate(valueUniTask);
        }

        public static async UniTask<Result> OnFailureCompensate(this UniTask<Result> resultUniTask, Func<string, Result> valueUniTask)
        {
            Result result = await resultUniTask;
            return result.OnFailureCompensate(valueUniTask);
        }
    }
}
