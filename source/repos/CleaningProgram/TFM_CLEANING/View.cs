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
    public partial class View : Form
    {
        Connection con = new Connection();
        public View()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            DataTable dt = retMonitor();
            dataGridView1.DataSource = dt;
        }
        public DataTable retMonitor()
        {
            string query = "Select * from tbl_cleaning order by start_time desc";
            con.OpenConnection();
            return con.GrdVw(query);
        }
    }
}
