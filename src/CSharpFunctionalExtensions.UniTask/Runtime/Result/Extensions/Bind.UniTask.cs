using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsBothOperands
    {
        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K, E>> Bind<T, K, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask<Result<K, E>>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return await result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Bind<T, K>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask<Result<K>>> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return await result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<K>> Bind<K>(this UniTask<Result> resultUniTask, Func<UniTask<Result<K>>> valueUniTask)
        {
            Result result = await resultUniTask;
            return await result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result> Bind<T>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask<Result>> valueUniTask)
        {
            Result<T> result = await resultUniTask;
            return await result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result> Bind(this UniTask<Result> resultUniTask, Func<UniTask<Result>> valueUniTask)
        {
            Result result = await resultUniTask;
            return await result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<Result<T, E>> Bind<T, E>(this UniTask<UnitResult<E>> resultUniTask, Func<UniTask<Result<T, E>>> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;
            return await result.Bind(valueUniTask);
        }

        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<UnitResult<E>> Bind<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask<UnitResult<E>>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;
            return await result.Bind(valueUniTask);
        }
        
        /// <summary>
        ///     Selects result from the return value of a given valueUniTask action. If the calling Result is a failure, a new failure result is returned instead.
        /// </summary>
        public static async UniTask<UnitResult<E>> Bind<E>(this UniTask<UnitResult<E>> resultUniTask, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;
            return await result.Bind(valueUniTask);
        }
    }
}
