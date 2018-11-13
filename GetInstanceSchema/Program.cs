using Sage.Common.Syndication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace GetInstanceSchema
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build the request URI. This example assumes that the Accounts 50 GCRM contract implementation is available
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("Accounts50", "GCRM", "-", "$schema");

            // Build an Sdata request from the URI
            Sage.Integration.Client.SDataRequest request = new Sage.Integration.Client.SDataRequest(uri.Uri)
            {
                ResponseContentType = Sage.Common.Syndication.MediaType.Xml,
                AllowPromptForCredentials = false,
                Username = "MANAGER",
                Password = string.Empty
            };

            // Out parameters for Send method
            Sage.Common.Syndication.IMediaTypeSerializer serializer;
            System.IO.Stream stream;

            // Submit the request
            request.Send(out serializer, out stream);

            // Check for a successful response
            if (request.IsStatusValidForVerb)
            {
                // The response was successful. The stream should now contain the xml schema
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                XmlSchema schema = XmlSchema.Read(stream, new ValidationEventHandler(XmlSchema_Validation));
                schemaSet.Add(schema);
                schemaSet.Compile();

                // Display a list of the elements in the schema
                foreach (XmlSchemaElement element in schema.Elements.Values)
                {
                    Console.WriteLine(element.Name);
                }
            }
            else
            {
                // There was a problem so output some debug information
                Console.WriteLine("failed to retrieve schema. Response was {0}", request.HttpStatusCode.ToString() );
                if (request.Diagnoses != null)
                {
                    foreach (Diagnosis diagnosis in request.Diagnoses)
                    {
                        Console.WriteLine(diagnosis.Message);
                    }
                }
            }

            Console.ReadKey(true);
        }

        static public void XmlSchema_Validation(object sender, ValidationEventArgs e)
        {
            Console.WriteLine(string.Format("Invalid schema ({0})", e.Message));
        }
    }
}
