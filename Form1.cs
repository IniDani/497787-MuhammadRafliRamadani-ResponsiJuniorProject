using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Responsi_497787
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" +
            "User Id={2};Password={3};Database={4};",
            "localhost", 5432, "postgres", "12345678", "Responsi_Dani");
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dataGridView1.DataSource = null;
                sql = "SELECT * FROM load_data()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception msg){
                MessageBox.Show("Error:" + msg.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
