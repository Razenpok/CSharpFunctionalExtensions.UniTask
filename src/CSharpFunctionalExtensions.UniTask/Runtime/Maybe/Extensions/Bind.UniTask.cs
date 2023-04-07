using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<Maybe<K>> Bind<T, K>(this UniTask<Maybe<T>> maybeUniTask, Func<T, UniTask<Maybe<K>>> selector)
        {
            Maybe<T> maybe = await maybeUniTask;
            return await maybe.Bind(selector);
        }
    }
}
