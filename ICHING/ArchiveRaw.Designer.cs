namespace ICHING
{
    partial class ArchiveRaw
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
            this.components = new System.ComponentModel.Container();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ichiDataSet1 = new ICHING.IchiDataSet1();
            this.ichiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new ICHING.IchiDataSet1TableAdapters.QuestionsTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainhexagramidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changablelinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondhexagramidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(12, 9);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(282, 29);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "ARCHIVED QUESTIONS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.mainhexagramidDataGridViewTextBoxColumn,
            this.changablelinesDataGridViewTextBoxColumn,
            this.secondhexagramidDataGridViewTextBoxColumn,
            this.datetimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 522);
            this.dataGridView1.TabIndex = 1;
            // 
            // ichiDataSet1
            // 
            this.ichiDataSet1.DataSetName = "IchiDataSet1";
            this.ichiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ichiDataSet1BindingSource
            // 
            this.ichiDataSet1BindingSource.DataSource = this.ichiDataSet1;
            this.ichiDataSet1BindingSource.Position = 0;
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.ichiDataSet1BindingSource;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mainhexagramidDataGridViewTextBoxColumn
            // 
            this.mainhexagramidDataGridViewTextBoxColumn.DataPropertyName = "main_hexagram_id";
            this.mainhexagramidDataGridViewTextBoxColumn.HeaderText = "main_hexagram_id";
            this.mainhexagramidDataGridViewTextBoxColumn.Name = "mainhexagramidDataGridViewTextBoxColumn";
            this.mainhexagramidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changablelinesDataGridViewTextBoxColumn
            // 
            this.changablelinesDataGridViewTextBoxColumn.DataPropertyName = "changable_lines";
            this.changablelinesDataGridViewTextBoxColumn.HeaderText = "changable_lines";
            this.changablelinesDataGridViewTextBoxColumn.Name = "changablelinesDataGridViewTextBoxColumn";
            this.changablelinesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondhexagramidDataGridViewTextBoxColumn
            // 
            this.secondhexagramidDataGridViewTextBoxColumn.DataPropertyName = "second_hexagram_id";
            this.secondhexagramidDataGridViewTextBoxColumn.HeaderText = "second_hexagram_id";
            this.secondhexagramidDataGridViewTextBoxColumn.Name = "secondhexagramidDataGridViewTextBoxColumn";
            this.secondhexagramidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetimeDataGridViewTextBoxColumn
            // 
            this.datetimeDataGridViewTextBoxColumn.DataPropertyName = "asked";
            this.datetimeDataGridViewTextBoxColumn.HeaderText = "asked";
            this.datetimeDataGridViewTextBoxColumn.Name = "datetimeDataGridViewTextBoxColumn";
            this.datetimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ArchiveRaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSubject);
            this.Name = "ArchiveRaw";
            this.Text = "Archive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ArchiveRaw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ichiDataSet1BindingSource;
        private IchiDataSet1 ichiDataSet1;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private IchiDataSet1TableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainhexagramidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changablelinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondhexagramidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetimeDataGridViewTextBoxColumn;
    }
}