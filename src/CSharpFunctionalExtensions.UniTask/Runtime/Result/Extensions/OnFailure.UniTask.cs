using System;
using System.ComponentModel;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T, E>> OnFailure<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<UniTask> valueUniTask)
            => resultUniTask.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T>> OnFailure<T>(this UniTask<Result<T>> resultUniTask, Func<UniTask> valueUniTask)
            => resultUniTask.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result> OnFailure(this UniTask<Result> resultUniTask, Func<UniTask> valueUniTask)
            => resultUniTask.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result> OnFailure(this UniTask<Result> resultUniTask, Func<string, UniTask> valueUniTask)
            => resultUniTask.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<UnitResult<E>> OnFailure<E>(this UniTask<UnitResult<E>> resultUniTask, Func<E, UniTask> valueUniTask)
            => resultUniTask.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<UnitResult<E>> OnFailure<E>(this UniTask<UnitResult<E>> resultUniTask, Func<UniTask> valueUniTask)
            => resultUniTask.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T>> OnFailure<T>(this UniTask<Result<T>> resultUniTask, Func<string, UniTask> valueUniTask)
            => resultUniTask.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T, E>> OnFailure<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<E, UniTask> valueUniTask)
            => resultUniTask.TapError(valueUniTask);
    }
}
