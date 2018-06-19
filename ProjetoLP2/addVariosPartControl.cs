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

    public partial class addVariosPartControl : UserControl
    {
        private static int qtd;
        private int Index = 1;
        private connection conex = new connection();

        public addVariosPartControl()
        {
            InitializeComponent();
        }

      
        public void getQtdPart(int part)
        {
            qtd = part;            
        }



        private void btnSim_Click(object sender, EventArgs e)
        {
            btnNao.Visible = false;
            btnSim.Visible = false;
            lblTexto1.Visible = false;
            lblTexto2.Visible = false;
            btnConf.Visible = true;
            btnParar.Visible = true;
            txtNome.Visible = true;
            txtPers.Visible = true;
            lblNome.Visible = true;
            lblPersonagem.Visible = true;
            Index = 1;
            lblAtual.Text = "1/8";
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void addVariosPartControl_Load(object sender, EventArgs e)
        {
            btnNao.Visible = true;
            btnSim.Visible = true;
            lblTexto1.Visible = true;
            lblTexto2.Visible = true;
            btnConf.Visible = false;
            btnParar.Visible = false;
            txtNome.Visible = false;
            txtPers.Visible = false;
            lblNome.Visible = false;
            lblPersonagem.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conex.conectar();

                string sql = "INSERT INTO participant(nome, personagem) VALUES('" +
                    txtNome.Text + "','" +
                    txtPers.Text + "')";
                string sql2 = "insert into part_torn values ((select max(id_part) from participant),(select max(id_torneio) from torneio))";

                MySqlCommand cmd = new MySqlCommand(sql, conex.conn);
                MySqlCommand cmd2 = new MySqlCommand(sql2, conex.conn);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                if(Index < qtd)
                {
                    txtNome.Clear();
                    txtPers.Clear();
                    Index++;
                    lblAtual.Text = Index + "/" + qtd;
                }
                else
                {
                    btnNao.Visible = true;
                    btnSim.Visible = true;
                    lblTexto1.Visible = true;
                    lblTexto2.Visible = true;
                    btnConf.Visible = false;
                    btnParar.Visible = false;
                    txtNome.Visible = false;
                    txtPers.Visible = false;
                    lblNome.Visible = false;
                    lblPersonagem.Visible = false;
                    this.Visible = false;
                }
                

            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conex.conn.Close();
            }

        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            btnNao.Visible = true;
            btnSim.Visible = true;
            lblTexto1.Visible = true;
            lblTexto2.Visible = true;
            btnConf.Visible = false;
            btnParar.Visible = false;
            txtNome.Visible = false;
            txtPers.Visible = false;
            lblNome.Visible = false;
            lblPersonagem.Visible = false;
            this.Visible = false;
        }

        private void lblPersonagem_Click(object sender, EventArgs e)
        {

        }
    }
}
