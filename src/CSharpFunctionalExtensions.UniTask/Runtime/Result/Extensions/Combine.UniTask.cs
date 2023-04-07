using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    public static partial class AsyncResultExtensionsLeftOperand
    {
       public static async UniTask<Result> Combine(this IEnumerable<UniTask<Result>> tasks, string errorMessageSeparator = null)
        {
            Result[] results = await UniTask.WhenAll(tasks);
            return results.Combine(errorMessageSeparator);
        }

        public static async UniTask<Result<IEnumerable<T>, E>> Combine<T, E>(this IEnumerable<UniTask<Result<T, E>>> tasks, Func<IEnumerable<E>, E> composerError)
        {
            Result<T, E>[] results = await UniTask.WhenAll(tasks);
            return results.Combine(composerError);
        }

        public static async UniTask<Result<IEnumerable<T>, E>> Combine<T, E>(this IEnumerable<UniTask<Result<T, E>>> tasks)
            where E : ICombine
        {
            Result<T, E>[] results = await UniTask.WhenAll(tasks);
            return results.Combine();
        }

        public static async UniTask<Result<IEnumerable<T>>> Combine<T>(this IEnumerable<UniTask<Result<T>>> tasks, string errorMessageSeparator = null)
        {
            Result<T>[] results = await UniTask.WhenAll(tasks);
            return results.Combine(errorMessageSeparator);
        }

        public static async UniTask<Result> Combine(this UniTask<IEnumerable<Result>> task, string errorMessageSeparator = null)
        {
            IEnumerable<Result> results = await task;
            return results.Combine(errorMessageSeparator);
        }

        public static async UniTask<Result<IEnumerable<T>, E>> Combine<T, E>(this UniTask<IEnumerable<Result<T, E>>> task, Func<IEnumerable<E>, E> composerError)
        {
            IEnumerable<Result<T, E>> results = await task;
            return results.Combine(composerError);
        }

        public static async UniTask<Result<IEnumerable<T>, E>> Combine<T, E>(this UniTask<IEnumerable<Result<T, E>>> task)
            where E : ICombine
        {
            IEnumerable<Result<T, E>> results = await task;
            return results.Combine();
        }

        public static async UniTask<Result<IEnumerable<T>>> Combine<T>(this UniTask<IEnumerable<Result<T>>> task, string errorMessageSeparator = null)
        {
            IEnumerable<Result<T>> results = await task;
            return results.Combine(errorMessageSeparator);
        }

        public static async UniTask<Result> Combine(this UniTask<IEnumerable<UniTask<Result>>> task, string errorMessageSeparator = null)
        {
            IEnumerable<UniTask<Result>> tasks = await task;
            return await tasks.Combine(errorMessageSeparator);
        }

        public static async UniTask<Result<IEnumerable<T>, E>> Combine<T, E>(this UniTask<IEnumerable<UniTask<Result<T, E>>>> task, Func<IEnumerable<E>, E> composerError)
        {
            IEnumerable<UniTask<Result<T, E>>> tasks = await task;
            return await tasks.Combine(composerError);
        }

        public static async UniTask<Result<IEnumerable<T>, E>> Combine<T, E>(this UniTask<IEnumerable<UniTask<Result<T, E>>>> task)
            where E : ICombine
        {
            IEnumerable<UniTask<Result<T, E>>> tasks = await task;
            return await tasks.Combine();
        }

        public static async UniTask<Result<IEnumerable<T>>> Combine<T>(this UniTask<IEnumerable<UniTask<Result<T>>>> task, string errorMessageSeparator = null)
        {
            IEnumerable<UniTask<Result<T>>> tasks = await task;
            return await tasks.Combine(errorMessageSeparator);
        }

        public static async UniTask<Result<K, E>> Combine<T, K, E>(this IEnumerable<UniTask<Result<T, E>>> tasks, Func<IEnumerable<T>, K> composer, Func<IEnumerable<E>, E> composerError)
        {
            IEnumerable<Result<T, E>> results = await UniTask.WhenAll(tasks);
            return results.Combine(composer, composerError);
        }

        public static async UniTask<Result<K, E>> Combine<T, K, E>(this IEnumerable<UniTask<Result<T, E>>> tasks, Func<IEnumerable<T>, K> composer)
            where E : ICombine
        {
            IEnumerable<Result<T, E>> results = await UniTask.WhenAll(tasks);
            return results.Combine(composer);
        }

        public static async UniTask<Result<K>> Combine<T, K>(this IEnumerable<UniTask<Result<T>>> tasks, Func<IEnumerable<T>, K> composer, string errorMessageSeparator = null)
        {
            IEnumerable<Result<T>> results = await UniTask.WhenAll(tasks);
            return results.Combine(composer, errorMessageSeparator);
        }

        public static async UniTask<Result<K, E>> Combine<T, K, E>(this UniTask<IEnumerable<UniTask<Result<T, E>>>> task, Func<IEnumerable<T>, K> composer, Func<IEnumerable<E>, E> composerError)
        {
            IEnumerable<UniTask<Result<T, E>>> tasks = await task;
            return await tasks.Combine(composer, composerError);
        }

        public static async UniTask<Result<K, E>> Combine<T, K, E>(this UniTask<IEnumerable<UniTask<Result<T, E>>>> task, Func<IEnumerable<T>, K> composer)
            where E : ICombine
        {
            IEnumerable<UniTask<Result<T, E>>> tasks = await task;
            return await tasks.Combine(composer);
        }

        public static async UniTask<Result<K>> Combine<T, K>(this UniTask<IEnumerable<UniTask<Result<T>>>> task, Func<IEnumerable<T>, K> composer, string errorMessageSeparator = null)
        {
            IEnumerable<UniTask<Result<T>>> tasks = await task;
            return await tasks.Combine(composer, errorMessageSeparator);
        }
    }
}
