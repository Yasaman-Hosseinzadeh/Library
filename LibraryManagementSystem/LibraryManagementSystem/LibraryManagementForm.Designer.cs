namespace LibraryManagementSystem
{
    partial class LibraryManagementForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RightPanel = new Panel();
            AddBookButton = new Button();
            AddMemberButton = new Button();
            TopPanel = new Panel();
            TextBox = new TextBox();
            BottomPanel = new Panel();
            panel1 = new Panel();
            buttonAddMember = new Button();
            buttonAddBook = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            MemberGridView = new DataGridView();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            BookGridView = new DataGridView();
            RightPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MemberGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookGridView).BeginInit();
            SuspendLayout();
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.LightSeaGreen;
            RightPanel.Controls.Add(AddBookButton);
            RightPanel.Controls.Add(AddMemberButton);
            RightPanel.Dock = DockStyle.Right;
            RightPanel.Location = new Point(672, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(128, 450);
            RightPanel.TabIndex = 0;
            // 
            // AddBookButton
            // 
            AddBookButton.BackColor = Color.LightGray;
            AddBookButton.FlatStyle = FlatStyle.Flat;
            AddBookButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddBookButton.Location = new Point(6, 136);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(110, 51);
            AddBookButton.TabIndex = 1;
            AddBookButton.Text = "افزودن کتاب";
            AddBookButton.UseVisualStyleBackColor = false;
            // 
            // AddMemberButton
            // 
            AddMemberButton.BackColor = Color.LightGray;
            AddMemberButton.FlatStyle = FlatStyle.Flat;
            AddMemberButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddMemberButton.Location = new Point(6, 72);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(110, 47);
            AddMemberButton.TabIndex = 0;
            AddMemberButton.Text = "افزودن اعضا";
            AddMemberButton.UseVisualStyleBackColor = false;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.LightSeaGreen;
            TopPanel.Controls.Add(TextBox);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(672, 67);
            TopPanel.TabIndex = 1;
            // 
            // TextBox
            // 
            TextBox.BackColor = Color.LightSeaGreen;
            TextBox.BorderStyle = BorderStyle.None;
            TextBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TextBox.Location = new Point(214, 25);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(244, 32);
            TextBox.TabIndex = 0;
            TextBox.Text = "سیستم مدیریت کتابخانه";
            TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // BottomPanel
            // 
            BottomPanel.BackColor = Color.LightSeaGreen;
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.Location = new Point(0, 396);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(672, 54);
            BottomPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(buttonAddMember);
            panel1.Controls.Add(buttonAddBook);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(131, 499);
            panel1.TabIndex = 0;
            // 
            // buttonAddMember
            // 
            buttonAddMember.Location = new Point(3, 159);
            buttonAddMember.Name = "buttonAddMember";
            buttonAddMember.Size = new Size(119, 39);
            buttonAddMember.TabIndex = 1;
            buttonAddMember.Text = "افزودن اعضا";
            buttonAddMember.UseVisualStyleBackColor = true;
            buttonAddMember.Click += buttonAddMember_Click;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Location = new Point(3, 102);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(119, 39);
            buttonAddBook.TabIndex = 0;
            buttonAddBook.Text = "افزودن کتاب";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 100);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightSeaGreen;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(122, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 26);
            textBox1.TabIndex = 0;
            textBox1.Text = "سیستم مدیریت کتابخانه";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // MemberGridView
            // 
            MemberGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberGridView.Dock = DockStyle.Fill;
            MemberGridView.Location = new Point(3, 19);
            MemberGridView.Name = "MemberGridView";
            MemberGridView.RightToLeft = RightToLeft.Yes;
            MemberGridView.RowTemplate.Height = 25;
            MemberGridView.Size = new Size(280, 359);
            MemberGridView.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(MemberGridView);
            groupBox1.Location = new Point(12, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 381);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "لیست اعضا";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(BookGridView);
            groupBox2.Location = new Point(304, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(286, 381);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "لیست کتابها";
            // 
            // BookGridView
            // 
            BookGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookGridView.Dock = DockStyle.Fill;
            BookGridView.Location = new Point(3, 19);
            BookGridView.Name = "BookGridView";
            BookGridView.RightToLeft = RightToLeft.Yes;
            BookGridView.RowTemplate.Height = 25;
            BookGridView.Size = new Size(280, 359);
            BookGridView.TabIndex = 2;
            // 
            // LibraryManagementForm
            // 
            ClientSize = new Size(731, 499);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "LibraryManagementForm";
            RightPanel.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MemberGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BookGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel RightPanel;
        private Panel TopPanel;
        private Panel BottomPanel;
        private TextBox TextBox;
        private Button AddBookButton;
        private Button AddMemberButton;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox1;
        private Button buttonAddMember;
        private Button buttonAddBook;
        private DataGridView MemberGridView;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView BookGridView;
    }
}