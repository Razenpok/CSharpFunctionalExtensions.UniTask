using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        /// <summary>
        /// Creates a new <see cref="Maybe{T}" /> if <paramref name="maybe" /> is empty, using the result of the supplied <paramref name="valueUniTaskFallbackOperation" />, otherwise it returns <paramref name="maybe" />
        /// </summary>
        /// <param name="maybe"></param>
        /// <param name="valueUniTaskFallbackOperation"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask<Maybe<T>> Or<T>(this Maybe<T> maybe, Func<UniTask<T>> valueUniTaskFallbackOperation)
        {
            if (maybe.HasNoValue)
                return await valueUniTaskFallbackOperation();

            return maybe;
        }

        /// <summary>
        /// Returns <paramref name="valueUniTaskFallback" /> if <paramref name="maybe" /> is empty, otherwise it returns <paramref name="maybe" />
        /// </summary>
        /// <param name="maybe"></param>
        /// <param name="valueUniTaskFallback"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask<Maybe<T>> Or<T>(this Maybe<T> maybe, UniTask<Maybe<T>> valueUniTaskFallback)
        {
            if (maybe.HasNoValue)
                return await valueUniTaskFallback;

            return maybe;
        }

        /// <summary>
        /// Returns the result of <paramref name="valueUniTaskFallbackOperation" /> if <paramref name="maybe" /> is empty, otherwise it returns <paramref name="maybe" />
        /// </summary>
        /// <param name="maybe"></param>
        /// <param name="valueUniTaskFallbackOperation"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask<Maybe<T>> Or<T>(this Maybe<T> maybe, Func<UniTask<Maybe<T>>> valueUniTaskFallbackOperation)
        {
            if (maybe.HasNoValue)
                return await valueUniTaskFallbackOperation();

            return maybe;
        }
    }
}
