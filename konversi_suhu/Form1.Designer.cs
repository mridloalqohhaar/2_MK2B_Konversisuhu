namespace konversi_suhu
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
            txtcelci = new TextBox();
            label1 = new Label();
            btnpanas = new Button();
            btnkonversi = new Button();
            btnreset = new Button();
            btndingin = new Button();
            btnkeluar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtream = new TextBox();
            txtfahrein = new TextBox();
            txtkelv = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtcelci
            // 
            txtcelci.BackColor = Color.AliceBlue;
            txtcelci.Cursor = Cursors.IBeam;
            txtcelci.Location = new Point(479, 145);
            txtcelci.Name = "txtcelci";
            txtcelci.Size = new Size(150, 31);
            txtcelci.TabIndex = 0;
            txtcelci.TextChanged += txtcelci_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppin", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 30);
            label1.Name = "label1";
            label1.Size = new Size(223, 27);
            label1.TabIndex = 1;
            label1.Text = "Konversi Suhu";
            label1.Click += label1_Click;
            // 
            // btnpanas
            // 
            btnpanas.BackColor = Color.DarkOrange;
            btnpanas.BackgroundImageLayout = ImageLayout.Zoom;
            btnpanas.Cursor = Cursors.AppStarting;
            btnpanas.Location = new Point(369, 207);
            btnpanas.Name = "btnpanas";
            btnpanas.Size = new Size(112, 34);
            btnpanas.TabIndex = 2;
            btnpanas.Text = "Panaskan";
            btnpanas.UseVisualStyleBackColor = false;
            btnpanas.Click += btnpanas_Click;
            // 
            // btnkonversi
            // 
            btnkonversi.BackColor = Color.LawnGreen;
            btnkonversi.Cursor = Cursors.AppStarting;
            btnkonversi.ForeColor = SystemColors.ActiveCaptionText;
            btnkonversi.Location = new Point(636, 208);
            btnkonversi.Name = "btnkonversi";
            btnkonversi.Size = new Size(112, 34);
            btnkonversi.TabIndex = 3;
            btnkonversi.Text = "Konversi";
            btnkonversi.UseVisualStyleBackColor = false;
            btnkonversi.Click += btnkonversi_Click;
            // 
            // btnreset
            // 
            btnreset.Cursor = Cursors.AppStarting;
            btnreset.Location = new Point(517, 404);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(112, 34);
            btnreset.TabIndex = 4;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btndingin
            // 
            btndingin.BackColor = Color.MediumTurquoise;
            btndingin.Cursor = Cursors.AppStarting;
            btndingin.Location = new Point(498, 207);
            btndingin.Name = "btndingin";
            btndingin.Size = new Size(112, 34);
            btndingin.TabIndex = 5;
            btndingin.Text = "Dinginkan";
            btndingin.UseVisualStyleBackColor = false;
            btndingin.Click += btndingin_Click;
            // 
            // btnkeluar
            // 
            btnkeluar.Cursor = Cursors.AppStarting;
            btnkeluar.Location = new Point(676, 404);
            btnkeluar.Name = "btnkeluar";
            btnkeluar.Size = new Size(112, 34);
            btnkeluar.TabIndex = 6;
            btnkeluar.Text = "Keluar";
            btnkeluar.UseVisualStyleBackColor = true;
            btnkeluar.Click += btnkeluar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 216);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 7;
            label2.Text = "Kelvin";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 86);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 8;
            label3.Text = "Reamur";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 151);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 9;
            label4.Text = "Fahrenheit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(369, 145);
            label5.Name = "label5";
            label5.Size = new Size(70, 25);
            label5.TabIndex = 10;
            label5.Text = "Celcius";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 192);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 11;
            // 
            // txtream
            // 
            txtream.BackColor = Color.AliceBlue;
            txtream.Location = new Point(165, 80);
            txtream.Name = "txtream";
            txtream.Size = new Size(150, 31);
            txtream.TabIndex = 12;
            // 
            // txtfahrein
            // 
            txtfahrein.BackColor = Color.AliceBlue;
            txtfahrein.Location = new Point(165, 145);
            txtfahrein.Name = "txtfahrein";
            txtfahrein.Size = new Size(150, 31);
            txtfahrein.TabIndex = 13;
            txtfahrein.TextChanged += textBox3_TextChanged;
            // 
            // txtkelv
            // 
            txtkelv.BackColor = Color.AliceBlue;
            txtkelv.Location = new Point(165, 210);
            txtkelv.Name = "txtkelv";
            txtkelv.Size = new Size(150, 31);
            txtkelv.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Poppin", 12F);
            label8.Location = new Point(84, 275);
            label8.Name = "label8";
            label8.Size = new Size(0, 23);
            label8.TabIndex = 15;
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(txtkelv);
            Controls.Add(txtfahrein);
            Controls.Add(txtream);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnkeluar);
            Controls.Add(btndingin);
            Controls.Add(btnreset);
            Controls.Add(btnkonversi);
            Controls.Add(btnpanas);
            Controls.Add(label1);
            Controls.Add(txtcelci);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcelci;
        private Label label1;
        private Button btnpanas;
        private Button btnkonversi;
        private Button btnreset;
        private Button btndingin;
        private Button btnkeluar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtream;
        private TextBox txtfahrein;
        private TextBox txtkelv;
        private Label label7;
        private Label label8;
    }
}
