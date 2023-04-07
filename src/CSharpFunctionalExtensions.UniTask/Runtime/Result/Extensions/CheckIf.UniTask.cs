using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsBothOperands
    {
        public static UniTask<Result<T>> CheckIf<T>(this UniTask<Result<T>> resultUniTask, bool condition,
            Func<T, UniTask<Result>> valueUniTask)
        {
            if (condition)
                return resultUniTask.Check(valueUniTask);
            else
                return resultUniTask;
        }

        public static UniTask<Result<T>> CheckIf<T, K>(this UniTask<Result<T>> resultUniTask, bool condition,
            Func<T, UniTask<Result<K>>> valueUniTask)
        {
            if (condition)
                return resultUniTask.Check(valueUniTask);
            else
                return resultUniTask;
        }

        public static UniTask<Result<T, E>> CheckIf<T, K, E>(this UniTask<Result<T, E>> resultUniTask, bool condition,
            Func<T, UniTask<Result<K, E>>> valueUniTask)
        {
            if (condition)
                return resultUniTask.Check(valueUniTask);
            else
                return resultUniTask;
        }

        public static UniTask<Result<T, E>> CheckIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition,
            Func<T, UniTask<UnitResult<E>>> valueUniTask)
        {
            if (condition)
                return resultUniTask.Check(valueUniTask);
            else
                return resultUniTask;
        }

        public static UniTask<UnitResult<E>> CheckIf<E>(this UniTask<UnitResult<E>> resultUniTask, bool condition,
            Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            if (condition)
                return resultUniTask.Check(valueUniTask);
            else
                return resultUniTask;
        }

        public static async UniTask<Result<T>> CheckIf<T>(this UniTask<Result<T>> resultUniTask,
            Func<T, bool> predicate, Func<T, UniTask<Result>> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsSuccess && predicate(result.Value))
                return await result.Check(valueUniTask);
            else
                return result;
        }

        public static async UniTask<Result<T>> CheckIf<T, K>(this UniTask<Result<T>> resultUniTask,
            Func<T, bool> predicate, Func<T, UniTask<Result<K>>> valueUniTask)
        {
            Result<T> result = await resultUniTask;

            if (result.IsSuccess && predicate(result.Value))
                return await result.Check(valueUniTask);
            else
                return result;
        }

        public static async UniTask<Result<T, E>> CheckIf<T, K, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<T, bool> predicate, Func<T, UniTask<Result<K, E>>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsSuccess && predicate(result.Value))
                return await result.Check(valueUniTask);
            else
                return result;
        }

        public static async UniTask<Result<T, E>> CheckIf<T, E>(this UniTask<Result<T, E>> resultUniTask,
            Func<T, bool> predicate, Func<T, UniTask<UnitResult<E>>> valueUniTask)
        {
            Result<T, E> result = await resultUniTask;

            if (result.IsSuccess && predicate(result.Value))
                return await result.Check(valueUniTask);
            else
                return result;
        }

        public static async UniTask<UnitResult<E>> CheckIf<E>(this UniTask<UnitResult<E>> resultUniTask,
            Func<bool> predicate, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            UnitResult<E> result = await resultUniTask;

            if (result.IsSuccess && predicate())
                return await result.Check(valueUniTask);
            else
                return result;
        }
    }
}
