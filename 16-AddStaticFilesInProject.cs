// wwwroot >> add >> add client side library 


//program.cs


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=index}/{id?}");
app.Run();


//index.cshtml


@{
    ViewData["Title"] = "Index";
    Layout = "~/Views/_Layout.cshtml";
}

<h1 class="bg-primary">Index</h1>
<h1 class="bg-danger">Index</h1>
<h1 class="bg-success">Index</h1>


// _Layout.cshtml

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>

    <link href="~/twitter-bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="~/tailwindcss/tailwind.min.css" rel="stylesheet" />
</head>
<body>

   
    

    <div>
        @RenderBody()
    </div>

    <script src="~/jquery/jquery.min.js"></script>
    <script src="~/twitter-bootstrap/js/bootstrap.min.js"></script>
</body>
</html>



//libman file


{
  "version": "1.0",
  "defaultProvider": "cdnjs",
  "libraries": [
    {
      "library": "twitter-bootstrap@5.3.2",
      "destination": "wwwroot/twitter-bootstrap/"
    },
    {
      "provider": "cdnjs",
      "library": "tailwindcss@2.2.19",
      "destination": "wwwroot/tailwindcss/"
    },
    {
      "provider": "cdnjs",
      "library": "jquery@3.7.1",
      "destination": "wwwroot/jquery/"
    }
  ,
{
  "provider": "cdnjs",
  "library": "react@18.2.0",
  "destination": "wwwroot/react/"
}
]
}