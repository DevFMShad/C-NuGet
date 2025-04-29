using JsonExample;
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

    class AddJsonEntries
    {
        static void Main(string[] args)
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

//after this is run it will update the users.json file

/* and it will look like this
[
  {
    "Name": "John Doe",
    "Age": 30,
    "City": "New York"
  },
  {
    "Name": "Jane Smith",
    "Age": 25,
    "City": "Los Angeles"
  },
  {
    "Name": "Bob Johnson",
    "Age": 40,
    "City": "Chicago"
  },
  {
    "Name": "Sarah Davis",
    "Age": 32,
    "City": "Boston"
  }
]*/