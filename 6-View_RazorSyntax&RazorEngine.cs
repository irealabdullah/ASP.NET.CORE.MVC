
@{
    ViewData["Title"] = "Index";
}

<h1>Index</h1>

//inline expression --> Single Line of Code 

<h1>Current Date and Time is @DateTime.Now</h1>

<h1>Current Year is @DateTime.Now.Year</h1>

//Multiple Line of Code we end with semicolon 

@{
    var name = "Abdullah";
    var age = "25";
}
<h2>Name = @name</h2>
<h2>Age = @age</h2>


@{
    string MyName = "Abdullah";

    if(MyName.Equals("Abdullah"))
    {
        <h3>Your name is @MyName</h3>
    }

    else
    {
        <h3>Your name is not @MyName</h3>
    }
}


@{
    for (int i = 0; i < 20; i++)
    {
        <h2>@i</h2>
    }
}

@{
    string[] names = {"Ali", "Arfat", "Abdullah"};

    foreach (var item in names)
    {
        <h3>@item</h3>
    }
}