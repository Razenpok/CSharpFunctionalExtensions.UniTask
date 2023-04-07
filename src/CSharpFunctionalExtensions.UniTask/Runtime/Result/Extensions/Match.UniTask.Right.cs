using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
        /// <summary>
        ///     Returns the result of the given <paramref name="onSuccessUniTask"/> valueUniTask action if the calling Result is a success. Otherwise, it returns the result of the given <paramref name="onFailureUniTask"/> valueUniTask action.
        /// </summary>
        public static UniTask<K> Match<T, K, E>(this Result<T, E> result, Func<T, UniTask<K>> onSuccessUniTask, Func<E, UniTask<K>> onFailureUniTask)
        {
            return result.IsSuccess
                ? onSuccessUniTask(result.Value)
                : onFailureUniTask(result.Error);
        }

        /// <summary>
        ///     Returns the result of the given <paramref name="onSuccessUniTask"/> valueUniTask action if the calling Result is a success. Otherwise, it returns the result of the given <paramref name="onFailureUniTask"/> valueUniTask action.
        /// </summary>
        public static UniTask<K> Match<K, T>(this Result<T> result, Func<T, UniTask<K>> onSuccessUniTask, Func<string, UniTask<K>> onFailureUniTask)
        {
            return result.IsSuccess
                ? onSuccessUniTask(result.Value)
                : onFailureUniTask(result.Error);
        }

        /// <summary>
        ///     Returns the result of the given <paramref name="onSuccessUniTask"/> valueUniTask action if the calling Result is a success. Otherwise, it returns the result of the given <paramref name="onFailureUniTask"/> valueUniTask action.
        /// </summary>
        public static UniTask<T> Match<T>(this Result result, Func<UniTask<T>> onSuccessUniTask, Func<string, UniTask<T>> onFailureUniTask)
        {
            return result.IsSuccess
                ? onSuccessUniTask()
                : onFailureUniTask(result.Error);
        }

        /// <summary>
        ///     Invokes the given <paramref name="onSuccessUniTask"/> action if the calling Result is a success. Otherwise, it invokes the given <paramref name="onFailureUniTask"/> action.
        /// </summary>
        public static UniTask Match<T, E>(this Result<T, E> result, Func<T, UniTask> onSuccessUniTask, Func<E, UniTask> onFailureUniTask)
        {
            return result.IsSuccess
                ? onSuccessUniTask(result.Value)
                : onFailureUniTask(result.Error);
        }

        /// <summary>
        ///     Invokes the given <paramref name="onSuccessUniTask"/> action if the calling Result is a success. Otherwise, it invokes the given <paramref name="onFailureUniTask"/> action.
        /// </summary>
        public static UniTask Match<E>(this UnitResult<E> result, Func<UniTask> onSuccessUniTask, Func<E, UniTask> onFailureUniTask)
        {
            return result.IsSuccess
                ? onSuccessUniTask()
                : onFailureUniTask(result.Error);
        }

        /// <summary>
        ///     Invokes the given <paramref name="onSuccessUniTask"/> action if the calling Result is a success. Otherwise, it invokes the given <paramref name="onFailureUniTask"/> action.
        /// </summary>
        public static UniTask Match<T>(this Result<T> result, Func<T, UniTask> onSuccessUniTask, Func<string, UniTask> onFailureUniTask)
        {
            return result.IsSuccess
                ? onSuccessUniTask(result.Value)
                : onFailureUniTask(result.Error);
        }

        /// <summary>
        ///     Invokes the given <paramref name="onSuccessUniTask"/> action if the calling Result is a success. Otherwise, it invokes the given <paramref name="onFailureUniTask"/> action.
        /// </summary>
        public static UniTask Match(this Result result, Func<UniTask> onSuccessUniTask, Func<string, UniTask> onFailureUniTask)
        {
            return result.IsSuccess
                ? onSuccessUniTask()
                : onFailureUniTask(result.Error);
        }
    }
}
