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

        private static string Path { get; set; } = Environment.CurrentDirectory + "/data.Xml";

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

                    fs.Close();
                }
            }
        }
        /// <summary>
        /// Parse the 'data.xml' file and store all info in UsertList and EventList
        /// </summary>
        public static void RetrieveAllData()
        {
            Console.WriteLine("Path of the file : " + Path);

            if (Path != string.Empty)
            {
                // Load the xml file

                XDocument xml = XDocument.Load("data.xml");

                IEnumerable<XElement> users = xml.Element("root").Elements("users");
                List<Dictionary<string,string>> userList = new List<Dictionary<string,string>>();

                IEnumerable<XElement> userInfos;

                // Variables values stored in User instance and add it UserList
                string firstName, lastName, sector, email, password = string.Empty;

                // Fill the dictionary with users values
                foreach (XElement user in users)
                {
                    userInfos = user.Elements("user");

                    foreach (XElement userInfo in userInfos)
                    {
                        firstName = userInfo.Element("firstname").Value;
                        lastName = userInfo.Element("lastname").Value;
                        sector = userInfo.Element("sector").Value;
                        email = userInfo.Element("email").Value;
                        password = userInfo.Element("password").Value;

                        UserList.Users.Add(new User(firstName, lastName, sector, email, password));
                    }
                }
            }
        }
    }
}
