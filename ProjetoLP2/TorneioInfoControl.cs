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
    public partial class TorneioInfoControl : UserControl
    {
        private string ID;
        private string IDJog;
        private string dtFim;
        private string dtIni;
        private string qtdPart;
        private string qtd;
        private string qtdVagas;
        private int mes;
        private int ano;
        private bool statusText = true;

        private connection conex = new connection();

        public TorneioInfoControl()
        {
            InitializeComponent();
            dgPart.AllowUserToAddRows = false;
            dgPart.RowHeadersVisible = false;
            dgPart.BackgroundColor = Color.White;
        }
        public void Carrega(String id)
        {
            ID = id;
            preencherCampos();
            addVariosPartControl1.Visible = false;
            PreencherTabela();
        }
        private void preencherCampos()
        {
            try
            {
                conex.conectar();
                string sql = "Select * from torneio where torneio_id ='" + ID + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conex.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtNome.Text = dt.Rows[0][1].ToString();
                dtFim = dt.Rows[0][3].ToString();
                dtIni = dt.Rows[0][2].ToString();
                qtdPart = dt.Rows[0][4].ToString();
                lblRest.Text = dt.Rows[0][5].ToString();
                qtdVagas = dt.Rows[0][5].ToString();
                preencheCombo(dtIni,dtFim);
                preencheCheck(qtdPart);
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

        private void preencheCheck(string qtd)
        {
            int QTD = Convert.ToInt32(qtd);
            if (QTD == 8)
                radio8.Checked = true;
            else if (QTD == 16)
                radio16.Checked = true;
            else
                radio32.Checked = true;
        }
        private void preencheCombo(string data1,string data2)
        {
            DateTime dataIni = DateTime.Parse(data1);
            DateTime dataFim = DateTime.Parse(data2);
            CoCoCombo();
            cbAno.SelectedItem = dataIni.Year;
            ano = dataIni.Year;
            cbMes.SelectedItem = dataIni.Month;
            mes = dataIni.Month;
            DiDiDia(cbDia);
            cbDia.SelectedItem = dataIni.Day;
            cbAno2.SelectedItem = dataFim.Year;
            ano = dataFim.Year;
            cbMes2.SelectedItem = dataFim.Month;
            mes = dataFim.Month;
            DiDiDia(cbDia2);
            cbDia2.SelectedItem = dataFim.Day;
        }

        private void TorneioInfoControl_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CoCoCombo()
        {
            for (int i = 0; i < 12; i++)
            {
                cbMes.Items.Add(i + 1);
                cbMes2.Items.Add(i + 1);
            }

            for (int i = DateTime.Now.Year + 20; i > 2000; i--)
            {
                cbAno.Items.Add(i);
                cbAno2.Items.Add(i);
            }

        }

        private void DiDiDia(ComboBox cb)
        {
            int diasDoMes = System.DateTime.DaysInMonth(ano, mes);
            cb.Items.Clear();

            for (int i = 1; i <= diasDoMes; i++)
            {
                cb.Items.Add(i);
            }


        }

        private void btnTabela_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(lblRest.Text) == 0)
            {
                if(radio8.Checked)
                {
                    tabelaTorneio8 Tabela1 = new tabelaTorneio8(ID);
                    Tabela1.ShowDialog();
                }
                else if(radio16.Checked)
                {
                    tabelaTorneio16 Tabela2 = new tabelaTorneio16(ID);
                    Tabela2.ShowDialog();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Seu torneio tem " + lblRest.Text + " vagas restante, inscreva o resto do participantes para ver/gerar a tabela",
                                "Ainda há vagas sobrando",
                                MessageBoxButtons.OK);
            }
        }

        private void addVariosPartControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(lblRest.Text) == 0)
            {
                MessageBox.Show("Você atingiu o numero maximo de participantes nesse campeonato", "Numero maximo de participantes", MessageBoxButtons.OK);
            }
            else
            {
                addVariosPartControl1.getIDTorneio(Convert.ToInt32(ID), Convert.ToInt32(qtdPart), Convert.ToInt32(lblRest.Text));
                addVariosPartControl1.BringToFront();
                addVariosPartControl1.Visible = true;
            }
        }
        public void PreencherTabela()
        {
            conex.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT j.jogador_id,CONCAT(j.nome, ', ',j.sobrenome) as Nome, p.nome as Personagem from personagem p inner join torneio_perso_jogador tpj on tpj.id_personagem = p.personagem_id inner join jogador j on j.jogador_id = tpj.id_jogador where tpj.id_torneio ='" + ID + "';", conex.conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                dgPart.DataSource = dt;
                this.dgPart.Columns["jogador_id"].Visible = false;
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
            this.Visible = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            CheckData();
        }

        private void CheckData()
        {
            if (statusText)
            {
                if (cbDia2.SelectedIndex > -1 && cbDia.SelectedIndex > -1)
                {
                    DateTime dtInicial = new DateTime(Convert.ToInt32(cbAno.SelectedItem), Convert.ToInt32(cbMes.SelectedItem), Convert.ToInt32(cbDia.SelectedItem), 0, 0, 0);
                    DateTime dtFinal = new DateTime(Convert.ToInt32(cbAno2.SelectedItem), Convert.ToInt32(cbMes2.SelectedItem), Convert.ToInt32(cbDia2.SelectedItem), 0, 0, 0);
                    if (dtInicial.Date < dtFinal.Date)
                    {
                        UpdateTorneio();
                    }
                    else
                    {
                        label1.Text = "Data Invalida";
                    }
                }
                else
                {
                    label1.Text = "Por favor insira data de inicio e termino do torneio valida!";
                }

            }
            else
            {
                label1.Text = "Insira o nome do Torneio";
            }


        }

        private void UpdateTorneio()
        {
            try
            {
                dtIni = Convert.ToString(cbAno.SelectedItem) + '-' + Convert.ToString(cbMes.SelectedItem) + '-' + Convert.ToString(cbDia.SelectedItem);
                dtFim = Convert.ToString(cbAno2.SelectedItem) + '-' + Convert.ToString(cbMes2.SelectedItem) + '-' + Convert.ToString(cbDia2.SelectedItem);
                if (radio8.Checked)
                    qtd = radio8.Text;
                else if (radio16.Checked)
                    qtd = radio16.Text;
                else if (radio32.Checked)
                    qtd = radio32.Text;
                conex.conectar();

                string sql = "UPDATE torneio SET nome ='" + txtNome.Text +
                            "',  dt_inicio = '" + dtIni +
                            "',  dt_fim ='" + dtFim +
                            "',  qtd_participantes ='" + qtd + 
                            "'WHERE TORNEIO_ID = '" + ID + "';";

                MySqlCommand cmd = new MySqlCommand(sql, conex.conn);
                MySqlDataReader dr;

                dr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conex.conn.Close();
                preencherCampos();
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome do Torneio";
                txtNome.ForeColor = Color.Silver;
                statusText = false;
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome do Torneio")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.Black;
                statusText = true;
            }
        }

        private void radio8_Click(object sender, EventArgs e)
        {
            if(radio8.Checked)
            {
                if (Convert.ToInt16(qtdPart) != 8)
                {
                    if ((Convert.ToInt16(qtdVagas) + 8) - (Convert.ToInt16(qtdPart) ) < 0)
                    {
                        preencheCheck(qtdPart);
                    }
                }
            }
            
        }

        private void radio16_Click(object sender, EventArgs e)
        {
            if (radio16.Checked)
            {

                if (Convert.ToInt16(qtdPart) != 8)
                {
                    if ((Convert.ToInt16(qtdVagas) + 16) - (Convert.ToInt16(qtdPart)) < 0)
                    {
                        preencheCheck(qtdPart);
                    }
                }
            }
        }

        private void radio8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRemPart_Click(object sender, EventArgs e)
        {
            if (IDJog is null)
            {
                MessageBox.Show("Por favor selecione um jogador", "Jogador não selecionado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBoxManager.Yes = "Sim";
                MessageBoxManager.No = "Não";
                MessageBoxManager.Register();
                var confirmResult = MessageBox.Show("Você tem certeza que quer remover o jogador do campeonato!?!",
                                         "Remover jogador",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {



                    try
                    {
                        conex.conectar();
                        string Query = "delete from torneio_perso_jogador where id_torneio='" + ID + "' and id_jogador='" + IDJog + "';";
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
                        IDJog = null;
                        conex.conn.Close();
                        PreencherTabela();
                        preencherCampos();
                    }
                }
            }
        }

        private void dgPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDJog = dgPart.CurrentRow.Cells[0].Value.ToString();
        }

        private void addVariosPartControl1_VisibleChanged(object sender, EventArgs e)
        {
            PreencherTabela();
        }
        private void UpdateFont()
        {
            //Change cell font
            foreach (DataGridViewColumn c in dgPart.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Roboto", 12F, GraphicsUnit.Pixel);
            }
        }
    }
}
