using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            //TODO: Check Validations
            var memebr = new Member() { 
                FirstName = FirstNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                CellPhone = CellPhoneTextBox.Text,
                SubscriptionCode = SubscriptionCodeTextBox.Text
            };

            var memebrs = Extensions.GetMembersFromJsonFile();

            memebrs.Add(memebr);

            memebrs.SetMembersToJsonFile();

            Close();
        }
    }
}
