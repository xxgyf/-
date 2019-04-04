using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen
{
    partial class controller
    {
        Painter painter;
        public static controller main;
        public frmScreen frm;
        public controller(Painter p)
        {
            painter = p;
            main = this;
        }

        public void init()
        {
            frm.Click += Frm_Click;
            frm.KeyDown += Frm_KeyDown;
        }

        private void Frm_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void paint()
        {
            painter.paint();
        }
    }
}
