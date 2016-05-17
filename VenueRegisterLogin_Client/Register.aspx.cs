using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void registerButton_Click(object sender, EventArgs e)
    {
        RegisterVenue();
    }
    protected void RegisterVenue()
    {
        RegisterLoginService.VenueRegistrationServiceClient register = new RegisterLoginService.VenueRegistrationServiceClient();
        RegisterLoginService.Venue v = new RegisterLoginService.Venue();
        v.VenueName = NameTextBox.Text;
        v.VenueAddress = AddressTextBox.Text;
        v.VenueCity = CityTextBox.Text;
        v.VenueState = StateTextBox.Text;
        v.VenueZipCode = ZipTextBox.Text;
        v.VenuePhone = PhoneTextBox.Text;
        v.VenueEmail = EmailTextBox.Text;
        v.VenueWebPage = WebPageTextBox.Text;
        v.VenueAgeRestriction = toNullableInt32(AgeTextBox.Text);
        string VenueUserName = VenueUserNameTextBox.Text;
        string VenuePassword = VenuePasswordTextBox.Text;
        
        //parsing a string into a nullable int
        public static int? toNullableInt32(string s)
        {
        int i;
        if (Int32.TryParse(s, out i)) return i;
        return null;
        }


        bool result = register.RegisterVenue(v, VenueUserName, VenuePassword);
        if (result)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            errorLabel.Text = "Registration failed";
        }

    }
}
