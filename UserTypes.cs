using System;

namespace JsonExample
{
    class UserTypes
    {
       public static void MainUserTypes(string[] args)
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