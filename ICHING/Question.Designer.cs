namespace ICHING
{
    partial class Question
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Question));
            this.btn_ask = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.lb_subject = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ask
            // 
            this.btn_ask.Location = new System.Drawing.Point(485, 188);
            this.btn_ask.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ask.Name = "btn_ask";
            this.btn_ask.Size = new System.Drawing.Size(100, 28);
            this.btn_ask.TabIndex = 0;
            this.btn_ask.Text = "Ask";
            this.btn_ask.UseVisualStyleBackColor = true;
            this.btn_ask.Click += new System.EventHandler(this.btn_ask_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(593, 188);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txt_subject
            // 
            this.txt_subject.Location = new System.Drawing.Point(21, 36);
            this.txt_subject.Margin = new System.Windows.Forms.Padding(4);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(671, 23);
            this.txt_subject.TabIndex = 2;
            // 
            // lb_subject
            // 
            this.lb_subject.AutoSize = true;
            this.lb_subject.Location = new System.Drawing.Point(17, 16);
            this.lb_subject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(59, 17);
            this.lb_subject.TabIndex = 3;
            this.lb_subject.Text = "Subject:";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(21, 74);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(83, 17);
            this.lbl_description.TabIndex = 4;
            this.lbl_description.Text = "Description:";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(23, 96);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_description.Size = new System.Drawing.Size(668, 70);
            this.txt_description.TabIndex = 5;
            // 
            // Question
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(709, 234);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lb_subject);
            this.Controls.Add(this.txt_subject);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ask);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Question";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ask the question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ask;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label lb_subject;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.TextBox txt_description;
    }
}