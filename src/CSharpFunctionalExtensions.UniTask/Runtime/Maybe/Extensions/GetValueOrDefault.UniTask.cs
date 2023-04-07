using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<T> GetValueOrDefault<T>(this UniTask<Maybe<T>> maybeUniTask, Func<UniTask<T>> defaultValue)
        {
            var maybe = await maybeUniTask;
            return await maybe.GetValueOrDefault(defaultValue);
        }
        
        public static async UniTask<K> GetValueOrDefault<T, K>(this UniTask<Maybe<T>> maybeUniTask, Func<T, UniTask<K>> selector,
            K defaultValue = default)
        {
            var maybe = await maybeUniTask;
            return await maybe.GetValueOrDefault(selector, defaultValue);
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this UniTask<Maybe<T>> maybeUniTask, Func<T, UniTask<K>> selector,
            Func<UniTask<K>> defaultValue)
        {
            var maybe = await maybeUniTask;
            return await maybe.GetValueOrDefault(selector, defaultValue);
        }
    }
}
