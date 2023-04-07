using System;
using System.ComponentModel;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T>> OnFailure<T>(this UniTask<Result<T>> resultUniTask, Action action)
            => resultUniTask.TapError(action);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result> OnFailure(this UniTask<Result> resultUniTask, Action action)
            => resultUniTask.TapError(action);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T, E>> OnFailure<T, E>(this UniTask<Result<T, E>> resultUniTask, Action action)
            => resultUniTask.TapError(action);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<UnitResult<E>> OnFailure<E>(this UniTask<UnitResult<E>> resultUniTask, Action action)
            => resultUniTask.TapError(action);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<UnitResult<E>> OnFailure<E>(this UniTask<UnitResult<E>> resultUniTask, Action<E> action)
            => resultUniTask.TapError(action);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T>> OnFailure<T>(this UniTask<Result<T>> resultUniTask, Action<string> action)
            => resultUniTask.TapError(action);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T, E>> OnFailure<T, E>(this UniTask<Result<T, E>> resultUniTask, Action<E> action)
            => resultUniTask.TapError(action);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result> OnFailure(this UniTask<Result> resultUniTask, Action<string> action)
            => resultUniTask.TapError(action);
    }
}
