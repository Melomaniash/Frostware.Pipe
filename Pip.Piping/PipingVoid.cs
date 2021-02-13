using System;

namespace Pip.Piping
{
    public static partial class Piping
    {
        public static T Pipe<T>(this T input, Action<T> func)
        {
            func(input);
            return input;
        }

        public static (T1, T2) Pipe2<T1, T2>(this (T1 arg1, T2 arg2) input, Action<T1, T2> func)
        {
            func(input.arg1, input.arg2);
            return input;
        }

        public static (T1, T2, T3) Pipe3<T1, T2, T3>(this (T1 arg1, T2 arg2, T3 arg3) input, Action<T1, T2, T3> func)
        {
            func(input.arg1, input.arg2, input.arg3);
            return input;
        }

        public static (T1, T2, T3, T4) Pipe4<T1, T2, T3, T4>(this (T1 arg1, T2 arg2, T3 arg3, T4 arg4) input, Action<T1, T2, T3, T4> func)
        {
            func(input.arg1, input.arg2, input.arg3, input.arg4);
            return input;
        }

        public static (T1, T2, T3, T4, T5) Pipe5<T1, T2, T3, T4, T5>(this (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) input, Action<T1, T2, T3, T4, T5> func)
        {
            func(input.arg1, input.arg2, input.arg3, input.arg4, input.arg5);
            return input;
        }
    }
}
