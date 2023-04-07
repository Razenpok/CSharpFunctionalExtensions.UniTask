using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class MaybeExtensions
    {
        /// <summary>
        ///     Executes the given async <paramref name="valueUniTask" /> if the <paramref name="maybe" /> has a value
        /// </summary>
        /// <param name="maybe"></param>
        /// <param name="valueUniTask"></param>
        /// <typeparam name="T"></typeparam>
        public static async UniTask Execute<T>(this Maybe<T> maybe, Func<T, UniTask> valueUniTask)
        {
            if (maybe.HasNoValue)
                return;

            await valueUniTask(maybe.GetValueOrThrow());
        }
    }
}
