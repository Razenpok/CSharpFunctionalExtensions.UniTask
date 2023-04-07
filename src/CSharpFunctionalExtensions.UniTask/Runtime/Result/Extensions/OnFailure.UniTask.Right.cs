using System;
using System.ComponentModel;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T>> OnFailure<T>(this Result<T> result, Func<UniTask> valueUniTask)
            => result.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T, E>> OnFailure<T, E>(this Result<T, E> result, Func<UniTask> valueUniTask)
            => result.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result> OnFailure(this Result result, Func<UniTask> valueUniTask)
            => result.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result> OnFailure(this Result result, Func<string, UniTask> valueUniTask)
            => result.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<UnitResult<E>> OnFailure<E>(this UnitResult<E> result, Func<UniTask> valueUniTask)
            => result.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<UnitResult<E>> OnFailure<E>(this UnitResult<E> result, Func<E, UniTask> valueUniTask)
            => result.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T>> OnFailure<T>(this Result<T> result, Func<string, UniTask> valueUniTask)
            => result.TapError(valueUniTask);

        [EditorBrowsable(EditorBrowsableState.Never)]
        [Obsolete("Use TapError() instead.")]
        public static UniTask<Result<T, E>> OnFailure<T, E>(this Result<T, E> result, Func<E, UniTask> valueUniTask)
            => result.TapError(valueUniTask);
    }
}
