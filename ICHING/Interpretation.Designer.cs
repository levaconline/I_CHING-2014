namespace ICHING
{
    partial class Interpretation
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
            this.rtbInterpretation = new System.Windows.Forms.RichTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbInterpretation
            // 
            this.rtbInterpretation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInterpretation.ForeColor = System.Drawing.Color.Gray;
            this.rtbInterpretation.Location = new System.Drawing.Point(12, 45);
            this.rtbInterpretation.Name = "rtbInterpretation";
            this.rtbInterpretation.ReadOnly = true;
            this.rtbInterpretation.Size = new System.Drawing.Size(700, 800);
            this.rtbInterpretation.TabIndex = 0;
            this.rtbInterpretation.Text = "";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(154, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Interpretation";
            // 
            // Interpretation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 865);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.rtbInterpretation);
            this.Name = "Interpretation";
            this.Text = "Interpretation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Interpretation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.RichTextBox rtbInterpretation;
    }
}