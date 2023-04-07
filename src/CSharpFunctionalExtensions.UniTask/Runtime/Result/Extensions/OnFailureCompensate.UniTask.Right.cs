using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        public static async UniTask<Result<T>> OnFailureCompensate<T>(this Result<T> result, Func<UniTask<Result<T>>> valueUniTask)
        {
            if (result.IsFailure)
                return await valueUniTask();

            return result;
        }

        public static async UniTask<Result<T, E>> OnFailureCompensate<T, E>(this Result<T, E> result, Func<UniTask<Result<T, E>>> valueUniTask)
        {
            if (result.IsFailure)
                return await valueUniTask();

            return result;
        }

        public static async UniTask<Result> OnFailureCompensate(this Result result, Func<UniTask<Result>> valueUniTask)
        {
            if (result.IsFailure)
                return await valueUniTask();

            return result;
        }

        public static async UniTask<Result<T>> OnFailureCompensate<T>(this Result<T> result, Func<string, UniTask<Result<T>>> valueUniTask)
        {
            if (result.IsFailure)
                return await valueUniTask(result.Error);

            return result;
        }

        public static async UniTask<Result<T, E>> OnFailureCompensate<T, E>(this Result<T, E> result,
            Func<E, UniTask<Result<T, E>>> valueUniTask)
        {
            if (result.IsFailure)
                return await valueUniTask(result.Error);

            return result;
        }
        
        public static async UniTask<Result> OnFailureCompensate(this Result result, Func<string, UniTask<Result>> valueUniTask)
        {
            if (result.IsFailure)
                return await valueUniTask(result.Error);

            return result;
        }
    }
}
