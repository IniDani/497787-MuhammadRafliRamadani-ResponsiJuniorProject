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
using System.Xml.Linq;

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
                MessageBox.Show("Error:" + msg.Message, "Failed to load data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"SELECT * FROM insert_data(:_nama, :_departemen, :_jabatan)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", NamaKaryawantb.Text);
                cmd.Parameters.AddWithValue("_departemen", DepKaryawantb.Text);
                cmd.Parameters.AddWithValue("_jabatan", Jabatantb.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Users Berhasil diinputkan", "Well Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    Loadbtn.PerformClick();
                    NamaKaryawantb.Text = DepKaryawantb.Text = NamaKaryawantb.Text = null;
                }
            }
            catch (Exception msg) {
                MessageBox.Show("Error:" + msg.Message, "Failed to insert data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                r = dataGridView1.Rows[e.RowIndex];
                NamaKaryawantb.Text = r.Cells["_nama"].Value.ToString();
                DepKaryawantb.Text = r.Cells["_departemen"].Value.ToString();
                Jabatantb.Text = r.Cells["_jabatan"].Value.ToString();
            }
        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilih data yang akan diupdate", "Good", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                conn.Open();
                sql = @"SELECT FROM * ";
                cmd = new NpgsqlCommand(sql, conn);
            }
            catch (Exception msg)
            {
                MessageBox.Show("Error:" + msg.Message, "Failed to edit data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
