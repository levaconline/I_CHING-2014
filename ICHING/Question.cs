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
    public partial class Question : Form
    {
        public Question()
        {
            InitializeComponent();
        }

        private void btn_ask_Click(object sender, EventArgs e)
        {
            if (this.txt_subject.Text == "")
            {
                MessageBox.Show("Fill the subject please.");
            }
            else
            {
                IChing.questionSubject = this.txt_subject.Text;
                IChing.questionDescription = this.txt_description.Text;
                Main.aTimer.Start();
                this.Close();
                
            }
        }
    }
}
