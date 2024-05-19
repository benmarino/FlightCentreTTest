using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightCentreTTest
{
    public partial class _Default : Page
    {
        protected int GetFlightCount(string value)
        {
            List<int> instanceCount = new List<int>();
            instanceCount.Add(CountChars(value, 'f'));
            instanceCount.Add(CountChars(value, 'l'));
            instanceCount.Add(CountChars(value, 'i'));
            instanceCount.Add(CountChars(value, 'g'));
            instanceCount.Add(CountChars(value, 'h'));
            instanceCount.Add(CountChars(value, 't'));
            instanceCount.Sort();
            return instanceCount[0];
        }
        protected int CountChars(string source, char toFind)
        {
            return source.Count(t => t == toFind);
        }

        protected void btnGetFlightCount_Click(object sender, EventArgs e)
        {
            int flightCount = GetFlightCount(txtFlightInput.Text);
            litFlightCount.Text = flightCount.ToString();
        }
        //not working!
        //protected void btnGetFlightCount_Click(object sender, EventArgs e)
        //{
        //    HttpClient client = new HttpClient();

        //    var currentUrl = Request.Url.ToString().ToLower().Replace("default", "api/flightcount/");
        //    //var flightEnc = HttpUtility.UrlDecode(txtFlightInput.Text);
        //    client.BaseAddress = new Uri(currentUrl);

        //    var postContent = new StringContent(txtFlightInput.Text, System.Text.Encoding.UTF8, "multipart/form-data");
        //    var response = client.PostAsync("flighcount", postContent).Result;
        //    //var response = client.GetAsync(currentUrl+ flightEnc).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var responseContent = response.Content.ReadAsStringAsync().Result;


        //        //int flightCount = GetFlightCount(txtFlightInput.Text);
        //        //litFlightCount.Text = flightCount.ToString();
        //    }
        //}
    }
}
