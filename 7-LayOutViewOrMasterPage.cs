// _LayoutOut.cshtml

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
</head>

<body>
     <header style="background-color: #333; color: #fff; text-align: center; padding: 10px;">
        <h1>My Website</h1>
        <nav>
            <ul style="list-style-type: none; padding: 0;">
                <li style="display: inline; margin-right: 20px;"><a href="#" style="text-decoration: none; color: #fff;">Home</a></li>
                <li style="display: inline; margin-right: 20px;"><a href="#" style="text-decoration: none; color: #fff;">About</a></li>
                <li style="display: inline;"><a href="#" style="text-decoration: none; color: #fff;">Contact</a></li>
            </ul>
        </nav>
    </header>



    <div>
        @RenderBody()  //Index page, about page, contact page ka html code yahan ajata hai 
    </div>
    


    <footer style="background-color: #333; color: #fff; text-align: center; padding: 10px;">
        &copy; 2023 My Website | All Rights Reserved
    </footer>

</body>
</html>



//--------------
//index.html

@{
    ViewData["Title"] = "Index"; 
    Layout = "~/Views/Home/Shared/_Layout.cshtml";   // Connect _layout.cshtml with all pages by using property called layout 

}

<h1>Index Page</h1>  // this code will go to render body 
<p>This is Index page</p>
