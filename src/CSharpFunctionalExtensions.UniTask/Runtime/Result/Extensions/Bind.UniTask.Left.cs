using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K, E>> Bind<T, K, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, Result<K, E>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Bind<T, K>(this UniTask<Result<T>> resultUniTask, Func<T, Result<K>> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Bind<K>(this UniTask<Result> resultUniTask, Func<Result<K>> valueUniTask)
        {
            Result result = await resultUniTask;
            return result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result> Bind<T>(this UniTask<Result<T>> resultUniTask, Func<T, Result> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result> Bind(this UniTask<Result> resultUniTask, Func<Result> valueUniTask)
        {
            Result result = await resultUniTask;
            return result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<T, E>> Bind<T, E>(this UniTask<UnitResult<E>> resultUniTask, Func<Result<T, E>> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;
            return result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<UnitResult<E>> Bind<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UnitResult<E>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return result.Bind(valueUniTask);
        }
        
        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<UnitResult<E>> Bind<E>(this UniTask<UnitResult<E>> resultUniTask, Func<UnitResult<E>> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;
            return result.Bind(valueUniTask);
        }
    }
}
