using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonExample
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    class DeserializeJson
    {
        static void Main(string[] args)
        {
            try
            {
                // Read JSON file
                string json = File.ReadAllText("users.json");

                // Deserialize into List<User>
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

                // Loop through and display users
                Console.WriteLine("Users in JSON file:");
                foreach (var user in users)
                {
                    Console.WriteLine($"Name: {user.Name}, Age: {user.Age}, City: {user.City}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing JSON: {ex.Message}");
            }
        }
    }
}