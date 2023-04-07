using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpFunctionalExtensions
{
    internal static class UniTaskExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UniTask<T> AsCompletedUniTask<T>(this T obj) => UniTask.FromResult(obj);
    }
}
