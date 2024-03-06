using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApplication
{
    public partial class PersoneEditForm : Form
    {
        public PersoneEditForm()
        {
            InitializeComponent();
            this.contactsTableAdapter.Fill(this.notebookDataSet.Contacts);
            this.contactTypeTableAdapter.Fill(this.notebookDataSet.ContactType);
            personsBindingSource.AddNew();
        }
        public PersoneEditForm(int index)
        {
            InitializeComponent();
            this.contactsTableAdapter.Fill(this.notebookDataSet.Contacts);
            this.contactTypeTableAdapter.Fill(this.notebookDataSet.ContactType);
            this.personsTableAdapter.Fill(this.notebookDataSet.Persons);
            personsBindingSource.Position = index;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            personsBindingSource.EndEdit();
            personsTableAdapter.Update(notebookDataSet.Persons);
            contactsTableAdapter.Update(notebookDataSet.Contacts);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
