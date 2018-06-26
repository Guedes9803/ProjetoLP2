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
    public partial class partControl : UserControl
    {
        private string id = "-1";
        private connection conex = new connection();

        public partControl()
        {
            InitializeComponent();
            addPartControl1.Visible = false;
            preencherTabela();
            dtTeste.AllowUserToAddRows = false;
            dtTeste.ReadOnly = true;
            dtTeste.RowHeadersVisible = false;
            dtTeste.BackgroundColor = Color.White;
            partInfoControl1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPartControl1.Visible = true;
            addPartControl1.BringToFront();
            dtTeste.Visible = false;
        }

        private void partControl_Load(object sender, EventArgs e)
        {

        }

        private void preencherTabela()
        {
            conex.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT jogador_id, cpf as 'CPF', nome as 'Nome',sobrenome as 'Sobrenome',apelido as 'Apelido',sexo as 'Sexo',qtd_vitorias as 'Quantidade Vitorias',qtd_derrotas as 'Quantidade de Derrotas' FROM jogador", conex.conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dtTeste.DataSource = dt;
                this.dtTeste.Columns["jogador_id"].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                UpdateFont();
                conex.conn.Close();
            }
        }

        private void addPartControl1_Load(object sender, EventArgs e)
        {

        }

        private void addPartControl1_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible && !dtTeste.Visible)
            {
                dtTeste.Visible = true;
                preencherTabela();
            }
        }

        private void dtTeste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtTeste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtTeste.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnCriarPart_Click(object sender, EventArgs e)
        {
            if(id == "-1")
            {
                MessageBox.Show("Selecione um participante", "Participante não selecionado", MessageBoxButtons.OK);
            }
            else
            {
                partInfoControl1.Carrega(id);
                partInfoControl1.BringToFront();
                partInfoControl1.Visible = true;
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "Sim";
            MessageBoxManager.No = "Não";
            MessageBoxManager.Register();
            var confirmResult = MessageBox.Show("Você tem certeza que quer deletar o jogador?!?",
                                     "Delatar Jogador",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {



                try
                {
                    conex.conectar();
                    string Query = "delete from jogador where jogador_id='" + id + "';";
                    MySqlCommand cmd = new MySqlCommand(Query, conex.conn);
                    MySqlDataReader rdr;
                    rdr = cmd.ExecuteReader();

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    conex.conn.Close();
                    preencherTabela();
                }
            }
            else
            {

            }
        }

        private void partInfoControl1_VisibleChanged(object sender, EventArgs e)
        {
            preencherTabela();
        }
        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dtTeste.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Roboto", 12F, GraphicsUnit.Pixel);
            }
        }

        private void partInfoControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
