using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthday_Calendar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
        }



        private void Btn_AddBirthday_Click(object sender, EventArgs e)
        {
            var birthdate = this.Calendar.SelectionStart;
            var name = this.TB_Name.Text;
            BirthdayContacts.addBirthdateToContacts(name, birthdate);
        }

        private void Btn_ShowBdayList_Click(object sender, EventArgs e)
        {
            new EditContactsForm().Show();
        }
    }
}
