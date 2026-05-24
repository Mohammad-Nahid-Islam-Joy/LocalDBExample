namespace LocalDBExample
{
    partial class UserForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserNameLabel = new Label();
            AgeLabel = new Label();
            SalaryLabel = new Label();
            PasswordLabel = new Label();
            UserNameBox = new TextBox();
            AgeBox = new TextBox();
            SalaryBox = new TextBox();
            PasswordBox = new TextBox();
            UserDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).BeginInit();
            SuspendLayout();
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Location = new Point(57, 44);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(63, 15);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "Username:";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(57, 96);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(31, 15);
            AgeLabel.TabIndex = 1;
            AgeLabel.Text = "Age:";
            // 
            // SalaryLabel
            // 
            SalaryLabel.AutoSize = true;
            SalaryLabel.Location = new Point(57, 148);
            SalaryLabel.Name = "SalaryLabel";
            SalaryLabel.Size = new Size(41, 15);
            SalaryLabel.TabIndex = 2;
            SalaryLabel.Text = "Salary:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(57, 200);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(60, 15);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password:";
            // 
            // UserNameBox
            // 
            UserNameBox.Location = new Point(142, 40);
            UserNameBox.Name = "UserNameBox";
            UserNameBox.Size = new Size(100, 23);
            UserNameBox.TabIndex = 4;
            // 
            // AgeBox
            // 
            AgeBox.Location = new Point(142, 92);
            AgeBox.Name = "AgeBox";
            AgeBox.Size = new Size(100, 23);
            AgeBox.TabIndex = 5;
            // 
            // SalaryBox
            // 
            SalaryBox.Location = new Point(142, 144);
            SalaryBox.Name = "SalaryBox";
            SalaryBox.Size = new Size(100, 23);
            SalaryBox.TabIndex = 6;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(142, 196);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(100, 23);
            PasswordBox.TabIndex = 7;
            // 
            // UserDataGridView
            // 
            UserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserDataGridView.Location = new Point(293, 40);
            UserDataGridView.Name = "UserDataGridView";
            UserDataGridView.Size = new Size(495, 179);
            UserDataGridView.TabIndex = 8;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 270);
            Controls.Add(UserDataGridView);
            Controls.Add(PasswordBox);
            Controls.Add(SalaryBox);
            Controls.Add(AgeBox);
            Controls.Add(UserNameBox);
            Controls.Add(PasswordLabel);
            Controls.Add(SalaryLabel);
            Controls.Add(AgeLabel);
            Controls.Add(UserNameLabel);
            Name = "UserForm";
            Text = "User Input Form";
            ((System.ComponentModel.ISupportInitialize)UserDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLabel;
        private Label AgeLabel;
        private Label SalaryLabel;
        private Label PasswordLabel;
        private TextBox UserNameBox;
        private TextBox AgeBox;
        private TextBox SalaryBox;
        private TextBox PasswordBox;
        private DataGridView UserDataGridView;
    }
}
