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
        private connection conex = new connection();
        public partControl()
        {
            InitializeComponent();
            addPartControl1.Visible = false;
            preencherTabela();
            dtTeste.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPartControl1.Visible = true;
            dtTeste.Visible = false;
        }

        private void partControl_Load(object sender, EventArgs e)
        {

        }

        private void preencherTabela()
        {
            conex.conectar();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM jogador", conex.conn);
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
    }
}
