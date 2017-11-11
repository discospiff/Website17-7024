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
            if (IsPostBack)
            {
                // we are hearing back from the page, after it was initially loaded.

                // see if the user uploaded a document.

                // is it a valid file?
                Boolean validFile = false;
                String[] allowedExtensions = { ".xml" };
                // String[] allowedExtensions = new String[1];
                // allowedExtensions[0] = ".xml";

                //has the user uploaded a file, and is it a valid file.
                String fileName = XMLFileUpload.FileName;
                // now check the extension.
                String fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
            }
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