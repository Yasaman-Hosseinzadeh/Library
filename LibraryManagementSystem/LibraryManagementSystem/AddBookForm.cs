using LibraryManagementSystem.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();

            ComboBoxStatus.DataSource = Extensions.GetComboBoxData();
            ComboBoxStatus.ValueMember = "Value";
            ComboBoxStatus.DisplayMember = "Name";
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            var book = new Book()
            {
                BookName = textBox1.Text,
                BookId = textBox2.Text,
                BookAuthor = textBox3.Text,
                BookDescription = textBox4.Text,
                BookStatus = ComboBoxStatus.Text
            };

            var books = Extensions.GetBooksFromJsonFile();

            books.Add(book);

            books.SetBooksToJsonFile();

            Close();
        }
    }
    }

