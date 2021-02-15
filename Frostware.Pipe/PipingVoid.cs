using System;

namespace Frostware.Pipe
{
    public static partial class Piping
    {
        /// <summary>
        /// Performs the given function passing in the input as an argument
        /// </summary>
        /// <typeparam name="T">Input type</typeparam>
        /// <param name="input">Input argument</param>
        /// <param name="func">Function the pipe will perform on the inputs</param>
        /// <returns>The input object</returns>
        public static T Pipe<T>(this T input, Action<T> func)
        {
            func(input);
            return input;
        }

        /// <summary>
        /// Performs the given function passing in 2 inputs as arguments
        /// </summary>
        /// <typeparam name="T1">First input type</typeparam>
        /// <typeparam name="T2">Second input type</typeparam>
        /// <param name="input">Input arguments</param>
        /// <param name="function">Function the pipe will perform on the inputs</param>
        /// <returns>The input object</returns>
        public static (T1, T2) Pipe2<T1, T2>(this (T1 arg1, T2 arg2) input, Action<T1, T2> function)
        {
            function(input.arg1, input.arg2);
            return input;
        }

        /// <summary>
        /// Performs the given function passing in 3 inputs as arguments
        /// </summary>
        /// <typeparam name="T1">First input type</typeparam>
        /// <typeparam name="T2">Second input type</typeparam>
        /// <typeparam name="T3">Third input type</typeparam>
        /// <param name="input">Input arguments</param>
        /// <param name="function">Function the pipe will perform on the inputs</param>
        /// <returns>The input object</returns>
        public static (T1, T2, T3) Pipe3<T1, T2, T3>(this (T1 arg1, T2 arg2, T3 arg3) input, Action<T1, T2, T3> function)
        {
            function(input.arg1, input.arg2, input.arg3);
            return input;
        }

        /// <summary>
        /// Performs the given function passing in 4 inputs as arguments
        /// </summary>
        /// <typeparam name="T1">First input type</typeparam>
        /// <typeparam name="T2">Second input type</typeparam>
        /// <typeparam name="T3">Third input type</typeparam>
        /// <typeparam name="T4">Fourth input type</typeparam>
        /// <param name="input">Input arguments</param>
        /// <param name="function">Function the pipe will perform on the inputs</param>
        /// <returns>The input object</returns>
        public static (T1, T2, T3, T4) Pipe4<T1, T2, T3, T4>(this (T1 arg1, T2 arg2, T3 arg3, T4 arg4) input, Action<T1, T2, T3, T4> function)
        {
            function(input.arg1, input.arg2, input.arg3, input.arg4);
            return input;
        }

        /// <summary>
        /// Performs the given function passing in 5 inputs as arguments
        /// </summary>
        /// <typeparam name="T1">First input type</typeparam>
        /// <typeparam name="T2">Second input type</typeparam>
        /// <typeparam name="T3">Third input type</typeparam>
        /// <typeparam name="T4">Fourth input type</typeparam>
        /// <typeparam name="T5">Fifth input type</typeparam>
        /// <param name="input">Input arguments</param>
        /// <param name="function">Function the pipe will perform on the inputs</param>
        /// <returns>The input object</returns>
        public static (T1, T2, T3, T4, T5) Pipe5<T1, T2, T3, T4, T5>(this (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) input, Action<T1, T2, T3, T4, T5> function)
        {
            function(input.arg1, input.arg2, input.arg3, input.arg4, input.arg5);
            return input;
        }
    }
}
