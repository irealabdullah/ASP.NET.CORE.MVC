/*There are two validation tag helper in asp.net core Mvc

validation message Tag Helpers
exp: asp-validation-for


agar mujhe har input tag ke neeche asp-validation-for show nahi rakhwana aur main chahta hoon ke yeh sab alehda show hoo jayeen somewhere else then we will use asp-validation-summary
*/

<input asp-for="Name" class="form-control" placeholder="Enter Name"/>
<span asp-validation-for="Name" style="color:red"></span>                  //yeh alehdah likhain 

<input asp-for="password" class="form-control" placeholder="Enter Password"/>
<span asp-validation-for="password" style="color:red"></span>               //yeh alehdah likhain 

<label asp-for="Confirmpassword"></label> // ab property ka name show nahi hoo ga
<input asp-for="Confirmpassword" class="form-control" placeholder="Enter Confirm Password" />
<span asp-validation-for="Confirmpassword" style="color:red"></span>        //yeh alehdah likhain 



//asp-validation-summary

<div class="container">
    <div class="row">
        <div class="col-sm-4">

            <div asp-validation-summary="All" style="color:red">

            </div>
<form asp-controller="Home" asp-action="Index" method="post">
   
    
    <input asp-for="Name" class="form-control" placeholder="Enter Name"/>
    <br />
                
    <input asp-for="Email" class="form-control" placeholder="Enter Email"/>
    <br />

    <input asp-for="Age" class="form-control" placeholder="Enter Age"/>
    <br />
               

    <input type="submit" value="Submit" class="btn btn-outline-primary"/>


</form>
        </div>
    </div>

</div>