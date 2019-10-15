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
    public partial class GB : Form
    {
        private int lotcount = 0;
        public int GBmaxShot = 0;
        public int GBshotcounter = 0;
        public bool GBcounter = false;

        private DateTime startTime;
        private DateTime endtime;
        private const int hour = 8; 
        Stopwatch stopwatch1 = new Stopwatch();
        private bool eightHour = false;
        private int check = 0;
        Connection con = new Connection();

        public GB()
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
             
            
            label21.Text = stopwatch1.Elapsed.ToString();


            if (stopwatch1.ElapsedMilliseconds < (1000 * 60 * 60 * 8))
            {
                
            }
            else
            {
                timer1.Stop();
                stopwatch1.Stop();
                TimerStop(); 
                CleaningBox clean = new CleaningBox();
                clean.Show();
                clean.alarm();


                //if (clean.buttonclicked == true)
                //{
                //    clean.stopSound();
                //}

                stopwatch1.Reset(); 
                eightHour = true;
            }
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
            GBshotcounter += Convert.ToInt32(lprTBX.Text);
            if (GBshotcounter < GBmaxShot)
            {
                if (shotCount(lprTBX.Text) == true)
                {
                    TimerStart();
                    button1.Enabled = true;
                    timeend.Text = DateTime.Now.ToString();
                    stopwatch1.Start();
                    
                    totalLBL.Text = GBshotcounter.ToString();
                    updAll();
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Sila Enter Nombor");
                }
            }
            else if (GBshotcounter >= GBmaxShot)
            {
                CleaningBox clean = new CleaningBox();
                clean.Show();
                clean.alarm();
                GBmaxShot = 0;
            }

        }

        public static void changeQTY(int one, int two)
        {
            //GBmaxShot = one;
            //GBshotcounter = two;

            GB form = new GB();
            form.Show();
        }


        public void updAll()
        {
            con.OpenConnection();  

            string query = "Insert into tbl_cleaning " +
                "values ('"+ dateTimeValue.Text + "','" + empTBX.Text + "','" + imiTBX.Text + "','" + lotnoTBX.Text + "'" +
                ",'" + startTime + "','" + endtime + "','" + lprTBX.Text + "','" + actualTBX.Text + "','" + GBshotcounter + "'" +
                ",'" + label1.Text + "') ";

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
            string dateName = DateTime.Now.ToString("yyyymmdd") + "GB_CLEANING";

            con.tableToFile(retMonitor(), @"\\172.16.3.14\xv9000\TFM\"+ dateName + ".csv"); 
        }
        public DataTable retMonitor()
        {
            string query = "Select * from tbl_cleaning order by start_time desc";
            con.OpenConnection();
            return con.GrdVw(query);
        }

        public bool shotCount(string inNumber)
        { 
            int x;
            bool success = false;

            if (int.TryParse(inNumber, out x) == true && Convert.ToInt32(inNumber) < GBmaxShot)
            {
                success = true;
            }
            else
            {
                MessageBox.Show("Sila Enter Nombor");
            }
            return success;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CleaningBox clean = new CleaningBox();
            clean.stopSound();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GBcounter = true;
            passcode form = new passcode();
            form.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }
    } 
}

