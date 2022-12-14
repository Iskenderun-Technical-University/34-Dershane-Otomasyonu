namespace GirisPaneli
{
    partial class ogrencibilgi2
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciKayitDataSet2 = new GirisPaneli.OgrenciKayitDataSet2();
            this.ogrKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogr_KayitTableAdapter = new GirisPaneli.OgrenciKayitDataSet2TableAdapters.Ogr_KayitTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayitDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrKayitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(794, 1129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 83);
            this.button1.TabIndex = 5;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.DataSource = this.ogrKayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1848, 1111);
            this.dataGridView1.TabIndex = 4;
            // 
            // ogrenciKayitDataSet2
            // 
            this.ogrenciKayitDataSet2.DataSetName = "OgrenciKayitDataSet2";
            this.ogrenciKayitDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrKayitBindingSource
            // 
            this.ogrKayitBindingSource.DataMember = "Ogr_Kayit";
            this.ogrKayitBindingSource.DataSource = this.ogrenciKayitDataSet2;
            // 
            // ogr_KayitTableAdapter
            // 
            this.ogr_KayitTableAdapter.ClearBeforeFill = true;
            // 
            // ogrNoDataGridViewTextBoxColumn
            // 
            this.ogrNoDataGridViewTextBoxColumn.DataPropertyName = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.HeaderText = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrNoDataGridViewTextBoxColumn.Name = "ogrNoDataGridViewTextBoxColumn";
            this.ogrNoDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            this.ogrAdDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            this.ogrSoyadDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrSinifDataGridViewTextBoxColumn
            // 
            this.ogrSinifDataGridViewTextBoxColumn.DataPropertyName = "OgrSinif";
            this.ogrSinifDataGridViewTextBoxColumn.HeaderText = "OgrSinif";
            this.ogrSinifDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrSinifDataGridViewTextBoxColumn.Name = "ogrSinifDataGridViewTextBoxColumn";
            this.ogrSinifDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrDalDataGridViewTextBoxColumn
            // 
            this.ogrDalDataGridViewTextBoxColumn.DataPropertyName = "OgrDal";
            this.ogrDalDataGridViewTextBoxColumn.HeaderText = "OgrDal";
            this.ogrDalDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrDalDataGridViewTextBoxColumn.Name = "ogrDalDataGridViewTextBoxColumn";
            this.ogrDalDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrCinsiyetDataGridViewTextBoxColumn
            // 
            this.ogrCinsiyetDataGridViewTextBoxColumn.DataPropertyName = "OgrCinsiyet";
            this.ogrCinsiyetDataGridViewTextBoxColumn.HeaderText = "OgrCinsiyet";
            this.ogrCinsiyetDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ogrCinsiyetDataGridViewTextBoxColumn.Name = "ogrCinsiyetDataGridViewTextBoxColumn";
            this.ogrCinsiyetDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrAdresDataGridViewTextBoxColumn
            // 
            this.ogrAdresDataGridViewTextBoxColumn.DataPropertyName = "OgrAdres";
            this.ogrAdresDataGridViewTextBoxColumn.HeaderText = "OgrAdres";
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
            this.ıdDataGridViewTextBoxColumn.Width = 200;
            // 
            // veliAdDataGridViewTextBoxColumn
            // 
            this.veliAdDataGridViewTextBoxColumn.DataPropertyName = "VeliAd";
            this.veliAdDataGridViewTextBoxColumn.HeaderText = "VeliAd";
            this.veliAdDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.veliAdDataGridViewTextBoxColumn.Name = "veliAdDataGridViewTextBoxColumn";
            this.veliAdDataGridViewTextBoxColumn.Width = 200;
            // 
            // veliTelDataGridViewTextBoxColumn
            // 
            this.veliTelDataGridViewTextBoxColumn.DataPropertyName = "VeliTel";
            this.veliTelDataGridViewTextBoxColumn.HeaderText = "VeliTel";
            this.veliTelDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.veliTelDataGridViewTextBoxColumn.Name = "veliTelDataGridViewTextBoxColumn";
            this.veliTelDataGridViewTextBoxColumn.Width = 200;
            // 
            // veliYakinlikDataGridViewTextBoxColumn
            // 
            this.veliYakinlikDataGridViewTextBoxColumn.DataPropertyName = "VeliYakinlik";
            this.veliYakinlikDataGridViewTextBoxColumn.HeaderText = "VeliYakinlik";
            this.veliYakinlikDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.veliYakinlikDataGridViewTextBoxColumn.Name = "veliYakinlikDataGridViewTextBoxColumn";
            this.veliYakinlikDataGridViewTextBoxColumn.Width = 200;
            // 
            // ogrencibilgi2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1897, 1359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ogrencibilgi2";
            this.Text = "ogrencibilgi2";
            this.Load += new System.EventHandler(this.ogrencibilgi2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayitDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrKayitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciKayitDataSet2 ogrenciKayitDataSet2;
        private System.Windows.Forms.BindingSource ogrKayitBindingSource;
        private OgrenciKayitDataSet2TableAdapters.Ogr_KayitTableAdapter ogr_KayitTableAdapter;
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