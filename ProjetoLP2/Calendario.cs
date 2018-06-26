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
    public partial class Calendario : UserControl
    {
        connection conex = new connection();
        DateTime agora = DateTime.Now;
        private int mes;
        private int ano;
        public Calendario()
        {
            InitializeComponent();
            mes = agora.Month;
            ano = agora.Year;
            CalendarioDia(agora.Month,agora.Year);
            lblAno.Text = agora.Year.ToString();
            GetMonth(agora.Month);

        }


        private void Calendario_Load(object sender, EventArgs e)
        {
            
        }
        private void GetMonth(int month)
        {
            if (month == 1)
                lblMes.Text = "Janeiro";
            else if (month == 2)
                lblMes.Text = "Fevereiro";
            else if (month == 3)
                lblMes.Text = "Março";
            else if (month == 4)
                lblMes.Text = "Abril";
            else if (month == 5)
                lblMes.Text = "Maio";
            else if (month == 6)
                lblMes.Text = "Junho";
            else if (month == 7)
                lblMes.Text = "Julho";
            else if (month == 8)
                lblMes.Text = "Agosto";
            else if (month == 9)
                lblMes.Text = "Setembro";
            else if (month == 10)
                lblMes.Text = "Outubro";
            else if (month == 11)
                lblMes.Text = "Novembro";
            else
                lblMes.Text = "Dezembro";

        }
        private void CalendarioDia(int month,int year)
        {
           Label[] dias = { lblDia1, lblDia2, lblDia3, lblDia4, lblDia5, lblDia6, lblDia7, lblDia8, lblDia9, lblDia10,
                            lblDia11, lblDia12, lblDia13, lblDia14, lblDia15, lblDia16, lblDia17, lblDia18, lblDia19, lblDia20,
                            lblDia21, lblDia22, lblDia23, lblDia24, lblDia25, lblDia26, lblDia27, lblDia28, lblDia29,lblDia30,
                            lblDia31, lblDia32, lblDia33, lblDia34, lblDia35, lblDia36, lblDia37};
            DateTime dt = new DateTime(year, month, 1);
            string dia_sem = dt.DayOfWeek.ToString();
            int dia = System.DateTime.DaysInMonth(year, month);
            
            if(dia_sem == "Sunday")
            {
                for(int i = 0;i < dias.Count();i++)
                {
                    if(i < dia)
                    {
                        dias[i].Text = (i + 1).ToString();
                    }
                    else
                    {
                        dias[i].Text = "";
                    }
                }
            }
            else if (dia_sem == "Monday")
            {
                dias[0].Text = "";
                for (int i = 1; i < dias.Count(); i++)
                {
                    if (i < dia+1)
                    {
                        dias[i].Text = (i).ToString();
                    }
                    else
                    {
                        dias[i].Text = "";
                    }
                }
            }
            else if (dia_sem == "Tuesday")
            {
                dias[0].Text = "";
                dias[1].Text = "";
                for (int i = 2; i < dias.Count(); i++)
                {
                    if (i < dia + 2)
                    {
                        dias[i].Text = (i - 1).ToString();
                    }
                    else
                    {
                        dias[i].Text = "";
                    }
                }
            }
            else if (dia_sem == "Wednesday")
            {
                dias[0].Text = "";
                dias[1].Text = "";
                dias[2].Text = "";
                for (int i = 3; i < dias.Count(); i++)
                {
                    if (i < dia + 3)
                    {
                        dias[i].Text = (i - 2).ToString();
                    }
                    else
                    {
                        dias[i].Text = "";
                    }
                }
            }
            else if (dia_sem == "Thursday")
            {
                dias[0].Text = "";
                dias[1].Text = "";
                dias[2].Text = "";
                dias[3].Text = "";
                for (int i = 4; i < dias.Count(); i++)
                {
                    if (i < dia + 4)
                    {
                        dias[i].Text = (i - 3).ToString();
                    }
                    else
                    {
                        dias[i].Text = "";
                    }
                }
            }
            else if (dia_sem == "Friday")
            {
                dias[0].Text = "";
                dias[1].Text = "";
                dias[2].Text = "";
                dias[3].Text = "";
                dias[4].Text = "";
                for (int i = 5; i < dias.Count() ; i++)
                {
                    if (i < dia + 5)
                    {
                        dias[i].Text = (i - 4).ToString();
                    }
                    else
                    {
                        dias[i].Text = "";
                    }
                }
            }
            else
            {
                dias[0].Text = "";
                dias[1].Text = "";
                dias[2].Text = "";
                dias[3].Text = "";
                dias[4].Text = "";
                dias[5].Text = "";
                for (int i = 6; i < dias.Count() ; i++)
                {
                    if (i < dia + 6)
                    {
                        dias[i].Text = (i - 5).ToString();
                    }
                    else
                    {
                        dias[i].Text = "";
                    }

                }
            }
            DataTorneio();
        }

        private void pnlVoltar_MouseClick(object sender, MouseEventArgs e)
        {
            if(mes > 1)
            {
                mes--;
                CalendarioDia(mes, ano);
                GetMonth(mes);
            }
            else if(mes == 1 && ano > 2000)
            {
                mes = 12;
                ano--;
                CalendarioDia(mes, ano);
                lblAno.Text = ano.ToString();
                GetMonth(mes);
            }
                
        }

        private void pnlProx_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlProx_Click(object sender, EventArgs e)
        {
            if (mes < 12)
            {
                mes++;
                CalendarioDia(mes, ano);
                GetMonth(mes);
            }
            else if (mes == 12 && ano < 2090)
            {
                mes = 1;
                ano++;
                CalendarioDia(mes, ano);
                lblAno.Text = ano.ToString();
                GetMonth(mes);
            }
        }

        private void pnlVoltar2_Click(object sender, EventArgs e)
        {
            if (ano > 2000)
            {
                ano--;
                CalendarioDia(mes, ano);
                lblAno.Text = ano.ToString();
            }

        }

        private void pnlProx2_Click(object sender, EventArgs e)
        {
            if(ano < 2090)
            {
                ano++;
                CalendarioDia(mes, ano);
                lblAno.Text = ano.ToString();
            }
        }
        private void DataTorneio()
        {
            Panel[] paineis = {pnl1, pnl2, pnl3, pnl4, pnl5, pnl6, pnl7, pnl8, pnl9, pnl10,
                                pnl11, pnl12, pnl13, pnl14, pnl15, pnl16, pnl17, pnl18, pnl19, pnl20,
                                pnl21, pnl22, pnl23, pnl24, pnl25, pnl26, pnl27, pnl28, pnl29, pnl30,
                                pnl31, pnl32, pnl33, pnl34, pnl35, pnl36, pnl37};
            Label[] dias = { lblDia1, lblDia2, lblDia3, lblDia4, lblDia5, lblDia6, lblDia7, lblDia8, lblDia9, lblDia10,
                            lblDia11, lblDia12, lblDia13, lblDia14, lblDia15, lblDia16, lblDia17, lblDia18, lblDia19, lblDia20,
                            lblDia21, lblDia22, lblDia23, lblDia24, lblDia25, lblDia26, lblDia27, lblDia28, lblDia29,lblDia30,
                            lblDia31, lblDia32, lblDia33, lblDia34, lblDia35, lblDia36, lblDia37};
            for (int i = 0;i < paineis.Count();i++)
            {
                paineis[i].BackColor = Color.Teal;
            }
            string dtIni;
            string dtFim;
            DateTime data1;
            DateTime data2;
            string mes1;
            string mes2;
            DateTime dataMax = new DateTime(ano, mes, DateTime.DaysInMonth(ano, mes));
            try
            {
                conex.conectar();
                string sql = "select dt_inicio, dt_fim from torneio;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conex.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dtFim = dt.Rows[i][1].ToString();
                    dtIni = dt.Rows[i][0].ToString();
                    data1 = DateTime.Parse(dtIni);
                    data2 = DateTime.Parse(dtFim);
                    mes1 = data1.Month.ToString("00");
                    mes2 = data2.Month.ToString("00");
                    if (Convert.ToInt16(mes1) - mes == 0 && Convert.ToInt16(mes2) - mes == 0)
                    {
                        
                        for (i = 0; i < paineis.Count(); i++)
                        {
                            if(!String.IsNullOrEmpty(dias[i].Text))
                            {
                                int diaUtual = Convert.ToInt16(dias[i].Text);
                                if (diaUtual >= data1.Day && diaUtual <= data2.Day)
                                    paineis[i].BackColor = Color.IndianRed;
                            }
                                
              
                        }
                    }
                    else if (Convert.ToInt16(mes1) - mes == 0 || Convert.ToInt16(mes1) - mes < 0 && Convert.ToInt16(mes2) - mes > 0)
                    {
                        for (i = 0; i < paineis.Count(); i++)
                        {
                            if (!String.IsNullOrEmpty(dias[i].Text))
                            {
                                int diaUtual = Convert.ToInt16(dias[i].Text);
                                if (diaUtual >= data1.Day)
                                    paineis[i].BackColor = Color.IndianRed;
                            }


                        }
                    }
                    else if (Convert.ToInt16(mes1) - mes < 0 && Convert.ToInt16(mes2) - mes == 0)
                    {
                        for (i = 0; i < paineis.Count(); i++)
                        {
                            if (!String.IsNullOrEmpty(dias[i].Text))
                            {
                                int diaUtual = Convert.ToInt16(dias[i].Text);
                                if (diaUtual <= data2.Day)
                                    paineis[i].BackColor = Color.IndianRed;
                            }


                        }
                    }
                    
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

        private void pnl7_Click(object sender, EventArgs e)
        {
            Panel myPanel = sender as Panel;

        }

        private void lblDia8_Click(object sender, EventArgs e)
        {

        }
    }
}
