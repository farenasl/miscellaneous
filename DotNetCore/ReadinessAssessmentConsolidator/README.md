Install OpenXml support into the project
OpenXml allows the project to work with MS Office documents like excels, words, powerpoints, etc

````
dotnet add package DocumentFormat.OpenXml --version 3.3.0
````

Remove packages from the project
`````
dotnet remove package Microsoft.Office.Interop.Excel
`````

# Resourced used to develop this.
* https://www.youtube.com/watch?v=-jCLDGXwY4k
* https://stackoverflow.com/questions/52927/console-writeline-and-generic-list
* https://stackoverflow.com/questions/17321958/listcustom-to-excel-c-sharp

# Execute the code
`````
dotnet run
`````