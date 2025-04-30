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
                XmlNodeList userNodes = doc.SelectNodes("//User");

                // Loop through each user node
                foreach (XmlNode node in userNodes)
                {
                    string name = node.SelectSingleNode("Name").InnerText;
                    int age = int.Parse(node.SelectSingleNode("Age").InnerText);
                    string city = node.SelectSingleNode("City").InnerText;

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