using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFM_CLEANING
{
    public partial class Form1 : Form
    {
        Connection con = new Connection();
        bool isStart = false;
        public static int count = 9;
        public static int counter;

        public Form1()
        {
            InitializeComponent(); 
        }

        private void startBtn_Click(object sender, EventArgs e)
        { 
            if ((firstlotLBL.Text.Trim() != "" || secondlotLBL.Text.Trim() != "") && counter < count)
            {
                counter += 1;
                changeCounter();
                isStart = true;
                
                DateTime time = DateTime.Now;
                string sqlFormattedDate = time.ToString("yyyy-MM-dd HH:mm:ss.fff");

                startimeLBL.Text = DateTime.Now.ToString();
                string query = "insert into pd.dbo.tbl_F1clean (startTime,LotNo,cycleCount,Process) values ('"+ time + "','"+ firstlotLBL.Text + "','" + counter + "','" + label1.Text + "' )";
                con.ExecuteScalar(query);

                //string query2 = "insert into pd.dbo.tbl_F1clean (startTime,LotNo,cycleCount,Process) values ('" + time + "','" + secondlotLBL.Text + "','" + counter + "','" + label1.Text + "' )";
                //con.ExecuteScalar(query2);
                disableFirst();
            }
            else if(counter-1==count)
            {
                counter = 0;
            }
            else if (String.IsNullOrEmpty(firstlotLBL.Text) || String.IsNullOrEmpty(secondlotLBL.Text))
            {
                MessageBox.Show("Sila Input Lot No");
            }
            
        }

        //ALLOW BOTH TEXT BOX1 AND TEXT BOX2 TO ENTER

        private void switcher()
        {
            DateTime time = DateTime.Now;
            string sqlFormattedDate = time.ToString("yyyy-MM-dd HH:mm:ss.fff");

            secondlotLBL.Text = firstlotLBL.Text;

            firstlotLBL.Enabled = true;
            secondlotLBL.Enabled = true;

            string query = "update pd.dbo.tbl_F1clean set endTime = '"+ time + "' where LotNo in ('"+ secondlotLBL.Text + "','" + firstlotLBL.Text + "') ";
            con.ExecuteScalar(query);

            firstlotLBL.Text = "";
            secondlotLBL.Text = "";
        }
        private void disableFirst()
        {
            if(isStart == true)
            {
                firstlotLBL.Enabled = false;
                secondlotLBL.Enabled = false;
            }
        }

        private void endBTN_Click(object sender, EventArgs e)
        {
            if (firstlotLBL.Text.Trim() != "" || secondlotLBL.Text.Trim() != "")
            {
                switcher();
                endTimeLBL.Text = DateTime.Now.ToString();
            }
            else
                MessageBox.Show("Sila Enter Lot No");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            passcode p = new passcode();
            p.ShowDialog();
            this.Hide();
        }
        //PASSING LABELS AS A STATIC AKA GLOBAL VARIABLE
        public static void changeLabel(string word, int integer)
        {
            Form1 form = new Form1();
            form.label1.Text = word;
            counter = integer;
            form.Show();  
        }
        public static void resetCounter(int integer,int count1)
        {
            Form1 form = new Form1();
            counter = integer;
            count = count1;
            form.Show();
        }
        public void changeCounter()
        {
            string counter1 = counter.ToString().PadLeft(3, '0');

            counterLBL1.Text = counter1[2].ToString();
            counterLBL2.Text = counter1[1].ToString();
            counterLBL3.Text = counter1[0].ToString();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }
    }
}
