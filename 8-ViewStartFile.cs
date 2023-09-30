//Why we need ViewStart file?
// Ans: Suppose we have 100 views so we have to set Layout property in all 100 pages so that is why we use viewStart File

// dont violate DRY principle 1) redundant code 2) maintainence overload 

// we make this file in views folder 

// ---------------------------------

//ViewStart.cshtml

@{
    Layout = "_Layout";  // We dont have to give full path 
}

//Layout = "~/Views/Home/Shared/_Layout.cshtml"; ab yeh likhne ke zaroorart nahi hai har page main  


//---------------------------

Layout = null;

//-------------------------


// if user wants to login and if admin wants to login 
@{

    if(User.IsInRole("Admin"))
    {
        Layout = "_Layout.cshtml";
    }
    else
    {
        Layout = "_Layout1.cshtml";
    }
}
