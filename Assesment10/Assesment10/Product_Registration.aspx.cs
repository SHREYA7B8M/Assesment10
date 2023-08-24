using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assesment10
{
    public partial class Product_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblInfo.Visible = false;
                DdlCategory.Items.Add("Tulips");
                DdlCategory.Items.Add("Roses");
                DdlCategory.Items.Add("Orchids");
                DdlCategory.Items.Add("Lavender");
                DdlCategory.Items.Add("Marigold");
                DdlCategory.Items.Add("Sunflower");


            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblInfo.Visible = true;
            LblInfo.Text = "Product Successfully Registered";
            LblInfo.Text += "<br>Product Name: " + TxtName.Text;
            LblInfo.Text += "<br>Product Category: " + DdlCategory.Text;
            LblInfo.Text += "<br>Product Price: " + TxtPrice.Text;
            LblInfo.Text += "<br>Product Description: " + TxtDescription.Text;
            LblInfo.Text += "<br>Product Release Date: " + CalReleaseDate.SelectedDate;

        }
    }

}