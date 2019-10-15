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
    public partial class CleaningBox : Form
    {
        DateTime now;
        string starttime;
        string endtime;
        Connection con = new Connection();
        public bool buttonclicked = false;
        //worker need to stop themselves
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"\\etmy2014\XV9000\TFM\Application\Alarm.wav");

        public CleaningBox()
        { 
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            now = DateTime.Now;
            starttime = now.ToString();
            label5.Text = starttime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            endtime = DateTime.Now.ToString();
            label6.Text = endtime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (empTBX.Text==""&& cycleTBX.Text=="")
            {
                MessageBox.Show("Sila Enter Data dan tekan Start kemudian tekan End apabila sudah habis.");
            }
            else
            {
                con.OpenConnection();
                string query = "Insert into tbl_cleaning (clean_worker,start_time,end_time,imi,tfm_lot)" +
                    "values ('" + empTBX.Text + "','" + starttime + "','" + endtime + "','" + cycleTBX.Text + "','" + cleaningCBX.Text + "')";
                con.ExecuteScalar(query);
                clearAll();
            }

        }
        private void clearAll()
        {
            empTBX.Text = "";
            cycleTBX.Text = "";
            cleaningCBX.Text = "";
        }
        public void playSound()
        { 
            player.PlayLooping(); 
        }
        public void stopSound()
        {
            player.Stop();
        } 
        private void alarmButton_Click(object sender, EventArgs e)
        {
            OnButtonClick();
        }
        public void OnButtonClick()
        {
            buttonclicked = true;
        }
        public void alarm()
        {
            if (buttonclicked == false)
            {
                playSound(); 
            }
            if (buttonclicked == true)
            {
                stopSound();
            }
        }
    }
}
