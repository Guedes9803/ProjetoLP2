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

        public addVariosPartControl()
        {
            InitializeComponent();
        }

      
        public void getQtdPart(int part)
        {
            qtd = part;            
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            MySqlConnection conn = new MySqlConnection();

            conn.ConnectionString = "Server=localhost; Database=birb; Uid=root; Pwd=Malued01@lol;";
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string sql = "INSERT INTO participant(nome, personagem) VALUES('" +
                    txtNome.Text + "','" +
                    txtPers.Text + "')";
                string sql2 = "insert into part_torn values ((select max(id_part) from participant),(select max(id_torneio) from torneio))";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
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
                conn.Close();
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
