using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        /// <summary>
        /// Executes the given <paramref name="valueUniTask" /> if the <paramref name="maybeUniTask" /> produces no value
        /// </summary>
        /// <param name="maybeUniTask"></param>
        /// <param name="valueUniTask"></param>
        /// <typeparam name="T"></typeparam>
        public static async UniTask ExecuteNoValue<T>(this UniTask<Maybe<T>> maybeUniTask, Func<UniTask> valueUniTask)
        {
            var maybe = await maybeUniTask;

            if (maybe.HasValue)
                return;

            await valueUniTask();
        }

    }
}
