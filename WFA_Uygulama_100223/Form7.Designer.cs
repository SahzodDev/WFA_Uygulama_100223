namespace WFA_Uygulama_100223
{
    partial class Form7
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label3 = new Label();
            chkKadin = new CheckBox();
            chkErkek = new CheckBox();
            label4 = new Label();
            numYas = new NumericUpDown();
            btnkaydet = new Button();
            lstBilgiler = new ListBox();
            btnDigerFormaGonder = new Button();
            ((System.ComponentModel.ISupportInitialize)numYas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 53);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(49, 101);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyad :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(127, 54);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(288, 27);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(127, 99);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(288, 27);
            txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 152);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 4;
            label3.Text = "Cinsiyet :";
            // 
            // chkKadin
            // 
            chkKadin.AutoSize = true;
            chkKadin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chkKadin.Location = new Point(138, 155);
            chkKadin.Name = "chkKadin";
            chkKadin.Size = new Size(82, 29);
            chkKadin.TabIndex = 5;
            chkKadin.Text = "Kadın";
            chkKadin.UseVisualStyleBackColor = true;
            // 
            // chkErkek
            // 
            chkErkek.AutoSize = true;
            chkErkek.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            chkErkek.Location = new Point(138, 190);
            chkErkek.Name = "chkErkek";
            chkErkek.Size = new Size(79, 29);
            chkErkek.TabIndex = 6;
            chkErkek.Text = "Erkek";
            chkErkek.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(73, 245);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 7;
            label4.Text = "Yaş :";
            // 
            // numYas
            // 
            numYas.Location = new Point(138, 247);
            numYas.Name = "numYas";
            numYas.Size = new Size(277, 27);
            numYas.TabIndex = 8;
            // 
            // btnkaydet
            // 
            btnkaydet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnkaydet.Location = new Point(138, 327);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(221, 52);
            btnkaydet.TabIndex = 9;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // lstBilgiler
            // 
            lstBilgiler.FormattingEnabled = true;
            lstBilgiler.ItemHeight = 20;
            lstBilgiler.Location = new Point(478, 53);
            lstBilgiler.Name = "lstBilgiler";
            lstBilgiler.Size = new Size(287, 264);
            lstBilgiler.TabIndex = 10;
            // 
            // btnDigerFormaGonder
            // 
            btnDigerFormaGonder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDigerFormaGonder.Location = new Point(554, 327);
            btnDigerFormaGonder.Name = "btnDigerFormaGonder";
            btnDigerFormaGonder.Size = new Size(221, 52);
            btnDigerFormaGonder.TabIndex = 11;
            btnDigerFormaGonder.Text = "Diğer Forma Gönder";
            btnDigerFormaGonder.UseVisualStyleBackColor = true;
            btnDigerFormaGonder.Click += btnDigerFormaGonder_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDigerFormaGonder);
            Controls.Add(lstBilgiler);
            Controls.Add(btnkaydet);
            Controls.Add(numYas);
            Controls.Add(label4);
            Controls.Add(chkErkek);
            Controls.Add(chkKadin);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form7";
            Text = "Form7";
            ((System.ComponentModel.ISupportInitialize)numYas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label3;
        private CheckBox chkKadin;
        private CheckBox chkErkek;
        private Label label4;
        private NumericUpDown numYas;
        private Button btnkaydet;
        private ListBox lstBilgiler;
        private Button btnDigerFormaGonder;
    }
}