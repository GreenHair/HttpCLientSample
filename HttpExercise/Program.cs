using HttpExerciseLib.Model;
using HttpExerciseLib.Service;
using System;
using System.Collections.Generic;

namespace HttpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpService service = new HttpService();
            List<User> users = service.GetUsers().Result;
            int count = 1;
            UserSerializer serializer = new UserSerializer();
            foreach(User user in users)
            {
                Console.WriteLine("Benutzer {0}", user.name.first);
                serializer.Serialize(String.Format("user{0}.xml", count), user);
                count++;
            }
            Console.ReadLine();
        }
    }
}
