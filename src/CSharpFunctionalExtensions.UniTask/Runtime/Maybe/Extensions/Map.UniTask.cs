using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<Maybe<K>> Map<T, K>(this UniTask<Maybe<T>> maybeUniTask, Func<T, UniTask<K>> valueUniTask)
        {
            Maybe<T> maybe = await maybeUniTask;
            return await maybe.Map(valueUniTask);
        }
    }
}
