namespace Responsi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNama = new System.Windows.Forms.Label();
            this.lblDepKaryawan = new System.Windows.Forms.Label();
            this.tbNamaKaryawan = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbDepKaryawan = new System.Windows.Forms.TextBox();
            this.tbIdKaryawan = new System.Windows.Forms.TextBox();
            this.lbl_idKar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(47, 78);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(99, 15);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama Karyawan :";
            // 
            // lblDepKaryawan
            // 
            this.lblDepKaryawan.AutoSize = true;
            this.lblDepKaryawan.Location = new System.Drawing.Point(48, 103);
            this.lblDepKaryawan.Name = "lblDepKaryawan";
            this.lblDepKaryawan.Size = new System.Drawing.Size(97, 15);
            this.lblDepKaryawan.TabIndex = 1;
            this.lblDepKaryawan.Text = "Dep. Karyawan   :";
            // 
            // tbNamaKaryawan
            // 
            this.tbNamaKaryawan.Location = new System.Drawing.Point(152, 75);
            this.tbNamaKaryawan.Name = "tbNamaKaryawan";
            this.tbNamaKaryawan.Size = new System.Drawing.Size(182, 23);
            this.tbNamaKaryawan.TabIndex = 2;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(47, 146);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(152, 146);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(48, 191);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.Size = new System.Drawing.Size(714, 200);
            this.dgvData.TabIndex = 7;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(687, 408);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbDepKaryawan
            // 
            this.tbDepKaryawan.Location = new System.Drawing.Point(151, 104);
            this.tbDepKaryawan.Name = "tbDepKaryawan";
            this.tbDepKaryawan.Size = new System.Drawing.Size(183, 23);
            this.tbDepKaryawan.TabIndex = 3;
            // 
            // tbIdKaryawan
            // 
            this.tbIdKaryawan.Location = new System.Drawing.Point(151, 46);
            this.tbIdKaryawan.Name = "tbIdKaryawan";
            this.tbIdKaryawan.Size = new System.Drawing.Size(182, 23);
            this.tbIdKaryawan.TabIndex = 9;
            // 
            // lbl_idKar
            // 
            this.lbl_idKar.AutoSize = true;
            this.lbl_idKar.Location = new System.Drawing.Point(46, 49);
            this.lbl_idKar.Name = "lbl_idKar";
            this.lbl_idKar.Size = new System.Drawing.Size(70, 15);
            this.lbl_idKar.TabIndex = 10;
            this.lbl_idKar.Text = "id karyawan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.lbl_idKar);
            this.Controls.Add(this.tbIdKaryawan);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbDepKaryawan);
            this.Controls.Add(this.tbNamaKaryawan);
            this.Controls.Add(this.lblDepKaryawan);
            this.Controls.Add(this.lblNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNama;
        private Label lblDepKaryawan;
        private TextBox tbNamaKaryawan;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private Button btnLoad;
        private TextBox tbDepKaryawan;
        private TextBox tbIdKaryawan;
        private Label lbl_idKar;
    }
}