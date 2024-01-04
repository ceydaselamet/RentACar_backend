namespace WinFormsApp3
{
    partial class ManageUsers
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            searchTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            userId = new TextBox();
            firstName = new TextBox();
            lastName = new TextBox();
            email = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button_1 = new Button();
            password = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(500, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(656, 295);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 350;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Visible = false;
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Entities.Concrete.User);
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(711, 61);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(157, 30);
            searchTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(972, 57);
            button1.Name = "button1";
            button1.Size = new Size(135, 48);
            button1.TabIndex = 2;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(271, 31);
            button2.Name = "button2";
            button2.Size = new Size(274, 83);
            button2.TabIndex = 3;
            button2.Text = "Tüm Kullanıcıları Listele";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(579, 71);
            label1.Name = "label1";
            label1.Size = new Size(105, 19);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Ara : ";
            // 
            // userId
            // 
            userId.Enabled = false;
            userId.Location = new Point(152, 165);
            userId.Name = "userId";
            userId.Size = new Size(110, 25);
            userId.TabIndex = 5;
            // 
            // firstName
            // 
            firstName.Location = new Point(152, 213);
            firstName.Name = "firstName";
            firstName.Size = new Size(110, 25);
            firstName.TabIndex = 6;
            // 
            // lastName
            // 
            lastName.Location = new Point(152, 270);
            lastName.Name = "lastName";
            lastName.Size = new Size(110, 25);
            lastName.TabIndex = 7;
            // 
            // email
            // 
            email.Location = new Point(152, 320);
            email.Name = "email";
            email.Size = new Size(110, 25);
            email.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 168);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 9;
            label2.Text = "Kullanıcı ID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 219);
            label3.Name = "label3";
            label3.Size = new Size(40, 19);
            label3.TabIndex = 10;
            label3.Text = "Ad : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 273);
            label4.Name = "label4";
            label4.Size = new Size(63, 19);
            label4.TabIndex = 11;
            label4.Text = "Soyad : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 326);
            label5.Name = "label5";
            label5.Size = new Size(57, 19);
            label5.TabIndex = 12;
            label5.Text = "Email : ";
            // 
            // button_1
            // 
            button_1.BackColor = SystemColors.ActiveCaption;
            button_1.Location = new Point(98, 426);
            button_1.Name = "button_1";
            button_1.Size = new Size(97, 34);
            button_1.TabIndex = 21;
            button_1.Text = "Ekle";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_1_Click;
            // 
            // password
            // 
            password.Location = new Point(152, 366);
            password.Name = "password";
            password.Size = new Size(110, 25);
            password.TabIndex = 24;
            password.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 371);
            label6.Name = "label6";
            label6.Size = new Size(52, 19);
            label6.TabIndex = 25;
            label6.Text = "Şifre : ";
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 503);
            Controls.Add(label6);
            Controls.Add(password);
            Controls.Add(button_1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(email);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(userId);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(searchTextBox);
            Controls.Add(dataGridView1);
            Name = "ManageUsers";
            Text = "ManageUsers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private TextBox searchTextBox;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox userId;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox email;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_1;
        private TextBox password;
        private Label label6;
    }
}