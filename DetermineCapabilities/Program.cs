using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Xml;
using Sage.Common.Syndication;

namespace DetermineCapabilities
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build the request URI. This example assumes that the Accounts 50 GCRM contract implementation is available
            SDataUri uri = new SDataUri();
            uri.BuildLocalPath("Accounts50", "GCRM", "-", "$schema");

			// The response was successful. The stream should now contain the xml schema
			XmlSchemaSet schemaSet = new XmlSchemaSet();
			XmlSchema schema = GetSchema(uri.Uri);

			if (schema != null)
				schemaSet.Add(schema);

			foreach (XmlSchemaImport importedSchema in schema.Includes)
			{
				schema = GetSchema(new Uri(importedSchema.SchemaLocation));

                if (schema != null)
                {
                    schemaSet.Add(schema);
                }
			}

			schemaSet.Compile();

			// Display a list of the elements in the schema
			foreach (XmlSchema compiledSchema in schemaSet.Schemas())
			{
				foreach (XmlSchemaElement element in compiledSchema.Elements.Values)
				{
					StringBuilder capabilities = new StringBuilder();
					foreach (XmlAttribute attribute in element.UnhandledAttributes)
					{
						if (attribute.LocalName.Equals("canGet", StringComparison.InvariantCultureIgnoreCase) ||
							attribute.LocalName.Equals("canPut", StringComparison.InvariantCultureIgnoreCase) ||
							attribute.LocalName.Equals("canPost", StringComparison.InvariantCultureIgnoreCase) ||
							attribute.LocalName.Equals("canDelete", StringComparison.InvariantCultureIgnoreCase))
						{
							capabilities.AppendFormat(" {0}: {1}.", attribute.LocalName, attribute.Value);
						}
					}

					Console.WriteLine("{0} - {1}", element.Name, capabilities);
				}
			}

            Console.ReadKey(true);
        }

        static public void XmlSchema_Validation(object sender, ValidationEventArgs e)
        {
            Console.WriteLine(string.Format("Invalid schema ({0})", e.Message));
        }

		static XmlSchema GetSchema(Uri schemaUri)
		{
			XmlSchema schema = null;

            // Out parameters for Send method
            IMediaTypeSerializer serializer;
			System.IO.Stream stream;

            // Send the request for the schema
            Sage.Integration.Client.SDataRequest request = new Sage.Integration.Client.SDataRequest(schemaUri)
            {
                ResponseContentType = MediaType.Xml,
                AllowPromptForCredentials = false,
                Username = "MANAGER",
                Password = string.Empty
            };

            request.Send(out serializer, out stream);

			if (request.IsStatusValidForVerb)
			{
				schema = XmlSchema.Read(stream, new ValidationEventHandler(XmlSchema_Validation));
			}
			else
			{
				// There was a problem so output some debug information
				Console.WriteLine("failed to retrieve schema. Response was {0}", request.HttpStatusCode.ToString());
				if (request.Diagnoses != null)
				{
                    foreach (Diagnosis diagnosis in request.Diagnoses)
                    {
                        Console.WriteLine(diagnosis.Message);
                    }
				}
			}

			return schema;
		}
    }
}

