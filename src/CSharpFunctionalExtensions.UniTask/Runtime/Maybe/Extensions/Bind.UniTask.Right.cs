using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static UniTask<Maybe<K>> Bind<T, K>(this Maybe<T> maybe, Func<T, UniTask<Maybe<K>>> selector)
        {
            if (maybe.HasNoValue)
                return Maybe<K>.None.AsCompletedUniTask();

            return selector(maybe.GetValueOrThrow());
        }
    }
}
