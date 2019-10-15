using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFM_CLEANING
{
    public partial class TabPress : Form
    {
        private int lotcount = 0;
        public static int TBshotcounter = 0;
        public static int TBmaxShot = 2996400;
        public static bool TBcounter = false;
        public static int GBmaxShot = 4999100;
        public static int GBshotcounter = 0;
        public static bool GBcounter = false;


        private DateTime endtime;
        private DateTime startTime; 
        private const int hour = 8; 
        Stopwatch stopwatch1 = new Stopwatch();
        private bool eightHour = false;
        private int check = 0;
        Connection con = new Connection();

        public TabPress()
        {
            InitializeComponent();
            button2.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {  
            if(lotnoTBX.Text == "" || imiTBX.Text == "")
            {
                MessageBox.Show("Sila Enter Lot No dan IMI");
            }
            else
            { 
                button1.Enabled = false;
                button2.Enabled = true;
                startTime = DateTime.Now; 
                timestart.Text = startTime.ToString();
            } 
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            TimeSpan start = TimeSpan.Zero;
            TimeSpan add = new TimeSpan(0,0,1); 
            TimeSpan combined = start.Add(TimeSpan.FromSeconds(1));
             
             


            //if (stopwatch1.ElapsedMilliseconds < (1000 * 60 * 60 * 8))
            //{
                
            //}
            //else
            //{
                timer1.Stop();
                stopwatch1.Stop();
                TimerStop(); 
            //    CleaningBox clean = new CleaningBox();
            //    clean.Show();
            //    clean.alarm();


            //    //if (clean.buttonclicked == true)
            //    //{
            //    //    clean.stopSound();
            //    //}

            //    stopwatch1.Reset(); 
            //    eightHour = true;
            //}
            //MessageBox.Show("The form will now be closed.", "Time Elapsed");
            //this.Close();
        }

        public void TimerStart()
        {
            DateTime startTime = DateTime.Now;
            timer1.Start();
        }

        public void TimerStop()
        {
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (shotCount(lprTBX.Text) == true)
            {
                TBshotcounter += Convert.ToInt32(lprTBX.Text)/4;
                GBshotcounter += Convert.ToInt32(lprTBX.Text);
                 
                //GBshotcounter = TBshotcounter;
                if (GBshotcounter < GBmaxShot && TBshotcounter < TBmaxShot)
                { 
                    TimerStart();
                    button1.Enabled = true;
                    timeend.Text = DateTime.Now.ToString();
                    stopwatch1.Start();

                    GBtotalLBL.Text = GBshotcounter.ToString();
                     
                    //if (GBshotcounter != 0)
                    //{
                    //    TBshotcounter += TBshotcounter + (GBshotcounter / 4);
                    //}
                    //else
                    //    GBshotcounter = 0;
                    tbtotalLBL.Text = TBshotcounter.ToString();
                    //tbtotalLBL.Text = tabpress.ToString();
                    updAll();
                    clearAll();
                }
                else if (GBshotcounter >= GBmaxShot || TBshotcounter >= TBmaxShot)
                {
                    GBtotalLBL.Text = GBshotcounter.ToString();
                    //int tabpress2 = 0;
                    //if (GBshotcounter != 0)
                    //{
                    //    TBshotcounter += GBshotcounter / 4;
                    //}
                    //else
                    //    GBshotcounter = 0;
                    tbtotalLBL.Text = TBshotcounter.ToString();

                    CleaningBox clean = new CleaningBox();
                    clean.Show();
                    clean.alarm();

                    if (GBshotcounter >= GBmaxShot)
                    {
                        GBshotcounter = 0;
                    }
                    if (TBshotcounter >= TBmaxShot)
                    {
                        TBshotcounter = 0;
                    }
                     

                    button1.Enabled = true;
                    updAll();
                    clearAll();
                }  
            }
            else
            {
                MessageBox.Show("Sila Enter Nombor");
            }

        }
        public static void changeQTY(int two)
        {
            //TabPress.TBmaxShot = one;
            TabPress.TBshotcounter = two; 

            TabPress form = new TabPress();
            form.Show(); 
        }

        public void updAll()
        {
            con.OpenConnection();
            int tabpress = 0;

            if (GBshotcounter != 0)
            {
                tabpress = GBshotcounter / 4;
            }
            else
                GBshotcounter = 0;

            string query = "Insert into tbl_cleaning " +
                "values ('" + dateTimeValue.Text + "','" + empTBX.Text + "','" + imiTBX.Text + "','" + lotnoTBX.Text + "'" +
                ",'" + startTime + "','" + endtime + "','" + lprTBX.Text + "','" + actualTBX.Text + "','" + TBshotcounter + "'" +
                ",'" + label1.Text + "','" + tabpress + "') ";

            con.ExecuteScalar(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lotcount += 1;
            
            if (lotcount == 12)
            {
                CleaningBox clean = new CleaningBox();
                lotcount = 0;  
                stopwatch1.Reset(); 
                clean.Show();
                clean.alarm();

                //if (clean.buttonclicked == true)
                //{
                //    clean.stopSound();
                //}
            } 
            updAll();
            clearAll();
        }

        public bool shotCount(string inNumber)
        {
            int x;
            bool success = false;

            if (int.TryParse(inNumber, out x) == true)
            {
                success = true;
                return success; 
            }
            else
            {
                MessageBox.Show("Sila Enter Nombor");
                return success;
            }
            
        }

        public void clearAll()
        { 
            actualTBX.Text = "";
            lprTBX.Text = ""; 
            lotnoTBX.Text = "";
            imiTBX.Text = "";
            dateTimeValue.Text = "";
            empTBX.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View form = new View();
            form.Show(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string dateName = DateTime.Now.ToString("yyyymmdd") + "TABPRESS_CLEANING";

            con.tableToFile(retMonitor(), @"\\172.16.3.14\xv9000\TFM\"+ dateName + ".csv"); 
        }
        public DataTable retMonitor()
        {
            string query = "Select * from tbl_cleaning order by start_time desc";
            con.OpenConnection();
            return con.GrdVw(query);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CleaningBox clean = new CleaningBox();
            clean.stopSound();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TBcounter = true;
            passcode form = new passcode();
            form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }
    } 
}

