using LibraryManagementSystem.Models;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    public partial class LibraryManagementForm : Form
    {
        public LibraryManagementForm()
        {
            InitializeComponent();

            MemberGridView.DataSource = Extensions.GetMembersFromJsonFile();
            //MemberGridView.Columns[0].HeaderText = "نام";
            //MemberGridView.Columns[1].HeaderText = "نام خانوداگی";
            //MemberGridView.Columns[2].HeaderText = "شماره همراه";
            //MemberGridView.Columns[3].HeaderText = "کد اشتراک";

            for (int i = 0; i < MemberGridView.Columns.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        MemberGridView.Columns[i].HeaderText = "نام";
                        continue;
                    case 1:
                        MemberGridView.Columns[i].HeaderText = "نام خانوداگی";
                        continue;
                    case 2:
                        MemberGridView.Columns[i].HeaderText = "شماره همراه";
                        continue;
                    case 3:
                        MemberGridView.Columns[i].HeaderText = "کد اشتراک";
                        continue;
                }
            }

            BookGridView.DataSource = Extensions.GetBooksFromJsonFile();

            for (int i = 0; i < BookGridView.Columns.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        BookGridView.Columns[i].HeaderText = "نام کتاب";
                        continue;
                    case 1:
                        BookGridView.Columns[i].HeaderText = "شناسه کتاب";
                        continue;
                    case 2:
                        BookGridView.Columns[i].HeaderText = "نویسنده";
                        continue;
                    case 3:
                        BookGridView.Columns[i].HeaderText = "توضیح مختصر";
                        continue;
                    case 4:
                        BookGridView.Columns[i].HeaderText = "وضعیت موجودی";
                        continue;
                }

            }
        }


        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void TextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void buttonAddBook_Click(object sender, EventArgs e)
        {
            var form = new AddBookForm();
            form.ShowDialog();
        }

        public void buttonAddMember_Click(object sender, EventArgs e)
        {
            var form = new AddMemberForm();
            form.ShowDialog();
        }
    }
}