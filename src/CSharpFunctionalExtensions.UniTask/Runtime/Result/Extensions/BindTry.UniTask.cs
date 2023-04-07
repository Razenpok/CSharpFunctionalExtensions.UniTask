using Cysharp.Threading.Tasks;
using System;

namespace CSharpFunctionalExtensions
{
	public static partial class AsyncResultExtensionsBothOperands
	{
        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>        
        /// <param name="resultUniTask">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result> BindTry(this UniTask<Result> resultUniTask, Func<UniTask<Result>> valueUniTask,
			Func<Exception, string> errorHandler = null)
		{            
			var result = await resultUniTask;
			return await result.BindTry(valueUniTask, errorHandler);
		}

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>        
        /// <typeparam name="K"><paramref name="valueUniTask" /> Result Type parameter</typeparam>        
        /// <param name="resultUniTask">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result<K>> BindTry<K>(this UniTask<Result> resultUniTask, Func<UniTask<Result<K>>> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            var result = await resultUniTask;
            return await result.BindTry(valueUniTask, errorHandler);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        /// <typeparam name="T">Result Type parameter</typeparam>        
        /// <param name="resultUniTask">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result> BindTry<T>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask<Result>> valueUniTask,
			Func<Exception, string> errorHandler = null)
		{
			var result = await resultUniTask;
			return await result.BindTry(valueUniTask, errorHandler);
		}

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>    
        /// <typeparam name="T">Result Type parameter</typeparam>
        /// <typeparam name="K"><paramref name="valueUniTask" /> Result Type parameter</typeparam>        
        /// <param name="resultUniTask">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result<K>> BindTry<T, K>(this UniTask<Result<T>> resultUniTask, Func<T, UniTask<Result<K>>> valueUniTask,
            Func<Exception, string> errorHandler = null)
        {
            var result = await resultUniTask;
            return await result.BindTry(valueUniTask, errorHandler);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        /// <typeparam name="T">Result Type parameter</typeparam>
        /// <typeparam name="E">Error Type parameter</typeparam>
        /// <param name="resultUniTask">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<UnitResult<E>> BindTry<T, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask<UnitResult<E>>> valueUniTask,
            Func<Exception, E> errorHandler)
        {
            var result = await resultUniTask;
            return await result.BindTry(valueUniTask, errorHandler);
        }

        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler
        /// </summary>
        /// <typeparam name="T">Result Type parameter</typeparam>
        /// <typeparam name="K"><paramref name="valueUniTask" /> Result Type parameter</typeparam>
        /// <typeparam name="E">Error Type parameter</typeparam>
        /// <param name="resultUniTask">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<Result<K, E>> BindTry<T, K, E>(this UniTask<Result<T, E>> resultUniTask, Func<T, UniTask<Result<K, E>>> valueUniTask,
			Func<Exception, E> errorHandler)
		{
			var result = await resultUniTask;
			return await result.BindTry(valueUniTask, errorHandler);
		}

        /// <summary>
		///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
		///     If a given function throws an exception, an error is returned from the given error handler
		/// </summary>
        /// <typeparam name="T">Result Type parameter</typeparam>
        /// <typeparam name="E">Error Type parameter</typeparam>
        /// <param name="resultUniTask">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
		public static async UniTask<Result<T, E>> BindTry<T, E>(this UniTask<UnitResult<E>> resultUniTask, Func<UniTask<Result<T, E>>> valueUniTask,
            Func<Exception, E> errorHandler)
        {
            var result = await resultUniTask;
            return await result.BindTry(valueUniTask, errorHandler);
        }


        /// <summary>
        ///     Selects result from the return value of a given function. If the calling Result is a failure, a new failure result is returned instead.
        ///     If a given function throws an exception, an error is returned from the given error handler        ///             ///     
        /// </summary>        
        /// <typeparam name="E">Error Type parameter</typeparam>
        /// <param name="resultUniTask">Extended result</param>
        /// <param name="valueUniTask">Function returning result to bind</param>
        /// <param name="errorHandler">Error handling function</param>
        /// <returns>Binding result</returns>
        public static async UniTask<UnitResult<E>> BindTry<E>(this UniTask<UnitResult<E>> resultUniTask, Func<UniTask<UnitResult<E>>> valueUniTask,
			Func<Exception, E> errorHandler)
		{
			var result = await resultUniTask;
			return await result.BindTry(valueUniTask, errorHandler);
		}			
	}
}
