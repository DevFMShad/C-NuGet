using System;
using System.Xml;

namespace JsonExample
{
    class XmlReaderProgram
    {
        public static void MainXmlReader(string[] args)
        {
            try
            {
                // Load the XML file
                XmlDocument doc = new XmlDocument();
                doc.Load("users.xml");

                // Get all User nodes
                XmlNodeList? userNodes = doc.SelectNodes("//User");

                if (userNodes == null)
                {
                    throw new Exception("No User nodes found in users.xml.");
                }

                // Loop through each user node
                foreach (XmlNode node in userNodes)
                {
                    XmlNode? nameNode = node.SelectSingleNode("Name");
                    XmlNode? ageNode = node.SelectSingleNode("Age");
                    XmlNode? cityNode = node.SelectSingleNode("City");

                    string name = nameNode?.InnerText ?? throw new Exception("Name node is missing.");
                    int age = int.Parse(ageNode?.InnerText ?? throw new Exception("Age node is missing."));
                    string city = cityNode?.InnerText ?? throw new Exception("City node is missing.");

                    // Display user information
                    Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading XML: {ex.Message}");
            }
        }
    }
}