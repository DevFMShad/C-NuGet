using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace JsonExample
{
    class DeserializeUserTypes
    {
        public static void MainDeserializeUserTypes(string[] args)
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
                List<User>? users = JsonConvert.DeserializeObject<List<User>>(json, settings);

                if (users == null)
                {
                    throw new Exception("Failed to deserialize user_types.json: Result is null.");
                }

                // Loop through and display users
                Console.WriteLine("User Types in JSON file:");
                foreach (var user in users)
                {
                    if (user is Admin admin)
                    {
                        Console.WriteLine($"Admin: {admin.Name ?? "Unknown"}, Role: {admin.Role ?? "Unknown"}, Can Manage: {admin.CanManageUsers}, City: {admin.City ?? "Unknown"}");
                    }
                    else if (user is RegularUser regularUser)
                    {
                        Console.WriteLine($"Regular User: {regularUser.Name ?? "Unknown"}, Role: {regularUser.Role ?? "Unknown"}, Membership: {regularUser.MembershipLevel ?? "Unknown"}, City: {regularUser.City ?? "Unknown"}");
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