# Frostware.Pipe: A lightweight piping framework for CSharp


## Table of contents
* [Why Piping?](#why-piping)
* [Introduction](#introduction)
  * [Basics](#basics)
* [Dependencies](#Dependencies)
  
# Introduction

### Why Piping?
Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit
in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident,
sunt in culpa qui officia deserunt mollit anim id est laborum.

### Basics
Pip extends all objects with the Pipe method, whether it be a string, an int or a class. Everything can be pipped.

```cs
"Hello".Pipe()
2.Pipe()
new Foo().Pipe()
```

The simplest form of pipe is the lambda pipe.

```cs
var result = "Hello"
     .Pipe(hello => hello + " World"); // returns "Hello World"

var result = 2
     .Pipe(two => two + 2); // returns 4
```

Pipes can be chained any amount of times, the result of the first being piped into the input of the next.

```cs
var result = 3f
    .Pipe(x => x / 2) // returns 1.5f
    //x here is 1.5f
    .Pipe(x => MathF.Round(x)); // returns 2f
```

Which is pretty cool, but this can be simplified.

Since the Pipe methods take in an Action or a Func, that means we can pass in methods that match the function signature.
In the case above, the second pipe takes in a float, so we can pass any 1 perameter method that takes in a float.

MathF.Round has an overload that takes in 1 float, which means we can do this:

```cs
var result = 3f
    .Pipe(x => x / 2) // returns 1.5f
    //the pipe will pass 1.5f into MathF.Round implicitly
    .Pipe(MathF.Round); // returns 2f
```

Console.WriteLine() also takes in 1 argument that can be a float. So we could also do this: 
```cs
3f
    .Pipe(x => x / 2f) // returns 1.5f
    .Pipe(MathF.Round); // returns 2f
    .Pipe(Console.WriteLine) //Prints 2 in the console
```

# Dependencies
* [Currify](https://github.com/leandromoh/Curryfy)
