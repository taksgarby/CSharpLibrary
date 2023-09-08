Following this tutorial:
https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-7-0
<br/>
Created on VS Code with C# extension.
<br/>
```diff
On CLI:<br/>
1 - create the class library project 

+ dotnet new classlib -o StringLibrary
// -o specified the location to place the output

2- add the library project to the solution 
+ dotnet sln add StringLibrary/StringLibrary.csproj

3 - create the console app 
+ dotnet new console -o ShowCase

4 - add the console app to the solution 
+ dotnet sln add ShowCase/ShowCase.csproj

5 - Initially, the new console app project doesn't have access to the class library. To allow it to call methods in the class library, create a project reference to the class library project.
+ dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj

6 - run the app 
+ dotnet run --project ShowCase/ShowCase.csproj 
```
