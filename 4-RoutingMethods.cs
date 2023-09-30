var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.Map("/Home", () => "Hello World!"); // app.Map() will work with all methods like POST, DELETE, UPDATE AND GET 
// WE CAN TEST THE URL WITH POSTMAN SOFTWARE
// alag alag request ke liye same kaam karna hai then we use Map()



//Specific methods ke liye generate karna hai then we use the below methods
app.MapGet("/Home", () => "GET"); // work with only get 
app.MapPost("/Home", () => "POST");   // work with only post
app.MapPut("/Home", () => "PUT");  // work with only put
app.MapDelete("/Home", () => "DELETE");  // work with only delete

app.Run();
// ----------------------------------------------------------------------------------

//if we want to write multiple line logic then we do this. see below!!!

app.UseRouting();
app.UseEndpoints(endpoints => //define end points 
{
    endpoints.MapGet("/Home", async (context) => 
    {
        await context.Response.WriteAsync("This is Get Request");
    });

    endpoints.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Post Request");
    });

    endpoints.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Delete Request");
    });

    endpoints.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("This is Put Request");
    });
}); 

//If we run our code 
app.Run( async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page Not Found");

});

app.Run();
