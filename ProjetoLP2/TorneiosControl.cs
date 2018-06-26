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
    public partial class TorneiosControl : UserControl
    {
        private String id = "-1";
        private String nome;
        private String dt_ini;
        private String dt_term;
        private String part;
        private connection conex = new connection();


        public TorneiosControl()
        {
            InitializeComponent();
            dtTeste.AllowUserToAddRows = false;
            dtTeste.ReadOnly = true;
            dtTeste.RowHeadersVisible = false;
            dtTeste.BackgroundColor = Color.White;

            PreencherTabela();
            criarTorneioControl1.Visible = false;
            torneioInfoControl1.Visible = false;
        }

        public void PreencherTabela()
        {
            conex.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT torneio_id,t.nome as 'Torneio',dt_inicio as 'Data Inicio',dt_fim as 'Data Fim'" +
                ",qtd_participantes as 'Numero de Participantes', qtd_vagas as 'Vagas Sobrando', premio as 'Prêmio', concat(j.nome, ', ',j.sobrenome)" +
                " as 'Campeão' FROM torneio t left join jogador j on j.jogador_id = t.id_vencedor", conex.conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dtTeste.DataSource = dt;
                this.dtTeste.Columns["torneio_id"].Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        { 
            criarTorneioControl1.BringToFront();
            criarTorneioControl1.Visible = true;
            criarTorneioControl1.CoCoCombo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PreencherTabela(); 
        }

        private void dtTeste_DoubleClick(object sender, EventArgs e)
        {
            //lblTeste.Text = dt_ini;
        }

        private void dtTeste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtTeste.CurrentRow.Cells[0].Value.ToString();
            dt_ini = dtTeste.CurrentRow.Cells[1].Value.ToString();
            dt_term = dtTeste.CurrentRow.Cells[2].Value.ToString();
            part =  dtTeste.CurrentRow.Cells[3].Value.ToString();
            nome = dtTeste.CurrentRow.Cells[4].Value.ToString();
            //lblTeste.Text = id;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if(id == "-1")
            {

               MessageBox.Show("Selecione um participante", "Participante não selecionada", MessageBoxButtons.OK);
                
            }
            else
            {
                torneioInfoControl1.Carrega(id);
                torneioInfoControl1.BringToFront();
                torneioInfoControl1.Visible = true;
            }

        }

        private void altTorneioControl1_Load(object sender, EventArgs e)
        {
        }

        private void TorneiosControl_Load(object sender, EventArgs e)
        {
            dtTeste.Visible = true;
            
            criarTorneioControl1.Visible = false;
            
            
            
        }

        private void criarTorneioControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //tabelaTorneio8 janela = new tabelaTorneio8(id);
            //janela.Show();
        }

        private void criarTorneioControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void criarTorneioControl1_VisibleChanged(object sender, EventArgs e)
        {
            PreencherTabela();
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            MessageBoxManager.Yes = "Sim";
            MessageBoxManager.No = "Não";
            MessageBoxManager.Register();
            var confirmResult = MessageBox.Show("Deletar Campeonato",
                                     "Você tem certeza que quer deletar o campeonato?!?",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {



                try
                {
                    conex.conectar();
                    string Query = "delete from torneio where torneio_id='" + id + "';";
                    MySqlCommand cmd = new MySqlCommand(Query, conex.conn);
                    MySqlDataReader rdr;
                    rdr = cmd.ExecuteReader();

                }
                catch (Exception)
                {
                    MessageBox.Show("Torneio possuie jogadores cadastrado, remova-os para poder deleta-lo", "Deletar Torneio", MessageBoxButtons.OK);
                    
                }
                finally
                {
                    conex.conn.Close();
                    PreencherTabela();
                }
            }
            else
            {

            }

        }


        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dtTeste.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Roboto", 12F, GraphicsUnit.Pixel);
            }
        }

        private void torneioInfoControl1_VisibleChanged(object sender, EventArgs e)
        {
            PreencherTabela();
        }
    }
}
