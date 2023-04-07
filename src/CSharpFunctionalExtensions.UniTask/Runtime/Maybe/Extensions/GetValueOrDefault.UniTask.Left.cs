using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<T> GetValueOrDefault<T>(this UniTask<Maybe<T>> maybeUniTask, Func<T> defaultValue)
        {
            var maybe = await maybeUniTask;
            return maybe.GetValueOrDefault(defaultValue);
        }
        
        public static async UniTask<K> GetValueOrDefault<T, K>(this UniTask<Maybe<T>> maybeUniTask, Func<T, K> selector,
            K defaultValue = default)
        {
            var maybe = await maybeUniTask;
            return maybe.GetValueOrDefault(selector, defaultValue);
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this UniTask<Maybe<T>> maybeUniTask, Func<T, K> selector,
            Func<K> defaultValue)
        {
            var maybe = await maybeUniTask;
            return maybe.GetValueOrDefault(selector, defaultValue);
        }
    }
}
