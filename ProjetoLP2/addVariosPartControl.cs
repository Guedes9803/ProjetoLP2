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
        private int id;
        private List<string> IDJog = new List<string>();
        private bool check = true;
        private List<string> PersID = new List<string>();    
        private connection conex = new connection();

        public addVariosPartControl()
        {
            InitializeComponent();
            PreencherCombo();
        }
        public static bool ValidaCpf(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;

            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * (multiplicador1[i]);
            }
            resto = soma % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            int soma2 = 0;

            for (int i = 0; i < 10; i++)
            {
                soma2 += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            }

            resto = soma2 % 11;

            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public void getQtdPart(int part)
        {
            qtd = part;
            id = -1;
            lblAgora.Text = "1/" + part;
            btnNao.Visible = true;
            btnSim.Visible = true;
            lblTexto1.Visible = true;
            lblTexto2.Visible = true;
            btnConf.Visible = false;
            btnParar.Visible = false;
            lblNome.Visible = false;
            lblCPF.Visible = false;
            lblApe.Visible = false;
            lblAgora.Visible = false;
            lblSobre.Visible = false;
            lblPersonagem.Visible = false;
            txtApe.Visible = false;
            txtNome.Visible = false;
            txtCPF.Visible = false;
            txtSobre.Visible = false;
            cbPers.Visible = false;
            btnPesquisa.Visible = false;
            cbJoga.Visible = false;
        }
        public void getIDTorneio(int ID,int part,int vagas)
        {
            id = ID;
            qtd = part;
            Index = part - vagas + 1;
            lblAgora.Text = Index + "/" + part;
            btnNao.Visible = false;
            btnSim.Visible = false;
            lblTexto1.Visible = false;
            lblTexto2.Visible = false;
            btnConf.Visible = true;
            btnParar.Visible = true;
            lblNome.Visible = true;
            lblCPF.Visible = true;
            lblApe.Visible = true;
            lblAgora.Visible = true;
            lblSobre.Visible = true;
            lblPersonagem.Visible = true;
            txtApe.Visible = true;
            txtCPF.Visible = true;
            txtSobre.Visible = true;
            cbPers.Visible = true;
            btnPesquisa.Visible = true;
            cbJoga.Visible = false;
        }


        private void btnSim_Click(object sender, EventArgs e)
        {
            btnNao.Visible = false;
            btnSim.Visible = false;
            lblTexto1.Visible = false;
            lblTexto2.Visible = false;
            btnConf.Visible = true;
            btnParar.Visible = true;
            lblNome.Visible = true;
            lblCPF.Visible = true;
            lblApe.Visible = true;
            lblAgora.Visible = true;
            lblSobre.Visible = true;
            lblPersonagem.Visible = true;
            txtApe.Visible = true;
            txtCPF.Visible = true;
            txtSobre.Visible = true;
            cbPers.Visible = true;
            btnPesquisa.Visible = true;
            Index = 1;
            lblAtual.Text = "";
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void addVariosPartControl_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string sql2;
            string sql;

            try
            {
                conex.conectar();
                if (check)
                {

                    sql = "INSERT INTO jogador(nome, sobrenome, apelido, cpf) values('" +
                    txtNome.Text + "','" + txtSobre.Text + "','" + txtApe.Text + "','" + txtCPF.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(sql, conex.conn);
                    cmd.ExecuteNonQuery();

                    if (id == -1)
                    {
                        sql2 = "insert into torneio_perso_jogador (id_torneio,id_jogador,id_personagem)" +
                            "values ((select max(torneio_id) from torneio), (select max(jogador_id) from jogador),'" + PersID[cbPers.SelectedIndex] + "');";
                    }
                    else
                    {
                        sql2 = "insert into torneio_perso_jogador (id_torneio,id_jogador,id_personagem)" +
                            "values ('" + id + "',(select max(jogador_id) from jogador),'" + PersID[cbPers.SelectedIndex] + "');";
                    }
                }
                else
                {
                    if (id == -1)
                    {
                        sql2 = "insert into torneio_perso_jogador (id_torneio,id_jogador,id_personagem)" +
                            "values ((select max(torneio_id) from torneio)," + IDJog[cbJoga.SelectedIndex] +",'" + PersID[cbPers.SelectedIndex] + "');";
                    }
                    else
                    {
                        sql2 = "insert into torneio_perso_jogador (id_torneio,id_jogador,id_personagem)" +
                            "values ('" + id + "','" + IDJog[cbJoga.SelectedIndex] + "','" + PersID[cbPers.SelectedIndex] + "');";
                    }
                }


                MySqlCommand cmd2 = new MySqlCommand(sql2, conex.conn);
                cmd2.ExecuteNonQuery();

                if(Index < qtd)
                {
                    lblNome.Visible = true;
                    lblCPF.Visible = true;
                    lblApe.Visible = true;
                    lblAgora.Visible = true;
                    lblSobre.Visible = true;
                    lblPersonagem.Visible = true;
                    txtApe.Visible = true;
                    txtCPF.Visible = true;
                    txtSobre.Visible = true;
                    cbPers.Visible = true;
                    cbJoga.Visible = false;
                    txtNome.Visible = true;
                    txtNome.Clear();
                    txtSobre.Clear();
                    txtApe.Clear();
                    txtCPF.Clear();
                    cbPers.SelectedIndex = -1;
                    
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
                    
                    lblNome.Visible = false;
                    lblPersonagem.Visible = false;
                    this.Visible = false;

                }

                check = true;
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Index++;
                lblAgora.Text = Index + "/" + qtd;
                cbJoga.SelectedIndex = -1;
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
            
            lblNome.Visible = false;
            lblPersonagem.Visible = false;
            this.Visible = false;
        }

        private void lblPersonagem_Click(object sender, EventArgs e)
        {

        }

        private void ckNovo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if(!ValidaCpf(txtCPF.Text))
            {
                label1.Text = "CPF invalido Insira um CPF valido";
            }
            else
            {
                if (check)
                {
                        try
                        {
                            conex.conectar();
                            string sql = "Select * from jogador where CPF ='" + txtCPF.Text + "';";
                            MySqlDataAdapter da = new MySqlDataAdapter(sql, conex.conn);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count == 0)
                            {
                                label1.Text = "CPF valido";
                            }
                            else
                            {
                                label1.Text = "Jogador com CPF já cadastrado";
                                
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
                for (int i = 0;i < dt.Rows.Count;i++)
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

        private void cbPers_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void txtCPF_MouseUp(object sender, MouseEventArgs e)
        {
            MaskedTextBox editBox = (MaskedTextBox)sender;
            editBox.SelectionStart = 0;
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {

        }

        private void cbPers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text = PersID[cbPers.SelectedIndex];
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            cbJoga.Items.Clear();
            lblApe.Visible = false;
            lblSobre.Visible = false;
            txtApe.Visible = false;
            txtCPF.Visible = false;
            txtSobre.Visible = false;
            txtNome.Visible = false;
            lblCPF.Visible = false;

            check = false;
            cbJoga.Visible = true;
            conex.conectar();
            string sql;
            if(id != -1)
            {
                sql = "SELECT jogador_id,CONCAT(nome, ' ', sobrenome) FROM jogador where "  +
                "jogador_id not in(select id_jogador from torneio_perso_jogador where id_torneio ='" + id + "');";
            }
            else
            {
                sql = "SELECT jogador_id,CONCAT(nome, ' ', sobrenome) FROM jogador where " +
                    "jogador_id not in(select id_jogador from torneio_perso_jogador where id_torneio = (select max(torneio_id) from torneio))";
            }
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conex.conn);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cbJoga.Items.Add(dt.Rows[i][1].ToString());
                    IDJog.Add(dt.Rows[i][0].ToString());
                    //label1.Text = dt.Rows[i][0].ToString();
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

        private void cbJoga_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
