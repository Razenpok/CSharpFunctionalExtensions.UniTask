using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<T> Finally<T>(this Result result, Func<Result, UniTask<T>> valueUniTask)
        {
            return await valueUniTask(result);
        }

        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<K> Finally<T, K>(this Result<T> result, Func<Result<T>, UniTask<K>> valueUniTask)
        {
            return await valueUniTask(result);
        }

        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<K> Finally<K, E>(this UnitResult<E> result, Func<UnitResult<E>, UniTask<K>> valueUniTask)
        {
            return await valueUniTask(result);
        }

        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<K> Finally<T, K, E>(this Result<T, E> result, Func<Result<T, E>, UniTask<K>> valueUniTask)
        {
            return await valueUniTask(result);
        }
    }
}
