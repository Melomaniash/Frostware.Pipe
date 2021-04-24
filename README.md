# Frostware.Pipe
[![nuget](https://img.shields.io/nuget/v/Frostware.Pipe?style=flat-square)](https://www.nuget.org/packages/Frostware.Pipe/)

A lightweight piping library for C#

## Table of contents
* [Why Piping?](#why-piping)
* [Basics](#basics)
* [Multi Pipes](#multi-pipes)
* [Curried Pipes](#curried-pipes)
* [Dependencies](#dependencies)
 
# Why Piping?

In computer programming, a pipe is a technique for passing information from one program process to another. A pipe passes a parameter such as the output of one process to another process which accepts it as input. The system temporarily holds the piped information until it is read by the receiving process.

This is useful because it allows us to write more readable code that requires less temporary variables.

Consider this example:
```cs
//prints "2" to the console
Console.WriteLine(MathF.Round(1.7f));
```
Here we are rounding 1.7, then printing the result to the console.
Which is fine, but there are 2 main problems with this.

1. The order of operations is the opposite of how it is read. 
2. Once this gets more complicated, it get's harder to keep track of what is going on. To combat this, it is common to cache intermediate states in order to maintain readability

Instead, we could use a pipe:

```cs
1.7f
   .Pipe(MathF.Round) // returns 2f
   .Pipe(Console.WriteLine); //Prints "2" in the console
```
Now, the operations are executed the way they are read and the logic is easier to follow and there is no longer a need to cache values for readability's sake.

# Basics
Frostware.Pipe extends all objects with the Pipe method whether it be a string, an int or a class. Everything can be piped.

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
In the case above, the second pipe takes in a float, so we can pass any 1 parameter method that takes in a float.

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

# Multi pipes
Multi pipes allow you to use a tuple to pipe multiple arguments at the same time.

```cs
//the tuples are mapped to the arguments in order

var result = (x: 1.75f, digits: 1)
    //this is equivalent to MathF.Round(x: 1.15f, digits: 1)
    .Pipe2(MathF.Round); // returns 2f
    
var result = (value: 1.75f, min: 0f, max: 1f)
    // this is equivalent to Math.Clamp(value: 1.75f, min: 0f, max: 1f)
    .Pipe3(Math.Clamp); // returns 1f 
```

# Curried Pipes
Curried functions are also supported
```cs

Func<float, Func<float, Func<float, float>>> Clamp;

6f
    .Pipe(Clamp)(0)(5)
    .Pipe(x => Console.WriteLine($"clamp: {x}")); // prints 5 to the console
```
Thanks to Curryfy, none curried functions may also be passed
```cs
Func<float, float, float, float> Clamp = Math.Clamp;

6f
    .Pipe(Clamp)(0)(5)
    .Pipe(x => Console.WriteLine($"clamp: {x}")); // prints 5 to the console
```
In these cases the function will be curried as part of the pipe.

It is important to note that due to implicit casting limitations, methods cannot be passed implicitly.
you will have to do one of the following:
```cs
//explicitly cast
6f
    .Pipe((Func<float, float, float, float>)Math.Clamp)(0)(5)
    .Pipe(x => Console.WriteLine($"clamp: {x}"));
  
//convert the method to a function
Func<float, float, float, float> Clamp = Math.Clamp;
```

# Dependencies
* [Curryfy](https://github.com/leandromoh/Curryfy)
