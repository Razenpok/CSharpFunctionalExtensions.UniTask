using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static async UniTask<Result> BindIf(this UniTask<Result> resultUniTask, bool condition, Func<UniTask<Result>> valueUniTask)
        {
            var result = await resultUniTask;
            return await result.BindIf(condition, valueUniTask);
        }

        public static async UniTask<Result<T>> BindIf<T>(this UniTask<Result<T>> resultUniTask, bool condition, Func<T, UniTask<Result<T>>> valueUniTask)
        {
            var result = await resultUniTask;
            return await result.BindIf(condition, valueUniTask);
        }

        public static async UniTask<UnitResult<E>> BindIf<E>(this UniTask<UnitResult<E>> resultUniTask, bool condition, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            var result = await resultUniTask;
            return await result.BindIf(condition, valueUniTask);
        }

        public static async UniTask<Result<T, E>> BindIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition, Func<T, UniTask<Result<T, E>>> valueUniTask)
        {
            var result = await resultUniTask;
            return await result.BindIf(condition, valueUniTask);
        }

        public static async UniTask<Result> BindIf(this UniTask<Result> resultUniTask, Func<bool> predicate, Func<UniTask<Result>> valueUniTask)
        {
            var result = await resultUniTask;
            return await result.BindIf(predicate, valueUniTask);
        }

        public static async UniTask<Result<T>> BindIf<T>(this UniTask<Result<T>> resultUniTask, Func<T, bool> predicate, Func<T, UniTask<Result<T>>> valueUniTask)
        {
            var result = await resultUniTask;
            return await result.BindIf(predicate, valueUniTask);
        }

        public static async UniTask<UnitResult<E>> BindIf<E>(this UniTask<UnitResult<E>> resultUniTask, Func<bool> predicate, Func<UniTask<UnitResult<E>>> valueUniTask)
        {
            
            var result = await resultUniTask;
            return await result.BindIf(predicate, valueUniTask);
        }

        public static async UniTask<Result<T, E>> BindIf<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, bool> predicate, Func<T, UniTask<Result<T, E>>> valueUniTask)
        {
            var result = await resultUniTask;
            return await result.BindIf(predicate, valueUniTask);
        }
    }
}
