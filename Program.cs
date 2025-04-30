using System;

namespace JsonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select a task to run:");
                Console.WriteLine("1. Task 2: XML Reader");
                Console.WriteLine("2. Task 3: Add New Entries to JSON");
                Console.WriteLine("3. Task 4: Deserialize JSON");
                Console.WriteLine("4. Task 5: User Types with Inheritance");
                Console.WriteLine("5. Task 6: Deserialize User Types");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        XmlReaderProgram.MainXmlReader(args);
                        break;
                    case "2":
                        AddJsonEntries.MainAddJsonEntries(args);
                        break;
                    case "3":
                        DeserializeJson.MainDeserializeJson(args);
                        break;
                    case "4":
                        UserTypes.MainUserTypes(args);
                        break;
                    case "5":
                        DeserializeUserTypes.MainDeserializeUserTypes(args);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}