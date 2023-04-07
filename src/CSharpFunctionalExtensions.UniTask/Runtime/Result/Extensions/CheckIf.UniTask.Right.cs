using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsRightOperand
    {
        public static UniTask<Result<T>> CheckIf<T>(this Result<T> result, bool condition, Func<T, UniTask<Result>> valueUniTask)
        {
            if (condition)
                return result.Check(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        public static UniTask<Result<T>> CheckIf<T, K>(this Result<T> result, bool condition, Func<T, UniTask<Result<K>>> valueUniTask)
        {
            if (condition)
                return result.Check(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        public static UniTask<Result<T, E>> CheckIf<T, K, E>(this Result<T, E> result, bool condition, Func<T, UniTask<Result<K, E>>> valueUniTask)
        {
            if (condition)
                return result.Check(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        public static UniTask<Result<T, E>> CheckIf<T, E>(this Result<T, E> result, bool condition, Func<T, UniTask<UnitResult<E>>> valueUniTask)
        {
            if (condition)
                return result.Check(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        public static UniTask<UnitResult<E>> CheckIf<E>(this UnitResult<E> result, bool condition, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            if (condition)
                return result.Check(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        public static UniTask<Result<T>> CheckIf<T>(this Result<T> result, Func<T, bool> predicate, Func<T, UniTask<Result>> valueUniTask)
        {
            if (result.IsSuccess && predicate(result.Value))
                return result.Check(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        public static UniTask<Result<T>> CheckIf<T, K>(this Result<T> result, Func<T, bool> predicate, Func<T, UniTask<Result<K>>> valueUniTask)
        {
            if (result.IsSuccess && predicate(result.Value))
                return result.Check(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        public static UniTask<Result<T, E>> CheckIf<T, K, E>(this Result<T, E> result, Func<T, bool> predicate, Func<T, UniTask<Result<K, E>>> valueUniTask)
        {
            if (result.IsSuccess && predicate(result.Value))
                return result.Check(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        public static UniTask<Result<T, E>> CheckIf<T, E>(this Result<T, E> result, Func<T, bool> predicate, Func<T, UniTask<UnitResult<E>>> valueUniTask)
        {
            if (result.IsSuccess && predicate(result.Value))
                return result.Check(valueUniTask);
            else
                return result.AsCompletedUniTask();
        }

        public static async UniTask<UnitResult<E>> CheckIf<E>(this UnitResult<E> result, Func<bool> predicate, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            if (result.IsSuccess && predicate())
                return await result.Check(valueUniTask);
            else
                return result;
        }
    }
}
