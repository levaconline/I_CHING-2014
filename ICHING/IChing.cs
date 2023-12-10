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
    public partial class IChing : Form
    {
        public static string confFile = "config.conf";

        public static string questionSubject = "";
        public static string questionDescription = "";
        public static int mainHexahramId = 0;
        public static int inverseHexagramId = 0;
        public static string mainHexagramTitle = "";
        public static string mainHexagramText = "";
        public static string lineComments = "";
        public static string inverseHexagramTitle = "";
        public static string inverseHexagramText = "";
        public static string datetimeOfQuestion = "";

        public static int[] linesNumbersMain = new int[6]; // main hexagram
        public static int[] linesNumbersSecond = new int[6]; // Second hexagram

        //Settings from config.conf file
        //public static int color_general = -1;
        //public static int color_changable = -2001;

        public static int language = 1;
        public static System.Drawing.Color color_general;
        public static System.Drawing.Color color_changable;

        public static int preferred_method = 0;
        public static string default_storage_path = "";

        public static System.Windows.Forms.SaveFileDialog saveFileDialog;

        public IChing()
        {
            InitializeComponent();
            language = Convert.ToInt32(Properties.Settings.Default.PropertyValues["language"]);
            color_general = Settings1.Default.HexagranColorGeneral;
            color_changable = Settings1.Default.HexagramColorChangable;
            preferred_method = Settings1.Default.PreferedMethod;
            default_storage_path = Settings1.Default.StorageDirPath;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Don't do this. This is slow.
           // this.menuStrip1.Items[0].MouseHover += new EventHandler(Form1_MouseHover);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.MdiParent = this;
            main.Show();

            Question question = new Question();
            question.ShowDialog();

            closeToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
            exportToolStripMenuItem.Enabled = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        public static void setQuestionSubject(string subject)
        {
            Main.setQuestionSubject(subject);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null) { 
                this.ActiveMdiChild.Close();
                closeControl();
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeControl();
        }

        void Form1_MouseHover(object sender, EventArgs e)
        {
            closeControl();
        }

        protected void closeControl()
        {
            // Controll Close option from File menu (Enabled/Disabled)
            if (this.ActiveMdiChild != null)
            {
                closeToolStripMenuItem.Enabled = true;
            }
            else
            {
                closeToolStripMenuItem.Enabled = false;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            int userId = 0;
            userId = getUserId(userName);

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            String connection = Settings1.Default.ConnectionString; // "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Ichi.mdb";
            conn.ConnectionString = connection;


            int counter = 0;
            string changableLines = "";
            foreach (int i in linesNumbersMain) {
                counter++;
                if (i == 6 || i == 9) {
                    changableLines += counter + ",";
                }

            }

            string sqlMain = "INSERT INTO Questions (user_id, qsubject, qdetails, main_hexagram_id, changable_lines, second_hexagram_id, asked) VALUES (@UserId,'" + questionSubject + "','" + questionDescription + "'," + Main.mainHexagramId + ",'" + changableLines + "'," + Main.secondHexagramId + ",#" + datetimeOfQuestion + "#);";

            Console.WriteLine(sqlMain);
            

            //DataSet ds = new DataSet();

            System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(sqlMain, conn);
            command.Connection = conn;
            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                command.Parameters.Add("@UserId", System.Data.OleDb.OleDbType.Numeric).Value = userId; ;
                //command.CommandText = sqlMain;
                int result = command.ExecuteNonQuery();
                Console.WriteLine("Result: " + result);
                conn.Close();
            }
        }

        private int getUserId(string userName)
        {
            int id = 0;

            // Try to find user in database. If user not exist, create it and return created id.
            System.Data.OleDb.OleDbConnection conn1 = new System.Data.OleDb.OleDbConnection();
            conn1.ConnectionString = Settings1.Default.ConnectionString;
            string sql = "SELECT * FROM Users WHERE username = '" + userName  + "'";
            conn1.Open();

            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(sql, conn1);

            adapter.Fill(ds);

            DataTableReader dtr = ds.CreateDataReader();

            dtr.Read();

            if (dtr.HasRows)
            {
                id = Convert.ToInt32(dtr[0]);
            }
            else
            {
                string insSql = "INSERT INTO Users (username) VALUES ('" + userName  + "');";
                System.Data.OleDb.OleDbCommand command1 = new System.Data.OleDb.OleDbCommand(insSql, conn1);
                command1.Connection = conn1;
                id = command1.ExecuteNonQuery();
            }

            conn1.Close();

            return id;
        }

        private void saveFileDialogs(String text, string extenzion)
        {
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.InitialDirectory = Settings1.Default.StorageDirPath;

            saveFileDialog.Filter = extenzion + " files (*." + extenzion + ")|*." + extenzion  + "|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(@saveFileDialog.FileName, text);
            }
        }

        private void editTheBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IchiEditor IChingEditor = new IchiEditor();
            IChingEditor.MdiParent = this;
            IChingEditor.Show();

            closeToolStripMenuItem.Enabled = true;
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchiveRaw archiveRaw = new ArchiveRaw();
            archiveRaw.MdiParent = this;
            archiveRaw.Show();

            closeToolStripMenuItem.Enabled = true;
        }

        private void asTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sourcePath = Settings1.Default.StorageDirPath;
            string fileName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + ".txt";
            string source = "";

            source += "\r\n" + questionSubject + "\r\n\r\n";
            source += questionDescription + "\r\n";
            source += "*****************************************************************************************************\r\n\r\n";
            source += mainHexahramId + "\r\n";
            source += mainHexagramTitle + "\r\n\r\n";
            source += mainHexagramText + "\r\n\r\n";
            source += lineComments + "\r\n-----------------------------------------------\r\n\r\n";
            source += inverseHexagramId + "\r\n";
            source += inverseHexagramTitle + "\r\n\r\n";
            source += inverseHexagramText + "\r\n\r\n---------------------\r\n";
            source += datetimeOfQuestion + "\r\n";

            saveFileDialogs(source, "txt");

        }

        private void textsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form interpretation = new Interpretation();
            interpretation.MdiParent = this;
            interpretation.Show();

            closeToolStripMenuItem.Enabled = true;
        }

    }
}
