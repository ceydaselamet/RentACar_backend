namespace WinFormsApp3
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            ManageCarsButton = new Button();
            ManageRentalsButton = new Button();
            ManageUsersButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ManageCarsButton
            // 
            ManageCarsButton.Location = new Point(115, 204);
            ManageCarsButton.Name = "ManageCarsButton";
            ManageCarsButton.Size = new Size(144, 122);
            ManageCarsButton.TabIndex = 0;
            ManageCarsButton.Text = "Manage Cars";
            ManageCarsButton.UseVisualStyleBackColor = true;
            ManageCarsButton.Click += ManageCarsButton_Click;
            // 
            // ManageRentalsButton
            // 
            ManageRentalsButton.Location = new Point(328, 204);
            ManageRentalsButton.Name = "ManageRentalsButton";
            ManageRentalsButton.Size = new Size(144, 122);
            ManageRentalsButton.TabIndex = 2;
            ManageRentalsButton.Text = "Manage Rentals";
            ManageRentalsButton.UseVisualStyleBackColor = true;
            ManageRentalsButton.Click += ManageRentalsButton_Click;
            // 
            // ManageUsersButton
            // 
            ManageUsersButton.Location = new Point(528, 204);
            ManageUsersButton.Name = "ManageUsersButton";
            ManageUsersButton.Size = new Size(144, 122);
            ManageUsersButton.TabIndex = 3;
            ManageUsersButton.Text = "Manage Users";
            ManageUsersButton.UseVisualStyleBackColor = true;
            ManageUsersButton.Click += ManageUsersButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Extra Bold", 30F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(251, 95);
            label1.Name = "label1";
            label1.Size = new Size(294, 47);
            label1.TabIndex = 4;
            label1.Text = "RENT A CAR";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ManageUsersButton);
            Controls.Add(ManageRentalsButton);
            Controls.Add(ManageCarsButton);
            Name = "MainScreen";
            Text = "RentACar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ManageCarsButton;
        private Button ManageRentalsButton;
        private Button ManageUsersButton;
        private Label label1;
    }
}