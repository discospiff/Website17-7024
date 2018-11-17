using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService
{
    public partial class ViewPlants : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filter = Request.QueryString["Combined_Name"];
            Response.Clear();
            Response.ContentType = "application/json; charset=utf-8";
            String rawJSON = ShowJSON(filter);
            Response.Write(rawJSON);
            Response.End();
        }

        /// <summary>
        /// Construct a series of objects, and poop them out in JSON format.
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        private string ShowJSON(string filter)
        {
            // create a strongly typed collection of plant objects.
            List<Plant> allPlants = new List<Plant>();

            Plant redbud = new Plant();
            redbud.Genus = "Cercis";
            redbud.Species = "canadensis";
            redbud.Cultivar = "alba";
            redbud.Common = "White Redbud";
            if (redbud.Common.Contains(filter))
            {
                allPlants.Add(redbud);
            }

            Plant pawpaw = new Plant();
            pawpaw.Genus = "Asimina";
            pawpaw.Species = "triloba";
            pawpaw.Cultivar = "Potomac";
            pawpaw.Common = "Potomac Paw Paw";
            if (pawpaw.Common.Contains(filter))
            {
                allPlants.Add(pawpaw);
            }

            // convert our list of plants to a JSON stream.
            string rawJson = JsonConvert.SerializeObject(allPlants);
            return rawJson;

        }
    }
}