using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsBothOperands
    {
        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<T> Finally<T>(this UniTask<Result> resultUniTask, Func<Result, UniTask<T>> valueUniTask)
        {
            Result result = await resultUniTask;
            return await valueUniTask(result);
        }

        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<K> Finally<T, K>(this UniTask<Result<T>> resultUniTask, Func<Result<T>, UniTask<K>> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return await valueUniTask(result);
        }

        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<K> Finally<K, E>(this UniTask<UnitResult<E>> resultUniTask, Func<UnitResult<E>, UniTask<K>> valueUniTask) 
        {
            UnitResult<E> result = await resultUniTask;
            return await valueUniTask(result);
        }

        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<K> Finally<T, K, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<Result<T, E>, UniTask<K>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return await valueUniTask(result);
        }
    }
}
