using System;

namespace Pip.Piping
{
    public static partial class Piping
    {
        public static TResult Pipe<T, TResult>(this T input, Func<T, TResult> func)
            => func(input);

        public static TResult Pipe2<T1, T2, TResult>(this (T1 arg1, T2 arg2) input, Func<T1, T2, TResult> func)
            => func(input.arg1, input.arg2);

        public static TResult Pipe3<T1, T2, T3, TResult>(this (T1 arg1, T2 arg2, T3 arg3) input, Func<T1, T2, T3, TResult> func)
           => func(input.arg1, input.arg2, input.arg3);

        public static TResult Pipe4<T1, T2, T3, T4, TResult>(this (T1 arg1, T2 arg2, T3 arg3, T4 arg4) input, Func<T1, T2, T3, T4, TResult> func)
          => func(input.arg1, input.arg2, input.arg3, input.arg4);

        public static TResult Pipe5<T1, T2, T3, T4, T5, TResult>(this (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) input, Func<T1, T2, T3, T4, T5, TResult> func)
          => func(input.arg1, input.arg2, input.arg3, input.arg4, input.arg5);
    }
}
