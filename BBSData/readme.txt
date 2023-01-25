https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database
https://stackoverflow.com/questions/20304058/how-to-re-create-database-for-entity-framework
 //https://www.codeproject.com/Articles/5321286/Executing-Raw-SQL-Queries-using-Entity-Framework-C

Go to Package Manager Console in Visual Studio and type:

    Enable-Migrations -Force
    Add-Migration init
    Update-Database
