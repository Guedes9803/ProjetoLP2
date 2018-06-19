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
        private String id;
        private String nome;
        private String dt_ini;
        private String dt_term;
        private String part;
        private connection conex = new connection();



        public TorneiosControl()
        {
            InitializeComponent();
            PreencherTabela();

        }

        private void PreencherTabela()
        {
            conex.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM torneio", conex.conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dtTeste.DataSource = dt;
                this.dtTeste.Columns["id_torneio"].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addVariosPartControl1.BringToFront();
            criarTorneioControl1.BringToFront();
            criarTorneioControl1.Visible = true;
            addVariosPartControl1.Visible = true;
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
            lblTeste.Text = dt_ini;
        }

        private void dtTeste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dtTeste.CurrentRow.Cells[0].Value.ToString();
            dt_ini = dtTeste.CurrentRow.Cells[1].Value.ToString();
            dt_term = dtTeste.CurrentRow.Cells[2].Value.ToString();
            part =  dtTeste.CurrentRow.Cells[3].Value.ToString();
            nome = dtTeste.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            altTorneioControl alterar = new altTorneioControl();
            if(id != null)
            {
                altTorneioControl1.Carrega(nome, dt_ini, dt_term, part, id);
                altTorneioControl1.Visible = true;
                altTorneioControl1.preencheCampos();

            }
                
        }

        private void altTorneioControl1_Load(object sender, EventArgs e)
        {
        }

        private void TorneiosControl_Load(object sender, EventArgs e)
        {
            dtTeste.Visible = true;
            altTorneioControl1.Visible = false;
            criarTorneioControl1.Visible = false;
            addVariosPartControl1.Visible = false;
            
            
        }

        private void criarTorneioControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            tabelaTorneio8 janela = new tabelaTorneio8(id);
            janela.Show();
        }

        private void criarTorneioControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
