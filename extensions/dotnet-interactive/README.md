# Other things you can 

#r "nuget:Microsoft.DotNet.Interactive.Kql, 1.0.0-beta.22405.1"

#r "nuget: Microsoft.DotNet.Interactive.SqlServer, 1.0.0-beta.22405.1"

#!connect mssql -h

#!connect mssql --kernel-name retailData "ConnectionString"

#!sql-retailData

run SQL COMMANDS



# The C# Notebook Programming Model

C# Notebooks are written using a variation on the C# scripting programming model commonly used for `.csx` scripts.
    
This article documents the ways that this programming model differs from normal C# scripting.
    
### Standard open namespaces and referenced packages

The following assemblies or packages are referenced by default:

* `.NETStandard.Library`
* `Microsoft.AspNetCore.Html.Abstractions`
* `Microsoft.DotNet.Interactive`
* `Microsoft.DotNet.Interactive.Formatting`

The following namespaces are opened by default:

* `System`
* `System.Collections`
* `System.Collections.Generic`
* `System.Ling`
* `System.Threading.Tasks`
* `System.Text`
* `Microsoft.DotNet.Interactive`
* `Microsoft.DotNet.Interactive.Formatting`