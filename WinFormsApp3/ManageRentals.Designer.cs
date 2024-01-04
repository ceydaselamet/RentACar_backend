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
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentalDetailDtoBindingSource = new BindingSource(components);
            button4 = new Button();
            button_1 = new Button();
            label1 = new Label();
            carStatus = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rentalDetailDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { carIdDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, rentDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, carStatusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = rentalDetailDtoBindingSource;
            dataGridView1.Location = new Point(147, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(951, 354);
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
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(606, 506);
            button4.Name = "button4";
            button4.Size = new Size(102, 34);
            button4.TabIndex = 25;
            button4.Text = "Reddet";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button_1
            // 
            button_1.BackColor = SystemColors.ActiveCaption;
            button_1.Location = new Point(478, 506);
            button_1.Name = "button_1";
            button_1.Size = new Size(97, 34);
            button_1.TabIndex = 24;
            button_1.Text = "Onayla";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Extra Bold", 30F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(385, 45);
            label1.Name = "label1";
            label1.Size = new Size(409, 47);
            label1.TabIndex = 26;
            label1.Text = "Manage Rentals";
            // 
            // carStatus
            // 
            carStatus.FormattingEnabled = true;
            carStatus.Items.AddRange(new object[] { "Bekleniyor", "Onaylandı", "Reddedildi" });
            carStatus.Location = new Point(977, 95);
            carStatus.Name = "carStatus";
            carStatus.Size = new Size(121, 25);
            carStatus.TabIndex = 27;
            // 
            // ManageRentals
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 579);
            Controls.Add(carStatus);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button_1);
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
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carStatusDataGridViewTextBoxColumn;
        private Button button4;
        private Button button_1;
        private Label label1;
        private ComboBox carStatus;
    }
}