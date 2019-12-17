-- REQUIREMENT --
Given an integer input, return the next fibonacci number.

-- SETUP --
This solution requires a database to store any previously calculated fibonacci numbers. 
You can specify the database connection string in the appsettings.json (or override file) by setting the ConnectionString value.
e.g:
"ConnectionString": "Data Source=./SQLEXPRESS;Initial Catalog=Fibonacci;User ID=sa;Password=password;MultipleActiveResultSets=true;"

You will also need to run the code-first migration, this can by done via the Package-Manager console:
Update-Database

-- OUTSTANDING ITEMS --
Logging: Add a logging framework such as log4net or Serilog to the DI.
Security: Add an API key verification to the endpoints.
Configuration: Add additional configuration to control input validation (is the input a fibonacci number), specify default Fibonacci number (currently it is {n: 2, xn:1})
Auto-Database-Migration: Add to startup the ability to create the database if it does not exist.
Code-Coverage: Add Code-Coverage framework to the solution to monitor unit tests.