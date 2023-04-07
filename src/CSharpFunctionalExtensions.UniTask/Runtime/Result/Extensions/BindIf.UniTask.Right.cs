using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static UniTask<Result> BindIf(this Result result, bool condition, Func<UniTask<Result>> valueUniTask)
        {
            if (!condition)
            {
                return result.AsCompletedUniTask();
            }

            return result.Bind(valueUniTask);
        }

        public static UniTask<Result<T>> BindIf<T>(this Result<T> result, bool condition, Func<T, UniTask<Result<T>>> valueUniTask)
        {
            if (!condition)
            {
                return result.AsCompletedUniTask();
            }

            return result.Bind(valueUniTask);
        }

        public static UniTask<UnitResult<E>> BindIf<E>(this UnitResult<E> result, bool condition, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            if (!condition)
            {
                return result.AsCompletedUniTask();
            }

            return result.Bind(valueUniTask);
        }

        public static UniTask<Result<T, E>> BindIf<T, E>(this Result<T, E> result, bool condition, Func<T, UniTask<Result<T, E>>> valueUniTask)
        {
            if (!condition)
            {
                return result.AsCompletedUniTask();
            }

            return result.Bind(valueUniTask);
        }

        public static UniTask<Result> BindIf(this Result result, Func<bool> predicate, Func<UniTask<Result>> valueUniTask)
        {
            if (!result.IsSuccess || !predicate())
            {
                return result.AsCompletedUniTask();
            }

            return result.Bind(valueUniTask);
        }

        public static UniTask<Result<T>> BindIf<T>(this Result<T> result, Func<T, bool> predicate, Func<T, UniTask<Result<T>>> valueUniTask)
        {
            if (!result.IsSuccess || !predicate(result.Value))
            {
                return result.AsCompletedUniTask();
            }

            return result.Bind(valueUniTask);
        }

        public static UniTask<UnitResult<E>> BindIf<E>(this UnitResult<E> result, Func<bool> predicate, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            if (!result.IsSuccess || !predicate())
            {
                return result.AsCompletedUniTask();
            }

            return result.Bind(valueUniTask);
        }

        public static UniTask<Result<T, E>> BindIf<T, E>(this Result<T, E> result, Func<T, bool> predicate, Func<T, UniTask<Result<T, E>>> valueUniTask)
        {
            if (!result.IsSuccess || !predicate(result.Value))
            {
                return result.AsCompletedUniTask();
            }

            return result.Bind(valueUniTask);
        }
    }
}
