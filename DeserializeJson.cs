using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonExample
{
    class DeserializeJson
    {
       public static void MainDeserializeJson(string[] args)
        {
            try
            {
                // Read JSON file
                string json = File.ReadAllText("users.json");

                // Deserialize into List<User>
                List<User>? users = JsonConvert.DeserializeObject<List<User>>(json);

                if (users == null)
                {
                    throw new Exception("Failed to deserialize users.json: Result is null.");
                }

                // Loop through and display users
                Console.WriteLine("Users in JSON file:");
                foreach (var user in users)
                {
                    Console.WriteLine($"Name: {user.Name ?? "Unknown"}, Age: {user.Age}, City: {user.City ?? "Unknown"}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing JSON: {ex.Message}");
            }
        }
    }
}