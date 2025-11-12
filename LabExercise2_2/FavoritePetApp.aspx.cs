using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LabExercise2_2
{
	public partial class FavoritePetApp : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			String pet = ListBox1.SelectedValue;
            Image1.ImageUrl = "~/Images/" +pet+ ".png";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image1.Height = Convert.ToInt16(DropDownList1.SelectedValue);
        }
    }
}