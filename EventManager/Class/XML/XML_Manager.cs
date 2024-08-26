using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
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
            // Saving users
            User user = new User();

            XElement[] usrContent;

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

            // Saving events
            Event eventItm = new Event();

            XElement[] evntContent;

            List<XElement> events = new List<XElement>();

            if (EventList.Events.Count > 0)
            {
                for (int i = 0; i < EventList.Events.Count; i++)
                {
                    eventItm = EventList.Events[i];

                    Console.WriteLine(eventItm.EventDes);

                    evntContent = new XElement[7]
                    {
                            new XElement("index", i),
                            new XElement("name", eventItm.EventName),
                            new XElement("author", eventItm.EventAuthor),
                            new XElement("start", eventItm.EventStart.ToString()),
                            new XElement("end", eventItm.EventEnd.ToString()),
                            new XElement("description", eventItm.EventDes),
                            new XElement("reminder_opt", eventItm.ReminderOpt.ToString())
                    };

                    events.Add(new XElement("event", evntContent));
                }
            }

            XElement[] contents = new XElement[2]
            {
                new XElement("users", users.ToArray()),
                new XElement("events", events.ToArray())
            };

            Root = new XElement("root", contents);

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
            else
            {
                using (FileStream fs = File.OpenWrite(path))
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

            if (File.Exists(Path))
            {
                // Load the xml file

                XDocument xml = XDocument.Load("data.xml");

                // Retrieving users data
                IEnumerable<XElement> users = xml.Element("root").Elements("users");
                IEnumerable<XElement> userInfos;

                string firstName, lastName, sector, email, password = string.Empty;
                
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

                // Retrieving events data
                
                IEnumerable<XElement> events = xml.Element("root").Elements("events");
                IEnumerable<XElement> eventInfos;

                string name, author, des;
                DateTime start, end;
                EventReminder.RemindSet reminder;
                
                foreach (XElement eventItm in events)
                {
                    eventInfos = eventItm.Elements("event");

                    foreach (XElement eventInfo in  eventInfos)
                    {
                        name = eventInfo.Element("name").Value;
                        author = eventInfo.Element("author").Value;
                        start = DateTime.Parse(eventInfo.Element("start").Value);
                        end = DateTime.Parse(eventInfo.Element("end").Value);
                        des = eventInfo.Element("description").Value;
                        reminder = (EventReminder.RemindSet)Enum.Parse(typeof(EventReminder.RemindSet), eventInfo.Element("reminder_opt").Value);

                        EventList.Events.Add(new Event(name, author, start, end, des, reminder));
                    }
                }
                
            }
        }
    }
}
