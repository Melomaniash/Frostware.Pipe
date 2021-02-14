using System;

namespace Pip.Piping
{
    public static partial class Piping
    {
        /// <summary>
        /// Performs the given function passing in the input as an argument
        /// </summary>
        /// <typeparam name="T">Input type</typeparam>
        /// <typeparam name="TResult">Function return type</typeparam>
        /// <param name="input">Input argument</param>
        /// <param name="function">Function the pipe will perform on the inputs</param>
        /// <returns>The function result</returns>
        public static TResult Pipe<T, TResult>(this T input, Func<T, TResult> function)
            => function(input);

        /// <summary>
        /// Performs the given function passing in 2 inputs as arguments
        /// </summary>
        /// <typeparam name="T1">First input type</typeparam>
        /// <typeparam name="T2">Second input type</typeparam>
        /// <typeparam name="TResult">Function return type</typeparam>
        /// <param name="input">Input arguments</param>
        /// <param name="function">Function the pipe will perform on the inputs</param>
        /// <returns>The function result</returns>
        public static TResult Pipe2<T1, T2, TResult>(this (T1 arg1, T2 arg2) input, Func<T1, T2, TResult> function)
            => function(input.arg1, input.arg2);

        /// <summary>
        /// Performs the given function passing in 3 inputs as arguments
        /// </summary>
        /// <typeparam name="T1">First input type</typeparam>
        /// <typeparam name="T2">Second input type</typeparam>
        /// <typeparam name="T3">Third input type</typeparam>
        /// <typeparam name="TResult">Function return type</typeparam>
        /// <param name="input">Input arguments</param>
        /// <param name="function">Function the pipe will perform on the inputs</param>
        /// <returns>The function result</returns>
        public static TResult Pipe3<T1, T2, T3, TResult>(this (T1 arg1, T2 arg2, T3 arg3) input, Func<T1, T2, T3, TResult> function)
           => function(input.arg1, input.arg2, input.arg3);

        /// <summary>
        /// Performs the given function passing in 4 inputs as arguments
        /// </summary>
        /// <typeparam name="T1">First input type</typeparam>
        /// <typeparam name="T2">Second input type</typeparam>
        /// <typeparam name="T3">Third input type</typeparam>
        /// <typeparam name="T4">Fourth input type</typeparam>
        /// <typeparam name="TResult">Function return type</typeparam>
        /// <param name="input">Input arguments</param>
        /// <param name="function">Function the pipe will perform on the inputs</param>
        /// <returns>The function result</returns>
        public static TResult Pipe4<T1, T2, T3, T4, TResult>(this (T1 arg1, T2 arg2, T3 arg3, T4 arg4) input, Func<T1, T2, T3, T4, TResult> function)
          => function(input.arg1, input.arg2, input.arg3, input.arg4);

        /// <summary>
        /// Performs the given function passing in 4 inputs as arguments
        /// </summary>
        /// <typeparam name="T1">First input type</typeparam>
        /// <typeparam name="T2">Second input type</typeparam>
        /// <typeparam name="T3">Third input type</typeparam>
        /// <typeparam name="T4">Fourth input type</typeparam>
        /// <typeparam name="T5">Fifth input type</typeparam>
        /// <typeparam name="TResult">Function return type</typeparam>
        /// <param name="input">Input arguments</param>
        /// <param name="function">Function the pipe will perform on the inputs</param>
        /// <returns>The function result</returns>
        public static TResult Pipe5<T1, T2, T3, T4, T5, TResult>(this (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) input, Func<T1, T2, T3, T4, T5, TResult> function)
          => function(input.arg1, input.arg2, input.arg3, input.arg4, input.arg5);
    }
}