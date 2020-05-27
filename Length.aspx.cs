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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Weight.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReferenceLength.LengthSoapClient client = new ServiceReferenceLength.LengthSoapClient();
            double km = 0;
            double m = 0;
            double ft = 0;

            if(txtBoxFoot.Text != "")
            {
                ft = double.Parse(txtBoxFoot.Text.ToString());
                txtBoxKilometer.Text = client.footToKilometer(ft).ToString();
                txtBoxMeter.Text = client.footToMeter(ft).ToString();
            }
            if(txtBoxKilometer.Text != "")
            {
                km = double.Parse(txtBoxKilometer.Text.ToString());
                txtBoxMeter.Text = client.kilometerToMeter(km).ToString();
                txtBoxFoot.Text = client.kilometerToFoot(km).ToString();
            }
            if(txtBoxMeter.Text != "")
            {
                m = double.Parse(txtBoxMeter.Text.ToString());
                txtBoxFoot.Text = client.meterToFoot(m).ToString();
                txtBoxKilometer.Text = client.meterToKilometer(m).ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtBoxFoot.Text = "";
            txtBoxKilometer.Text = "";
            txtBoxMeter.Text = "";
        }
    }
}