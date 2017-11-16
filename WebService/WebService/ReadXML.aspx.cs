using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Schema;

namespace WebService
{
    public partial class ReadXML : System.Web.UI.Page
    {
        String fileName = "";

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
                if (XMLFileUpload.HasFile)
                {
                    fileName = XMLFileUpload.FileName;
                    // now check the extension.
                    String fileExtension = System.IO.Path.GetExtension(fileName).ToLower();

                    // is this file extension legal
                    if (fileExtension == allowedExtensions[0])
                    {
                        // construct the path where we want to save the file.
                        String path = Server.MapPath("~/XML/");
                        // if we are here, the file is valid, so save the file.

                        XMLFileUpload.PostedFile.SaveAs(path + XMLFileUpload.FileName);
                        fileName = path + XMLFileUpload.FileName;
                        LblStatus.Text = "Upload Successful";
                    } else
                    {
                        LblStatus.Text = "File extension not permitted";
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (fileName != null && fileName.Length > 0)
            {
                // declare an XML DOM document
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);

                ValidateXML(fileName);
            }
            
        }

        /// <summary>
        /// Validate XML against an XSD.
        /// </summary>
        /// <param name="fileName">The XML file we want to validate.</param>
        private void ValidateXML(String fileName)
        {
            // how we want to read and validate the document.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |= System.Xml.Schema.XmlSchemaValidationFlags.ProcessSchemaLocation;
            settings.ValidationFlags |= System.Xml.Schema.XmlSchemaValidationFlags.ReportValidationWarnings;

            // what method do we call when things go wrong?
            settings.ValidationEventHandler += new ValidationEventHandler(this.ValidationEventHandle);

            // validate the document.
            XmlReader xmlReader = XmlReader.Create(fileName, settings);
            try
            {
                //read the document one line at a time.
                while (xmlReader.Read())
                {
                    // leave blank for the moment.

                }
                LblStatus.Text = "Validation Passed";
            } catch (Exception e)
            {
                LblStatus.Text = e.Message;
            }
        }

        /// <summary>
        /// This method is called only when the XML fails validation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void ValidationEventHandle(object sender, ValidationEventArgs args)
        {
            Console.WriteLine("Vaidation error: " + args.Message);
            LblStatus.Text = "Validation Failed.  Message: " + args.Message;
            throw new Exception("Validation failed.  Message: " + args.Message);
        }

        protected void BtnConvertWebService_Click(object sender, EventArgs e)
        {
            UnitConversion.lengthUnitSoapClient client = new UnitConversion.lengthUnitSoapClient("lengthUnitSoap12");
            double convertedValue = client.ChangeLengthUnit(250, UnitConversion.Lengths.Meters, UnitConversion.Lengths.Inches);
            LblStatus.Text = "250 meters in inches is: " + convertedValue;
        }
    }
}