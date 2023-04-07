using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<Maybe<T>> Where<T>(this Maybe<T> maybe, Func<T, UniTask<bool>> predicate)
        {
            if (maybe.HasNoValue)
                return Maybe<T>.None;

            if (await predicate(maybe.GetValueOrThrow()))
                return maybe;

            return Maybe<T>.None;
        }
    }
}
