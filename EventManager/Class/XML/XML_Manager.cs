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
        private static string Path { get; set; } = string.Empty;

        private static String GetPath()
        {
            if (File.Exists(Environment.CurrentDirectory + "/data.xml"))
            {
                Console.WriteLine("Path exist");

                return Environment.CurrentDirectory + "/data.xml";
            }
            else
            {
                Console.WriteLine("Path dont exist");
                return string.Empty;
            }
        }
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

            Path = Environment.CurrentDirectory + "/data.xml";

            Console.WriteLine(Path);

            if (!File.Exists(Path))
            {
                using (FileStream fs = File.Create(Path))
                {
                    xml.Save(fs);
                }
            }
        }
        /// <summary>
        /// Parse the 'data.xml' file and store all info in UsertList and EventList
        /// </summary>
        public static void RetrieveAllData()
        {
            Console.WriteLine("Path of the file : " + GetPath());

            if (GetPath() != string.Empty)
            {
                // Load the xml file

                XDocument xml = XDocument.Load("data.xml");

                IEnumerable<XElement> users = xml.Element("root").Elements("users");
                List<Dictionary<string,string>> userList = new List<Dictionary<string,string>>();

                IEnumerable<XElement> userInfos;
                Dictionary<string,string> userValues = new Dictionary<string,string>();

                // Variables values stored in User instance and add it UserList
                string firstName, lastName, sector, email, password = string.Empty;

                // Fill the dictionary with users values
                foreach (XElement user in users)
                {
                    userInfos = user.Elements("user").Elements();

                    foreach (XElement userInfo in userInfos)
                    {
                        userValues.Add(userInfo.Name.ToString(), userInfo.Value);

                        Console.WriteLine($"Key : {userInfo.Name.ToString()}; Value : {userInfo.Value}");
                    }

                    userValues.TryGetValue("firstname", out firstName);
                    userValues.TryGetValue("lastname", out  lastName);
                    userValues.TryGetValue("sector", out sector);
                    userValues.TryGetValue("email", out email);
                    userValues.TryGetValue("password", out password);

                    UserList.Users.Add(new User(firstName, lastName, sector, email, string.Empty, password));
                }

                Console.WriteLine(userList.Count);
            }
        }
    }
}
