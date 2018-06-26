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
        private char Sexo;

        public addPartControl()
        {
            InitializeComponent();
            
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            if(ValidaCpf(txtCPF.Text) && !String.IsNullOrEmpty(txtNome.Text))
            {
                conex.conectar();
                checkGender();
                string sql = "INSERT INTO jogador(nome, sobrenome, apelido, cpf, sexo) values('" +
                        txtNome.Text + "','" + txtSobre.Text + "','" + txtApe.Text + "','" + txtCPF.Text + "','" + Sexo.ToString() + "');";

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

        private void checkGender()
        {
            if(checkF.Checked)
            {
                Sexo = 'F';
            }
            else if(checkM.Checked)
            {
                Sexo = 'M';
            }
        }

        private void TTAst_Popup(object sender, PopupEventArgs e)
        {

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

        private void txtCPF_MouseUp(object sender, MouseEventArgs e)
        {
            MaskedTextBox editBox = (MaskedTextBox)sender;
            editBox.SelectionStart = 0;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (!ValidaCpf(txtCPF.Text))
            {
                label5.Text = "CPF invalido Insira um CPF valido";
            }
            else
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
                        label5.Text = "CPF valido";
                    }
                    else
                    {
                        label5.Text = "Usuario já cadastrado";

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

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
