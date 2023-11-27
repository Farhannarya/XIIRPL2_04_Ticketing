namespace XIIRPL2_04_Ticketing.MasterForm
{
    partial class FormMasterKodePromo
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
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtKode_Promo = new TextBox();
            txtMaksimum_diskon = new NumericUpDown();
            txtPresentase_diskon = new NumericUpDown();
            txtBerlaku_sampai = new DateTimePicker();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            btnSimpan = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimum_diskon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentase_diskon).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(851, 260);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(259, 17);
            label2.TabIndex = 6;
            label2.Text = "Semua kode promo yang akan muncul di sini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 5;
            label1.Text = "Master Kode Promo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(12, 487);
            label6.Name = "label6";
            label6.Size = new Size(108, 17);
            label6.TabIndex = 11;
            label6.Text = "Maksimum diskon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(12, 444);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 10;
            label5.Text = "Presentase diskon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 403);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 9;
            label4.Text = "Berlaku sampai";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 360);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 8;
            label3.Text = "Kode Promo";
            // 
            // txtKode_Promo
            // 
            txtKode_Promo.Location = new Point(143, 359);
            txtKode_Promo.Name = "txtKode_Promo";
            txtKode_Promo.Size = new Size(254, 23);
            txtKode_Promo.TabIndex = 12;
            // 
            // txtMaksimum_diskon
            // 
            txtMaksimum_diskon.Location = new Point(143, 487);
            txtMaksimum_diskon.Name = "txtMaksimum_diskon";
            txtMaksimum_diskon.Size = new Size(254, 23);
            txtMaksimum_diskon.TabIndex = 13;
            // 
            // txtPresentase_diskon
            // 
            txtPresentase_diskon.Location = new Point(143, 444);
            txtPresentase_diskon.Name = "txtPresentase_diskon";
            txtPresentase_diskon.Size = new Size(254, 23);
            txtPresentase_diskon.TabIndex = 14;
            // 
            // txtBerlaku_sampai
            // 
            txtBerlaku_sampai.Location = new Point(143, 403);
            txtBerlaku_sampai.Name = "txtBerlaku_sampai";
            txtBerlaku_sampai.Size = new Size(254, 23);
            txtBerlaku_sampai.TabIndex = 15;
            txtBerlaku_sampai.ValueChanged += txtBerlaku_sampai_ValueChanged;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(586, 360);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(206, 55);
            txtDeskripsi.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(502, 360);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 17;
            label8.Text = "Deskripsi";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(748, 522);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 30);
            btnSimpan.TabIndex = 20;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(656, 522);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 19;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormMasterKodePromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 603);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(txtBerlaku_sampai);
            Controls.Add(txtPresentase_diskon);
            Controls.Add(txtMaksimum_diskon);
            Controls.Add(txtKode_Promo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterKodePromo";
            Text = "FormMasterKodePromo";
            Load += FormMasterKodePromo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaksimum_diskon).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPresentase_diskon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtKode_Promo;
        private NumericUpDown txtMaksimum_diskon;
        private NumericUpDown txtPresentase_diskon;
        private DateTimePicker txtBerlaku_sampai;
        private TextBox txtDeskripsi;
        private Label label8;
        private Button btnSimpan;
        private Button button1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}