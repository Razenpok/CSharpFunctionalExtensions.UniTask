using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static async UniTask<T> GetValueOrDefault<T>(this Result<T> result, Func<UniTask<T>> valueUniTask)
        {
            if (result.IsFailure)
                return await valueUniTask();

            return result.Value;
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this Result<T> result, Func<T, K> selector,
            Func<UniTask<K>> valueUniTask)
        {
            if (result.IsFailure)
                return await valueUniTask();

            return selector(result.Value);
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this Result<T> result, Func<T, UniTask<K>> valueUniTask,
            K defaultValue = default)
        {
            if (result.IsFailure)
                return defaultValue;

            return await valueUniTask(result.Value);
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this Result<T> result, Func<T, UniTask<K>> valueUniTask,
            Func<UniTask<K>> defaultValue)
        {
            if (result.IsFailure)
                return await defaultValue();

            return await valueUniTask(result.Value);
        }
    }
}
