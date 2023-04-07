using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static async UniTask<T> GetValueOrDefault<T>(this UniTask<Result<T>> resultUniTask, Func<T> defaultValue)
        {
            var result = await resultUniTask;
            return result.GetValueOrDefault(defaultValue);
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this UniTask<Result<T>> resultUniTask, Func<T, K> selector,
            K defaultValue = default)
        {
            var result = await resultUniTask;
            return result.GetValueOrDefault(selector, defaultValue);
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this UniTask<Result<T>> resultUniTask, Func<T, K> selector,
            Func<K> defaultValue)
        {
            var result = await resultUniTask;
            return result.GetValueOrDefault(selector, defaultValue);
        }
    }
}
