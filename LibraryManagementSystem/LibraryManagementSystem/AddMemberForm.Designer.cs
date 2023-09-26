namespace LibraryManagementSystem
{
    partial class AddMemberForm
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
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            CellPhoneLabel = new Label();
            SubscriptionCodeLabel = new Label();
            FirstNameTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            CellPhoneTextBox = new TextBox();
            SubscriptionCodeTextBox = new TextBox();
            AddMemberButton = new Button();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(756, 53);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(21, 15);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "نام";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(708, 113);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(69, 15);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "نام خانوادگی";
            // 
            // CellPhoneLabel
            // 
            CellPhoneLabel.AutoSize = true;
            CellPhoneLabel.Location = new Point(684, 164);
            CellPhoneLabel.Name = "CellPhoneLabel";
            CellPhoneLabel.Size = new Size(93, 15);
            CellPhoneLabel.TabIndex = 2;
            CellPhoneLabel.Text = "شماره تلفن همراه";
            // 
            // SubscriptionCodeLabel
            // 
            SubscriptionCodeLabel.AutoSize = true;
            SubscriptionCodeLabel.Location = new Point(720, 232);
            SubscriptionCodeLabel.Name = "SubscriptionCodeLabel";
            SubscriptionCodeLabel.Size = new Size(57, 15);
            SubscriptionCodeLabel.TabIndex = 3;
            SubscriptionCodeLabel.Text = "کد اشتراک";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(468, 45);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(186, 23);
            FirstNameTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(468, 105);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(186, 23);
            LastNameTextBox.TabIndex = 5;
            // 
            // CellPhoneTextBox
            // 
            CellPhoneTextBox.Location = new Point(468, 161);
            CellPhoneTextBox.Name = "CellPhoneTextBox";
            CellPhoneTextBox.Size = new Size(186, 23);
            CellPhoneTextBox.TabIndex = 6;
            // 
            // SubscriptionCodeTextBox
            // 
            SubscriptionCodeTextBox.Location = new Point(468, 224);
            SubscriptionCodeTextBox.Name = "SubscriptionCodeTextBox";
            SubscriptionCodeTextBox.Size = new Size(186, 23);
            SubscriptionCodeTextBox.TabIndex = 7;
            // 
            // AddMemberButton
            // 
            AddMemberButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AddMemberButton.Location = new Point(468, 273);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(309, 50);
            AddMemberButton.TabIndex = 8;
            AddMemberButton.Text = "ذخیره";
            AddMemberButton.UseVisualStyleBackColor = true;
            AddMemberButton.Click += AddMemberButton_Click;
            // 
            // AddMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddMemberButton);
            Controls.Add(SubscriptionCodeTextBox);
            Controls.Add(CellPhoneTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(SubscriptionCodeLabel);
            Controls.Add(CellPhoneLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Name = "AddMemberForm";
            Text = "فرم اعضا";
            Load += AddMemberForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label CellPhoneLabel;
        private Label SubscriptionCodeLabel;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTextBox;
        private TextBox CellPhoneTextBox;
        private TextBox SubscriptionCodeTextBox;
        private Button AddMemberButton;
    }
}