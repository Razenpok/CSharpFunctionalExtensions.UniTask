#nullable enable

using System;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class ResultExtensions
    {
        public static UniTask<Result<T>> EnsureNotNull<T>(this UniTask<Result<T?>> resultUniTask, Func<string> errorFactory)
            where T : class
        {
            return resultUniTask.Ensure(value => value != null, _ => errorFactory()).Map(value => value!);
        }

        public static UniTask<Result<T>> EnsureNotNull<T>(this UniTask<Result<T?>> resultUniTask, Func<string> errorFactory)
            where T : struct
        {
            return resultUniTask.Ensure(value => value != null, _ => errorFactory()).Map(value => value!.Value);
        }

        public static UniTask<Result<T, E>> EnsureNotNull<T, E>(this UniTask<Result<T?, E>> resultUniTask, Func<E> errorFactory)
            where T : class
        {
            return resultUniTask.Ensure(value => UniTask.FromResult(value != null), _ => errorFactory()).Map(value => value!);
        }

        public static UniTask<Result<T, E>> EnsureNotNull<T, E>(this UniTask<Result<T?, E>> resultUniTask, Func<E> errorFactory)
            where T : struct
        {
            return resultUniTask.Ensure(value => UniTask.FromResult(value != null), _ => errorFactory()).Map(value => value!.Value);
        }
    }
}
