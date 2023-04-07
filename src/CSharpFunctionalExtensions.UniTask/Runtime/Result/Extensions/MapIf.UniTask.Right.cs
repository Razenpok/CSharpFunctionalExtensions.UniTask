using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static UniTask<Result<T>> MapIf<T>(this Result<T> result, bool condition, Func<T, UniTask<T>> valueUniTask)
        {
            if (!condition)
            {
                return result.AsCompletedUniTask();
            }

            return result.Map(valueUniTask);
        }

        public static UniTask<Result<T, E>> MapIf<T, E>(this Result<T, E> result, bool condition, Func<T, UniTask<T>> valueUniTask)
        {
            if (!condition)
            {
                return result.AsCompletedUniTask();
            }

            return result.Map(valueUniTask);
        }

        public static UniTask<Result<T>> MapIf<T>(this Result<T> result, Func<T, bool> predicate, Func<T, UniTask<T>> valueUniTask)
        {
            if (!result.IsSuccess || !predicate(result.Value))
            {
                return result.AsCompletedUniTask();
            }

            return result.Map(valueUniTask);
        }

        public static UniTask<Result<T, E>> MapIf<T, E>(this Result<T, E> result, Func<T, bool> predicate, Func<T, UniTask<T>> valueUniTask)
        {
            if (!result.IsSuccess || !predicate(result.Value))
            {
                return result.AsCompletedUniTask();
            }

            return result.Map(valueUniTask);
        }
    }
}
