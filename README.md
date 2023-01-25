The database must first be setup.  This application uses SQL Server Express

Go to Package Manager Console in Visual Studio, make sure the BBSData project is selected then type:

    Enable-Migrations -Force
    Add-Migration init
    Update-Database

To seed the database run the BBSDataSeed application.

The backend is behind a WebAPI service.  Be sure to run in Visual Studio with multi-project startup and start the BBSService app and the BSBWebApp App.
