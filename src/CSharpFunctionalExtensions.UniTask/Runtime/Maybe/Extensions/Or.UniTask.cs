using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        /// <summary>
        /// Creates a new <see cref="Maybe{T}" /> if <paramref name="maybeUniTask" /> is empty, using the supplied <paramref name="fallback" />, otherwise it returns <paramref name="maybeUniTask" />
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="fallback"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask<Maybe<T>> Or<T>(this UniTask<Maybe<T>> maybeUniTask, UniTask<T> fallback)
        {
            Maybe<T> maybe = await maybeUniTask;

            if (maybe.HasNoValue)
            {
                var value = await fallback;
                return Maybe<T>.From(value);
            }

            return maybe;
        }

        /// <summary>
        /// Creates a new <see cref="Maybe{T}" /> if <paramref name="maybeUniTask" /> is empty, using the result of the supplied <paramref name="fallbackOperation" />, otherwise it returns <paramref name="maybeUniTask" />
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="fallbackOperation"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask<Maybe<T>> Or<T>(this UniTask<Maybe<T>> maybeUniTask, Func<UniTask<T>> fallbackOperation)
        {
            Maybe<T> maybe = await maybeUniTask;

            if (maybe.HasNoValue)
            {
                var value = await fallbackOperation();

                return Maybe<T>.From(value);
            }

            return maybe;
        }

        /// <summary>
        /// Returns <paramref name="fallbackOperation" /> if <paramref name="maybeUniTask" /> is empty, otherwise it returns <paramref name="maybeUniTask" />
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="fallbackOperation"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask<Maybe<T>> Or<T>(this UniTask<Maybe<T>> maybeUniTask, Func<UniTask<Maybe<T>>> fallbackOperation)
        {
            Maybe<T> maybe = await maybeUniTask;

            if (maybe.HasNoValue)
                return await fallbackOperation();

            return maybe;
        }
    }
}
