using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static async UniTask<Result<T>> MapIf<T>(this UniTask<Result<T>> resultUniTask, bool condition, Func<T, T> valueUniTask)
        {
            var result = await resultUniTask;
            return result.MapIf(condition, valueUniTask);
        }

        public static async UniTask<Result<T, E>> MapIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition, Func<T, T> valueUniTask)
        {
            var result = await resultUniTask;
            return result.MapIf(condition, valueUniTask);
        }

        public static async UniTask<Result<T>> MapIf<T>(this UniTask<Result<T>> resultUniTask, Func<T, bool> predicate, Func<T, T> valueUniTask)
        {
            var result = await resultUniTask;
            return result.MapIf(predicate, valueUniTask);
        }

        public static async UniTask<Result<T, E>> MapIf<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, bool> predicate, Func<T, T> valueUniTask)
        {
            var result = await resultUniTask;
            return result.MapIf(predicate, valueUniTask);
        }
    }
}
