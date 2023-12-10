using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICHING
{
    public partial class ArchiveRaw : Form
    {
        public ArchiveRaw()
        {
            InitializeComponent();
        }

        private void ArchiveRaw_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ichiDataSet1.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.ichiDataSet1.Questions);

        }
    }
}
