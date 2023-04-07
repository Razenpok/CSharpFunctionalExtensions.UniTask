using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<Maybe<K>> Map<T, K>(this UniTask<Maybe<T>> valueUniTask, Func<T, K> selector)
        {
            Maybe<T> maybe = await valueUniTask;
            return maybe.Map(selector);
        }
    }
}
