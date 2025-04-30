using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonExample
{
    class AddJsonEntries
    {
       public static void MainAddJsonEntries(string[] args)
        {
            try
            {
                // Read existing JSON file
                string json = File.ReadAllText("users.json");
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);

                // Add new user
                User newUser = new User
                {
                    Name = "Sarah Davis",
                    Age = 32,
                    City = "Boston"
                };
                users.Add(newUser);

                // Serialize back to JSON and save
                string updatedJson = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText("users.json", updatedJson);

                Console.WriteLine("New user added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding user: {ex.Message}");
            }
        }
    }
}