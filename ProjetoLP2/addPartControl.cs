using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoLP2
{
    public partial class addPartControl : UserControl
    {
        public addPartControl()
        {
            InitializeComponent();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();

            conn.ConnectionString = "Server=localhost; Database=birb; Uid=root;";

            if (conn.State != System.Data.ConnectionState.Open)
                conn.Open();

            string sql = "INSERT INTO participant(nome, personagem) VALUES('" +
                txtNome.Text + "','" +
                txtPers.Text + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                cmd.ExecuteNonQuery();
                label5.Text = "Usuario Criado com sucesso!";
            }
            catch (Exception ex)
            {
                label5.Text = "Erro: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addPartControl_Load(object sender, EventArgs e)
        {

        }
    }
}
