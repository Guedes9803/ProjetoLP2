using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLP2
{
    public partial class partControl : UserControl
    {
        public partControl()
        {
            InitializeComponent();
            addPartControl1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPartControl1.Visible = true;
        }

        private void partControl_Load(object sender, EventArgs e)
        {

        }

        private void addPartControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
