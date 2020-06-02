using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Soap_WebService_Consumer
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            WeatherService.WeatherSoapClient client = new WeatherService.WeatherSoapClient("WeatherSoap");
            WeatherService.WeatherReturn result = client.GetCityWeatherByZIP(TextBox1.Text);
            
            Label2.Text = result.City ;
        }
    }
}