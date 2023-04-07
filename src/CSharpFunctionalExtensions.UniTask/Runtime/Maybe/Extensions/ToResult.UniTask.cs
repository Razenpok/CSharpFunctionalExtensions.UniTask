using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<Result<T>> ToResult<T>(this UniTask<Maybe<T>> maybeUniTask, string errorMessage)
        {
            Maybe<T> maybe = await maybeUniTask;
            return maybe.ToResult(errorMessage);
        }

        public static async UniTask<Result<T, E>> ToResult<T, E>(this UniTask<Maybe<T>> maybeUniTask, E error)
        {
            Maybe<T> maybe = await maybeUniTask;
            return maybe.ToResult(error);
        }
    }
}
