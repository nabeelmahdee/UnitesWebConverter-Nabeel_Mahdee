using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*
 Nabeel Ahmed Mahdee
 991532760
*/

namespace UnitesWebConverter_Nabeel_Mahdee
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Length.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReferenceToWeight.WebService1SoapClient client = new ServiceReferenceToWeight.WebService1SoapClient();
            double kg = 0;
            double gm = 0;
            double lb = 0;

            if (txtBoxPound.Text != "")
            {
                lb = double.Parse(txtBoxPound.Text.ToString());
                txtBoxGram.Text = client.poundToGram(lb).ToString();
                txtBoxKilogram.Text = client.poundToKilogram(lb).ToString();
            }
            if (txtBoxGram.Text != "")
            {
                gm = double.Parse(txtBoxGram.Text.ToString());
                txtBoxPound.Text = client.gramToPound(gm).ToString();
                txtBoxKilogram.Text = client.gramToKilogram(gm).ToString();
            }
            if (txtBoxKilogram.Text != "")
            {
                kg = double.Parse(txtBoxKilogram.Text.ToString());
                txtBoxGram.Text = client.kilogramToGram(kg).ToString();
                txtBoxPound.Text = client.kilogramToPound(kg).ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtBoxGram.Text = "";
            txtBoxKilogram.Text = "";
            txtBoxPound.Text = "";
        }
    }
}