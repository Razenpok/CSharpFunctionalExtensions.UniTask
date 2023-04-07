using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
   public static partial class AsyncResultExtensionsRightOperand
    {
        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<Result<T>> Check<T>(this Result<T> result, Func<T, UniTask<Result>> valueUniTask)
        {
            return await result.Bind(valueUniTask).Map(() => result.Value);
        }

        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<Result<T>> Check<T, K>(this Result<T> result, Func<T, UniTask<Result<K>>> valueUniTask)
        {
            return await result.Bind(valueUniTask).Map(_ => result.Value);
        }

        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<Result<T, E>> Check<T, K, E>(this Result<T, E> result, Func<T, UniTask<Result<K, E>>> valueUniTask)
        {
            return await result.Bind(valueUniTask).Map(_ => result.Value);
        }

        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<Result<T, E>> Check<T, E>(this Result<T, E> result, Func<T, UniTask<UnitResult<E>>> valueUniTask)
        {
            return await result.Bind(valueUniTask).Map(() => result.Value);
        }

        /// <summary>
        ///     If the calling result is a success, the given valueUniTask action is executed and its Result is checked. If this Result is a failure, it is returned. Otherwise, the calling result is returned.
        /// </summary>
        public static async UniTask<UnitResult<E>> Check<E>(this UnitResult<E> result, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            return await result.Bind(valueUniTask).Map(() => result);
        }
    }
}
