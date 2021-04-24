using Curryfy;
using System;

namespace Frostware.Pipe
{
    public static partial class Piping
    {
        /// <summary>
        /// Takes in a 2 argument function, curries it, then returns a partially applied function with input applied to the first argument
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T2, TResult> Pipe<T1, T2, TResult>(this T1 input, Func<T1, T2, TResult> function)
            => function.Curry()(input);

        /// <summary>
        /// Takes in a 3 argument function, curries it, then returns a partially applied function with input applied to the first argument
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T2, Func<T3, TResult>> Pipe<T1, T2, T3, TResult>(this T1 input, Func<T1, T2, T3, TResult> function)
            => function.Curry()(input);

        /// <summary>
        /// Takes in a 3 argument function, curries it, then returns a partially applied function with the 2 inputs applied
        /// to the first 2 arguments
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T3, TResult> Pipe2<T1, T2, T3, TResult>(this (T1 arg1, T2 arg2) input, Func<T1, T2, T3, TResult> function)
            => function.Curry()(input.arg1)(input.arg2);


        /// <summary>
        /// Takes in a 4 argument function, curries it, then returns a partially applied function with the input applied
        /// to the first argument
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T2, Func<T3, Func<T4, TResult>>> Pipe<T1, T2, T3, T4, TResult>(this T1 input, Func<T1, T2, T3, T4, TResult> function)
            => function.Curry()(input);

        /// <summary>
        /// Takes in a 4 argument function, curries it, then returns a partially applied function with the 2 inputs applied
        /// to the first 2 arguments
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T3, Func<T4, TResult>> Pipe2<T1, T2, T3, T4, TResult>(this (T1 input1, T2 input2) input, Func<T1, T2, T3, T4, TResult> function)
            => function.Curry()(input.input1)(input.input2);

        /// <summary>
        /// Takes in a 4 argument function, curries it, then returns a partially applied function with the 3 inputs applied
        /// to the first 3 arguments
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T4, TResult> Pipe3<T1, T2, T3, T4, TResult>(this (T1 input1, T2 input2, T3 input3) input, Func<T1, T2, T3, T4, TResult> function)
            => function.Curry()(input.input1)(input.input2)(input.input3);

        /// <summary>
        /// Takes in a 5 argument function, curries it, then returns a partially applied function with input applied to the first argument
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>> Pipe<T1, T2, T3, T4, T5, TResult>(this T1 input, Func<T1, T2, T3, T4, T5, TResult> function)
            => function.Curry()(input);

        /// <summary>
        /// Takes in a 5 argument function, curries it, then returns a partially applied function with the 2 inputs applied
        /// to the first 2 arguments
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T3, Func<T4, Func<T5, TResult>>> Pipe2<T1, T2, T3, T4, T5, TResult>(this (T1 input1, T2 input2) input, Func<T1, T2, T3, T4, T5, TResult> function)
            => function.Curry()(input.input1)(input.input2);

        /// <summary>
        /// Takes in a 5 argument function, curries it, then returns a partially applied function with the 3 inputs applied
        /// to the first 3 arguments
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T4, Func<T5, TResult>> Pipe3<T1, T2, T3, T4, T5, TResult>(this (T1 input1, T2 input2, T3 input3) input, Func<T1, T2, T3, T4, T5, TResult> function)
            => function.Curry()(input.input1)(input.input2)(input.input3);

        /// <summary>
        /// Takes in a 5 argument function, curries it, then returns a partially applied function with the 4 inputs applied
        /// to the first 4 arguments
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="function"></param>
        /// <returns></returns>
        public static Func<T5, TResult> Pipe4<T1, T2, T3, T4, T5, TResult>(this (T1 input1, T2 input2, T3 input3, T4 input4) input, Func<T1, T2, T3, T4, T5, TResult> function)
            => function.Curry()(input.input1)(input.input2)(input.input3)(input.input4);
    }
}