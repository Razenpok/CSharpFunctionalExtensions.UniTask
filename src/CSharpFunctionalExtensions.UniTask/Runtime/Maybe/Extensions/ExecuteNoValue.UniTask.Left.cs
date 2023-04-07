using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        /// <summary>
        /// Executes the given <paramref name="action" /> if the <paramref name="maybeUniTask" /> produces no value
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        public static async UniTask ExecuteNoValue<T>(this UniTask<Maybe<T>> maybeUniTask, Action action)
        {
            var maybe = await maybeUniTask;

            if (maybe.HasValue)
                return;

            action();
        }
    }
}
