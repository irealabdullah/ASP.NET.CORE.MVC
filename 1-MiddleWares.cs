var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>  // we use USE() method so that we can run multiple middle wares
{
    await context.Response.WriteAsync("Hello Abdullah \n");
    await next(context); // move to next middlware 

});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hi Abdullah \n");
    await next(context); // move to next middlware 

});

app.Run(async(context) => // we use run() in end. iske baad koi middleware/method run nahi hoo ga 
{
    await context.Response.WriteAsync("Welcome to Asp.Net core 6 ");
});



//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Abdullah Tariq");
//});
app.Run();

//--------------------------------------------------------
//Note#
//if we use Run() in start then below methods will not run