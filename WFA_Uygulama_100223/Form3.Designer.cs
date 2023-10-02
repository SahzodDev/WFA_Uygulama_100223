namespace WFA_Uygulama_100223
{
    partial class Form3
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
            btnForm4Ac = new Button();
            btnForm5Ac = new Button();
            btnFormplariKapat = new Button();
            SuspendLayout();
            // 
            // btnForm4Ac
            // 
            btnForm4Ac.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnForm4Ac.Location = new Point(282, 41);
            btnForm4Ac.Name = "btnForm4Ac";
            btnForm4Ac.Size = new Size(197, 79);
            btnForm4Ac.TabIndex = 0;
            btnForm4Ac.Text = "Form4 Aç";
            btnForm4Ac.UseVisualStyleBackColor = true;
            btnForm4Ac.Click += btnForm4Ac_Click;
            // 
            // btnForm5Ac
            // 
            btnForm5Ac.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnForm5Ac.Location = new Point(282, 139);
            btnForm5Ac.Name = "btnForm5Ac";
            btnForm5Ac.Size = new Size(197, 79);
            btnForm5Ac.TabIndex = 1;
            btnForm5Ac.Text = "Form5 Aç";
            btnForm5Ac.UseVisualStyleBackColor = true;
            btnForm5Ac.Click += btnForm5Ac_Click;
            // 
            // btnFormplariKapat
            // 
            btnFormplariKapat.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnFormplariKapat.Location = new Point(78, 309);
            btnFormplariKapat.Name = "btnFormplariKapat";
            btnFormplariKapat.Size = new Size(657, 53);
            btnFormplariKapat.TabIndex = 2;
            btnFormplariKapat.Text = "Formları Kapat";
            btnFormplariKapat.UseVisualStyleBackColor = true;
            btnFormplariKapat.Click += btnFormplariKapat_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFormplariKapat);
            Controls.Add(btnForm5Ac);
            Controls.Add(btnForm4Ac);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnForm4Ac;
        private Button btnForm5Ac;
        private Button btnFormplariKapat;
    }
}