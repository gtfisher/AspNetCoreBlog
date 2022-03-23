# ASP.Net Core 

Loosely based on https://blog.georgekosmidis.net/using-litedb-in-an-asp-net-core-api.html and https://www.arctek.dev/blog/blog-with-csharp-pt3

## Web API using [LieteDB](https://www.litedb.org/)

DB file is ./Data/Blog.db

## Views

Views re using CSHTML, but includies styling for Bootstrap and Tailwind (Tailwind is using cdn version, this should not be used in production)

[Alpine](https://alpinejs.dev/) is used to fetch content from api and to render dynamic content

## To run

`dotnet run`

or with watch

`dotnet run`

## Todo

Add update/Create/Delete to Views
Add Firebase authentication
Configure Database location