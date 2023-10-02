namespace WFA_Uygulama_100223
{
    partial class Form8
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
            lstBilgiler = new ListBox();
            SuspendLayout();
            // 
            // lstBilgiler
            // 
            lstBilgiler.FormattingEnabled = true;
            lstBilgiler.ItemHeight = 20;
            lstBilgiler.Location = new Point(12, 12);
            lstBilgiler.Name = "lstBilgiler";
            lstBilgiler.Size = new Size(405, 424);
            lstBilgiler.TabIndex = 0;
            lstBilgiler.SelectedIndexChanged += lstBilgiler_SelectedIndexChanged;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 450);
            Controls.Add(lstBilgiler);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstBilgiler;
    }
}