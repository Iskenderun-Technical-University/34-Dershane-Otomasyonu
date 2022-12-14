namespace GirisPaneli
{
    partial class ogrencibilgiformu
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciKayitDataSet = new GirisPaneli.OgrenciKayitDataSet();
            this.ogrKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogr_KayitTableAdapter = new GirisPaneli.OgrenciKayitDataSetTableAdapters.Ogr_KayitTableAdapter();
            this.ogrenciKayitDataSet1 = new GirisPaneli.OgrenciKayitDataSet1();
            this.ogrKayitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogr_KayitTableAdapter1 = new GirisPaneli.OgrenciKayitDataSet1TableAdapters.Ogr_KayitTableAdapter();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSinifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrCinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veliYakinlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayitDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrKayitBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrNoDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrSinifDataGridViewTextBoxColumn,
            this.ogrDalDataGridViewTextBoxColumn,
            this.ogrCinsiyetDataGridViewTextBoxColumn,
            this.ogrAdresDataGridViewTextBoxColumn,
            this.ıdDataGridViewTextBoxColumn,
            this.veliAdDataGridViewTextBoxColumn,
            this.veliTelDataGridViewTextBoxColumn,
            this.veliYakinlikDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrKayitBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1931, 1230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciKayitDataSet
            // 
            this.ogrenciKayitDataSet.DataSetName = "OgrenciKayitDataSet";
            this.ogrenciKayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrKayitBindingSource
            // 
            this.ogrKayitBindingSource.DataMember = "Ogr_Kayit";
            this.ogrKayitBindingSource.DataSource = this.ogrenciKayitDataSet;
            // 
            // ogr_KayitTableAdapter
            // 
            this.ogr_KayitTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciKayitDataSet1
            // 
            this.ogrenciKayitDataSet1.DataSetName = "OgrenciKayitDataSet1";
            this.ogrenciKayitDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrKayitBindingSource1
            // 
            this.ogrKayitBindingSource1.DataMember = "Ogr_Kayit";
            this.ogrKayitBindingSource1.DataSource = this.ogrenciKayitDataSet1;
            // 
            // ogr_KayitTableAdapter1
            // 
            this.ogr_KayitTableAdapter1.ClearBeforeFill = true;
            // 
            // ogrNoDataGridViewTextBoxColumn
            // 
            this.ogrNoDataGridViewTextBoxColumn.DataPropertyName = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.HeaderText = "No";
            this.ogrNoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrNoDataGridViewTextBoxColumn.Name = "ogrNoDataGridViewTextBoxColumn";
            this.ogrNoDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrSinifDataGridViewTextBoxColumn
            // 
            this.ogrSinifDataGridViewTextBoxColumn.DataPropertyName = "OgrSinif";
            this.ogrSinifDataGridViewTextBoxColumn.HeaderText = "Sinif";
            this.ogrSinifDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrSinifDataGridViewTextBoxColumn.Name = "ogrSinifDataGridViewTextBoxColumn";
            this.ogrSinifDataGridViewTextBoxColumn.Width = 80;
            // 
            // ogrDalDataGridViewTextBoxColumn
            // 
            this.ogrDalDataGridViewTextBoxColumn.DataPropertyName = "OgrDal";
            this.ogrDalDataGridViewTextBoxColumn.HeaderText = "Dal";
            this.ogrDalDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrDalDataGridViewTextBoxColumn.Name = "ogrDalDataGridViewTextBoxColumn";
            this.ogrDalDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrCinsiyetDataGridViewTextBoxColumn
            // 
            this.ogrCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "OgrCinsiyet";
            this.ogrCinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.ogrCinsiyetDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrCinsiyetDataGridViewTextBoxColumn.Name = "ogrCinsiyetDataGridViewTextBoxColumn";
            // 
            // ogrAdresDataGridViewTextBoxColumn
            // 
            this.ogrAdresDataGridViewTextBoxColumn.DataPropertyName = "OgrAdres";
            this.ogrAdresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.ogrAdresDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrAdresDataGridViewTextBoxColumn.Name = "ogrAdresDataGridViewTextBoxColumn";
            this.ogrAdresDataGridViewTextBoxColumn.Width = 200;
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıdDataGridViewTextBoxColumn.Width = 50;
            // 
            // veliAdDataGridViewTextBoxColumn
            // 
            this.veliAdDataGridViewTextBoxColumn.DataPropertyName = "VeliAd";
            this.veliAdDataGridViewTextBoxColumn.HeaderText = "VeliAd";
            this.veliAdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.veliAdDataGridViewTextBoxColumn.Name = "veliAdDataGridViewTextBoxColumn";
            this.veliAdDataGridViewTextBoxColumn.Width = 150;
            // 
            // veliTelDataGridViewTextBoxColumn
            // 
            this.veliTelDataGridViewTextBoxColumn.DataPropertyName = "VeliTel";
            this.veliTelDataGridViewTextBoxColumn.HeaderText = "VeliTel";
            this.veliTelDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.veliTelDataGridViewTextBoxColumn.Name = "veliTelDataGridViewTextBoxColumn";
            this.veliTelDataGridViewTextBoxColumn.Width = 150;
            // 
            // veliYakinlikDataGridViewTextBoxColumn
            // 
            this.veliYakinlikDataGridViewTextBoxColumn.DataPropertyName = "VeliYakinlik";
            this.veliYakinlikDataGridViewTextBoxColumn.HeaderText = "VeliYakinlik";
            this.veliYakinlikDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.veliYakinlikDataGridViewTextBoxColumn.Name = "veliYakinlikDataGridViewTextBoxColumn";
            this.veliYakinlikDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrencibilgiformu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1931, 1230);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ogrencibilgiformu";
            this.Text = "ogrencibilgiformu";
            this.Load += new System.EventHandler(this.ogrencibilgiformu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayitDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrKayitBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciKayitDataSet ogrenciKayitDataSet;
        private System.Windows.Forms.BindingSource ogrKayitBindingSource;
        private OgrenciKayitDataSetTableAdapters.Ogr_KayitTableAdapter ogr_KayitTableAdapter;
        private OgrenciKayitDataSet1 ogrenciKayitDataSet1;
        private System.Windows.Forms.BindingSource ogrKayitBindingSource1;
        private OgrenciKayitDataSet1TableAdapters.Ogr_KayitTableAdapter ogr_KayitTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSinifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrCinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliYakinlikDataGridViewTextBoxColumn;
    }
}