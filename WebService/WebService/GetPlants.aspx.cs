using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService
{
    public partial class GetPlants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnReadPlants_Click(object sender, EventArgs e)
        {
            // access the web client resource to get data from the internet.
            using(var webClient = new WebClient())
            {
                // download our JSON data.  Store it in a variable named rawData.
                string rawData = webClient.DownloadString("http://plantplaces.com/perl/mobile/viewplantsjson.pl?Combined_Name=Redbud");

                //  convert the raw data into a series of objects that we can program against.
                PlantCollection plantCollection = JsonConvert.DeserializeObject<PlantCollection>(rawData);

                // print something out so that we can debug.
                Console.WriteLine(plantCollection.Plants.Count);
            }
        }
    }
}