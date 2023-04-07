using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<T> Finally<T>(this UniTask<Result> resultUniTask, Func<Result, T> valueUniTask)
        {
            Result result = await resultUniTask;
            return result.Finally(valueUniTask);
        }

        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<K> Finally<T, K>(this UniTask<Result<T>> resultUniTask, Func<Result<T>, K> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return result.Finally(valueUniTask);
        }

        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<K> Finally<K, E>(this UniTask<UnitResult<E>> resultUniTask, Func<UnitResult<E>, K> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;
            return result.Finally(valueUniTask);
        }

        /// <summary>
        ///     Passes the result to the given valueUniTask action (regardless of success/failure state) to yield a final output value.
        /// </summary>
        public static async UniTask<K> Finally<T, K, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<Result<T, E>, K> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return result.Finally(valueUniTask);
        }
    }
}
