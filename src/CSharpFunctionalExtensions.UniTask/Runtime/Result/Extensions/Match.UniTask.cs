using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
        /// <summary>
        ///     Returns the result of the given <paramref name="onSuccessUniTask"/> valueUniTask action if the calling Result is a success. Otherwise, it returns the result of the given <paramref name="onFailureUniTask"/> valueUniTask action.
        /// </summary>
        public static async UniTask<K> Match<T, K, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask<K>> onSuccessUniTask, Func<E, UniTask<K>> onFailureUniTask)
        {
            return await (await resultUniTask)
                .Match(onSuccessUniTask, onFailureUniTask);
        }

        /// <summary>
        ///     Returns the result of the given <paramref name="onSuccessUniTask"/> valueUniTask action if the calling Result is a success. Otherwise, it returns the result of the given <paramref name="onFailureUniTask"/> valueUniTask action.
        /// </summary>
        public static async UniTask<K> Match<K, T>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask<K>> onSuccessUniTask, Func<string, UniTask<K>> onFailureUniTask)
        {
            return await (await resultUniTask)
                .Match(onSuccessUniTask, onFailureUniTask);
        }

        /// <summary>
        ///     Returns the result of the given <paramref name="onSuccessUniTask"/> valueUniTask action if the calling Result is a success. Otherwise, it returns the result of the given <paramref name="onFailureUniTask"/> valueUniTask action.
        /// </summary>
        public static async UniTask<T> Match<T>(this UniTask<Result> resultUniTask, Func<UniTask<T>> onSuccessUniTask, Func<string, UniTask<T>> onFailureUniTask)
        {
            return await (await resultUniTask)
                .Match(onSuccessUniTask, onFailureUniTask);
        }

        /// <summary>
        ///     Invokes the given <paramref name="onSuccessUniTask"/> action if the calling Result is a success. Otherwise, it invokes the given <paramref name="onFailureUniTask"/> action.
        /// </summary>
        public static async UniTask Match<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask> onSuccessUniTask, Func<E, UniTask> onFailureUniTask)
        {
            await (await resultUniTask)
                .Match(onSuccessUniTask, onFailureUniTask);
        }

        /// <summary>
        ///     Invokes the given <paramref name="onSuccessUniTask"/> action if the calling Result is a success. Otherwise, it invokes the given <paramref name="onFailureUniTask"/> action.
        /// </summary>
        public static async UniTask Match<E>(this UniTask<UnitResult<E>> resultUniTask, Func<UniTask> onSuccessUniTask, Func<E, UniTask> onFailureUniTask)
        {
            await (await resultUniTask)
                .Match(onSuccessUniTask, onFailureUniTask);
        }

        /// <summary>
        ///     Invokes the given <paramref name="onSuccessUniTask"/> action if the calling Result is a success. Otherwise, it invokes the given <paramref name="onFailureUniTask"/> action.
        /// </summary>
        public static async UniTask Match<T>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask> onSuccessUniTask, Func<string, UniTask> onFailureUniTask)
        {
            await (await resultUniTask)
                .Match(onSuccessUniTask, onFailureUniTask);
        }

        /// <summary>
        ///     Invokes the given <paramref name="onSuccessUniTask"/> action if the calling Result is a success. Otherwise, it invokes the given <paramref name="onFailureUniTask"/> action.
        /// </summary>
        public static async UniTask Match(this UniTask<Result> resultUniTask, Func<UniTask> onSuccessUniTask, Func<string, UniTask> onFailureUniTask)
        {
            await (await resultUniTask)
                .Match(onSuccessUniTask, onFailureUniTask);
        }
    }
}
