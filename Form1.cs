using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen
{
    public partial class frmScreen : Form
    {
        public Bitmap paper;
        public static frmScreen scr;
        //public static MouseEventArgs mouseEvent = null;
        public frmScreen(Bitmap paper)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            this.paper = paper;
            scr = this;
            controller.main.frm = this;
        }

        private void close_frmScreen(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void frmScreen_Paint(object sender, PaintEventArgs e)
        {
            //Console.WriteLine("ppp");
            e.Graphics.DrawImage(paper,0,0,Width,Height);
        }
        [DllImport("user32")]
        public static extern void ShowCursor(bool i);

        private void frmScreen_Load(object sender, EventArgs e)
        {
            ShowCursor(false);
        }

        private void frmScreen_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
    }
}
