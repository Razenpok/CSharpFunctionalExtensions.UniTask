using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        /// <summary>
        ///     This method should be used in linq queries. We recommend using Bind method.
        /// </summary>
        public static async UniTask<Result<TR>> SelectMany<T, TK, TR>(
            this UniTask<Result<T>> resultUniTask,
            Func<T, UniTask<Result<TK>>> valueUniTask,
            Func<T, TK, TR> project)
        {
            Result<T> result = await resultUniTask;
            return await result.SelectMany(valueUniTask, project);
        }

        /// <summary>
        ///     This method should be used in linq queries. We recommend using Bind method.
        /// </summary>
        public static async UniTask<Result<TR, TE>> SelectMany<T, TK, TE, TR>(
            this UniTask<Result<T, TE>> resultUniTask,
            Func<T, UniTask<Result<TK, TE>>> valueUniTask,
            Func<T, TK, TR> project)
        {
            Result<T, TE> result = await resultUniTask;
            return await result.SelectMany(valueUniTask, project);
        }
    }
}
