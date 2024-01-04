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
            RentalId = new DataGridViewTextBoxColumn();
            carIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentalDetailDtoBindingSource = new BindingSource(components);
            btnReject_Click = new Button();
            btnApprove_Click = new Button();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RentalId, carIdDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, rentDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn, carStatusDataGridViewTextBoxColumn });
            dataGridView1.DataSource = rentalDetailDtoBindingSource;
            dataGridView1.Location = new Point(168, 148);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1087, 416);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // RentalId
            // 
            RentalId.DataPropertyName = "RentalId";
            RentalId.HeaderText = "RentalId";
            RentalId.MinimumWidth = 6;
            RentalId.Name = "RentalId";
            RentalId.Width = 125;
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
            // btnReject_Click
            // 
            btnReject_Click.BackColor = SystemColors.ActiveCaption;
            btnReject_Click.Location = new Point(693, 595);
            btnReject_Click.Margin = new Padding(3, 4, 3, 4);
            btnReject_Click.Name = "btnReject_Click";
            btnReject_Click.Size = new Size(117, 40);
            btnReject_Click.TabIndex = 25;
            btnReject_Click.Text = "Reddet";
            btnReject_Click.UseVisualStyleBackColor = false;
            btnReject_Click.Click += button4_Click;
            // 
            // btnApprove_Click
            // 
            btnApprove_Click.BackColor = SystemColors.ActiveCaption;
            btnApprove_Click.Location = new Point(546, 595);
            btnApprove_Click.Margin = new Padding(3, 4, 3, 4);
            btnApprove_Click.Name = "btnApprove_Click";
            btnApprove_Click.Size = new Size(111, 40);
            btnApprove_Click.TabIndex = 24;
            btnApprove_Click.Text = "Onayla";
            btnApprove_Click.UseVisualStyleBackColor = false;
            btnApprove_Click.Click += button_1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Extra Bold", 30F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(440, 53);
            label1.Name = "label1";
            label1.Size = new Size(514, 58);
            label1.TabIndex = 26;
            label1.Text = "Manage Rentals";
            // 
            // carStatus
            // 
            carStatus.FormattingEnabled = true;
            carStatus.Items.AddRange(new object[] { "Bekleniyor", "Onaylandı", "Reddedildi" });
            carStatus.Location = new Point(1117, 112);
            carStatus.Margin = new Padding(3, 4, 3, 4);
            carStatus.Name = "carStatus";
            carStatus.Size = new Size(138, 28);
            carStatus.TabIndex = 27;
            // 
            // ManageRentals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 681);
            Controls.Add(carStatus);
            Controls.Add(label1);
            Controls.Add(btnReject_Click);
            Controls.Add(btnApprove_Click);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnReject_Click;
        private Button btnApprove_Click;
        private Label label1;
        private ComboBox carStatus;
        private DataGridViewTextBoxColumn RentalId;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carStatusDataGridViewTextBoxColumn;
    }
}