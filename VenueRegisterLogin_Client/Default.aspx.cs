using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void loginButton_Click(object sender, EventArgs e)
    {
        Login();
    }

    protected void Login()
    {
        RegisterLoginService.VenueRegistrationServiceClient rs = new RegisterLoginService.VenueRegistrationServiceClient();

        int key = rs.VenueLogin(userTextBox.Text, passTextBox.Text); 
        if(key != 0)
        {
            errorLabel.Text = "Welcome";
            Session["Userkey"] = key;
            Response.Redirect("Shows.aspx");
        }
        else
        {
            errorLabel.Text = "Invalid Login";
        }
    }
}