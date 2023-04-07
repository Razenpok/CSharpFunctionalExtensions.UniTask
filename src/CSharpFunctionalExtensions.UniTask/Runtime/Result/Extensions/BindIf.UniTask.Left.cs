using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static async UniTask<Result> BindIf(this UniTask<Result> resultUniTask, bool condition, Func<Result> valueUniTask)
        {
            var result = await resultUniTask;
            return result.BindIf(condition, valueUniTask);
        }

        public static async UniTask<Result<T>> BindIf<T>(this UniTask<Result<T>> resultUniTask, bool condition, Func<T, Result<T>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.BindIf(condition, valueUniTask);
        }

        public static async UniTask<UnitResult<E>> BindIf<E>(this UniTask<UnitResult<E>> resultUniTask, bool condition, Func<UnitResult<E>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.BindIf(condition, valueUniTask);
        }

        public static async UniTask<Result<T, E>> BindIf<T, E>(this UniTask<Result<T, E>> resultUniTask, bool condition, Func<T, Result<T, E>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.BindIf(condition, valueUniTask);
        }

        public static async UniTask<Result> BindIf(this UniTask<Result> resultUniTask, Func<bool> predicate, Func<Result> valueUniTask)
        {
            var result = await resultUniTask;
            return result.BindIf(predicate, valueUniTask);
        }

        public static async UniTask<Result<T>> BindIf<T>(this UniTask<Result<T>> resultUniTask, Func<T, bool> predicate, Func<T, Result<T>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.BindIf(predicate, valueUniTask);
        }

        public static async UniTask<UnitResult<E>> BindIf<E>(this UniTask<UnitResult<E>> resultUniTask, Func<bool> predicate, Func<UnitResult<E>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.BindIf(predicate, valueUniTask);
        }

        public static async UniTask<Result<T, E>> BindIf<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, bool> predicate, Func<T, Result<T, E>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.BindIf(predicate, valueUniTask);
        }
    }
}
