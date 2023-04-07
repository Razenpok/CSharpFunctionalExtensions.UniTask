using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static async UniTask<Result> Compensate(this UniTask<Result> resultUniTask, Func<string, Result> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }

        public static async UniTask<UnitResult<E>> Compensate<E>(this UniTask<Result> resultUniTask, Func<string, UnitResult<E>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }

        public static async UniTask<Result> Compensate<T>(this UniTask<Result<T>> resultUniTask, Func<string, Result> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }

        public static async UniTask<Result<T>> Compensate<T>(this UniTask<Result<T>> resultUniTask, Func<string, Result<T>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }

        public static async UniTask<Result<T, E>> Compensate<T, E>(this UniTask<Result<T>> resultUniTask, Func<string, Result<T, E>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }

        public static async UniTask<Result> Compensate<E>(this UniTask<UnitResult<E>> resultUniTask, Func<E, Result> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }

        public static async UniTask<UnitResult<E2>> Compensate<E, E2>(this UniTask<UnitResult<E>> resultUniTask, Func<E, UnitResult<E2>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }

        public static async UniTask<Result> Compensate<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<E, Result> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }

        public static async UniTask<UnitResult<E2>> Compensate<T, E, E2>(this UniTask<Result<T, E>> resultUniTask, Func<E, UnitResult<E2>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }

        public static async UniTask<Result<T, E2>> Compensate<T, E, E2>(this UniTask<Result<T, E>> resultUniTask, Func<E, Result<T, E2>> valueUniTask)
        {
            var result = await resultUniTask;
            return result.Compensate(valueUniTask);
        }
    }
}
