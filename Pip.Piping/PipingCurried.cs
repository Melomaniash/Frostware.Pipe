using Curryfy;
using System;

namespace Pip.Piping
{
    public static partial class Piping
    {
        public static Func<TArg2, TFuncResult> Pipe<TArg1, TArg2, TFuncResult>(this TArg1 input, Func<TArg1, TArg2, TFuncResult> func)
            => func.Curry()(input);

        public static Func<TArg2, Func<TArg3, TFuncResult>> Pipe<TArg1, TArg2, TArg3, TFuncResult>(this TArg1 input, Func<TArg1, TArg2, TArg3, TFuncResult> func)
            => func.Curry()(input);

        public static Func<TArg2, Func<TArg3, Func<TArg4, TFuncResult>>> Pipe<TArg1, TArg2, TArg3, TArg4, TFuncResult>(this TArg1 input, Func<TArg1, TArg2, TArg3, TArg4, TFuncResult> func)
            => func.Curry()(input);

        public static Func<TArg2, Func<TArg3, Func<TArg4, Func<TArg5, TFuncResult>>>> Pipe<TArg1, TArg2, TArg3, TArg4, TArg5, TFuncResult>(this TArg1 input, Func<TArg1, TArg2, TArg3, TArg4, TArg5, TFuncResult> func)
            => func.Curry()(input);
    }
}