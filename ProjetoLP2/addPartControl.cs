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
        private connection conex = new connection();
        public addPartControl()
        {
            InitializeComponent();
            
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            conex.conectar();

            string sql = "INSERT INTO participant(nome, personagem) VALUES('" +
                txtNome.Text + "','" +
                txtPers.Text + "')";

            MySqlCommand cmd = new MySqlCommand(sql, conex.conn);

            try
            {
                cmd.ExecuteNonQuery();
                this.Visible = false;

            }
            catch (Exception ex)
            {
                label5.Text = "Erro: " + ex.Message;
            }
            finally
            {
                conex.conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void addPartControl_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TTAst_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
