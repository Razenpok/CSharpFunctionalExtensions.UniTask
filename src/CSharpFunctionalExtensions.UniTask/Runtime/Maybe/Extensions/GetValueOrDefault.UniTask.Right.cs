using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<T> GetValueOrDefault<T>(this Maybe<T> maybe, Func<UniTask<T>> valueUniTask)
        {
            if (maybe.HasNoValue)
                return await valueUniTask();

            return maybe.GetValueOrThrow();
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this Maybe<T> maybe, Func<T, K> selector,
            Func<UniTask<K>> valueUniTask)
        {
            if (maybe.HasNoValue)
                return await valueUniTask();

            return selector(maybe.GetValueOrThrow());
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this Maybe<T> maybe, Func<T, UniTask<K>> valueUniTask,
            K defaultValue = default)
        {
            if (maybe.HasNoValue)
                return defaultValue;

            return await valueUniTask(maybe.GetValueOrThrow());
        }

        public static async UniTask<K> GetValueOrDefault<T, K>(this Maybe<T> maybe, Func<T, UniTask<K>> valueUniTask,
            Func<UniTask<K>> defaultValue)
        {
            if (maybe.HasNoValue)
                return await defaultValue();

            return await valueUniTask(maybe.GetValueOrThrow());
        }
    }
}
