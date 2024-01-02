namespace WinFormsApp3
{
    partial class ManageRentals
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
            fullName = new TextBox();
            label3 = new Label();
            carStatus = new ComboBox();
            returnDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            rentDate = new DateTimePicker();
            carId = new TextBox();
            dataGridView1 = new DataGridView();
            carIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentalDetailDtoBindingSource = new BindingSource(components);
            button3 = new Button();
            button4 = new Button();
            button_1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentalDetailDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // fullName
            // 
            fullName.Location = new Point(44, 191);
            fullName.Name = "fullName";
            fullName.Size = new Size(241, 27);
            fullName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(35, 480);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 16;
            label3.Text = "Onay Durumu : ";
            // 
            // carStatus
            // 
            carStatus.FormattingEnabled = true;
            carStatus.Location = new Point(35, 533);
            carStatus.Name = "carStatus";
            carStatus.Size = new Size(250, 28);
            carStatus.TabIndex = 15;
            // 
            // returnDate
            // 
            returnDate.Location = new Point(35, 426);
            returnDate.Name = "returnDate";
            returnDate.Size = new Size(250, 27);
            returnDate.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 373);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 13;
            label2.Text = "Teslim Tarihi : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 254);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 12;
            label1.Text = "Kiralama Başlangıç Tarihi : ";
            // 
            // rentDate
            // 
            rentDate.Location = new Point(35, 304);
            rentDate.Name = "rentDate";
            rentDate.Size = new Size(250, 27);
            rentDate.TabIndex = 11;
            // 
            // carId
            // 
            carId.Location = new Point(44, 131);
            carId.Name = "carId";
            carId.Size = new Size(104, 27);
            carId.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { carIdDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, rentDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, carStatusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = rentalDetailDtoBindingSource;
            dataGridView1.Location = new Point(409, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(930, 416);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            carIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            carIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            rentDateDataGridViewTextBoxColumn.HeaderText = "RentDate";
            rentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            rentDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            returnDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // carStatusDataGridViewTextBoxColumn
            // 
            carStatusDataGridViewTextBoxColumn.DataPropertyName = "CarStatus";
            carStatusDataGridViewTextBoxColumn.HeaderText = "CarStatus";
            carStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            carStatusDataGridViewTextBoxColumn.Name = "carStatusDataGridViewTextBoxColumn";
            carStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentalDetailDtoBindingSource
            // 
            rentalDetailDtoBindingSource.DataSource = typeof(Entities.DTOs.RentalDetailDto);
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(104, 640);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(111, 38);
            button3.TabIndex = 26;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(179, 568);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(117, 40);
            button4.TabIndex = 25;
            button4.Text = "Düzenle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button_1
            // 
            button_1.BackColor = SystemColors.ActiveCaption;
            button_1.Location = new Point(45, 568);
            button_1.Margin = new Padding(3, 4, 3, 4);
            button_1.Name = "button_1";
            button_1.Size = new Size(111, 40);
            button_1.TabIndex = 24;
            button_1.Text = "Ekle";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_1_Click;
            // 
            // ManageRentals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 681);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button_1);
            Controls.Add(dataGridView1);
            Controls.Add(fullName);
            Controls.Add(label3);
            Controls.Add(carStatus);
            Controls.Add(returnDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rentDate);
            Controls.Add(carId);
            Name = "ManageRentals";
            Text = "ManageRentals";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentalDetailDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fullName;
        private Label label3;
        private ComboBox carStatus;
        private DateTimePicker returnDate;
        private Label label2;
        private Label label1;
        private DateTimePicker rentDate;
        private TextBox carId;
        private DataGridView dataGridView1;
        private BindingSource rentalDetailDtoBindingSource;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carStatusDataGridViewTextBoxColumn;
        private Button button3;
        private Button button4;
        private Button button_1;
    }
}