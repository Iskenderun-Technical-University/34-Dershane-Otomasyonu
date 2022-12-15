namespace GirisPaneli
{
    partial class ogrodevbilgii
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
            this.ogrKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciKayitDataSet6 = new GirisPaneli.OgrenciKayitDataSet6();
            this.ogr_KayitTableAdapter = new GirisPaneli.OgrenciKayitDataSet6TableAdapters.Ogr_KayitTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrDalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogreniOdevDurumuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.yKSDenemePuanıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yKSDenemeNetiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayitDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.ogrNoDataGridViewTextBoxColumn,
            this.ogrAdDataGridViewTextBoxColumn,
            this.ogrSoyadDataGridViewTextBoxColumn,
            this.ogrDalDataGridViewTextBoxColumn,
            this.ogreniOdevDurumuDataGridViewCheckBoxColumn,
            this.yKSDenemePuanıDataGridViewTextBoxColumn,
            this.yKSDenemeNetiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrKayitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(845, 364);
            this.dataGridView1.TabIndex = 0;
            // 
            // ogrKayitBindingSource
            // 
            this.ogrKayitBindingSource.DataMember = "Ogr_Kayit";
            this.ogrKayitBindingSource.DataSource = this.ogrenciKayitDataSet6;
            // 
            // ogrenciKayitDataSet6
            // 
            this.ogrenciKayitDataSet6.DataSetName = "OgrenciKayitDataSet6";
            this.ogrenciKayitDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogr_KayitTableAdapter
            // 
            this.ogr_KayitTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(364, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrNoDataGridViewTextBoxColumn
            // 
            this.ogrNoDataGridViewTextBoxColumn.DataPropertyName = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.HeaderText = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.Name = "ogrNoDataGridViewTextBoxColumn";
            // 
            // ogrAdDataGridViewTextBoxColumn
            // 
            this.ogrAdDataGridViewTextBoxColumn.DataPropertyName = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.HeaderText = "OgrAd";
            this.ogrAdDataGridViewTextBoxColumn.Name = "ogrAdDataGridViewTextBoxColumn";
            // 
            // ogrSoyadDataGridViewTextBoxColumn
            // 
            this.ogrSoyadDataGridViewTextBoxColumn.DataPropertyName = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.HeaderText = "OgrSoyad";
            this.ogrSoyadDataGridViewTextBoxColumn.Name = "ogrSoyadDataGridViewTextBoxColumn";
            // 
            // ogrDalDataGridViewTextBoxColumn
            // 
            this.ogrDalDataGridViewTextBoxColumn.DataPropertyName = "OgrDal";
            this.ogrDalDataGridViewTextBoxColumn.HeaderText = "OgrDal";
            this.ogrDalDataGridViewTextBoxColumn.Name = "ogrDalDataGridViewTextBoxColumn";
            // 
            // ogreniOdevDurumuDataGridViewCheckBoxColumn
            // 
            this.ogreniOdevDurumuDataGridViewCheckBoxColumn.DataPropertyName = "OgreniOdevDurumu";
            this.ogreniOdevDurumuDataGridViewCheckBoxColumn.HeaderText = "OgreniOdevDurumu";
            this.ogreniOdevDurumuDataGridViewCheckBoxColumn.Name = "ogreniOdevDurumuDataGridViewCheckBoxColumn";
            // 
            // yKSDenemePuanıDataGridViewTextBoxColumn
            // 
            this.yKSDenemePuanıDataGridViewTextBoxColumn.DataPropertyName = "YKSDenemePuanı";
            this.yKSDenemePuanıDataGridViewTextBoxColumn.HeaderText = "YKSDenemePuanı";
            this.yKSDenemePuanıDataGridViewTextBoxColumn.Name = "yKSDenemePuanıDataGridViewTextBoxColumn";
            // 
            // yKSDenemeNetiDataGridViewTextBoxColumn
            // 
            this.yKSDenemeNetiDataGridViewTextBoxColumn.DataPropertyName = "YKSDenemeNeti";
            this.yKSDenemeNetiDataGridViewTextBoxColumn.HeaderText = "YKSDenemeNeti";
            this.yKSDenemeNetiDataGridViewTextBoxColumn.Name = "yKSDenemeNetiDataGridViewTextBoxColumn";
            // 
            // ogrodevbilgii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ogrodevbilgii";
            this.Text = "Öğrenci Ödev Bilgileri";
            this.Load += new System.EventHandler(this.ogrodevbilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciKayitDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private OgrenciKayitDataSet6 ogrenciKayitDataSet6;
        private System.Windows.Forms.BindingSource ogrKayitBindingSource;
        private OgrenciKayitDataSet6TableAdapters.Ogr_KayitTableAdapter ogr_KayitTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrDalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ogreniOdevDurumuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yKSDenemePuanıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yKSDenemeNetiDataGridViewTextBoxColumn;
    }
}