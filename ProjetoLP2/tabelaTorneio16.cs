using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoLP2
{
    public partial class tabelaTorneio16 : Form
    {
        connection conex = new connection();
        private string ID;
        private List<string> IDJog = new List<string>();
        private List<string> NumPart = new List<string>();
        public tabelaTorneio16(string id)
        {
            ID = id;
            InitializeComponent();
        }
        private void CriaCampos()
        {
            try
            {
                Label[] top16 = { lbl16Top1, lbl16Top2, lbl16Top3, lbl16Top4, lbl16Top5, lbl16Top6, lbl16Top7, lbl16Top8,
                                    lbl16Top9, lbl16Top10, lbl16Top11, lbl16Top12, lbl16Top13, lbl16Top14, lbl16Top15, lbl16Top16};
                conex.conectar();

                MySqlDataAdapter da = new MySqlDataAdapter("select jogador_id from jogador where jogador_id in(select id_jogador from torneio_perso_jogador where id_torneio ='" + ID + "')", conex.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                string[] id = new string[dt.Rows.Count];
                for (int i = 0; i < top16.Count(); i++)
                {
                    id[i] = Convert.ToString(dt.Rows[i][0]);
                }
                MixArray(id);
                conex.conn.Close();
                for (int i = 0; i < top16.Count(); i++)
                {
                    conex.conectar();
                    string sql = "Select nome from jogador where jogador_id ='" + id[i] + "';";
                    MySqlDataAdapter da2 = new MySqlDataAdapter(sql, conex.conn);
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);
                    if (i % 2 == 0)
                    {
                        string sql2 = "insert into partida(num_partida,id_jogador1,id_torneio,round) values( '" + Convert.ToString((i + 2) / 2) + "','" +
                                       id[i] + "','" + ID + "', 'Oitavas');";
                        MySqlCommand cmd = new MySqlCommand(sql2, conex.conn);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string sql2 = "update partida set id_jogador2 ='" + id[i] + "' where num_partida ='" + Convert.ToString((i + 1) / 2) + "'and id_torneio ='"
                                       + ID + "'; ";
                        MySqlCommand cmd = new MySqlCommand(sql2, conex.conn);
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                    }
                    conex.conn.Close();

                }
            }
            catch (Exception ex)
            {

                throw;
            }

            finally
            {
                CheckCamp();
            }

        }
        public static void MixArray(string[] array)
        {
            int index;
            string temp;
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                index = rand.Next(array.Length);

                temp = array[i];
                array[i] = array[index];
                array[index] = temp;
            }
        }
        private void CheckCamp()
        {
            try
            {
                conex.conectar();
                string sql = "Select * from partida where id_torneio ='" + ID + "';";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conex.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conex.conn.Close();
                if (dt.Rows.Count == 0)
                {
                    CriaCampos();
                }
                else
                {
                    IDJog.Clear();
                    NumPart.Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        IDJog.Add(Convert.ToString(dt.Rows[i][1]));
                        IDJog.Add(Convert.ToString(dt.Rows[i][2]));
                        NumPart.Add(Convert.ToString(dt.Rows[i][0]));
                        NumPart.Add(Convert.ToString(dt.Rows[i][0]));
                    }

                    PreencheCampos();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
        private void PreencheCampos()
        {
            
            conex.conectar();
            Label[] camp = {lbl16Top1, lbl16Top2, lbl16Top3, lbl16Top4, lbl16Top5, lbl16Top6, lbl16Top7, lbl16Top8,
                                    lbl16Top9, lbl16Top10, lbl16Top11, lbl16Top12, lbl16Top13, lbl16Top14, lbl16Top15, lbl16Top16,
                                    lbl8Top1, lbl8Top2, lbl8Top3, lbl8Top4, lbl8Top5, lbl8Top6, lbl8Top7, lbl8Top8,
                                    lbl4Top1, lbl4Top2, lbl4Top3, lbl4Top4, lbl2Top1, lbl2Top1};
            for (int i = 0; i < camp.Count(); i++)
            {
                camp[i].Text = "";
            }
            lbl2Top2.Text = "";
            string sql = "Select concat(j1.nome,' ',j1.sobrenome),concat(j2.nome, ' ',j2.sobrenome ) from jogador j1 inner join partida p on p.id_jogador1 = j1.jogador_id" +
                                " inner join jogador j2 on p.id_jogador2 = j2.jogador_id where id_torneio ='" + ID + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conex.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int lblID = 0;
            for (int i = 0; i < dt.Rows.Count; i++, lblID++)
            {
                camp[lblID].Text = dt.Rows[i][0].ToString();
                lblID++;
                camp[lblID].Text = dt.Rows[i][1].ToString();
                    if (i == 14)
                {
                    lbl2Top1.Text = dt.Rows[14][0].ToString();
                    lbl2Top2.Text = dt.Rows[14][1].ToString();
                }
            }
            conex.conn.Close();
        }

        private void LBLClick(int index, string etapa)
        {
            try
            {
                conex.conectar();
                string sql;
                int numProx;
                numProx = (Convert.ToInt16(NumPart[index]) % 2) + (Convert.ToInt16(NumPart[index]) / 2) + 8;
                sql = "Select * from partida where id_torneio ='" + ID + "'and num_partida ='" + numProx + "';";
                string sql3 = "update partida set id_vencedor ='" + IDJog[index] + "' where num_partida ='" + NumPart[index] + "'and id_torneio ='"
                + ID + "';";
                MySqlCommand cmd2 = new MySqlCommand(sql3, conex.conn);

                MySqlDataAdapter da = new MySqlDataAdapter(sql, conex.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    object value = dt.Rows[0][1];
                    object value2 = dt.Rows[0][2];
                    if (Convert.ToInt16(NumPart[index]) % 2 == 1)
                    {
                        if (value != DBNull.Value)
                        {

                        }
                        else
                        {
                            MessageBoxManager.Yes = "Sim";
                            MessageBoxManager.No = "Não";
                            MessageBoxManager.Register();
                            var confirmResult = MessageBox.Show("Você" + Convert.ToString(numProx) + "está preste a selecionar o ganhador dessa partida, essa mudança não podera ser desfeita. Você selecionou o certo?", "Selecionar Vencedor", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                string sql2 = "update partida set id_jogador1 ='" + IDJog[index] + "' where num_partida ='" + numProx + "'and id_torneio ='"
                                           + ID + "'; ";
                                MySqlCommand cmd = new MySqlCommand(sql2, conex.conn);
                                cmd.ExecuteNonQuery();
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                    else if (Convert.ToInt16(NumPart[index]) % 2 == 0)
                    {
                        if (value2 != DBNull.Value)
                        {
                            conex.conn.Close();
                        }
                        else
                        {
                            MessageBoxManager.Yes = "Sim";
                            MessageBoxManager.No = "Não";
                            MessageBoxManager.Register();
                            var confirmResult = MessageBox.Show("Você" + Convert.ToString(numProx) + "está preste a selecionar o ganhador dessa partida, essa mudança não podera ser desfeita. Você selecionou o certo?", "Selecionar Vencedor", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                string sql2 = "update partida set id_jogador2 ='" + IDJog[index] + "' where num_partida ='" + numProx + "'and id_torneio ='"
                                            + ID + "'; ";
                                MySqlCommand cmd = new MySqlCommand(sql2, conex.conn);
                                cmd.ExecuteNonQuery();
                            }
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    conex.conn.Close();
                }
                else
                {
                    MessageBoxManager.Yes = "Sim";
                    MessageBoxManager.No = "Não";
                    MessageBoxManager.Register();
                    var confirmResult = MessageBox.Show("Você" + Convert.ToString(numProx) + "está preste a selecionar o ganhador dessa partida, essa mudança não podera ser desfeita. Você selecionou o certo?", "Selecionar Vencedor", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (Convert.ToInt16(NumPart[index]) % 2 == 1)
                        {
                            string sql2 = "insert into partida(num_partida,id_jogador1,id_torneio,round) values( '" + numProx + "','" +
                                        IDJog[index] + "','" + ID + "','" + etapa + "');";
                            MySqlCommand cmd = new MySqlCommand(sql2, conex.conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            string sql2 = "insert into partida(num_partida,id_jogador2,id_torneio,round) values( '" + numProx + "','" +
                                        IDJog[index] + "','" + ID + "', '" + etapa + "');";
                            MySqlCommand cmd = new MySqlCommand(sql2, conex.conn);
                            cmd.ExecuteNonQuery();
                        }
                        cmd2.ExecuteNonQuery();
                    }
                    conex.conn.Close();
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                CheckCamp();
            }
        }

        private void tabelaTorneio16_Load(object sender, EventArgs e)
        {
            CheckCamp();
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl16Top1_Click(object sender, EventArgs e)
        {
            Label[] camp = {lbl16Top1, lbl16Top2, lbl16Top3, lbl16Top4, lbl16Top5, lbl16Top6, lbl16Top7, lbl16Top8,
                                    lbl16Top9, lbl16Top10, lbl16Top11, lbl16Top12, lbl16Top13, lbl16Top14, lbl16Top15, lbl16Top16,
                                    lbl8Top1, lbl8Top2, lbl8Top3, lbl8Top4, lbl8Top5, lbl8Top6, lbl8Top7, lbl8Top8,
                                    lbl4Top1, lbl4Top2, lbl4Top3, lbl4Top4, lbl2Top1, lbl2Top1};
            Label myLabel = sender as Label;
            int index = Array.IndexOf(camp, myLabel);
            if (index < 16)
                LBLClick(index, "Quartas");
            else if (index > 15 && index < 24)
                LBLClick(index, "Semi");
            else
                LBLClick(index, "Final");
        }

        private void lbl2Top1_Click(object sender, EventArgs e)
        {
            Label[] camp = {lbl16Top1, lbl16Top2, lbl16Top3, lbl16Top4, lbl16Top5, lbl16Top6, lbl16Top7, lbl16Top8,
                                    lbl16Top9, lbl16Top10, lbl16Top11, lbl16Top12, lbl16Top13, lbl16Top14, lbl16Top15, lbl16Top16,
                                    lbl8Top1, lbl8Top2, lbl8Top3, lbl8Top4, lbl8Top5, lbl8Top6, lbl8Top7, lbl8Top8,
                                    lbl4Top1, lbl4Top2, lbl4Top3, lbl4Top4, lbl2Top1, lbl2Top1};
            Label myLabel = sender as Label;
            int index = Array.IndexOf(camp, myLabel);

            MessageBoxManager.Yes = "Sim";
            MessageBoxManager.No = "Não";
            MessageBoxManager.Register();
            var confirmResult = MessageBox.Show("Você está preste a selecionar o ganhador do campeonato, essa mudança não podera ser desfeita. Você selecionou o certo?", "Selecionar Vencedor", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                conex.conn.Open();
                string sql2 = "update partida set id_vencedor ='" + IDJog[index] + "' where num_partida ='" + NumPart[index] + "'and id_torneio ='"
                            + ID + "'; ";
                MySqlCommand cmd = new MySqlCommand(sql2, conex.conn);
                cmd.ExecuteNonQuery();
                conex.conn.Close();
            }
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
