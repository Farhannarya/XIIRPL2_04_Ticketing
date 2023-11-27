namespace XIIRPL2_04_Ticketing.MasterForm
{
    partial class FormMasterBandara
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
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNama = new TextBox();
            txtKodeIATA = new TextBox();
            txtKota = new TextBox();
            txtNegara = new ComboBox();
            label7 = new Label();
            txtJmlTerminal = new NumericUpDown();
            label8 = new Label();
            txtAlamat = new TextBox();
            button1 = new Button();
            btnSimpan = new Button();
            BtnEdit = new DataGridViewButtonColumn();
            BtnDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Master Bandara";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(292, 17);
            label2.TabIndex = 1;
            label2.Text = "Semua bandara yang terdaftar akan muncul di sini";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BtnEdit, BtnDelete });
            dataGridView1.Location = new Point(12, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(790, 226);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(19, 330);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 3;
            label3.Text = "Nama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(19, 364);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 4;
            label4.Text = "Kode IATA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(19, 399);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 5;
            label5.Text = "Kota";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(19, 433);
            label6.Name = "label6";
            label6.Size = new Size(50, 17);
            label6.TabIndex = 6;
            label6.Text = "Negara";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(106, 329);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(161, 23);
            txtNama.TabIndex = 7;
            // 
            // txtKodeIATA
            // 
            txtKodeIATA.Location = new Point(106, 363);
            txtKodeIATA.Name = "txtKodeIATA";
            txtKodeIATA.Size = new Size(161, 23);
            txtKodeIATA.TabIndex = 8;
            // 
            // txtKota
            // 
            txtKota.Location = new Point(106, 398);
            txtKota.Name = "txtKota";
            txtKota.Size = new Size(161, 23);
            txtKota.TabIndex = 9;
            // 
            // txtNegara
            // 
            txtNegara.FormattingEnabled = true;
            txtNegara.Location = new Point(106, 432);
            txtNegara.Name = "txtNegara";
            txtNegara.Size = new Size(161, 23);
            txtNegara.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(378, 335);
            label7.Name = "label7";
            label7.Size = new Size(101, 17);
            label7.TabIndex = 11;
            label7.Text = "Jumlah Terminal";
            // 
            // txtJmlTerminal
            // 
            txtJmlTerminal.Location = new Point(515, 330);
            txtJmlTerminal.Name = "txtJmlTerminal";
            txtJmlTerminal.Size = new Size(206, 23);
            txtJmlTerminal.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(378, 369);
            label8.Name = "label8";
            label8.Size = new Size(48, 17);
            label8.TabIndex = 13;
            label8.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(515, 369);
            txtAlamat.Multiline = true;
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(206, 96);
            txtAlamat.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(537, 499);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 15;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(628, 499);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 30);
            btnSimpan.TabIndex = 16;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Text = "Edit";
            BtnEdit.UseColumnTextForButtonValue = true;
            // 
            // BtnDelete
            // 
            BtnDelete.HeaderText = "Delete";
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Text = "Delete";
            BtnDelete.UseColumnTextForButtonValue = true;
            // 
            // FormMasterBandara
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 571);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtAlamat);
            Controls.Add(label8);
            Controls.Add(txtJmlTerminal);
            Controls.Add(label7);
            Controls.Add(txtNegara);
            Controls.Add(txtKota);
            Controls.Add(txtKodeIATA);
            Controls.Add(txtNama);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormMasterBandara";
            Text = "FormMasterBandara";
            Load += FormMasterBandara_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlTerminal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNama;
        private TextBox txtKodeIATA;
        private TextBox txtKota;
        private ComboBox txtNegara;
        private Label label7;
        private NumericUpDown txtJmlTerminal;
        private Label label8;
        private TextBox txtAlamat;
        private Button button1;
        private Button btnSimpan;
        private DataGridViewButtonColumn BtnEdit;
        private DataGridViewButtonColumn BtnDelete;
    }
}