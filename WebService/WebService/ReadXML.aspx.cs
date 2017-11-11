using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService
{
    public partial class ReadXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ValidateXML("");
        }

        /// <summary>
        /// Validate XML against an XSD.
        /// </summary>
        /// <param name="fileName">The XML file we want to validate.</param>
        private void ValidateXML(String fileName)
        {

        }
    }
}