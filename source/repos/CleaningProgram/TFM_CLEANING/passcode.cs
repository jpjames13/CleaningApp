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
    public partial class passcode : Form
    {
        Connection con = new Connection();
        public passcode()
        {
            InitializeComponent();
            changeBTN.Enabled = false; 
            //Fire the events don't use this portion of code as main when different form calling
        } 
        public void changeSettings()
        {
            string pwd = "";

            string query = "Select password from pd.dbo.tbl_access where id like '" + idTBX.Text.TrimEnd() + "%' ";
            pwd = con.ExecuteScalar(query); 


            if (pwdTBX.Text==pwd.TrimEnd() && idTBX.Text!="")
            {
                counterTBX.Enabled = true; 
                changeBTN.Enabled = true; 
                resetcounterboxTBX.Enabled = true; 
            }
        }

        private void enterBtn_Click(object sender, EventArgs e)
        { 
            if (idTBX.Text != "")
            { 
                changeSettings(); 
            }
            else
            {
                MessageBox.Show("Enter Password and ID");
            }
        }

        private void processTBX_TextChanged(object sender, EventArgs e)
        { 
            //try
            //{ 
            //    Form1.changeLabel(processTBX.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("My program got bugs please feedback to IE JON");
            //}
        }

        private void counterTBX_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    Form1.count = Convert.ToInt32(counterTBX.Text); 
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("My program got bugs please feedback to IE JON");
            //}
        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
            try
            {  
                int x;

                if ((Int32.TryParse(resetcounterboxTBX.Text, out x)) && TabPress.GBcounter == false && TabPress.TBcounter == true)
                {
                    //Form1.resetCounter(Convert.ToInt32(resetcounterboxTBX.Text) - 1);
                    //this.Hide();
                    //Form1.changeLabel(processTBX.Text, Convert.ToInt32(resetcounterboxTBX.Text));
                    TabPress.changeQTY(Convert.ToInt32(resetcounterboxTBX.Text));
                    this.Hide();
                }
                else if ((Int32.TryParse(resetcounterboxTBX.Text, out x)) && TabPress.GBcounter == true && TabPress.TBcounter == false)
                {
                    //Form1.resetCounter(Convert.ToInt32(resetcounterboxTBX.Text) - 1);
                    //this.Hide();
                    //Form1.changeLabel(processTBX.Text, Convert.ToInt32(resetcounterboxTBX.Text));
                    GB.changeQTY(Convert.ToInt32(counterTBX.Text), TabPress.GBshotcounter = Convert.ToInt32(resetcounterboxTBX.Text));
                     
                    this.Hide();
                }
                else
                    MessageBox.Show("Please enter number");
                //you know why I commented this out? cause it overrides the change label method and count
                //Form1 form = new Form1();
                //form.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Program got bugs please feedback to IE JON");
            }
        }

        //private void pwdchangeBTN_Click(object sender, EventArgs e)
        //{
        //    NewPassword form = new NewPassword();
        //    form.Show();
        //}

        private void resetBTN_Click(object sender, EventArgs e)
        {
            int x;

            if (Int32.TryParse(resetcounterboxTBX.Text, out x))
            {
                //Form1.resetCounter(Convert.ToInt32(resetcounterboxTBX.Text)-1);
                //this.Hide();
                
            }
            else
                MessageBox.Show("Please enter number");

        }
    }
}
