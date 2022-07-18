using HttpExerciseLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HttpExerciseLib.Service
{
    public class UserSerializer
    {
        public void Serialize(string filename, User user)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(User));

            using (var writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, user);
            }
        }

        public List<User> Deserialize(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(User));
            List<User> users = null;
            using(var reader = new StreamReader(filename))
            {
                users = (List<User>)serializer.Deserialize(reader);
            }
            return users;
        }
    }
}
