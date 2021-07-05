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
    public partial class EditContactsForm : Form, IObserver
    {
        public EditContactsForm()
        {
            InitializeComponent();
            BirthdayContacts.Instance.attach(this);
            update(BirthdayContacts.Instance);

            initializeInputFields();
        }

        private void initializeInputFields()
        {
            if(DGV_Contacts.Rows.Count > 1)
            {
                var firstRow = DGV_Contacts.Rows[0];
                TB_Name.Text = firstRow.Cells[0].Value.ToString();
                DTP_DateOfBirth.Value = DateTime.Parse(firstRow.Cells[1].Value.ToString());
            }
            
        }

        List<Person> contacts;

        private void DGV_Contacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= DGV_Contacts.Rows.Count - 1 || e.RowIndex < 0) return;
            var clickedRow = DGV_Contacts.Rows[e.RowIndex];
            TB_Name.Text = clickedRow.Cells[0].Value.ToString();
            DTP_DateOfBirth.Value = DateTime.Parse(clickedRow.Cells[1].Value.ToString());
        }

        public void update(ISubject subject)
        {
            if (DGV_Contacts.Columns.Count > 0)
                if (subject is BirthdayContacts bdayContacts)
                {
                    contacts = bdayContacts.Contacts;
                    DGV_Contacts.Rows.Clear();
                    contacts.ForEach(person => DGV_Contacts.Rows.Add(person.name, person.birthdate));

                    if (DGV_Contacts.SortedColumn is null) DGV_Contacts.Sort(DGV_Contacts.Columns[0], ListSortDirection.Ascending);
                }
        }

        private void BtnAddBday_Click(object sender, EventArgs e)
        {
            addBirthday();
        }

        private void addBirthday()
        {
            Person personAdded = new Person(TB_Name.Text, DTP_DateOfBirth.Value);

            if (BirthdayContacts.addBirthdateToContacts(personAdded))
            {
                Lbl_Status.Text = "New Person <" + personAdded + "> was added to your contacts.";
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = DGV_Contacts.SelectedCells[0].RowIndex;
            string selectedRowName = DGV_Contacts.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string selectedRowDate = DGV_Contacts.Rows[selectedRowIndex].Cells[1].Value.ToString();
            Person personRemoved = new Person(selectedRowName, DateTime.Parse(selectedRowDate));
            Person personAdded = new Person(TB_Name.Text, DTP_DateOfBirth.Value);

            Lbl_Status.Text = BirthdayContacts.editBirthday(personRemoved, personAdded);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = DGV_Contacts.SelectedCells[0].RowIndex;
            string selectedRowName = DGV_Contacts.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string selectedRowDate = DGV_Contacts.Rows[selectedRowIndex].Cells[1].Value.ToString();
            Person personRemoved = new Person(selectedRowName, DateTime.Parse(selectedRowDate));

            if (removeSelectedContact())
            {
                Lbl_Status.Text = "Person <" + personRemoved + "> was successfully removed from contacts.";
            }

        }

        private bool removeSelectedContact()
        {
            int selectedRowIndex = DGV_Contacts.SelectedCells[0].RowIndex;
            string selectedRowName = DGV_Contacts.Rows[selectedRowIndex].Cells[0].Value.ToString();
            string selectedRowDate = DGV_Contacts.Rows[selectedRowIndex].Cells[1].Value.ToString();

            return BirthdayContacts.removeBirthdayFromContacts(selectedRowName, DateTime.Parse(selectedRowDate));
        }

        private void DTP_DateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            if (!DTP_DateOfBirth.Value.Equals(monthCalendar1.SelectionStart))
                monthCalendar1.SelectionStart = DTP_DateOfBirth.Value;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!DTP_DateOfBirth.Value.Equals(monthCalendar1.SelectionStart))
                DTP_DateOfBirth.Value = monthCalendar1.SelectionStart;
        }

        private void TB_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                addBirthday();
        }
    }
}
