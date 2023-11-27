namespace XIIRPL2_04_Ticketing.MasterForm
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 33);
            label1.Name = "label1";
            label1.Size = new Size(126, 29);
            label1.TabIndex = 0;
            label1.Text = "Daftar Akun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(314, 17);
            label2.TabIndex = 1;
            label2.Text = "Daftarkan diri Anda untuk menggunakan Bromo Airlines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Username➤";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 142);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Nama➤";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 174);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 4;
            label5.Text = "Tanggal Lahir➤";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 206);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 5;
            label6.Text = "Nomor Telepon➤";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 237);
            label7.Name = "label7";
            label7.Size = new Size(85, 20);
            label7.TabIndex = 6;
            label7.Text = "Password➤";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(171, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(203, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 206);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(171, 237);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(203, 23);
            textBox4.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(327, 281);
            button1.Name = "button1";
            button1.Size = new Size(97, 31);
            button1.TabIndex = 12;
            button1.Text = "Daftar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(38, 398);
            label8.Name = "label8";
            label8.Size = new Size(136, 20);
            label8.TabIndex = 13;
            label8.Text = "Sudah punya akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(189, 400);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(40, 17);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(480, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 236);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(863, 471);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegister";
            Text = "FormRegister";

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label8;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}