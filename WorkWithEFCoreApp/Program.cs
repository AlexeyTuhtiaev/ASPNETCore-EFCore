using System;
using WorkWithEFCoreApp.Entities;

namespace WorkWithEFCoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User { Name = "Alexey", Surname = "Tuhtiaev"};
            Operations.Create(user);

            User userFromDb = Operations.GetUser(user.Id);

            Print(userFromDb);

            Console.ReadKey();
        }

        static void Print(User user)
        {
            Console.WriteLine(user.Name);
        }
    }
}
