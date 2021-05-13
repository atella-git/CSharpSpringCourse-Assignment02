using System;
using HomeWork2.Models;
using System.Linq;
using System.Collections.Generic;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();
            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });
            //Dispaly the names with password hello
            var pwd = users.Where(s => s.Password == "hello");
            Console.WriteLine(string.Join("\n", pwd.Select(s=> s.Name)));
            //Remove the user with lower case passwords
            users.RemoveAll(q => q.Name.ToLower() == q.Password);

            //Remove the first user with password hello            
            var fstUser = users.FirstOrDefault(r => r.Password == "hello");
            if (fstUser != default)
            {
                users.Remove(fstUser);
            }

            foreach (var user in users)
            {
                Console.WriteLine($"name {user.Name} password {user.Password}");
            }
        }
    }
}
