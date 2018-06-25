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
using System.Runtime.InteropServices;


namespace ProjetoLP2
{
    public partial class frmPrincipal : Form
    {
        //<--Variaveis pra possibilitar mexer o aplicativo
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //-->
        public frmPrincipal()
        {
            InitializeComponent();
            SideBar.Height = homeBtn.Height;
            SideBar.Top = homeBtn.Top;
            homeControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SideBar.Height = torneioBtn.Height;
            SideBar.Top = torneioBtn.Top;
            torneiosControl1.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SideBar.Height = participanteBtn.Height;
            SideBar.Top = participanteBtn.Top;
            partControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SideBar.Height = homeBtn.Height;
            SideBar.Top = homeBtn.Top;
            homeControl1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SideBar.Height = button4.Height;
            SideBar.Top = button4.Top;
            calendario1.BringToFront();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void torneiosControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void partControl1_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
