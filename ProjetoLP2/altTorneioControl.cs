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
    public partial class altTorneioControl : UserControl
    {
        private string ID;
        private string Nome;
        private string dt_Inicio;
        private string dt_final;
        private string participantes;

        public altTorneioControl()
        {
            InitializeComponent();
        }

        public void Carrega(String n,String dt_ini, String dt_fim, String p,String id)
        {
            Nome = n;
            ID = id;
            dt_Inicio = dt_ini;
            dt_final = dt_fim;
            participantes = p;
        }

        public void preencheCampos()
        {
            txtNome.Text = Nome;
            txtIni.Text = dt_Inicio;
            txtTerm.Text = dt_final;
            txtQtd.Text = participantes;
            lblTeste.Text = ID;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=birb; Uid=root; Pwd=Malued01@lol;";
            try
            {
                
                string sql = "UPDATE TORNEIO SET data_inicio = '"
                    + this.txtIni.Text + "', data_termino = '"
                    + this.txtTerm.Text + "', nome_torneio = '" 
                    + this.txtNome.Text + "',participante = '"
                    + this.txtQtd.Text +
                    "' where id_torneio ='" + this.lblTeste.Text + "';";

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader dr;
                conn.Open();                            
                dr = cmd.ExecuteReader();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                label5.Text = "Erro: " + ex;              
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void altTorneioControl_Load(object sender, EventArgs e)
        {

        }




        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

