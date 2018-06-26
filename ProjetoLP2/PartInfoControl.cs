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
    public partial class PartInfoControl : UserControl
    {
        private string ID;
        private string IDTorn;
        private List<string> PersID = new List<string>();
        private connection conex = new connection();
        public PartInfoControl()
        {
            InitializeComponent();
            btnDesf.Visible = false;
            btnSalva.Visible = false;
            dgTorn.AllowUserToAddRows = false;
            dgTorn.ReadOnly = true;
            dgTorn.RowHeadersVisible = false;
            dgTorn.BackgroundColor = Color.White;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            lblPers.Visible = false;
            cbPers.Visible = false;
        }

        private void PartInfoControl_Load(object sender, EventArgs e)
        {

        }
        public void Carrega(String id)
        {
            ID = id;
            PreencherCampos();
            PreencheTabela();
        }
        private void PreencherCampos()
        {
            try
            {

                    conex.conectar();
                    string sql = "Select * from jogador where jogador_id ='" + ID + "';";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conex.conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    txtNome.Text = dt.Rows[0][2].ToString();
                    txtSobre.Text = dt.Rows[0][3].ToString();
                    txtApe.Text = dt.Rows[0][4].ToString();
                    txtCPF.Text = dt.Rows[0][1].ToString();
                

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


        private void btnAlt_Click(object sender, EventArgs e)
        {
            txtApe.ReadOnly = false;
            txtCPF.ReadOnly = false;
            txtNome.ReadOnly = false;
            txtSobre.ReadOnly = false;
            btnAlt.Visible = false;
            btnSalva.Visible = true;
            btnDesf.Visible = true;
        }

        private void btnDesf_Click(object sender, EventArgs e)
        {
            PreencherCampos();
            btnDesf.Visible = false;
            btnSalva.Visible = false;
            txtApe.ReadOnly = true;
            txtCPF.ReadOnly = true;
            txtNome.ReadOnly = true;
            txtSobre.ReadOnly = true;
            btnAlt.Visible = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void PreencheTabela()
        {
            conex.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter("select t.torneio_id, t.nome as Campeonato, p.nome as Personagem from personagem p inner join torneio_perso_jogador tpj on tpj.id_personagem = p.personagem_id inner join torneio t on t.torneio_id = tpj.id_torneio where tpj.id_jogador = '" + ID + "';", conex.conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dgTorn.DataSource = dt;
                this.dgTorn.Columns["torneio_id"].Visible = false;
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

        private void dgTorn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTorn = dgTorn.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (IDTorn is null)
            {
                MessageBox.Show("Por favor selecione um campeonato", "Campeonato não selecionado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBoxManager.Yes = "Sim";
                MessageBoxManager.No = "Não";
                MessageBoxManager.Register();
                var confirmResult = MessageBox.Show("Você tem certeza que quer remover a inscrição do campeonato!?!",
                                         "Remover inscrição",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {



                    try
                    {
                        conex.conectar();
                        string Query = "delete from torneio_perso_jogador where id_jogador='" + ID + "' and id_torneio='" + IDTorn + "';";
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
                        IDTorn = null;
                        conex.conn.Close();
                        PreencheTabela();
                    }
                }
            }
        }

        private void PreencherCombo()
        {
            conex.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM personagem", conex.conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbPers.Items.Add(dt.Rows[i][1].ToString());
                    PersID.Add(dt.Rows[i][0].ToString());
                }
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(IDTorn is null)
            {
                MessageBox.Show("Por favor selecione um campeonato", "Campeonato não selecionado", MessageBoxButtons.OK);
            }
            else
            {
                lblCamp.Visible = false;
                dgTorn.Visible = false;
                lblPers.Visible = true;
                cbPers.Visible = true;
                btnSalvar.Visible = true;
                btnCancelar.Visible = true;
                btnAlterar.Visible = false;
                btnRemover.Visible = false;
                PreencherCombo();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                conex.conectar();
                string sql = "UPDATE torneio_perso_jogador SET id_personagem = '"
                    + PersID[cbPers.SelectedIndex] +
                    "' where id_torneio ='" + IDTorn + "' and id_jogador = '" + ID + "';";

                MySqlCommand cmd = new MySqlCommand(sql, conex.conn);

                MySqlDataReader dr;

                dr = cmd.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.conn.Close();
                btnSalvar.Visible = false;
                btnCancelar.Visible = false;
                dgTorn.Visible = true;
                lblPers.Visible = false;
                cbPers.Visible = false;
                cbPers.SelectedIndex = -1;
                btnAlterar.Visible = true;
                btnRemover.Visible = true;
                PreencheTabela();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            btnAlterar.Visible = true;
            btnRemover.Visible = true;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                conex.conectar();
                string sql = "UPDATE jogador SET nome = '"
                    + txtNome.Text + "', sobrenome = '" + txtSobre.Text + "', apelido ='" + txtApe.Text +
                    "' where jogador_id = '" + ID + "';";

                MySqlCommand cmd = new MySqlCommand(sql, conex.conn);

                MySqlDataReader dr;

                dr = cmd.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conex.conn.Close();
                btnAlt.Visible = true;
                btnSalva.Visible = false;
                btnDesf.Visible = false;
                PreencherCampos();
            }
        }

        private void dgTorn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
