namespace WinFormsApp1
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
            dataGridView1 = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { carIdDataGridViewTextBoxColumn, brandNameDataGridViewTextBoxColumn, colorNameDataGridViewTextBoxColumn, modelNameDataGridViewTextBoxColumn, fuelTypeNameDataGridViewTextBoxColumn, gearTypeNameDataGridViewTextBoxColumn, modelYearDataGridViewTextBoxColumn, dailyPriceDataGridViewTextBoxColumn, carImageDataGridViewTextBoxColumn });
            dataGridView1.DataSource = carDetailDtoBindingSource;
            dataGridView1.Location = new Point(560, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(747, 460);
            dataGridView1.TabIndex = 0;
            //dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            // ManageCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 727);
            Controls.Add(dataGridView1);
            Name = "ManageCars";
            Text = "ManageCars";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carDetailDtoBindingSource).EndInit();
            ResumeLayout(false);
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
        private BindingSource carDetailDtoBindingSource;
    }
}