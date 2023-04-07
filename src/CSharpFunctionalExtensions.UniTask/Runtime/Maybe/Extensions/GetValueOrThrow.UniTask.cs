using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        public static async UniTask<T> GetValueOrThrow<T>(this UniTask<Maybe<T>> maybeUniTask)
        {
            var maybe = await maybeUniTask;
            return maybe.GetValueOrThrow();
        }

        /// <summary>
        ///     Returns <paramref name="maybeUniTask" />'s inner value if it has one, otherwise throws an InvalidOperationException
        ///     with <paramref name="errorMessage" />
        /// </summary>
        /// <exception cref="InvalidOperationException">Maybe has no value.</exception>
        public static async UniTask<T> GetValueOrThrow<T>(this UniTask<Maybe<T>> maybeUniTask, string errorMessage)
        {
            var maybe = await maybeUniTask;
            return maybe.GetValueOrThrow(errorMessage);
        }
    }
}
