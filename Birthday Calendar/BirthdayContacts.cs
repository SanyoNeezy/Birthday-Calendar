using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Birthday_Calendar
{
    public sealed class BirthdayContacts : ISubject
    {
        // Singleton pattern
        private static BirthdayContacts instance = null;
        public static BirthdayContacts Instance
        {
            get
            {
                if (instance is null)
                {
                    instance = new BirthdayContacts();
                }
                return instance;
            }
        }

        private BirthdayContacts()
        {
            _contacts = readContactsFromFileSystem();
        }

        List<IObserver> observers = new List<IObserver>();

        public void notify()
        {
            observers.ForEach(o => o.update(this));
        }

        public void attach(IObserver observer)
        {
            observers.Add(observer);
        }

        static List<Person> _contacts = new List<Person>();

        public List<Person> Contacts
        {
            get
            {
                if (_contacts is null) return new List<Person>();
                else return _contacts;
            }
            private set
            {
                _contacts = value;
                notify();
                updateContactsFile(_contacts);
            }
        }

        public const string cDateFormat = "dd/MM/yyyy";
        private const string cJsonFileName = "\\birthdates.json";

        private static string getJsonDirectory()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Birthday Calendar By Sanyo Neezy";
        }

        private static string getJsonPath()
        {
            return getJsonDirectory() + cJsonFileName;
        }

        private static List<Person> readContactsFromFileSystem()
        {
            var formatProvider = new IsoDateTimeConverter();
            formatProvider.DateTimeFormat = cDateFormat;
            var jsonDirectory = getJsonDirectory();
            var jsonPath = jsonDirectory + cJsonFileName;
            var contacts = new List<Person>();
            string jsonFileText = string.Empty;

            try
            {
                if (!Directory.Exists(jsonDirectory)) Directory.CreateDirectory(jsonDirectory);

                if (!File.Exists((jsonPath))) File.Create(jsonPath);

                jsonFileText = File.ReadAllText(jsonPath);
            }
            catch (Exception e)
            {
                MessageBox.Show("Oh lol fail. Frag Sascha nomma und schicke ihm diese Meldung:\nFehler beim Erzeugen des JsonDirectory.\n\n" + e.Message);
            }

            if (jsonFileText.Length > 0)
                try
                {
                    contacts = JsonConvert.DeserializeObject<List<Person>>(jsonFileText, formatProvider);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Oh lol fail. Frag Sascha nomma und schicke ihm diese Meldung:\nFehler beim Deserialisieren der JSON Datei.\n\n" + e.Message);
                }
            return contacts;

        }

        public static string editBirthday(Person personRemoved, Person personAdded)
        {
            if (!_contacts.Contains(personRemoved))
                return "Contact <" + personRemoved + "> was not found in your Contacts. No Action was performed.";
            if (_contacts.Contains(personAdded))
                return "Edit cannot be performed. You already have a contact with the exact name and date of birth <" + personAdded + "> in your Contacts. Consider changing the name to something meaningful to you.";

            if (!removeBirthdayFromContacts(personRemoved))
                return "The selected Contact <" + personRemoved + "> could not be removed. Contact <" + personAdded + "> was not added to your Contacts.";

            if (!addBirthdateToContacts(personAdded))
                return "Something went wrong! Contact <" + personRemoved + "> was removed, but Contact <" + personAdded + "> could not be added.";

            return "Contact <" + personRemoved + "> was successfully changed to <" + personAdded + ">.";
        }

        public static bool addBirthdateToContacts(string name, DateTime dateOfBirth)
        {
            return addBirthdateToContacts(new Person(name, dateOfBirth));
        }

        public static bool addBirthdateToContacts(Person newFriend)
        {
            if (_contacts.Contains(newFriend))
                return false;

            _contacts.Add(newFriend);
            Instance.Contacts = _contacts;
            return true;
        }

        private void updateContactsFile(List<Person> contacts)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());

            using (StreamWriter sw = new StreamWriter(getJsonPath()))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, contacts);
            }
        }



        public static bool removeBirthdayFromContacts(string name, DateTime dateOfBirth)
        {
            return removeBirthdayFromContacts(new Person(name, dateOfBirth));
        }
        public static bool removeBirthdayFromContacts(Person person)
        {
            if (_contacts.Remove(person))
            {
                Instance.Contacts = _contacts;
                return true;
            }
            else return false;
        }

        public static void addBirthdateToContacts(string name, string birthdate)
        {
            addBirthdateToContacts(name, DateTime.Parse(birthdate));
        }

        public List<Person> getNearingBirthdays()
        {
            List<Person> contactsWithNearBdays = Instance.Contacts.FindAll(person => DateHandler.birthdayIsNearing(person.getBirthdate()));

            return contactsWithNearBdays;
        }


    }
}