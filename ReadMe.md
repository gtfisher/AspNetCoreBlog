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

## API

curl --request GET \
  --url https://localhost:7034/blog

```
curl --request POST \
  --url https://localhost:7034/blog \
  --header 'Content-Type: application/json' \
  --data '{
		"title": "Third Post",
		"views": 0,
		"content": "Some third random post from somewhere",
		"excerpt": "Some third random",
		"coverImagePath": "image1.jpg",
		"public": true
}'
```


## Todo

* Add update/Create/Delete to Views
* Add swagger (maybe)
* Add Firebase authentication
* add auth protection to api
* Configure Database location
* sort out table rendering