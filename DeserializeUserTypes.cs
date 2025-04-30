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

    public class Admin : User
    {
        public string Role { get; set; }
        public bool CanManageUsers { get; set; }
    }

    public class RegularUser : User
    {
        public string Role { get; set; }
        public string MembershipLevel { get; set; }
    }

    class DeserializeUserTypes
    {
        static void Main(string[] args)
        {
            try
            {
                // Read JSON file
                string json = File.ReadAllText("user_types.json");

                // Configure JsonSerializerSettings for polymorphic deserialization
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };

                // Deserialize into List<User>
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json, settings);

                // Loop through and display users
                Console.WriteLine("User Types in JSON file:");
                foreach (var user in users)
                {
                    if (user is Admin admin)
                    {
                        Console.WriteLine($"Admin: {admin.Name}, Role: {admin.Role}, Can Manage: {admin.CanManageUsers}, City: {admin.City}");
                    }
                    else if (user is RegularUser regularUser)
                    {
                        Console.WriteLine($"Regular User: {regularUser.Name}, Role: {regularUser.Role}, Membership: {regularUser.MembershipLevel}, City: {regularUser.City}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deserializing user types: {ex.Message}");
            }
        }
    }
}