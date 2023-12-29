namespace WinFormsApp2
{
    partial class ManageCars
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            CarStatus = new DataGridViewTextBoxColumn();
            carDetailDtoBindingSource = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            carId = new TextBox();
            brandName = new ComboBox();
            modelName = new ComboBox();
            colorName = new ComboBox();
            fuelTypeName = new ComboBox();
            gearTypeName = new ComboBox();
            modelYear = new TextBox();
            dailyPrice = new TextBox();
            button_1 = new Button();
            button2 = new Button();
            button3 = new Button();
            carDetailDtoBindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 127);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(529, 35);
            label1.Name = "label1";
            label1.Size = new Size(348, 45);
            label1.TabIndex = 0;
            label1.Text = "Araç Yönetim Paneli";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, CarStatus });
            dataGridView1.DataSource = carDetailDtoBindingSource;
            dataGridView1.Location = new Point(282, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1164, 497);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "CarId";
            dataGridViewTextBoxColumn10.HeaderText = "CarId";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "BrandName";
            dataGridViewTextBoxColumn11.HeaderText = "BrandName";
            dataGridViewTextBoxColumn11.MinimumWidth = 6;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "ColorName";
            dataGridViewTextBoxColumn12.HeaderText = "ColorName";
            dataGridViewTextBoxColumn12.MinimumWidth = 6;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "ModelName";
            dataGridViewTextBoxColumn13.HeaderText = "ModelName";
            dataGridViewTextBoxColumn13.MinimumWidth = 6;
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "FuelTypeName";
            dataGridViewTextBoxColumn14.HeaderText = "FuelTypeName";
            dataGridViewTextBoxColumn14.MinimumWidth = 6;
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "GearTypeName";
            dataGridViewTextBoxColumn15.HeaderText = "GearTypeName";
            dataGridViewTextBoxColumn15.MinimumWidth = 6;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "ModelYear";
            dataGridViewTextBoxColumn16.HeaderText = "ModelYear";
            dataGridViewTextBoxColumn16.MinimumWidth = 6;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "DailyPrice";
            dataGridViewTextBoxColumn17.HeaderText = "DailyPrice";
            dataGridViewTextBoxColumn17.MinimumWidth = 6;
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.DataPropertyName = "CarImage";
            dataGridViewTextBoxColumn18.HeaderText = "CarImage";
            dataGridViewTextBoxColumn18.MinimumWidth = 6;
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.Width = 125;
            // 
            // CarStatus
            // 
            CarStatus.DataPropertyName = "CarStatus";
            CarStatus.HeaderText = "CarStatus";
            CarStatus.MinimumWidth = 6;
            CarStatus.Name = "CarStatus";
            CarStatus.Width = 125;
            // 
            // carDetailDtoBindingSource
            // 
            carDetailDtoBindingSource.DataSource = typeof(Entities.DTOs.CarDetailDto);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "CarId";
            dataGridViewTextBoxColumn1.HeaderText = "CarId";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "BrandName";
            dataGridViewTextBoxColumn2.HeaderText = "BrandName";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "ColorName";
            dataGridViewTextBoxColumn3.HeaderText = "ColorName";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "ModelName";
            dataGridViewTextBoxColumn4.HeaderText = "ModelName";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "FuelTypeName";
            dataGridViewTextBoxColumn5.HeaderText = "FuelTypeName";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "GearTypeName";
            dataGridViewTextBoxColumn6.HeaderText = "GearTypeName";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "ModelYear";
            dataGridViewTextBoxColumn7.HeaderText = "ModelYear";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "DailyPrice";
            dataGridViewTextBoxColumn8.HeaderText = "DailyPrice";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "CarImage";
            dataGridViewTextBoxColumn9.HeaderText = "CarImage";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.Width = 125;
            // 
            // carId
            // 
            carId.Location = new Point(13, 190);
            carId.Name = "carId";
            carId.Size = new Size(150, 27);
            carId.TabIndex = 2;
            carId.Text = "Araç Id";
            // 
            // brandName
            // 
            brandName.DataSource = carDetailDtoBindingSource1;
            brandName.DisplayMember = "BrandName";
            brandName.FormattingEnabled = true;
            brandName.Location = new Point(12, 238);
            brandName.Name = "brandName";
            brandName.Size = new Size(151, 28);
            brandName.TabIndex = 3;
            brandName.SelectedIndexChanged += brandName_GetBrands;
            // 
            // modelName
            // 
            modelName.DataSource = carDetailDtoBindingSource;
            modelName.FormattingEnabled = true;
            modelName.Location = new Point(12, 289);
            modelName.Name = "modelName";
            modelName.Size = new Size(151, 28);
            modelName.TabIndex = 4;
            modelName.SelectedIndexChanged += modelName_SelectedIndexChanged;
            // 
            // colorName
            // 
            colorName.DataSource = carDetailDtoBindingSource;
            colorName.FormattingEnabled = true;
            colorName.Location = new Point(12, 335);
            colorName.Name = "colorName";
            colorName.Size = new Size(151, 28);
            colorName.TabIndex = 5;
            colorName.SelectedIndexChanged += colorName_SelectedIndexChanged;
            // 
            // fuelTypeName
            // 
            fuelTypeName.DataSource = carDetailDtoBindingSource;
            fuelTypeName.FormattingEnabled = true;
            fuelTypeName.Location = new Point(12, 381);
            fuelTypeName.Name = "fuelTypeName";
            fuelTypeName.Size = new Size(151, 28);
            fuelTypeName.TabIndex = 6;
            fuelTypeName.SelectedIndexChanged += fuelTypeName_SelectedIndexChanged;
            // 
            // gearTypeName
            // 
            gearTypeName.DataSource = carDetailDtoBindingSource;
            gearTypeName.FormattingEnabled = true;
            gearTypeName.Location = new Point(13, 430);
            gearTypeName.Name = "gearTypeName";
            gearTypeName.Size = new Size(151, 28);
            gearTypeName.TabIndex = 7;
            gearTypeName.SelectedIndexChanged += gearTypeName_SelectedIndexChanged;
            // 
            // modelYear
            // 
            modelYear.Location = new Point(13, 487);
            modelYear.Name = "modelYear";
            modelYear.Size = new Size(150, 27);
            modelYear.TabIndex = 8;
            modelYear.Text = "Model Yılı";
            // 
            // dailyPrice
            // 
            dailyPrice.Location = new Point(12, 536);
            dailyPrice.Name = "dailyPrice";
            dailyPrice.Size = new Size(151, 27);
            dailyPrice.TabIndex = 9;
            dailyPrice.Text = "Günlük Fiyatı";
            // 
            // button_1
            // 
            button_1.BackColor = SystemColors.ActiveCaption;
            button_1.Location = new Point(12, 596);
            button_1.Name = "button_1";
            button_1.Size = new Size(111, 40);
            button_1.TabIndex = 10;
            button_1.Text = "Ekle";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button1_ClickAsync;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(146, 596);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 11;
            button2.Text = "Düzenle";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(71, 667);
            button3.Name = "button3";
            button3.Size = new Size(111, 38);
            button3.TabIndex = 12;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            // 
            // carDetailDtoBindingSource1
            // 
            carDetailDtoBindingSource1.DataSource = typeof(Entities.DTOs.CarDetailDto);
            // 
            // ManageCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 739);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button_1);
            Controls.Add(dailyPrice);
            Controls.Add(modelYear);
            Controls.Add(gearTypeName);
            Controls.Add(fuelTypeName);
            Controls.Add(colorName);
            Controls.Add(modelName);
            Controls.Add(brandName);
            Controls.Add(carId);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "ManageCars";
            Text = "ManageCars";
            Load += ManageCars_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fuelTypeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gearTypeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dailyPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carImageDataGridViewTextBoxColumn;
        private TextBox carId;
        private ComboBox brandName;
        private BindingSource carDetailDtoBindingSource;
        private ComboBox modelName;
        private ComboBox colorName;
        private ComboBox fuelTypeName;
        private ComboBox gearTypeName;
        private TextBox modelYear;
        private TextBox dailyPrice;
        private Button button_1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn CarStatus;
        private BindingSource carDetailDtoBindingSource1;
    }
}