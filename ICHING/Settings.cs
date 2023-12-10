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
    public partial class Settings : Form
    {
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;

        public Settings()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = Settings1.Default.Language; //IChing.language;
            txt_color_general.BackColor = Settings1.Default.HexagranColorGeneral; // Color.FromArgb(IChing.color_general);
            txt_color_changable.BackColor = Settings1.Default.HexagramColorChangable; //Color.FromArgb(IChing.color_changable);
            txtDefaultStoragePath.Text = Settings1.Default.StorageDirPath; //IChing.default_storage_path;
        }

        private void btn_color_general_Click(object sender, EventArgs e)
        {
           if (colorDialog1.ShowDialog() == DialogResult.OK){
              txt_color_general.BackColor = colorDialog1.Color;
           }
        }

        private void btn_color_changable_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_color_changable.BackColor = colorDialog1.Color;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Settings1.Default.HexagranColorGeneral = txt_color_general.BackColor;
            Settings1.Default.HexagramColorChangable = txt_color_changable.BackColor;
            Settings1.Default.Language = comboBox1.SelectedIndex;
            Settings1.Default.StorageDirPath = txtDefaultStoragePath.Text;
            Settings1.Default.PreferedMethod = cbb_prefered_method.SelectedIndex;
            Settings1.Default.Save();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowser = new System.Windows.Forms.FolderBrowserDialog();

            folderBrowser.Description = "Select the directory that you want to use as the default.";
            folderBrowser.RootFolder = Environment.SpecialFolder.Personal;

            DialogResult result = folderBrowser.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDefaultStoragePath.Text = folderBrowser.SelectedPath.ToString();
            }
        }

    }
}
