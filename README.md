Following this tutorial:
https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code?pivots=dotnet-7-0
<br/>
Created on VS Code with C# extension.
<br/>

On CLI:<br/>
1 - create the class library project <br/>

<p style="color:blue">dotnet new classlib -o StringLibrary<br/></p>
// -o specified the location to place the output<br/>

2- add the library project to the solution <br/>
dotnet sln add StringLibrary/StringLibrary.csproj<br/>

3 - create the console app <br/>
dotnet new console -o ShowCase<br/>

4 - add the console app to the solution <br/>
dotnet sln add ShowCase/ShowCase.csproj<br/>

5 - Initially, the new console app project doesn't have access to the class library. To allow it to call methods in the class library, create a project reference to the class library project.<br/>
dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj<br/>

6 - run the app </br>
dotnet run --project ShowCase/ShowCase.csproj </br>
