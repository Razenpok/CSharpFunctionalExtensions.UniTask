using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<Maybe<T>> Where<T>(this UniTask<Maybe<T>> maybeUniTask, Func<T, UniTask<bool>> predicate)
        {
            Maybe<T> maybe = await maybeUniTask;
            return await maybe.Where(predicate);
        }
    }
}
