using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace EventManager
{
    public static class XML_Manager
    {
        public static XElement Root { get; set; }
        public static void SaveAllData()
        {
            XElement[] usrContent = new XElement[6];

            User user = new User();

            List<XElement> users = new List<XElement>();

            if (UserList.Users.Count > 0)
            {
                for (int i = 0; i < UserList.Users.Count; i++)
                {
                    user = UserList.Users[i];

                    usrContent = new XElement[6]
                    {
                        new XElement("index", i),
                        new XElement("firstname", user.FirstName),
                        new XElement("lastname", user.LastName),
                        new XElement("sector", user.Sector),
                        new XElement("email", user.Email),
                        new XElement("password", user.EncryptedPassword)
                    };

                    users.Add(new XElement("user", usrContent));
                }
            }

            Root = new XElement("root", new XElement("users", users.ToArray()));

            XDocument xml = new XDocument(Root);

            string path = Environment.CurrentDirectory + "/data.xml";

            Console.WriteLine(path);
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                    xml.Save(fs);
                }
            }
        }
    }
}
