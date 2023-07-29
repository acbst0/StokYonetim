namespace Stoker
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            txtAd = new TextBox();
            label1 = new Label();
            txtKategori = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtAlis = new TextBox();
            label4 = new Label();
            txtSatis = new TextBox();
            label5 = new Label();
            txtAdet = new NumericUpDown();
            txtKdv = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            txtBarkod = new TextBox();
            txtMarka = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)txtAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKdv).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(367, 275);
            button1.Name = "button1";
            button1.Size = new Size(195, 47);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(134, 12);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(428, 28);
            txtAd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 15);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 2;
            label1.Text = "Ürün Adı : ";
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(192, 46);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(370, 28);
            txtKategori.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 49);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 4;
            label2.Text = "Ürün Kategorisi : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 157);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 6;
            label3.Text = "Alış Fiyatı : ";
            // 
            // txtAlis
            // 
            txtAlis.Location = new Point(143, 154);
            txtAlis.Name = "txtAlis";
            txtAlis.PlaceholderText = "Virgül Kullanın";
            txtAlis.Size = new Size(141, 28);
            txtAlis.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 157);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 8;
            label4.Text = "Satış Fiyatı : ";
            // 
            // txtSatis
            // 
            txtSatis.Location = new Point(421, 154);
            txtSatis.Name = "txtSatis";
            txtSatis.PlaceholderText = "Virgül Kullanın";
            txtSatis.Size = new Size(141, 28);
            txtSatis.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 190);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 10;
            label5.Text = "Adet : ";
            // 
            // txtAdet
            // 
            txtAdet.Location = new Point(99, 188);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(144, 28);
            txtAdet.TabIndex = 11;
            // 
            // txtKdv
            // 
            txtKdv.Location = new Point(343, 188);
            txtKdv.Name = "txtKdv";
            txtKdv.Size = new Size(144, 28);
            txtKdv.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 190);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 12;
            label6.Text = "KDV : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 225);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 14;
            label7.Text = "Barkod : ";
            // 
            // txtBarkod
            // 
            txtBarkod.Location = new Point(119, 222);
            txtBarkod.MaxLength = 13;
            txtBarkod.Name = "txtBarkod";
            txtBarkod.Size = new Size(219, 28);
            txtBarkod.TabIndex = 15;
            txtBarkod.KeyPress += txtBarkod_KeyPress;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(110, 80);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(452, 28);
            txtMarka.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 83);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 17;
            label8.Text = "Marka : ";
            // 
            // Form2
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(573, 334);
            Controls.Add(label8);
            Controls.Add(txtMarka);
            Controls.Add(txtBarkod);
            Controls.Add(label7);
            Controls.Add(txtKdv);
            Controls.Add(label6);
            Controls.Add(txtAdet);
            Controls.Add(label5);
            Controls.Add(txtSatis);
            Controls.Add(label4);
            Controls.Add(txtAlis);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtKategori);
            Controls.Add(label1);
            Controls.Add(txtAd);
            Controls.Add(button1);
            Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Ürün Ekleme";
            ((System.ComponentModel.ISupportInitialize)txtAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKdv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtAd;
        private Label label1;
        private TextBox txtKategori;
        private Label label2;
        private Label label3;
        private TextBox txtAlis;
        private Label label4;
        private TextBox txtSatis;
        private Label label5;
        private NumericUpDown txtAdet;
        private NumericUpDown txtKdv;
        private Label label6;
        private Label label7;
        private TextBox txtBarkod;
        private TextBox txtMarka;
        private Label label8;
    }
}