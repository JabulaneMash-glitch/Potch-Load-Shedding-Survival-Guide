using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstOpp2024
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            HttpCookie cook = new HttpCookie("info");
            cook["name"] = txtName.Text;
            cook["sur"] = txtSur.Text;
            cook["email"] = txtEmail.Text;
            string zone = "";
            if(rdbZone1.Checked)
            {
                zone = "Zone 1(Central Business District)";
            }
            else if (rdbZone2.Checked)
            {
                zone = "Zone 2(Van der Hoff Park)";
            }
            else if (rdbZone3.Checked)
            {
                zone = "Zone 3(Bult Area and University Campus)";
            }
            else if (rdbZone4.Checked)
            {
                zone = "Zone 4(Grimbeek Park and Baillie Park)";
            }
            else if (rdbZone5.Checked)
            {
                zone = "Zone 5(Mohadin and Promosa)";
            }
            else if (rdbZone6.Checked)
            {
                zone = "Zone 6(Ikageng)";
            }
            Session["zone"] = zone;
            Response.Cookies.Add(cook);
            cook.Expires = DateTime.Now.AddMinutes(10);

            Response.Redirect("Info.aspx");
        }
    }
}