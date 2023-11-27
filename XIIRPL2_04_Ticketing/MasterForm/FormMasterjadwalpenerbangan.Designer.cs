namespace XIIRPL2_04_Ticketing.MasterForm
{
    partial class FormMasterjadwalpenerbangan
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
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtKe = new ComboBox();
            txtDari = new ComboBox();
            label4 = new Label();
            txtMaskapai = new ComboBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtTanggal_Keberangkatan = new DateTimePicker();
            txtDurasi_Penerbangan = new TextBox();
            txtHrga_Pertiket = new NumericUpDown();
            BtnSimpan = new Button();
            button1 = new Button();
            txtKode_Penerbangan = new TextBox();
            txtWaktu_Keberangkatan = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHrga_Pertiket).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(274, 17);
            label2.TabIndex = 3;
            label2.Text = "Semua jadwal penerbangan akan muncul di sini\r\n";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(252, 25);
            label1.TabIndex = 2;
            label1.Text = "Master Jadwal Penerbangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(846, 230);
            dataGridView1.TabIndex = 4;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 354);
            label3.Name = "label3";
            label3.Size = new Size(113, 17);
            label3.TabIndex = 5;
            label3.Text = "Kode Penerbangan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(12, 441);
            label6.Name = "label6";
            label6.Size = new Size(22, 17);
            label6.TabIndex = 10;
            label6.Text = "Ke";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(12, 393);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 9;
            label5.Text = "Dari";
            // 
            // txtKe
            // 
            txtKe.FormattingEnabled = true;
            txtKe.Location = new Point(158, 435);
            txtKe.Name = "txtKe";
            txtKe.Size = new Size(161, 23);
            txtKe.TabIndex = 18;
            // 
            // txtDari
            // 
            txtDari.FormattingEnabled = true;
            txtDari.Location = new Point(158, 387);
            txtDari.Name = "txtDari";
            txtDari.Size = new Size(161, 23);
            txtDari.TabIndex = 19;
            txtDari.SelectedIndexChanged += txtDari_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 489);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 20;
            label4.Text = "Maskapai";
            // 
            // txtMaskapai
            // 
            txtMaskapai.FormattingEnabled = true;
            txtMaskapai.Location = new Point(158, 483);
            txtMaskapai.Name = "txtMaskapai";
            txtMaskapai.Size = new Size(161, 23);
            txtMaskapai.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(434, 399);
            label7.Name = "label7";
            label7.Size = new Size(121, 17);
            label7.TabIndex = 22;
            label7.Text = "Durasi Penerbangan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(434, 356);
            label9.Name = "label9";
            label9.Size = new Size(141, 17);
            label9.TabIndex = 24;
            label9.Text = "Tanggal Keberangkatan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(434, 483);
            label10.Name = "label10";
            label10.Size = new Size(95, 17);
            label10.TabIndex = 25;
            label10.Text = "Harga Per Tiket";
            // 
            // txtTanggal_Keberangkatan
            // 
            txtTanggal_Keberangkatan.Format = DateTimePickerFormat.Short;
            txtTanggal_Keberangkatan.Location = new Point(581, 354);
            txtTanggal_Keberangkatan.Name = "txtTanggal_Keberangkatan";
            txtTanggal_Keberangkatan.Size = new Size(161, 23);
            txtTanggal_Keberangkatan.TabIndex = 26;
            txtTanggal_Keberangkatan.Value = new DateTime(2023, 11, 20, 0, 0, 0, 0);
            // 
            // txtDurasi_Penerbangan
            // 
            txtDurasi_Penerbangan.Location = new Point(581, 393);
            txtDurasi_Penerbangan.Name = "txtDurasi_Penerbangan";
            txtDurasi_Penerbangan.Size = new Size(161, 23);
            txtDurasi_Penerbangan.TabIndex = 28;
            // 
            // txtHrga_Pertiket
            // 
            txtHrga_Pertiket.Location = new Point(581, 483);
            txtHrga_Pertiket.Name = "txtHrga_Pertiket";
            txtHrga_Pertiket.Size = new Size(161, 23);
            txtHrga_Pertiket.TabIndex = 29;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Location = new Point(713, 570);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(75, 30);
            BtnSimpan.TabIndex = 31;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = true;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(622, 570);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 30;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtKode_Penerbangan
            // 
            txtKode_Penerbangan.Location = new Point(158, 348);
            txtKode_Penerbangan.Name = "txtKode_Penerbangan";
            txtKode_Penerbangan.Size = new Size(161, 23);
            txtKode_Penerbangan.TabIndex = 8;
            txtKode_Penerbangan.TextChanged += textBox1_TextChanged;
            // 
            // txtWaktu_Keberangkatan
            // 
            txtWaktu_Keberangkatan.Location = new Point(581, 441);
            txtWaktu_Keberangkatan.Name = "txtWaktu_Keberangkatan";
            txtWaktu_Keberangkatan.Size = new Size(161, 23);
            txtWaktu_Keberangkatan.TabIndex = 32;
            txtWaktu_Keberangkatan.TextChanged += textBox1_TextChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(434, 447);
            label8.Name = "label8";
            label8.Size = new Size(132, 17);
            label8.TabIndex = 33;
            label8.Text = "Waktu Keberangkatan";
            // 
            // FormMasterjadwalpenerbangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 638);
            Controls.Add(label8);
            Controls.Add(txtWaktu_Keberangkatan);
            Controls.Add(BtnSimpan);
            Controls.Add(button1);
            Controls.Add(txtHrga_Pertiket);
            Controls.Add(txtDurasi_Penerbangan);
            Controls.Add(txtTanggal_Keberangkatan);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(txtMaskapai);
            Controls.Add(label4);
            Controls.Add(txtDari);
            Controls.Add(txtKe);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtKode_Penerbangan);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterjadwalpenerbangan";
            Text = "FormMasterjadwalpenerbangan";
            Load += FormMasterjadwalpenerbangan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHrga_Pertiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label6;
        private Label label5;
        private ComboBox txtKe;
        private ComboBox txtDari;
        private Label label4;
        private ComboBox txtMaskapai;
        private Label label7;
        private Label label9;
        private Label label10;
        private DateTimePicker txtTanggal_Keberangkatan;
        private TextBox txtDurasi_Penerbangan;
        private NumericUpDown txtHrga_Pertiket;
        private Button BtnSimpan;
        private Button button1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private TextBox txtKode_Penerbangan;
        private TextBox txtWaktu_Keberangkatan;
        private Label label8;
    }
}