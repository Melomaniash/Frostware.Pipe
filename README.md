# Frostware.Pipe: A lightweight piping framework for CSharp

## Table of contents
* [Why Piping?](#why-piping)
* [Basics](#basics)
* [Dependencies](#dependencies)
 
# Why Piping?

In computer programming, a pipe is a technique for passing information from one program process to another. A pipe passes a parameter such as the output of one process to another process which accepts it as input. The system temporarily holds the piped information until it is read by the receiving process.

This is usefull cause it alows us to write more readable code that requires less temporary variables.

Consider this example:
```cs
//prints "2" to the console
Console.WriteLine(MathF.Round(1.7f));
```
Here we are rounding 1.7, then printing the result to the console;
Which is fine, but there are 2 main problems with this.

1. The order of oporations is the opposite of how it is read. 
2. Once this gets more complicated, it get's harder to keep track of what is going on. To combat this, it is common to cache intermidiate states in order to maintain readability

Instead, we could use a pipe:

```cs
1.7f
   .Pipe(MathF.Round) // returns 2f
   .Pipe(Console.WriteLine); //Prints "2" in the console
```
Now, the operations are executed the way they are read and the logic is easier to follow, there is no longer a need to cache values for readability's sake.


# Basics
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

Console.WriteLine() also takes in a float, so we can take the result of our rounding and print it to the console. 
```cs
3f
    .Pipe(x => x / 2f) // returns 1.5f
    .Pipe(MathF.Round) // returns 2f
    .Pipe(Console.WriteLine); //Prints "2" in the console
```

# Dependencies
* [Currify](https://github.com/leandromoh/Curryfy)
