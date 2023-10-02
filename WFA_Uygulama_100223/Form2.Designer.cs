namespace WFA_Uygulama_100223
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
            lblHosgeldin = new Label();
            SuspendLayout();
            // 
            // lblHosgeldin
            // 
            lblHosgeldin.BackColor = SystemColors.ActiveCaption;
            lblHosgeldin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHosgeldin.ImageAlign = ContentAlignment.MiddleRight;
            lblHosgeldin.Location = new Point(229, 143);
            lblHosgeldin.Name = "lblHosgeldin";
            lblHosgeldin.Size = new Size(287, 56);
            lblHosgeldin.TabIndex = 0;
            lblHosgeldin.TextAlign = ContentAlignment.MiddleCenter;
            lblHosgeldin.Click += lblHosgeldin_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHosgeldin);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblHosgeldin;
    }
}