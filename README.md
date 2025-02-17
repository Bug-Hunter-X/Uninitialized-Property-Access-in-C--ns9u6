# Uninitialized Property Access in C#.NET
This example demonstrates a common error in C#: accessing a property before it has been assigned a value.  Uninitialized properties can lead to unexpected behavior or exceptions.

## Bug
The `bug.cs` file shows a class with a property `MyProperty` which is not initialized before being accessed in the `MyMethod`.  Accessing `MyProperty` without setting it might return the default value (0 for integers), or it might lead to exceptions if the usage of `MyProperty` involves further logic that is not tolerant to null or zero values.

## Solution
The `bugSolution.cs` file provides a corrected version. It initializes `MyProperty` either directly or by using a constructor. This eliminates the unpredictable behavior.

## How to run
1.  Save the files as `bug.cs` and `bugSolution.cs`.
2.  Compile and run using a C# compiler (like the one included with Visual Studio or .NET SDK).
3. Observe the output of each version.  The uninitialized version can have a random result, while the corrected version provides predictable behaviour. 