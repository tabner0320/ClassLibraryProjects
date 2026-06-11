# ClassLibraryProjects

This project was created by following the Microsoft Learn tutorial for creating a .NET Class Library and Console Application.

## Projects

### StringLibrary

A class library that contains the `StartsWithUpper()` extension method. This method checks whether a string begins with an uppercase letter.

### StringLibraryTest

An xUnit test project used to test the functionality of the StringLibrary project.

### ShowCase

A console application that allows users to enter text and displays whether the text begins with an uppercase letter.

## Technologies Used

* C#
* .NET 10
* xUnit
* Visual Studio Code

## How to Run

1. Clone the repository.
2. Open the project folder in Visual Studio Code.
3. Run the application:

```bash
dotnet run --project ShowCase/ShowCase.csproj
```

## Example Output

```text
Hello
Input: Hello        Begins with uppercase? : Yes

hello
Input: hello        Begins with uppercase? : No
```

## Author

Theophilus Abner
