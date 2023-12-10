namespace ICHING
{
    partial class IchiEditor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fourthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fifthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sixthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ichingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ichiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ichiDataSet = new ICHING.IchiDataSet();
            this.ichingTableAdapter = new ICHING.IchiDataSetTableAdapters.IchingTableAdapter();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.firstDataGridViewTextBoxColumn,
            this.secondDataGridViewTextBoxColumn,
            this.thirdDataGridViewTextBoxColumn,
            this.fourthDataGridViewTextBoxColumn,
            this.fifthDataGridViewTextBoxColumn,
            this.sixthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ichingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1146, 633);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MainText";
            this.dataGridViewTextBoxColumn1.HeaderText = "MainText";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // firstDataGridViewTextBoxColumn
            // 
            this.firstDataGridViewTextBoxColumn.DataPropertyName = "First";
            this.firstDataGridViewTextBoxColumn.HeaderText = "First";
            this.firstDataGridViewTextBoxColumn.Name = "firstDataGridViewTextBoxColumn";
            // 
            // secondDataGridViewTextBoxColumn
            // 
            this.secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            this.secondDataGridViewTextBoxColumn.HeaderText = "Second";
            this.secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            // 
            // thirdDataGridViewTextBoxColumn
            // 
            this.thirdDataGridViewTextBoxColumn.DataPropertyName = "Third";
            this.thirdDataGridViewTextBoxColumn.HeaderText = "Third";
            this.thirdDataGridViewTextBoxColumn.Name = "thirdDataGridViewTextBoxColumn";
            // 
            // fourthDataGridViewTextBoxColumn
            // 
            this.fourthDataGridViewTextBoxColumn.DataPropertyName = "Fourth";
            this.fourthDataGridViewTextBoxColumn.HeaderText = "Fourth";
            this.fourthDataGridViewTextBoxColumn.Name = "fourthDataGridViewTextBoxColumn";
            // 
            // fifthDataGridViewTextBoxColumn
            // 
            this.fifthDataGridViewTextBoxColumn.DataPropertyName = "Fifth";
            this.fifthDataGridViewTextBoxColumn.HeaderText = "Fifth";
            this.fifthDataGridViewTextBoxColumn.Name = "fifthDataGridViewTextBoxColumn";
            // 
            // sixthDataGridViewTextBoxColumn
            // 
            this.sixthDataGridViewTextBoxColumn.DataPropertyName = "Sixth";
            this.sixthDataGridViewTextBoxColumn.HeaderText = "Sixth";
            this.sixthDataGridViewTextBoxColumn.Name = "sixthDataGridViewTextBoxColumn";
            // 
            // ichingBindingSource
            // 
            this.ichingBindingSource.DataMember = "Iching";
            this.ichingBindingSource.DataSource = this.ichiDataSetBindingSource;
            // 
            // ichiDataSetBindingSource
            // 
            this.ichiDataSetBindingSource.DataSource = this.ichiDataSet;
            this.ichiDataSetBindingSource.Position = 0;
            // 
            // ichiDataSet
            // 
            this.ichiDataSet.DataSetName = "IchiDataSet";
            this.ichiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ichingTableAdapter
            // 
            this.ichingTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Edit I Ching texts";
            // 
            // IchiEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 697);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IchiEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "I Ching Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IchiEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ichiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ichiDataSetBindingSource;
        private IchiDataSet ichiDataSet;
        private System.Windows.Forms.BindingSource ichingBindingSource;
        private IchiDataSetTableAdapters.IchingTableAdapter ichingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tekstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prvaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trecaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cetvrtaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maintextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fourthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fifthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sixthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTitle;
    }
}