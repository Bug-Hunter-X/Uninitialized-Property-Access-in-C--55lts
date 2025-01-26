# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a class property before it has been assigned a value.  This can lead to unexpected `NullReferenceException` or other exceptions depending on the property type. 

The `bug.cs` file contains code that exemplifies this issue. The `bugSolution.cs` file provides a corrected version.

## How to reproduce the bug

1. Compile and run `bug.cs`.
2. Observe the exception that is thrown.

## Solution

The solution involves initializing the property either in the constructor or before accessing it in the method.