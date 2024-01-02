namespace WinFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCars));
            dataGridView1 = new DataGridView();
            carIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            brandNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            colorNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            modelNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fuelTypeNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            gearTypeNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            modelYearDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dailyPriceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            carImageDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ısSuitableDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            carDetailDtoBindingSource = new BindingSource(components);
            carIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fuelTypeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gearTypeNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelYearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dailyPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carImageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ısSuitableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            carId = new TextBox();
            brandName = new ComboBox();
            carModelName = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button_1 = new Button();
            dailyPrice = new TextBox();
            modelYear = new TextBox();
            gearTypeName = new ComboBox();
            carDetailDtoBindingSource1 = new BindingSource(components);
            fuelTypeName = new ComboBox();
            colorName = new ComboBox();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            carImage = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { carIdDataGridViewTextBoxColumn1, brandNameDataGridViewTextBoxColumn1, colorNameDataGridViewTextBoxColumn1, modelNameDataGridViewTextBoxColumn1, fuelTypeNameDataGridViewTextBoxColumn1, gearTypeNameDataGridViewTextBoxColumn1, modelYearDataGridViewTextBoxColumn1, dailyPriceDataGridViewTextBoxColumn1, carImageDataGridViewTextBoxColumn1, ısSuitableDataGridViewCheckBoxColumn1 });
            dataGridView1.DataSource = carDetailDtoBindingSource;
            dataGridView1.Location = new Point(468, 353);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(872, 265);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // carIdDataGridViewTextBoxColumn1
            // 
            carIdDataGridViewTextBoxColumn1.DataPropertyName = "CarId";
            carIdDataGridViewTextBoxColumn1.HeaderText = "CarId";
            carIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            carIdDataGridViewTextBoxColumn1.Name = "carIdDataGridViewTextBoxColumn1";
            carIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // brandNameDataGridViewTextBoxColumn1
            // 
            brandNameDataGridViewTextBoxColumn1.DataPropertyName = "BrandName";
            brandNameDataGridViewTextBoxColumn1.HeaderText = "BrandName";
            brandNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            brandNameDataGridViewTextBoxColumn1.Name = "brandNameDataGridViewTextBoxColumn1";
            brandNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // colorNameDataGridViewTextBoxColumn1
            // 
            colorNameDataGridViewTextBoxColumn1.DataPropertyName = "ColorName";
            colorNameDataGridViewTextBoxColumn1.HeaderText = "ColorName";
            colorNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            colorNameDataGridViewTextBoxColumn1.Name = "colorNameDataGridViewTextBoxColumn1";
            colorNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // modelNameDataGridViewTextBoxColumn1
            // 
            modelNameDataGridViewTextBoxColumn1.DataPropertyName = "ModelName";
            modelNameDataGridViewTextBoxColumn1.HeaderText = "ModelName";
            modelNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            modelNameDataGridViewTextBoxColumn1.Name = "modelNameDataGridViewTextBoxColumn1";
            modelNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // fuelTypeNameDataGridViewTextBoxColumn1
            // 
            fuelTypeNameDataGridViewTextBoxColumn1.DataPropertyName = "FuelTypeName";
            fuelTypeNameDataGridViewTextBoxColumn1.HeaderText = "FuelTypeName";
            fuelTypeNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            fuelTypeNameDataGridViewTextBoxColumn1.Name = "fuelTypeNameDataGridViewTextBoxColumn1";
            fuelTypeNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // gearTypeNameDataGridViewTextBoxColumn1
            // 
            gearTypeNameDataGridViewTextBoxColumn1.DataPropertyName = "GearTypeName";
            gearTypeNameDataGridViewTextBoxColumn1.HeaderText = "GearTypeName";
            gearTypeNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            gearTypeNameDataGridViewTextBoxColumn1.Name = "gearTypeNameDataGridViewTextBoxColumn1";
            gearTypeNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // modelYearDataGridViewTextBoxColumn1
            // 
            modelYearDataGridViewTextBoxColumn1.DataPropertyName = "ModelYear";
            modelYearDataGridViewTextBoxColumn1.HeaderText = "ModelYear";
            modelYearDataGridViewTextBoxColumn1.MinimumWidth = 6;
            modelYearDataGridViewTextBoxColumn1.Name = "modelYearDataGridViewTextBoxColumn1";
            modelYearDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dailyPriceDataGridViewTextBoxColumn1
            // 
            dailyPriceDataGridViewTextBoxColumn1.DataPropertyName = "DailyPrice";
            dailyPriceDataGridViewTextBoxColumn1.HeaderText = "DailyPrice";
            dailyPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dailyPriceDataGridViewTextBoxColumn1.Name = "dailyPriceDataGridViewTextBoxColumn1";
            dailyPriceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // carImageDataGridViewTextBoxColumn1
            // 
            carImageDataGridViewTextBoxColumn1.DataPropertyName = "CarImage";
            carImageDataGridViewTextBoxColumn1.HeaderText = "CarImage";
            carImageDataGridViewTextBoxColumn1.MinimumWidth = 6;
            carImageDataGridViewTextBoxColumn1.Name = "carImageDataGridViewTextBoxColumn1";
            carImageDataGridViewTextBoxColumn1.Visible = false;
            carImageDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ısSuitableDataGridViewCheckBoxColumn1
            // 
            ısSuitableDataGridViewCheckBoxColumn1.DataPropertyName = "IsSuitable";
            ısSuitableDataGridViewCheckBoxColumn1.HeaderText = "IsSuitable";
            ısSuitableDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            ısSuitableDataGridViewCheckBoxColumn1.Name = "ısSuitableDataGridViewCheckBoxColumn1";
            ısSuitableDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // carDetailDtoBindingSource
            // 
            carDetailDtoBindingSource.DataSource = typeof(Entities.DTOs.CarDetailDto);
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
            // colorNameDataGridViewTextBoxColumn
            // 
            colorNameDataGridViewTextBoxColumn.DataPropertyName = "ColorName";
            colorNameDataGridViewTextBoxColumn.HeaderText = "ColorName";
            colorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            colorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            modelNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            modelNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // fuelTypeNameDataGridViewTextBoxColumn
            // 
            fuelTypeNameDataGridViewTextBoxColumn.DataPropertyName = "FuelTypeName";
            fuelTypeNameDataGridViewTextBoxColumn.HeaderText = "FuelTypeName";
            fuelTypeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fuelTypeNameDataGridViewTextBoxColumn.Name = "fuelTypeNameDataGridViewTextBoxColumn";
            fuelTypeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // gearTypeNameDataGridViewTextBoxColumn
            // 
            gearTypeNameDataGridViewTextBoxColumn.DataPropertyName = "GearTypeName";
            gearTypeNameDataGridViewTextBoxColumn.HeaderText = "GearTypeName";
            gearTypeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            gearTypeNameDataGridViewTextBoxColumn.Name = "gearTypeNameDataGridViewTextBoxColumn";
            gearTypeNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelYearDataGridViewTextBoxColumn
            // 
            modelYearDataGridViewTextBoxColumn.DataPropertyName = "ModelYear";
            modelYearDataGridViewTextBoxColumn.HeaderText = "ModelYear";
            modelYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            modelYearDataGridViewTextBoxColumn.Name = "modelYearDataGridViewTextBoxColumn";
            modelYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // dailyPriceDataGridViewTextBoxColumn
            // 
            dailyPriceDataGridViewTextBoxColumn.DataPropertyName = "DailyPrice";
            dailyPriceDataGridViewTextBoxColumn.HeaderText = "DailyPrice";
            dailyPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            dailyPriceDataGridViewTextBoxColumn.Name = "dailyPriceDataGridViewTextBoxColumn";
            dailyPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // carImageDataGridViewTextBoxColumn
            // 
            carImageDataGridViewTextBoxColumn.DataPropertyName = "CarImage";
            carImageDataGridViewTextBoxColumn.HeaderText = "CarImage";
            carImageDataGridViewTextBoxColumn.MinimumWidth = 6;
            carImageDataGridViewTextBoxColumn.Name = "carImageDataGridViewTextBoxColumn";
            carImageDataGridViewTextBoxColumn.Width = 125;
            // 
            // ısSuitableDataGridViewCheckBoxColumn
            // 
            ısSuitableDataGridViewCheckBoxColumn.DataPropertyName = "IsSuitable";
            ısSuitableDataGridViewCheckBoxColumn.HeaderText = "IsSuitable";
            ısSuitableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            ısSuitableDataGridViewCheckBoxColumn.Name = "ısSuitableDataGridViewCheckBoxColumn";
            ısSuitableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // carId
            // 
            carId.Enabled = false;
            carId.Location = new Point(17, 153);
            carId.Name = "carId";
            carId.Size = new Size(134, 25);
            carId.TabIndex = 1;
            carId.Text = "Araç Id";
            carId.Click += addButtonActive;
            // 
            // brandName
            // 
            brandName.FormattingEnabled = true;
            brandName.Location = new Point(17, 192);
            brandName.Name = "brandName";
            brandName.Size = new Size(133, 25);
            brandName.TabIndex = 2;
            brandName.Click += addButtonActive;
            // 
            // carModelName
            // 
            carModelName.FormattingEnabled = true;
            carModelName.Location = new Point(17, 238);
            carModelName.Name = "carModelName";
            carModelName.Size = new Size(133, 25);
            carModelName.TabIndex = 3;
            carModelName.Click += addButtonActive;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.HotTrack;
            button3.Enabled = false;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(69, 562);
            button3.Name = "button3";
            button3.Size = new Size(97, 32);
            button3.TabIndex = 20;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Enabled = false;
            button2.Location = new Point(134, 501);
            button2.Name = "button2";
            button2.Size = new Size(102, 34);
            button2.TabIndex = 19;
            button2.Text = "Düzenle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_ClickAsync;
            // 
            // button_1
            // 
            button_1.BackColor = SystemColors.ActiveCaption;
            button_1.Location = new Point(17, 501);
            button_1.Name = "button_1";
            button_1.Size = new Size(97, 34);
            button_1.TabIndex = 18;
            button_1.Text = "Ekle";
            button_1.UseVisualStyleBackColor = false;
            button_1.Click += button_1_ClickAsync;
            // 
            // dailyPrice
            // 
            dailyPrice.Location = new Point(18, 449);
            dailyPrice.Name = "dailyPrice";
            dailyPrice.PlaceholderText = "Günlük Fiyatı";
            dailyPrice.Size = new Size(133, 25);
            dailyPrice.TabIndex = 17;
            dailyPrice.Click += addButtonActive;
            // 
            // modelYear
            // 
            modelYear.Location = new Point(17, 408);
            modelYear.Name = "modelYear";
            modelYear.PlaceholderText = "Model Yılı";
            modelYear.Size = new Size(132, 25);
            modelYear.TabIndex = 16;
            modelYear.Click += addButtonActive;
            // 
            // gearTypeName
            // 
            gearTypeName.DataSource = carDetailDtoBindingSource1;
            gearTypeName.FormattingEnabled = true;
            gearTypeName.Location = new Point(17, 359);
            gearTypeName.Name = "gearTypeName";
            gearTypeName.Size = new Size(133, 25);
            gearTypeName.TabIndex = 15;
            gearTypeName.Click += addButtonActive;
            // 
            // carDetailDtoBindingSource1
            // 
            carDetailDtoBindingSource1.DataSource = typeof(Entities.DTOs.CarDetailDto);
            // 
            // fuelTypeName
            // 
            fuelTypeName.DataSource = carDetailDtoBindingSource;
            fuelTypeName.FormattingEnabled = true;
            fuelTypeName.Location = new Point(16, 317);
            fuelTypeName.Name = "fuelTypeName";
            fuelTypeName.Size = new Size(133, 25);
            fuelTypeName.TabIndex = 14;
            fuelTypeName.Click += addButtonActive;
            // 
            // colorName
            // 
            colorName.DataSource = carDetailDtoBindingSource;
            colorName.FormattingEnabled = true;
            colorName.Location = new Point(16, 278);
            colorName.Name = "colorName";
            colorName.Size = new Size(133, 25);
            colorName.TabIndex = 13;
            colorName.Click += addButtonActive;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(190, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // carImage
            // 
            carImage.BackColor = SystemColors.ActiveCaption;
            carImage.Location = new Point(302, 353);
            carImage.Name = "carImage";
            carImage.Size = new Size(97, 34);
            carImage.TabIndex = 23;
            carImage.Text = "Resim Seç";
            carImage.UseVisualStyleBackColor = false;
            carImage.Click += selectCarImageButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1361, 100);
            panel1.TabIndex = 24;
            // 
            // ManageCars
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 641);
            Controls.Add(panel1);
            Controls.Add(carImage);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button_1);
            Controls.Add(dailyPrice);
            Controls.Add(modelYear);
            Controls.Add(gearTypeName);
            Controls.Add(fuelTypeName);
            Controls.Add(colorName);
            Controls.Add(carModelName);
            Controls.Add(brandName);
            Controls.Add(carId);
            Controls.Add(dataGridView1);
            Name = "ManageCars";
            Text = "ManageCars";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fuelTypeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gearTypeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dailyPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carImageDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn ısSuitableDataGridViewCheckBoxColumn;
        private BindingSource carDetailDtoBindingSource;
        private TextBox carId;
        private ComboBox brandName;
        private ComboBox carModelName;
        private Button button3;
        private Button button2;
        private Button button_1;
        private TextBox dailyPrice;
        private TextBox modelYear;
        private ComboBox gearTypeName;
        private ComboBox fuelTypeName;
        private ComboBox colorName;
        private BindingSource carDetailDtoBindingSource1;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button carImage;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fuelTypeNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn gearTypeNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn modelYearDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dailyPriceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn carImageDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn ısSuitableDataGridViewCheckBoxColumn1;
        private Panel panel1;
    }
}