using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoLP2
{
    public partial class tabelaTorneio8 : Form
    {
        private string ID;

        public tabelaTorneio8(string id)
        {
            ID = id;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabelaTorneio8_Load(object sender, EventArgs e)
        {
            PreencheCampos();
        }
        private void PreencheCampos()
        {
            try
            {
                Label[] top8 = { lbl8Top1, lbl8Top2, lbl8Top3, lbl8Top4, lbl8Top5, lbl8Top6, lbl8Top7, lbl8Top8 };
                MySqlConnection conn = new MySqlConnection();
                

                conn.ConnectionString = "Server=localhost; Database=birb; Uid=root;";

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("select nome from participant where id_part in(select id_part from part_torn where id_torneio ='" +  ID + "')", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                label1.Text = Convert.ToString(dt.Rows[0][0]);
                string[] nome = new string[dt.Rows.Count];
                for (int i = 0; i < top8.Count(); i++)
                {
                    nome[i] = Convert.ToString(dt.Rows[i]);
                    top8[i].Text = Convert.ToString(dt.Rows[i][0]);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
