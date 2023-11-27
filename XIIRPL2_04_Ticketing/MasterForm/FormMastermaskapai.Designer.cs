namespace XIIRPL2_04_Ticketing.MasterForm
{
    partial class FormMastermaskapai
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
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            txtNama = new TextBox();
            label1 = new Label();
            txtPerusahaan = new TextBox();
            label2 = new Label();
            txtJmlKru = new NumericUpDown();
            label5 = new Label();
            txtDeskripsi = new TextBox();
            label8 = new Label();
            btnSimpan = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlKru).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(12, 61);
            label3.Name = "label3";
            label3.Size = new Size(298, 17);
            label3.TabIndex = 5;
            label3.Text = "Semua maskapai yang terdaftar akan muncul di sini";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 36);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 4;
            label4.Text = "Master Maskapai";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.Location = new Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(779, 226);
            dataGridView1.TabIndex = 6;
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
            // txtNama
            // 
            txtNama.Location = new Point(108, 318);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(161, 23);
            txtNama.TabIndex = 9;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(21, 324);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 8;
            label1.Text = "Nama";
            // 
            // txtPerusahaan
            // 
            txtPerusahaan.Location = new Point(108, 363);
            txtPerusahaan.Name = "txtPerusahaan";
            txtPerusahaan.Size = new Size(161, 23);
            txtPerusahaan.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 369);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 12;
            label2.Text = "Perusahaan";
            // 
            // txtJmlKru
            // 
            txtJmlKru.Location = new Point(108, 412);
            txtJmlKru.Name = "txtJmlKru";
            txtJmlKru.Size = new Size(161, 23);
            txtJmlKru.TabIndex = 13;
            txtJmlKru.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(12, 418);
            label5.Name = "label5";
            label5.Size = new Size(72, 17);
            label5.TabIndex = 14;
            label5.Text = "Jumlah Kru";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(516, 318);
            txtDeskripsi.Multiline = true;
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(206, 96);
            txtDeskripsi.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(401, 324);
            label8.Name = "label8";
            label8.Size = new Size(57, 17);
            label8.TabIndex = 15;
            label8.Text = "Deskripsi";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(630, 476);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 30);
            btnSimpan.TabIndex = 18;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // button1
            // 
            button1.Location = new Point(531, 476);
            button1.Name = "button1";
            button1.Size = new Size(75, 30);
            button1.TabIndex = 17;
            button1.Text = "Batal";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormMastermaskapai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 545);
            Controls.Add(btnSimpan);
            Controls.Add(button1);
            Controls.Add(txtDeskripsi);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(txtJmlKru);
            Controls.Add(label2);
            Controls.Add(txtPerusahaan);
            Controls.Add(txtNama);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label4);
            Name = "FormMastermaskapai";
            Text = "FormMastermaskapai";
            Load += FormMastermaskapai_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtJmlKru).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox txtNama;
        private Label label1;
        private TextBox txtPerusahaan;
        private Label label2;
        private NumericUpDown txtJmlKru;
        private Label label5;
        private TextBox txtDeskripsi;
        private Label label8;
        private Button btnSimpan;
        private Button button1;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}