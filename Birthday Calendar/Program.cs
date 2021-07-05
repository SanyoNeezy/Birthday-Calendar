using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthday_Calendar
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (StartupDialog())
                Application.Run(new EditContactsForm());
        }

        static bool StartupDialog()
        {
            List<Person> people;
            people = BirthdayContacts.Instance.getNearingBirthdays();

            var nearingBirthdatesFormatString = "";

            people.ForEach(person => nearingBirthdatesFormatString += person.name + "\t-\t" + person.birthdate + "\n");

            string message = "### Birthday Reminder ###\n\n Birthdays for the next " + DateHandler.remindInAdvanceTimeSpan.Days + " days:\n\n" + nearingBirthdatesFormatString + "\nWould you like to add more entries?";
            string caption = "Nearing Birthdays";
            return DialogResult.Yes == MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);
        }
    }
}
