namespace ICHING
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.langGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_color_changable = new System.Windows.Forms.TextBox();
            this.txt_color_general = new System.Windows.Forms.TextBox();
            this.btn_color_changable = new System.Windows.Forms.Button();
            this.btn_color_general = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_prefered_method = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveFileLocation = new System.Windows.Forms.Button();
            this.txtDefaultStoragePath = new System.Windows.Forms.TextBox();
            this.langGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(398, 280);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 29);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(494, 280);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 29);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // langGroupBox
            // 
            this.langGroupBox.Controls.Add(this.comboBox1);
            this.langGroupBox.Location = new System.Drawing.Point(10, 12);
            this.langGroupBox.Name = "langGroupBox";
            this.langGroupBox.Size = new System.Drawing.Size(279, 74);
            this.langGroupBox.TabIndex = 2;
            this.langGroupBox.TabStop = false;
            this.langGroupBox.Text = " Language ";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "English";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "Srpski"});
            this.comboBox1.Location = new System.Drawing.Point(6, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "English";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_color_changable);
            this.groupBox1.Controls.Add(this.txt_color_general);
            this.groupBox1.Controls.Add(this.btn_color_changable);
            this.groupBox1.Controls.Add(this.btn_color_general);
            this.groupBox1.Location = new System.Drawing.Point(10, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Heksagram coloring";
            // 
            // txt_color_changable
            // 
            this.txt_color_changable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_color_changable.Enabled = false;
            this.txt_color_changable.Location = new System.Drawing.Point(11, 56);
            this.txt_color_changable.Name = "txt_color_changable";
            this.txt_color_changable.Size = new System.Drawing.Size(74, 23);
            this.txt_color_changable.TabIndex = 3;
            // 
            // txt_color_general
            // 
            this.txt_color_general.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_color_general.Enabled = false;
            this.txt_color_general.Location = new System.Drawing.Point(11, 24);
            this.txt_color_general.Name = "txt_color_general";
            this.txt_color_general.Size = new System.Drawing.Size(74, 23);
            this.txt_color_general.TabIndex = 2;
            this.txt_color_general.WordWrap = false;
            // 
            // btn_color_changable
            // 
            this.btn_color_changable.Location = new System.Drawing.Point(94, 54);
            this.btn_color_changable.Name = "btn_color_changable";
            this.btn_color_changable.Size = new System.Drawing.Size(176, 25);
            this.btn_color_changable.TabIndex = 1;
            this.btn_color_changable.Text = "Changable line color";
            this.btn_color_changable.UseVisualStyleBackColor = true;
            this.btn_color_changable.Click += new System.EventHandler(this.btn_color_changable_Click);
            // 
            // btn_color_general
            // 
            this.btn_color_general.Location = new System.Drawing.Point(94, 22);
            this.btn_color_general.Name = "btn_color_general";
            this.btn_color_general.Size = new System.Drawing.Size(176, 25);
            this.btn_color_general.TabIndex = 0;
            this.btn_color_general.Text = "General line color";
            this.btn_color_general.UseVisualStyleBackColor = true;
            this.btn_color_general.Click += new System.EventHandler(this.btn_color_general_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.SolidColorOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_prefered_method);
            this.groupBox2.Location = new System.Drawing.Point(308, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 74);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Preffered method ";
            // 
            // cbb_prefered_method
            // 
            this.cbb_prefered_method.FormattingEnabled = true;
            this.cbb_prefered_method.Items.AddRange(new object[] {
            "50 Rods",
            "3 Coins"});
            this.cbb_prefered_method.Location = new System.Drawing.Point(11, 23);
            this.cbb_prefered_method.Name = "cbb_prefered_method";
            this.cbb_prefered_method.Size = new System.Drawing.Size(259, 24);
            this.cbb_prefered_method.TabIndex = 0;
            this.cbb_prefered_method.Text = "50 Rods";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveFileLocation);
            this.groupBox3.Controls.Add(this.txtDefaultStoragePath);
            this.groupBox3.Location = new System.Drawing.Point(308, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 96);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Default Save Location ";
            // 
            // btnSaveFileLocation
            // 
            this.btnSaveFileLocation.Location = new System.Drawing.Point(142, 57);
            this.btnSaveFileLocation.Name = "btnSaveFileLocation";
            this.btnSaveFileLocation.Size = new System.Drawing.Size(127, 25);
            this.btnSaveFileLocation.TabIndex = 1;
            this.btnSaveFileLocation.Text = "Change location";
            this.btnSaveFileLocation.UseVisualStyleBackColor = true;
            this.btnSaveFileLocation.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDefaultStoragePath
            // 
            this.txtDefaultStoragePath.Location = new System.Drawing.Point(11, 28);
            this.txtDefaultStoragePath.Name = "txtDefaultStoragePath";
            this.txtDefaultStoragePath.Size = new System.Drawing.Size(258, 23);
            this.txtDefaultStoragePath.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(605, 321);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.langGroupBox);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.langGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox langGroupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_color_changable;
        private System.Windows.Forms.Button btn_color_general;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txt_color_general;
        private System.Windows.Forms.TextBox txt_color_changable;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_prefered_method;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveFileLocation;
        private System.Windows.Forms.TextBox txtDefaultStoragePath;
    }
}