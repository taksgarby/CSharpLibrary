Following this tutorial:
https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-7-0
<br/>
Created on VS Code with C# extension.
<br/>

```diff
On CLI:
1 - create the class library project
+ dotnet new classlib -o StringLibrary
// -o specified the location to place the output

2- add the library project to the solution
+ dotnet sln add StringLibrary/StringLibrary.csproj

3 - create the console app
+ dotnet new console -o ShowCase

4 - add the console app to the solution
+ dotnet sln add ShowCase/ShowCase.csproj

5 - create a project reference so the new console app has access to the class library project.
+ dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj

6 - run the app
+ dotnet run --project ShowCase/ShowCase.csproj
```

Unit test

```diff

1 - create a test project
2 - add the test project to the solution
- dotnet sln add StringLibraryTest/StringLibraryTest.csproj

3 - add a project reference
- dotnet add StringLibraryTest/StringLibraryTest.csproj reference StringLibrary/StringLibrary.csproj

4 - add unit test methods
5 - run the tests
- dotnet test StringLibraryTest/StringLibraryTest.csproj
6 - tun the tests with the release build configuration
- dotnet test StringLibraryTest/StringLibraryTest.csproj


```
