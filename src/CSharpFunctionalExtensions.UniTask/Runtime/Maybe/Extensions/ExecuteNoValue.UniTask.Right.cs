using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        /// <summary>
        ///     Executes the given async <paramref name="valueUniTask" /> if the <paramref name="maybe" /> has no value
        /// </summary>
        /// <param name="maybe"></param>
        /// <param name="valueUniTask"></param>
        /// <typeparam name="T"></typeparam>
        public static async UniTask ExecuteNoValue<T>(this Maybe<T> maybe, Func<UniTask> valueUniTask)
        {
            if (maybe.HasValue)
                return;

            await valueUniTask();
        }
    }
}
