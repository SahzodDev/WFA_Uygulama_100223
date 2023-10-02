namespace WFA_Uygulama_100223
{
    partial class Form6
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
            rtxText = new RichTextBox();
            btnKaydet = new Button();
            btnTextTemizle = new Button();
            lblText = new Label();
            btnDosyadanOku = new Button();
            btnLabelTemizle = new Button();
            SuspendLayout();
            // 
            // rtxText
            // 
            rtxText.Location = new Point(12, 12);
            rtxText.Name = "rtxText";
            rtxText.Size = new Size(520, 266);
            rtxText.TabIndex = 0;
            rtxText.Text = "";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(71, 301);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(134, 44);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Dosyaya Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTextTemizle
            // 
            btnTextTemizle.Location = new Point(354, 301);
            btnTextTemizle.Name = "btnTextTemizle";
            btnTextTemizle.Size = new Size(134, 44);
            btnTextTemizle.TabIndex = 2;
            btnTextTemizle.Text = "Text'i Temizle";
            btnTextTemizle.UseVisualStyleBackColor = true;
            btnTextTemizle.Click += btnTextTemizle_Click;
            // 
            // lblText
            // 
            lblText.BackColor = SystemColors.ActiveCaption;
            lblText.Location = new Point(12, 375);
            lblText.Name = "lblText";
            lblText.Size = new Size(520, 54);
            lblText.TabIndex = 3;
            // 
            // btnDosyadanOku
            // 
            btnDosyadanOku.Location = new Point(71, 479);
            btnDosyadanOku.Name = "btnDosyadanOku";
            btnDosyadanOku.Size = new Size(134, 44);
            btnDosyadanOku.TabIndex = 4;
            btnDosyadanOku.Text = "Dosyadan Oku";
            btnDosyadanOku.UseVisualStyleBackColor = true;
            btnDosyadanOku.Click += btnDosyadanOku_Click;
            // 
            // btnLabelTemizle
            // 
            btnLabelTemizle.Location = new Point(354, 479);
            btnLabelTemizle.Name = "btnLabelTemizle";
            btnLabelTemizle.Size = new Size(134, 44);
            btnLabelTemizle.TabIndex = 5;
            btnLabelTemizle.Text = "Label'ı Temizle";
            btnLabelTemizle.UseVisualStyleBackColor = true;
            btnLabelTemizle.Click += btnLabelTemizle_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 565);
            Controls.Add(btnLabelTemizle);
            Controls.Add(btnDosyadanOku);
            Controls.Add(lblText);
            Controls.Add(btnTextTemizle);
            Controls.Add(btnKaydet);
            Controls.Add(rtxText);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtxText;
        private Button btnKaydet;
        private Button btnTextTemizle;
        private Label lblText;
        private Button btnDosyadanOku;
        private Button btnLabelTemizle;
    }
}