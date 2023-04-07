using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<Maybe<K>> Map<T, K>(this Maybe<T> maybe, Func<T, UniTask<K>> valueUniTask)
        {
            if (maybe.HasNoValue)
                return Maybe<K>.None;

            return await valueUniTask(maybe.GetValueOrThrow());
        }
    }
}
