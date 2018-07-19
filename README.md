# SpaApiMiddleware
Enable SPA calls to be served from wwwwroot and only /api calls to go through dotnet core controllers.

## How to use it
In your .net core 2.0 Startup.cs class add :

`
using SpaApiMiddleware;
`

and then in Configure method add:

`
app.UseSpaApiOnly(indexHtmlPage:"index.html", apiPath:"api");
`

Both apiPath and indexHtmlPage are optional parameters.

Have fun,
Daiot
