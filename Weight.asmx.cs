using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/*
 Nabeel Ahmed Mahdee
 991532760
*/

namespace UnitesWebConverter_Nabeel_Mahdee
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double kilogramToGram(double kg)
        {
            return kg * 1000;
        }
        [WebMethod]
        public double gramToKilogram(double g)
        {
            return g / 1000;
        }
        [WebMethod]
        public double poundToKilogram(double lb)
        {
            return lb * 0.453592;
        }
        [WebMethod]
        public double kilogramToPound(double kg)
        {
            return kg / 0.453592;
        }
        [WebMethod]
        public double poundToGram(double lb)
        {
            return lb * 453.592;
        }
        [WebMethod]
        public double gramToPound(double gm)
        {
            return gm / 453.592;
        }
    }
}
