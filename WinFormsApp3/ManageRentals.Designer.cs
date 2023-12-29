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
            dataGridView1 = new DataGridView();
            carIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentalDetailDtoBindingSource = new BindingSource(components);
            carId = new TextBox();
            rentDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            returnDate = new DateTimePicker();
            carStatus = new ComboBox();
            label3 = new Label();
            brandName = new ComboBox();
            fullName = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button_1 = new Button();
            getRentalDetails = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentalDetailDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { carIdDataGridViewTextBoxColumn, brandNameDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, rentDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, carStatusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = rentalDetailDtoBindingSource;
            dataGridView1.Location = new Point(351, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(980, 384);
            dataGridView1.TabIndex = 0;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            carIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            carIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            brandNameDataGridViewTextBoxColumn.HeaderText = "BrandName";
            brandNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            brandNameDataGridViewTextBoxColumn.Width = 125;
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
            rentDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            returnDateDataGridViewTextBoxColumn.Width = 150;
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
            // carId
            // 
            carId.Location = new Point(22, 88);
            carId.Name = "carId";
            carId.Size = new Size(104, 27);
            carId.TabIndex = 1;
            // 
            // rentDate
            // 
            rentDate.Location = new Point(12, 293);
            rentDate.Name = "rentDate";
            rentDate.Size = new Size(250, 27);
            rentDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 249);
            label1.Name = "label1";
            label1.Size = new Size(240, 25);
            label1.TabIndex = 3;
            label1.Text = "Kiralama Başlangıç Tarihi : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 376);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 4;
            label2.Text = "Teslim Tarihi : ";
            // 
            // returnDate
            // 
            returnDate.Location = new Point(12, 420);
            returnDate.Name = "returnDate";
            returnDate.Size = new Size(250, 27);
            returnDate.TabIndex = 5;
            // 
            // carStatus
            // 
            carStatus.FormattingEnabled = true;
            carStatus.Location = new Point(12, 516);
            carStatus.Name = "carStatus";
            carStatus.Size = new Size(250, 28);
            carStatus.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 474);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 7;
            label3.Text = "Onay Durumu : ";
            // 
            // brandName
            // 
            brandName.FormattingEnabled = true;
            brandName.Location = new Point(22, 142);
            brandName.Name = "brandName";
            brandName.Size = new Size(240, 28);
            brandName.TabIndex = 8;
            // 
            // fullName
            // 
            fullName.Location = new Point(21, 203);
            fullName.Name = "fullName";
            fullName.Size = new Size(241, 27);
            fullName.TabIndex = 9;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(797, 510);
            button3.Name = "button3";
            button3.Size = new Size(111, 38);
            button3.TabIndex = 23;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(608, 508);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 22;
            button2.Text = "Düzenle";
            button2.UseVisualStyleBackColor = false;
            // 
            // button_1
            // 
            button_1.BackColor = SystemColors.ActiveCaption;
            button_1.Location = new Point(435, 510);
            button_1.Name = "button_1";
            button_1.Size = new Size(111, 40);
            button_1.TabIndex = 21;
            button_1.Text = "Ekle";
            button_1.UseVisualStyleBackColor = false;
            // 
            // getRentalDetails
            // 
            getRentalDetails.BackColor = SystemColors.ActiveCaption;
            getRentalDetails.Location = new Point(998, 504);
            getRentalDetails.Name = "getRentalDetails";
            getRentalDetails.Size = new Size(181, 50);
            getRentalDetails.TabIndex = 24;
            getRentalDetails.Text = "Kiralamaları Getir";
            getRentalDetails.UseVisualStyleBackColor = false;
            getRentalDetails.Click += getRentalDetails_Click;
            // 
            // ManageRentals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 598);
            Controls.Add(getRentalDetails);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button_1);
            Controls.Add(fullName);
            Controls.Add(brandName);
            Controls.Add(label3);
            Controls.Add(carStatus);
            Controls.Add(returnDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rentDate);
            Controls.Add(carId);
            Controls.Add(dataGridView1);
            Name = "ManageRentals";
            Text = "ManageRentals";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rentalDetailDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource rentalDetailDtoBindingSource;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carStatusDataGridViewTextBoxColumn;
        private TextBox carId;
        private DateTimePicker rentDate;
        private Label label1;
        private Label label2;
        private DateTimePicker returnDate;
        private ComboBox carStatus;
        private Label label3;
        private ComboBox brandName;
        private TextBox fullName;
        private Button button3;
        private Button button2;
        private Button button_1;
        private Button getRentalDetails;
    }
}