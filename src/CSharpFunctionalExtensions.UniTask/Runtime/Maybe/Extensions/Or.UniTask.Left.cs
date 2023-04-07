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
        public static async UniTask<Maybe<T>> Or<T>(this UniTask<Maybe<T>> maybeUniTask, T fallback)
        {
            Maybe<T> maybe = await maybeUniTask;

            if (maybe.HasNoValue)
                return Maybe<T>.From(fallback);

            return maybe;
        }

        /// <summary>
        /// Creates a new <see cref="Maybe{T}" /> if <paramref name="maybeUniTask" /> is empty, using the result of the supplied <paramref name="fallbackOperation" />, otherwise it returns <paramref name="maybeUniTask" />
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="fallbackOperation"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask<Maybe<T>> Or<T>(this UniTask<Maybe<T>> maybeUniTask, Func<T> fallbackOperation)
        {
            Maybe<T> maybe = await maybeUniTask;

            if (maybe.HasNoValue)
                return Maybe<T>.From(fallbackOperation());

            return maybe;
        }

        /// <summary>
        /// Returns <paramref name="fallback" /> if <paramref name="maybeUniTask" /> is empty, otherwise it returns <paramref name="maybeUniTask" />
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="fallback"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask<Maybe<T>> Or<T>(this UniTask<Maybe<T>> maybeUniTask, Maybe<T> fallback)
        {
            Maybe<T> maybe = await maybeUniTask;

            if (maybe.HasNoValue)
                return fallback;

            return maybe;
        }

        /// <summary>
        /// Returns <paramref name="fallbackOperation" /> if <paramref name="maybeUniTask" /> is empty, otherwise it returns <paramref name="maybeUniTask" />
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="fallbackOperation"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask<Maybe<T>> Or<T>(this UniTask<Maybe<T>> maybeUniTask, Func<Maybe<T>> fallbackOperation)
        {
            Maybe<T> maybe = await maybeUniTask;

            if (maybe.HasNoValue)
                return fallbackOperation();

            return maybe;
        }
    }
}
