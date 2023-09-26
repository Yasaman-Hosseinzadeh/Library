namespace LibraryManagementSystem
{
    partial class AddBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BookNameLabel = new Label();
            BookCodeLabel = new Label();
            AuthorLabel = new Label();
            DescriptionLabel = new Label();
            ExistLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            AddBookButton = new Button();
            ComboBoxStatus = new ComboBox();
            SuspendLayout();
            // 
            // BookNameLabel
            // 
            BookNameLabel.AutoSize = true;
            BookNameLabel.Location = new Point(766, 48);
            BookNameLabel.Name = "BookNameLabel";
            BookNameLabel.Size = new Size(21, 15);
            BookNameLabel.TabIndex = 0;
            BookNameLabel.Text = "نام";
            // 
            // BookCodeLabel
            // 
            BookCodeLabel.AutoSize = true;
            BookCodeLabel.Location = new Point(768, 103);
            BookCodeLabel.Name = "BookCodeLabel";
            BookCodeLabel.Size = new Size(19, 15);
            BookCodeLabel.TabIndex = 1;
            BookCodeLabel.Text = "کد";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(739, 163);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(48, 15);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "نویسنده";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(710, 227);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(77, 15);
            DescriptionLabel.TabIndex = 3;
            DescriptionLabel.Text = "توضیح مختصر";
            // 
            // ExistLabel
            // 
            ExistLabel.AutoSize = true;
            ExistLabel.Location = new Point(678, 280);
            ExistLabel.Name = "ExistLabel";
            ExistLabel.Size = new Size(109, 15);
            ExistLabel.TabIndex = 4;
            ExistLabel.Text = "وضعیت موجود بودن";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(457, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(457, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(457, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(457, 219);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 23);
            textBox4.TabIndex = 8;
            // 
            // AddBookButton
            // 
            AddBookButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddBookButton.Location = new Point(457, 325);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(330, 43);
            AddBookButton.TabIndex = 10;
            AddBookButton.Text = "ذخیره";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // ComboBoxStatus
            // 
            ComboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxStatus.FormattingEnabled = true;
            ComboBoxStatus.Location = new Point(457, 274);
            ComboBoxStatus.Name = "ComboBoxStatus";
            ComboBoxStatus.Size = new Size(203, 23);
            ComboBoxStatus.TabIndex = 11;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ComboBoxStatus);
            Controls.Add(AddBookButton);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ExistLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(BookCodeLabel);
            Controls.Add(BookNameLabel);
            Name = "AddBookForm";
            Text = "فرم کتاب ها";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BookNameLabel;
        private Label BookCodeLabel;
        private Label AuthorLabel;
        private Label DescriptionLabel;
        private Label ExistLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button AddBookButton;
        private ComboBox ComboBoxStatus;
    }
}