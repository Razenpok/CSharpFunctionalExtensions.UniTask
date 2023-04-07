using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K, E>> Map<T, K, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, K> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return result.Map(valueUniTask);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K, E>> Map<K, E>(this UniTask<UnitResult<E>> resultUniTask, Func<K> valueUniTask) 
        {
            UnitResult<E> result = await resultUniTask;
            return result.Map(valueUniTask);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Map<T, K>(this UniTask<Result<T>> resultUniTask, Func<T, K> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return result.Map(valueUniTask);
        }

        /// <summary>
        ///     Creates a new result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Map<K>(this UniTask<Result> resultUniTask, Func<K> valueUniTask)
        {
            Result result = await resultUniTask;
            return result.Map(valueUniTask);
        }
    }
}
