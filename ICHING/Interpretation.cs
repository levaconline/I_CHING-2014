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
    public partial class Interpretation : Form
    {
        public Interpretation()
        {
            InitializeComponent();
        }

        private void Interpretation_Load(object sender, EventArgs e)
        {

            // Get texts from DB
            IChing.lineComments = "";
            rtbInterpretation.AppendText("\r\n");
            string mainText = getText(IChing.mainHexahramId, IChing.linesNumbersMain, true);
            string secondHexagramText = getText(IChing.inverseHexagramId, IChing.linesNumbersSecond, false);

            // Fill the rich text box
            //rtbInterpretation.
           // rtbInterpretation.Text = mainText + "\r\n\r\n" + secondHexagramText;

            rtbInterpretation.Visible = true;

        }

        private string getText(int hexagramId, int[] changableLines, bool isMainHexagram)
        {
            string ichingText = hexagramId + "  ";
            int counter = 2; 

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            String connection = Settings1.Default.ConnectionString; 
            string sqlMain = "SELECT * FROM Iching WHERE id = " + hexagramId;
            Console.WriteLine(sqlMain);
            conn.ConnectionString = connection;
            conn.Open();
            DataSet ds = new DataSet();
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(sqlMain, conn);
            adapter.Fill(ds);
            DataTableReader reader = ds.CreateDataReader();
            reader.Read();
            if (!reader.HasRows)
            {
                Console.WriteLine("Empty DataTableReader");
            }
            else
            {
                ichingText += reader[1].ToString() + "\r\n\r\n" + reader[2].ToString();

                // rtbInterpretation.ForeColor = Color.Azure;
                rtbInterpretation.SelectionFont = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                rtbInterpretation.AppendText(hexagramId + "  " + reader[1].ToString());

                rtbInterpretation.SelectionFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                rtbInterpretation.AppendText("\r\n\r\n" + reader[2].ToString() + "\r\n\r\n");

                if (isMainHexagram)
                {
                    IChing.mainHexagramTitle = reader[1].ToString(); 
                    IChing.mainHexagramText = reader[2].ToString();

                    foreach (int lineNumber in changableLines)
                    {
                        counter++;
                        if (lineNumber == 9 || lineNumber == 6)
                        {
                            ichingText += "\r\n\r\n" + reader[counter].ToString();
                            IChing.lineComments += "\r\n\r\n" + reader[counter].ToString();

                            rtbInterpretation.SelectionFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                            rtbInterpretation.AppendText(reader[counter].ToString() + "\r\n\r\n");
                        }
                    }
                }
                else
                {
                    IChing.inverseHexagramTitle = reader[1].ToString(); 
                    IChing.inverseHexagramText = reader[2].ToString();
                }

            }
            conn.Close();

            return ichingText;
        }
    }
}
