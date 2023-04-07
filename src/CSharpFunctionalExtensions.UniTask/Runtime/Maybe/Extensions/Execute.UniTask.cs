using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        /// <summary>
        /// Executes the given <paramref name="valueUniTask" /> if the <paramref name="maybeUniTask" /> produces a value
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="valueUniTask"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async UniTask Execute<T>(this UniTask<Maybe<T>> maybeUniTask, Func<T, UniTask> valueUniTask)
        {
            var maybe = await maybeUniTask;

            if (maybe.HasNoValue)
                return;

            await valueUniTask(maybe.GetValueOrThrow());
        }
    }
}
