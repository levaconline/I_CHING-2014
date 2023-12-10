using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace ICHING
{
    public partial class Main : Form
    {
        /**
         * Total rods
         * */
        private int totalRods = 50;

        // Here will be placed one special rod
        private int placeForOneSpecialRod = 0;

        // Places during divisions
        private int leftHand = 0;
        private int rightHand = 0;
        private int leftPlace = 0;
        private int rightPlace = 0;
        private int oneFromRightHand = 0;

        public static int mainHexagramId = 0;
        public static int secondHexagramId = 0;

        private int[][] divisionValues = new int[6][] 
        {
            new int[3]{0, 0, 0}, 
            new int[3]{0, 0, 0}, 
            new int[3]{0, 0, 0}, 
            new int[3]{0, 0, 0}, 
            new int[3]{0, 0, 0}, 
            new int[3]{0, 0, 0}
        };

        //private List<int[]> divisionValues = new List<int[]>();
        //public static int[] linesNumbersMain = new int[6]; // main hexagram
        //int[] linesNumbersSecond = new int[6]; // Second hexagram

        // Line position in pixels (y axis)
        private int pos = 0;
        private int pos1 = 0; // Second pane

        // Panel width
        private int panelWidth = 0;
        private int panelWidth1 = 0;

        // Pixels between 2 lines
        private int step = 0;
        private int step1 = 0; // Second pane

        // Line width
        private int lineWeight = 5;

        // Space in the changable line in percent %
        private int chspacerPercent = 20; // %
        private int spacer = 10; // Will be overriden in main
        private int spacer2 = 10; // Second pane. Will be owerriten

        // Using for timer
        private static int conter = 0;
        private int counterStartVal = 0;
        private int counterEndVal = 0;

        // We should to prevent starting counter from zero due to we should avoid to have all rods in one hand. (This value is in percent: %).
        private int variance = 20;

        // Division (1-3) for making one line
        private int division = 1;

        // Line number (everu line has 3 division)
        private int line = 1;

        // Calculated code line
        private int lineCode = 0; 

        // Prepare pen 
        Pen pen; 
        Pen penGeneral; 
        Pen penChangable; 

        public static System.Timers.Timer aTimer;
        delegate void SetTextCallback(string count);

        public Main()
        {
            InitializeComponent();

            // Take one rod
            takeOneRod();

            penGeneral = new Pen(Settings1.Default.HexagranColorGeneral, lineWeight);
            penChangable = new Pen(Settings1.Default.HexagramColorChangable, lineWeight);

            initMainPane();
            initSecondPane();

            counterStartVal = (int)Math.Round(Convert.ToDecimal(totalRods - 1) / 100 * variance);
            counterEndVal = totalRods - counterStartVal;

            aTimer = new System.Timers.Timer(1);
            aTimer.Enabled = true;
            aTimer.Stop();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            
        }

        private void initMainPane()
        {
            // Start position of drawing hexagram will be bottom position of panel
            pos = panel1.Height - lineWeight;

            // Calculate step (distance between lines according to panel height
            decimal s = pos / 6;
            step = (int)Math.Floor(s);

            // Panel width
            panelWidth = panel1.Width;

            // Calculate space in changable line (according to percent: chspacerPercent)
            spacer = (int)Math.Ceiling((double)(panelWidth / 100 * chspacerPercent / 2));
        }

        private void initSecondPane()
        {
            // Start position of drawing hexagram will be bottom position of panel
            pos1 = panel2.Height - lineWeight;

            // Calculate step (distance between lines according to panel height
            decimal s = pos1 / 6;
            step1 = (int)Math.Floor(s);

            // Panel width
            panelWidth1 = panel2.Width;

            // Calculate space in changable line (according to percent: chspacerPercent)
            spacer2 = (int)Math.Ceiling((double)(panelWidth1 / 100 * chspacerPercent / 2));
        }
        
        public void setQuestion(String question)
        {
            lbl_question_subject.Text = question;
        }

        private void btn_processor_Click(object sender, EventArgs e)
        {

            Console.WriteLine("-----------------------");
            Console.WriteLine("Line: " + line);
            Console.WriteLine("Division: " + division);
            Console.WriteLine("Counter: " + conter);

            leftHand = conter;
            rightHand = totalRods - conter;
            Console.WriteLine("Left hand: " + leftHand);
            Console.WriteLine("Right hand: " + rightHand);
            Console.WriteLine("           --");
            Console.WriteLine("Total rods: " + totalRods);
            Console.WriteLine(" ");

            // Take one rod from right hand
            oneFromRightHand = rightHand - (rightHand - 1);
            rightHand = rightHand - oneFromRightHand;
            Console.WriteLine("Right hand - 1: " + rightHand);

            // Lefthand calculations
            float ld = (float)leftHand % (float)4;
            Console.WriteLine("Left % 4: " + leftHand + " % 4 = " + ld.ToString());
            if(ld > 0){
                Console.WriteLine("Left / 4: " + ld.ToString());
                leftPlace = (int)ld;
                Console.WriteLine("Left: " + leftPlace.ToString());
            }else{
                leftPlace = 4;
            }

            // Right hand calculations
            float rd = (float)rightHand % (float)4;
            Console.WriteLine("Right % 4: " + rightHand + " % 4 = " + rd.ToString());
            if (rd > 0)
            {
                Console.WriteLine("Right / 4: " + rd.ToString());
                rightPlace = (int)rd;
                Console.WriteLine("Right: " + rightPlace.ToString());
            }
            else
            {
                rightPlace = 4;
            }

            Console.WriteLine("Final: " + oneFromRightHand + ", " + leftPlace + ", " + rightPlace);
            Console.WriteLine(" ");

            // Add results
            divisionValues[line - 1][division - 1] = oneFromRightHand + leftPlace + rightPlace; // ;
            totalRods = totalRods - divisionValues[line - 1][division - 1];

            // Free hands
            oneFromRightHand = oneFromRightHand - oneFromRightHand; // Procedural 0
            leftPlace = leftPlace - leftPlace;
            rightPlace = rightPlace - rightPlace;

            // Count division
            division++;
            if (division > 3) 
            {
                // Free places
                totalRods = totalRods + divisionValues[line-1][0] + divisionValues[line-1][1] + divisionValues[line-1][2];
                Console.WriteLine("Division1: " + divisionValues[line-1][0]);
                Console.WriteLine("Division2: " + divisionValues[line-1][1]);
                Console.WriteLine("Division3: " + divisionValues[line-1][2]);
                Console.WriteLine("For new line: " + totalRods);
                Console.WriteLine(" ");

                lineCode = divisionValues[line - 1][0] + divisionValues[line - 1][1] + divisionValues[line - 1][2];

                Console.WriteLine("Write line: " + lineCode);
                /**
                Depending on the combinations of sticks you will have either a Yang line indicated by a solid line ( ______ ) or a Yin line, indicated by a broken line ( ___ ___ )

                5+4+4 - Old Yang line ---
                9+8+8 - Old Yin line  - -

                5+8+8 - Young Yang line ---
                9+8+4 - Young Yang line ---
                9+4+8 - Young Yang line ---
                 * 
                5+4+8 - Young Yin line  - -
                5+8+4 - Young Yin line  - -
                9+4+4 - Young Yin line  - - 
                 * */
                
                if (lineCode == 13 )
                {
                    // Old Yang 9 _____
                    drawLine("changable_compact", 1, line);
                    drawLine("simple_light", 2, line);
                    IChing.linesNumbersMain[line - 1] = 9; // Nine is this line number
                    IChing.linesNumbersSecond[line - 1] = 8;
                }
                else if (lineCode == 25)
                {
                    // Old Yin 6 __ __
                    drawLine("changable_light", 1, line);
                    drawLine("simple_compact", 2, line);
                    IChing.linesNumbersMain[line - 1] = 6; // Six is this line number
                    IChing.linesNumbersSecond[line - 1] = 7;
                }
                else if (lineCode == 21)
                {
                    // Young Yang 7 _____
                    drawLine("simple_compact", 1, line);
                    drawLine("simple_compact", 2, line);
                    IChing.linesNumbersMain[line - 1] = 7; // Seven is this line number
                    IChing.linesNumbersSecond[line - 1] = 7;
                }
                else if (lineCode == 17)
                {
                    // Young Yin 8 __ __
                    drawLine("simple_light", 1, line);
                    drawLine("simple_light", 2, line);
                    IChing.linesNumbersMain[line - 1] = 8; // Eight is this line number
                    IChing.linesNumbersSecond[line - 1] = 8;
                }

                division = 1;
                line++;
            }

            // Reset Timer count
            counterStartVal = (int)Math.Round(Convert.ToDecimal(totalRods) / 100 * variance);
            counterEndVal = totalRods - counterStartVal;
            conter = counterStartVal;
            Console.WriteLine("Counter start val: " + counterStartVal);
            Console.WriteLine("Counter end val: " + counterEndVal);

            if (line > 6)
            { 
                btn_processor.Enabled = false;
                aTimer.Stop();

                IChing.datetimeOfQuestion = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                mainHexagramId = getHexagramId(IChing.linesNumbersMain);
                secondHexagramId = getHexagramId(IChing.linesNumbersSecond);
                IChing.mainHexahramId = mainHexagramId;
                IChing.inverseHexagramId = secondHexagramId;

                Console.WriteLine("Main: " + mainHexagramId);
                Console.WriteLine("Inverse: " + secondHexagramId);

                lblMainHexagramId.Text = mainHexagramId.ToString();
                lblSecondHexagramId.Text = secondHexagramId.ToString();

                lbl_question_subject.Text = IChing.questionSubject;

                /**
                // Get texts from DB
                IChing.lineComments = "";
                string mainText = getText(mainHexagramId, IChing.linesNumbersMain, true);
                string secondHexagramText = getText(secondHexagramId, IChing.linesNumbersSecond, false);

                // Fill the rich text box
                rtText.Text = mainText + "\r\n\r\n" + secondHexagramText;

                rtText.Visible = true;
                */

                Form interpretation = new Interpretation();
                interpretation.MdiParent = ParentForm;
                //interpretation.rtbInterpretation.Text = rtText.Text;
                //interpretation.rtbInterpretation.Text = 
                interpretation.Show();
                //this.Close();
            }


            /**
            drawLine("simple_compact", 1);
            drawLine("simple_compact", 2);
            //drawLine("simple_compact", 3);
            //drawLine("simple_light", 4);
            //drawLine("simple_light", 5);
            //drawLine("simple_light", 6);
            drawLine("changable_compact", 3);
            drawLine("changable_light", 4);
            drawLine("simple_compact", 5);
            drawLine("simple_compact", 6);
             * */
       }

        private void takeOneRod() {
            placeForOneSpecialRod = totalRods - 49;
            totalRods = totalRods - placeForOneSpecialRod;
        }

        /**
        private string getText(int hexagramId, int[] changableLines, bool isMainHexagram)
        {
            string ichingText = "";
            int counter = 2; // Start from 2 because of colimns about line comments in table not start from 0

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            String connection = Settings1.Default.ConnectionString; //"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\Ichi.mdb"; //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\Tables.accdb;Persist Security Info=True";
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
                ichingText = reader[1].ToString() + "\r\n\r\n" + reader[2].ToString() + "\r\n\r\n";

                if (isMainHexagram)
                {
                    lblMainHexagramName.Text = reader[1].ToString();
                    IChing.mainHexagramTitle = lblMainHexagramName.Text;
                    IChing.mainHexagramText = reader[2].ToString();

                    foreach (int lineNumber in changableLines)
                    {
                        counter++;
                        if (lineNumber == 9 || lineNumber == 6)
                        {
                            ichingText += "\r\n\r\n" + reader[counter].ToString();
                            IChing.lineComments += "\r\n\r\n" + reader[counter].ToString();
                        }
                    }
                }
                else
                {
                    lblSecondHexagramName.Text = reader[1].ToString();
                    IChing.inverseHexagramTitle = lblSecondHexagramName.Text;
                    IChing.inverseHexagramText = reader[2].ToString();
                }

            }
            conn.Close();

            return ichingText;
        }
         * **/

        public void Main_Load(object sender, EventArgs e)
        {

        }

        public void drawLine(String type, int pane, int position) {

            // Convert position to height px
            int y = 0;
            if (pane == 1)
            {
                y = pos - (position - 1) * step;
            } else {
                y = pos1 - (position - 1) * step1;
            }

            if (type == "simple_compact" || type == "changable_compact")
            {
                if (type == "simple_compact")
                {
                    pen = penGeneral;
                }
                else if (type == "changable_compact")
                {
                    pen = penChangable;
                }
                else
                {
                    // Unsuported
                }

                if (pane == 1)
                {
                    Graphics line = panel1.CreateGraphics();
                    line.DrawLine(pen, new Point(0, y), new Point(panelWidth, y));
                }
                else
                {
                    Graphics line = panel2.CreateGraphics();
                    line.DrawLine(pen, new Point(0, y), new Point(panelWidth1, y));
                }
            }
            else if (type == "simple_light" || type == "changable_light")
            {
                int firstEnd = 0;
                int secondVeginning = 0;
                if (pane == 1)
                {
                    firstEnd = panelWidth / 2 - spacer;
                    secondVeginning = panelWidth / 2 + spacer;
                }
                else
                {
                    firstEnd = panelWidth1 / 2 - spacer;
                    secondVeginning = panelWidth1 / 2 + spacer;
                }

                if (type == "simple_light")
                {
                    pen = penGeneral;
                }
                else if (type == "changable_light")
                {
                    pen = penChangable;
                }
                else
                {
                    // Unsuported
                }
                if (pane == 1)
                {
                    Graphics line = panel1.CreateGraphics();
                    line.DrawLine(pen, new Point(0, y), new Point(firstEnd, y));
                    line.DrawLine(pen, new Point(secondVeginning, y), new Point(panelWidth, y));
                }
                else
                {
                    Graphics line = panel2.CreateGraphics();
                    line.DrawLine(pen, new Point(0, y), new Point(firstEnd, y));
                    line.DrawLine(pen, new Point(secondVeginning, y), new Point(panelWidth1, y));
                }
            }
        }

        public static void setQuestionSubject(string questionSubject)
        {
            //lbl_question_subject.Text = questionSubject;
        }


        private void SetText(String count)
        {
            if (this.lbl_question_subject.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { count });
            }
            else
            {
                this.lbl_question_subject.Text = count;
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            conter++;
            Console.WriteLine(conter);
            if (conter > counterEndVal)
            {
                conter = counterStartVal;
            }
            SetText(conter.ToString());
        }

        private int getHexagramId(Array lineNumbers)
        {
            Console.WriteLine("\r\nLines...");
            //Console.WriteLine(lineNumbers.ToString());
            //Console.WriteLine(lineNumbers);

            int id = 0;
            string mainHexahramLineNumbers = "";

            foreach (int no in lineNumbers)
            {
                Console.WriteLine(no);
                if (no == 9)
                {
                    mainHexahramLineNumbers += "7";
                }
                else if (no == 6)
                {
                    mainHexahramLineNumbers += "8";
                }
                else
                {
                    mainHexahramLineNumbers += no.ToString();
                }
            }

            int iexagramInt = Convert.ToInt32(mainHexahramLineNumbers);

            switch (iexagramInt)
            {
                    /** 777777
                     * _____
                     * _____
                     * _____
                     * _____
                     * _____
                     * _____
                     **/
                case 777777:
                    id = 1;
                    break;

                /** 888888
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 **/
                case 888888:
                    id = 2;
                    break;

                /** 788878
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 **/
                case 788878:
                    id = 3;
                    break;

                /** 878887
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 **/
                case 878887:
                    id = 4;
                    break;

                /** 777878
                 * __ __
                 * _____
                 * __ __
                 * _____
                 * _____
                 * _____
                 **/
                case 777878:
                    id = 5;
                    break;

                /** 878777
                 * _____
                 * _____
                 * _____
                 * __ __
                 * _____
                 * __ __
                 **/
                case 878777:
                    id = 6;
                    break;

                /** 878888
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 **/
                case 878888:
                    id = 7;
                    break;

                /** 888878
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 **/
                case 888878:
                    id = 8;
                    break;

                /** 777877
                 * _____
                 * _____
                 * __ __
                 * _____
                 * _____
                 * _____
                 **/
                case 777877:
                    id = 9;
                    break;

                /** 778777
                 * _____
                 * _____
                 * _____
                 * __ __
                 * _____
                 * _____
                 **/
                case 778777:
                    id = 10;
                    break;

                /** 777888
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 * _____
                 * _____
                 **/
                case 777888:
                    id = 11;
                    break;

                /** 888777
                 * _____
                 * _____
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 **/
                case 888777:
                    id = 12;
                    break;

                /** 787777
                 * _____
                 * _____
                 * _____
                 * _____
                 * __ __
                 * _____
                 **/
                case 787777:
                    id = 13;
                    break;

                /** 777787
                 * _____
                 * __ __
                 * _____
                 * _____
                 * _____
                 * _____
                 **/
                case 777787:
                    id = 14;
                    break;

                /** 887888
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 **/
                case 887888:
                    id = 15;
                    break;

                /** 888788
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 **/
                case 888788:
                    id = 16;
                    break;

                /** 788778
                 * __ __
                 * _____
                 * _____
                 * __ __
                 * __ __
                 * _____
                 **/
                case 788778:
                    id = 17;
                    break;

                /** 877887
                 * _____
                 * __ __
                 * __ __
                 * _____
                 * _____
                 * __ __
                 **/
                case 877887:
                    id = 18;
                    break;

                /** 778888
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 * _____
                 **/
                case 778888:
                    id = 19;
                    break;

                /** 888877
                 * _____
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 **/
                case 888877:
                    id = 20;
                    break;

                /** 788787
                 * _____
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 * _____
                 **/
                case 788787:
                    id = 21;
                    break;

                /** 788787
                 * _____
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 * _____
                 **/
                case 787887:
                    id = 22;
                    break;

                /** 888887
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 **/
                case 888887:
                    id = 23;
                    break;

                /** 788888
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 **/
                case 788888:
                    id = 24;
                    break;

                /** 788777
                 * _____
                 * _____
                 * _____
                 * __ __
                 * __ __
                 * _____
                 **/
                case 788777:
                    id = 25;
                    break;

                /** 777887
                 * _____
                 * __ __
                 * __ __
                 * _____
                 * _____
                 * _____
                 **/
                case 777887:
                    id = 26;
                    break;

                /** 788887
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 **/
                case 788887:
                    id = 27;
                    break;

                /** 788887
                 * __ __
                 * _____
                 * _____
                 * _____
                 * _____
                 * __ __
                 **/
                case 877778:
                    id = 28;
                    break;

                /** 878878
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 **/
                case 878878:
                    id = 29;
                    break;

                /** 787787
                 * _____
                 * __ __
                 * _____
                 * _____
                 * __ __
                 * _____
                 **/
                case 787787:
                    id = 30;
                    break;

                /** 887778
                 * __ __
                 * _____
                 * _____
                 * _____
                 * __ __
                 * __ __
                 **/
                case 887778:
                    id = 31;
                    break;

                /** 877788
                 * __ __
                 * __ __
                 * _____
                 * _____
                 * _____
                 * __ __
                 **/
                case 877788:
                    id = 32;
                    break;

                /** 887777
                 * _____
                 * _____
                 * _____
                 * _____
                 * __ __
                 * __ __
                 **/
                case 887777:
                    id = 33;
                    break;

                /** 777788
                 * __ __
                 * __ __
                 * _____
                 * _____
                 * _____
                 * _____
                 **/
                case 777788:
                    id = 34;
                    break;

                /** 888787
                 * _____
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 **/
                case 888787:
                    id = 35;
                    break;

                /** 787888
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 * _____
                 **/
                case 787888:
                    id = 36;
                    break;

                /** 787877
                 * _____
                 * _____
                 * __ __
                 * _____
                 * __ __
                 * _____
                 **/
                case 787877:
                    id = 37;
                    break;

                /** 778787
                 * _____
                 * __ __
                 * _____
                 * __ __
                 * _____
                 * _____
                 **/
                case 8787877:
                    id = 38;
                    break;

                /** 887878
                 * __ __
                 * _____
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 **/
                case 887878:
                    id = 39;
                    break;

                /** 878788
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 * _____
                 * __ __
                 **/
                case 878788:
                    id = 40;
                    break;

                /** 778887
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 * _____
                 **/
                case 778887:
                    id = 41;
                    break;

                /** 788877
                 * _____
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 **/
                case 788877:
                    id = 42;
                    break;

                /** 777778
                 * __ __
                 * _____
                 * _____
                 * _____
                 * _____
                 * _____
                 **/
                case 777778:
                    id = 43;
                    break;

                /** 877777
                 * _____
                 * _____
                 * _____
                 * _____
                 * _____
                 * __ __
                 **/
                case 877777:
                    id = 44;
                    break;

                /** 888778
                 * __ __
                 * _____
                 * _____
                 * __ __
                 * __ __
                 * __ __
                 **/
                case 888778:
                    id = 45;
                    break;

                /** 877888
                 * __ __
                 * __ __
                 * __ __
                 * _____
                 * _____
                 * __ __
                 **/
                case 877888:
                    id = 46;
                    break;

                /** 878778
                 * __ __
                 * _____
                 * _____
                 * __ __
                 * _____
                 * __ __
                 **/
                case 878778:
                    id = 47;
                    break;

                /** 877878
                 * __ __
                 * _____
                 * __ __
                 * _____
                 * _____
                 * __ __
                 **/
                case 877878:
                    id = 48;
                    break;

                /** 787778
                 * __ __
                 * _____
                 * _____
                 * _____
                 * __ __
                 * _____
                 **/
                case 787778:
                    id = 49;
                    break;

                /** 877787
                 * _____
                 * __ __
                 * _____
                 * _____
                 * _____
                 * __ __
                 **/
                case 877787:
                    id = 50;
                    break;

                /** 788788
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 * _____
                 **/
                case 788788:
                    id = 51;
                    break;

                /** 887887
                 * _____
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 **/
                case 887887:
                    id = 52;
                    break;

                /** 887877
                 * _____
                 * _____
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 **/
                case 887877:
                    id = 53;
                    break;

                /** 778788
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 * _____
                 * _____
                 **/
                case 778788:
                    id = 54;
                    break;

                /** 778788
                 * __ __
                 * __ __
                 * _____
                 * _____
                 * __ __
                 * _____
                 **/
                case 787788:
                    id = 55;
                    break;

                /** 887787
                 * _____
                 * __ __
                 * _____
                 * _____
                 * __ __
                 * __ __
                 **/
                case 887787:
                    id = 56;
                    break;

                /** 877877
                 * _____
                 * _____
                 * __ __
                 * _____
                 * _____
                 * __ __
                 **/
                case 877877:
                    id = 57;
                    break;

                /** 778778
                 * __ __
                 * _____
                 * _____
                 * __ __
                 * _____
                 * _____
                 **/
                case 778778:
                    id = 58;
                    break;

                /** 878877
                 * _____
                 * _____
                 * __ __
                 * __ __
                 * _____
                 * __ __
                 **/
                case 878877:
                    id = 59;
                    break;

                /** 778878
                 * __ __
                 * _____
                 * __ __
                 * __ __
                 * _____
                 * _____
                 **/
                case 778878:
                    id = 60;
                    break;

                /** 778877
                 * _____
                 * _____
                 * __ __
                 * __ __
                 * _____
                 * _____
                 **/
                case 778877:
                    id = 61;
                    break;

                /** 887788
                 * __ __
                 * __ __
                 * _____
                 * _____
                 * __ __
                 * __ __
                 **/
                case 887788:
                    id = 62;
                    break;

                /** 787878
                 * __ __
                 * _____
                 * __ __
                 * _____
                 * __ __
                 * _____
                 **/
                case 787878:
                    id = 63;
                    break;

                /** 878787
                 * _____
                 * __ __
                 * _____
                 * __ __
                 * _____
                 * __ __
                 **/
                case 878787:
                    id = 64;
                    break;

                default:
                    id = 0;
                    break;

            }

            return id;
        }
    }
}
