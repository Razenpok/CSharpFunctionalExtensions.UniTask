using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        /// <summary>
        /// Executes the given <paramref name="action" /> if the <paramref name="maybeUniTask" /> produces a value
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask Execute<T>(this UniTask<Maybe<T>> maybeUniTask, Action<T> action)
        {
            var maybe = await maybeUniTask;

            if (maybe.HasNoValue)
                return;

            action(maybe.GetValueOrThrow());
        }
    }
}
