# CassiaMallServer

[![Build Status](https://dev.azure.com/faminghou/CassiaMallServer/_apis/build/status/FamingHou.CassiaMallServer?branchName=master)](https://dev.azure.com/faminghou/CassiaMallServer/_build/latest?definitionId=6&branchName=master)

#### Set StartUp Project

Set **CassiaMall.Web.Host** as the startup project to avoid errors when executing ``` Add-Migration ``` or ``` Update-Database ```command.

#### Update-Database

Click Tools -> Nuget Package Manager -> Package Manager Console, and make sure that you select **CassiaMall.EntityFrameworkCore** as the default project, and then ``` Update-Database ``` in the command line
