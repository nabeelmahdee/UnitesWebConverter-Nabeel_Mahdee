using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace UnitesWebConverter_Nabeel_Mahdee
{
    /// <summary>
    /// Summary description for Length
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Length : System.Web.Services.WebService
    {

        [WebMethod]
        public double kilometerToMeter (double km)
        {
            return km*1000;
        } 
        [WebMethod]
        public double meterToKilometer (double m)
        {
            return m/1000;
        } 
        [WebMethod]
        public double meterToFoot (double m)
        {
            return m*3.28084;
        }
        [WebMethod]
        public double footToMeter (double ft)
        {
            return ft/3.28084;
        }

        [WebMethod]
        public double kilometerToFoot (double km)
        {
            return km*3280.84;
        }

        [WebMethod]
        public double footToKilometer (double ft)
        {
            return ft/3280.84;
        }
    }
}
