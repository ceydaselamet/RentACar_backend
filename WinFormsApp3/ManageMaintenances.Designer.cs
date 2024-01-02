namespace WinFormsApp3
{
    partial class ManageMaintenances
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
            maintenanceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maintenanceTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maintenanceDetailDtoBindingSource = new BindingSource(components);
            maintenanceId = new TextBox();
            carId = new TextBox();
            maintenanceType = new ComboBox();
            date = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button3 = new Button();
            button2 = new Button();
            button_1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maintenanceDetailDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maintenanceIdDataGridViewTextBoxColumn, carIdDataGridViewTextBoxColumn, maintenanceTypeDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = maintenanceDetailDtoBindingSource;
            dataGridView1.Location = new Point(619, 171);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(746, 325);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // maintenanceIdDataGridViewTextBoxColumn
            // 
            maintenanceIdDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceId";
            maintenanceIdDataGridViewTextBoxColumn.HeaderText = "MaintenanceId";
            maintenanceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            maintenanceIdDataGridViewTextBoxColumn.Name = "maintenanceIdDataGridViewTextBoxColumn";
            maintenanceIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            carIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            carIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // maintenanceTypeDataGridViewTextBoxColumn
            // 
            maintenanceTypeDataGridViewTextBoxColumn.DataPropertyName = "MaintenanceType";
            maintenanceTypeDataGridViewTextBoxColumn.HeaderText = "MaintenanceType";
            maintenanceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            maintenanceTypeDataGridViewTextBoxColumn.Name = "maintenanceTypeDataGridViewTextBoxColumn";
            maintenanceTypeDataGridViewTextBoxColumn.Width = 250;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // maintenanceDetailDtoBindingSource
            // 
            maintenanceDetailDtoBindingSource.DataSource = typeof(Entities.DTOs.MaintenanceDetailDto);
            // 
            // maintenanceId
            // 
            maintenanceId.Location = new Point(172, 142);
            maintenanceId.Name = "maintenanceId";
            maintenanceId.Size = new Size(163, 27);
            maintenanceId.TabIndex = 1;
            maintenanceId.Text = "Bakım Id";
            // 
            // carId
            // 
            carId.Location = new Point(172, 200);
            carId.Name = "carId";
            carId.Size = new Size(163, 27);
            carId.TabIndex = 2;
            carId.Text = "Araç Id";
            // 
            // maintenanceType
            // 
            maintenanceType.FormattingEnabled = true;
            maintenanceType.Location = new Point(172, 255);
            maintenanceType.Name = "maintenanceType";
            maintenanceType.Size = new Size(163, 28);
            maintenanceType.TabIndex = 3;
            // 
            // date
            // 
            date.Location = new Point(172, 348);
            date.Name = "date";
            date.Size = new Size(264, 27);
            date.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 146);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 5;
            label1.Text = "ID : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 204);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 6;
            label2.Text = "Araç ID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 260);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 7;
            label3.Text = "Bakım Türü : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 348);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 8;
            label4.Text = "Bakım Zamanı : ";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Enabled = false;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(102, 528);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(111, 38);
            button3.TabIndex = 23;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Enabled = false;
            button2.Location = new Point(176, 456);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(117, 40);
            button2.TabIndex = 22;
            button2.Text = "Düzenle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button_1
            // 
            button_1.BackColor = SystemColors.ActiveCaption;
            button_1.Location = new Point(42, 456);
            button_1.Margin = new Padding(3, 4, 3, 4);
            button_1.Name = "button_1";
            button_1.Size = new Size(111, 40);
            button_1.TabIndex = 21;
            button_1.Text = "Ekle";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_1_Click;
            // 
            // ManageMaintenances
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 726);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button_1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(date);
            Controls.Add(maintenanceType);
            Controls.Add(carId);
            Controls.Add(maintenanceId);
            Controls.Add(dataGridView1);
            Name = "ManageMaintenances";
            Text = "ManageMaintenances";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)maintenanceDetailDtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn maintenanceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maintenanceTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private BindingSource maintenanceDetailDtoBindingSource;
        private TextBox maintenanceId;
        private TextBox carId;
        private ComboBox maintenanceType;
        private DateTimePicker date;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button_1;
    }
}