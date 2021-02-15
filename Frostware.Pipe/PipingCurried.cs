using Curryfy;
using System;

namespace Frostware.Pipe
{
    public static partial class Piping
    {
        /// <summary>
        /// Takes in a 2 argument function, curries it, then returns a partially applied function with input applied to the first argument
        /// </summary>
        /// <typeparam name="TArg1"></typeparam>
        /// <typeparam name="TArg2"></typeparam>
        /// <typeparam name="TFuncResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Func<TArg2, TFuncResult> PipeCurry<TArg1, TArg2, TFuncResult>(this TArg1 input, Func<TArg1, TArg2, TFuncResult> func)
            => func.Curry()(input);

        /// <summary>
        /// Takes in a 3 argument function, curries it, then returns a partially applied function with input applied to the first argument
        /// </summary>
        /// <typeparam name="TArg1"></typeparam>
        /// <typeparam name="TArg2"></typeparam>
        /// <typeparam name="TArg3"></typeparam>
        /// <typeparam name="TFuncResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Func<TArg2, Func<TArg3, TFuncResult>> PipeCurry<TArg1, TArg2, TArg3, TFuncResult>(this TArg1 input, Func<TArg1, TArg2, TArg3, TFuncResult> func)
            => func.Curry()(input);

        /// <summary>
        /// Takes in a 4 argument function, curries it, then returns a partially applied function with input applied to the first argument
        /// </summary>
        /// <typeparam name="TArg1"></typeparam>
        /// <typeparam name="TArg2"></typeparam>
        /// <typeparam name="TArg3"></typeparam>
        /// <typeparam name="TArg4"></typeparam>
        /// <typeparam name="TFuncResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Func<TArg2, Func<TArg3, Func<TArg4, TFuncResult>>> PipeCurry<TArg1, TArg2, TArg3, TArg4, TFuncResult>(this TArg1 input, Func<TArg1, TArg2, TArg3, TArg4, TFuncResult> func)
            => func.Curry()(input);

        /// <summary>
        /// Takes in a 5 argument function, curries it, then returns a partially applied function with input applied to the first argument
        /// </summary>
        /// <typeparam name="TArg1"></typeparam>
        /// <typeparam name="TArg2"></typeparam>
        /// <typeparam name="TArg3"></typeparam>
        /// <typeparam name="TArg4"></typeparam>
        /// <typeparam name="TArg5"></typeparam>
        /// <typeparam name="TFuncResult"></typeparam>
        /// <param name="input"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Func<TArg2, Func<TArg3, Func<TArg4, Func<TArg5, TFuncResult>>>> PipeCurry<TArg1, TArg2, TArg3, TArg4, TArg5, TFuncResult>(this TArg1 input, Func<TArg1, TArg2, TArg3, TArg4, TArg5, TFuncResult> func)
            => func.Curry()(input);
    }
}