namespace ICHING
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_question_subject = new System.Windows.Forms.Label();
            this.btn_processor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMainHexagramId = new System.Windows.Forms.Label();
            this.lblMainHexagramName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSecondHexagramId = new System.Windows.Forms.Label();
            this.lblSecondHexagramName = new System.Windows.Forms.Label();
            this.rtText = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_question_subject
            // 
            this.lbl_question_subject.AutoSize = true;
            this.lbl_question_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question_subject.Location = new System.Drawing.Point(12, 9);
            this.lbl_question_subject.Name = "lbl_question_subject";
            this.lbl_question_subject.Size = new System.Drawing.Size(82, 20);
            this.lbl_question_subject.TabIndex = 0;
            this.lbl_question_subject.Text = "SUBJECT";
            // 
            // btn_processor
            // 
            this.btn_processor.Location = new System.Drawing.Point(16, 32);
            this.btn_processor.Name = "btn_processor";
            this.btn_processor.Size = new System.Drawing.Size(102, 33);
            this.btn_processor.TabIndex = 1;
            this.btn_processor.Text = "Click";
            this.btn_processor.UseVisualStyleBackColor = true;
            this.btn_processor.Click += new System.EventHandler(this.btn_processor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblMainHexagramId);
            this.panel1.Location = new System.Drawing.Point(16, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 297);
            this.panel1.TabIndex = 2;
            // 
            // lblMainHexagramId
            // 
            this.lblMainHexagramId.AutoSize = true;
            this.lblMainHexagramId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHexagramId.Location = new System.Drawing.Point(4, 0);
            this.lblMainHexagramId.Name = "lblMainHexagramId";
            this.lblMainHexagramId.Size = new System.Drawing.Size(0, 31);
            this.lblMainHexagramId.TabIndex = 4;
            // 
            // lblMainHexagramName
            // 
            this.lblMainHexagramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHexagramName.Location = new System.Drawing.Point(12, 83);
            this.lblMainHexagramName.Name = "lblMainHexagramName";
            this.lblMainHexagramName.Size = new System.Drawing.Size(1023, 24);
            this.lblMainHexagramName.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSecondHexagramId);
            this.panel2.Location = new System.Drawing.Point(239, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 208);
            this.panel2.TabIndex = 3;
            // 
            // lblSecondHexagramId
            // 
            this.lblSecondHexagramId.AutoSize = true;
            this.lblSecondHexagramId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondHexagramId.Location = new System.Drawing.Point(3, 0);
            this.lblSecondHexagramId.Name = "lblSecondHexagramId";
            this.lblSecondHexagramId.Size = new System.Drawing.Size(0, 29);
            this.lblSecondHexagramId.TabIndex = 5;
            // 
            // lblSecondHexagramName
            // 
            this.lblSecondHexagramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondHexagramName.Location = new System.Drawing.Point(274, 173);
            this.lblSecondHexagramName.Name = "lblSecondHexagramName";
            this.lblSecondHexagramName.Size = new System.Drawing.Size(761, 20);
            this.lblSecondHexagramName.TabIndex = 5;
            // 
            // rtText
            // 
            this.rtText.BackColor = System.Drawing.SystemColors.Window;
            this.rtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtText.BulletIndent = 7;
            this.rtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtText.Location = new System.Drawing.Point(377, 235);
            this.rtText.Margin = new System.Windows.Forms.Padding(12);
            this.rtText.Name = "rtText";
            this.rtText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtText.Size = new System.Drawing.Size(658, 382);
            this.rtText.TabIndex = 6;
            this.rtText.Text = "MainTitle\n\nMainText\n\nLinesComments\n\n\nSecondTitle\n\nSecondText";
            this.rtText.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 771);
            this.Controls.Add(this.lblMainHexagramName);
            this.Controls.Add(this.rtText);
            this.Controls.Add(this.lblSecondHexagramName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_processor);
            this.Controls.Add(this.lbl_question_subject);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_processor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_question_subject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMainHexagramId;
        private System.Windows.Forms.Label lblSecondHexagramId;
        private System.Windows.Forms.Label lblMainHexagramName;
        private System.Windows.Forms.Label lblSecondHexagramName;
        private System.Windows.Forms.RichTextBox rtText;
    }
}