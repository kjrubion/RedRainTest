# RedRainTest
This project is created using .NET6 CORE API.
It contains, the service, domain, infra, and test files.
For easier debugging ,it is configured using SwaggerGEN and the connection string is stored in the **appsettings.json** file.

The stored procedure is in the sql file, run it first to create the procedure required for the query.
The file is in **2-Infra > Sql > GetEntityByType.sql**

The request accepts two parameters:

 1. Type - The required type of entity (For example : test)
 2. Source - the source is the db connection string. Supply a connection string that connects to a local database that contains the table "Entities". (For example: **Data Source = DESKTOP-KHAKG9D\SQLEXPRESS;Initial Catalog=RedRainDB;User ID=dev; Password=123456;**)

The app should return a generic response that contains the data, status code, and message.

This API can still be improved by the following:

 - For this instance to be *cloud resilient* this can be modified by using a Redis for caching.
 - The unit test done in this project is very simple, I could add more mocking unit tests.
 - Since the project only queries from one table, using a SP process is okay, but if the project becomes more complex, a combination of dapper and efcore can be utilized.
 - If there's a slow response, then using a caching can be implemented. It can be in-memory or server type like redis. It could also be due to the type of query. If there are stored procedures not generated then that could also cause a problem.
 - To retrieve the entitie, I would much prefer using raw sql squery instead of using stored procedures, and partner it with Dapper or EFCore.
