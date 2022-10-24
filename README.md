# **Bug Tracker**

An Example project built in a .net Blazor application to track bugs and assign them to users

The Project is a .net 6 ASP .NET CORE Server-Side Blazor application using Entity Framework with SQLite to store data locally
I choose to use a SQLite DB as this makes it much easier to get up and running with the app

To run the build the app you need to run the following commands in the project folder:

```
dotnet build
dotnet dotnet ef database update
```

This will build the app and create a SQLite database file under user AppData\Local folder

To run the app run the command:

```
dotnet run
```

Whilst running you can navigate to either http://localhost:5038 or https://localhost:7038 to test the app