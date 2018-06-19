﻿using System;
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
    public partial class criarTorneioControl : UserControl
    {
        private int dia;
        private int mes;
        private int ano;
        private string dtIni;
        private string dtFim;
        private string part;
        private connection conex = new connection();

        public criarTorneioControl()
        {
            InitializeComponent();
        }


        public void CoCoCombo()
        {
            mesCombo.Items.Clear();
            mesCombo2.Items.Clear();
            anoCombo.Items.Clear();
            anoCombo2.Items.Clear();
            for (int i = 0;i < 12;i++)
            {
                mesCombo.Items.Add(i+1);
                mesCombo2.Items.Add(i + 1);
            }
                
            for (int i = DateTime.Now.Year + 20;i > 2000;i-- )
            {
                anoCombo.Items.Add(i);
                anoCombo2.Items.Add(i);
            }
                
            mesCombo.Enabled = false;
            diaCombo.Enabled = false;
            mesCombo2.Enabled = false;
            diaCombo2.Enabled = false;
        }

        private void DiDiDia()
        {
            int diasDoMes = System.DateTime.DaysInMonth(ano, mes);
            diaCombo.Items.Clear();

            for (int i = 1; i <= diasDoMes; i++)
            {
                diaCombo.Items.Add(i);
            }
                

        }
        private void DiDiDia2()
        {
            int diasDoMes = System.DateTime.DaysInMonth(ano, mes);
            diaCombo2.Items.Clear();

            for (int i = 1; i <= diasDoMes; i++)
            {
                diaCombo2.Items.Add(i);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mes =  Convert.ToInt32(mesCombo.SelectedItem);
            diaCombo.Enabled = true;
            DiDiDia();
        }

        private void anoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ano = Convert.ToInt32(anoCombo.SelectedItem);
            mesCombo.Enabled = true;
            
        }

        private void criarTorneioControl_Load(object sender, EventArgs e)
        {

        }

        private void diaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void anoCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesCombo2.Enabled = true;
        }

        private void mesCombo2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mes = Convert.ToInt32(mesCombo.SelectedItem);
            diaCombo2.Enabled = true;
            DiDiDia2();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           
            
        try
            {
                dtIni = Convert.ToString(anoCombo.SelectedItem) + '-' + Convert.ToString(mesCombo.SelectedItem) + '-' + Convert.ToString(diaCombo.SelectedItem);
                dtFim = Convert.ToString(anoCombo2.SelectedItem) + '-' + Convert.ToString(mesCombo2.SelectedItem) + '-' + Convert.ToString(diaCombo2.SelectedItem);
                if (radio8.Checked)
                    part = radio8.Text;
                else if (radio16.Checked)
                    part = radio16.Text;
                else if (radio32.Checked)
                    part = radio32.Text;
                conex.conectar();

                string sql = "INSERT INTO TORNEIO(nome_torneio, data_inicio, data_termino, participante) VALUES('" +
                    txtNome.Text + "','" +
                    dtIni + "','" +
                    dtFim + "'," +
                    part + ")";

                MySqlCommand cmd = new MySqlCommand(sql, conex.conn);
                cmd.ExecuteNonQuery();
                this.Visible = false;
                addVariosPartControl teste = new addVariosPartControl();
                teste.getQtdPart(Convert.ToInt32(part));
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conex.conn.Close();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if(txtNome.Text == "Nome do Torneio")
            {
                txtNome.Text = "";
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome do Torneio";
                txtNome.ForeColor = Color.Silver;
            }
        }


    }
}
