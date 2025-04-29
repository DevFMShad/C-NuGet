using Newtonsoft.Json;
using System;

namespace JsonExample
{
    // Base User class
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }

    // Admin user type
    public class Admin : User
    {
        public string Role { get; set; } = "Admin";
        public bool CanManageUsers { get; set; } = true;
    }

    // Regular user type
    public class RegularUser : User
    {
        public string Role { get; set; } = "User";
        public string MembershipLevel { get; set; } = "Standard";
    }

    class UserTypes
    {
        static void Main(string[] args)
        {
            // Create sample users
            Admin admin = new Admin
            {
                Name = "Emma Clark",
                Age = 45,
                City = "San Francisco",
                CanManageUsers = true
            };

            RegularUser regularUser = new RegularUser
            {
                Name = "Mike Lee",
                Age = 29,
                City = "Austin",
                MembershipLevel = "Premium"
            };

            // Display user information
            Console.WriteLine($"Admin: {admin.Name}, Role: {admin.Role}, Can Manage: {admin.CanManageUsers}, City: {admin.City}");
            Console.WriteLine($"Regular User: {regularUser.Name}, Role: {regularUser.Role}, Membership: {regularUser.MembershipLevel}, City: {regularUser.City}");
        }
    }
}