using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace screen
{
    static class Program
    {
        static char type = ' ';
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(args.Length==0|| (type = args[0].ToLower()[1])=='c')
            {
                Application.Run(new frmConfig());
            }else
            {
                Painter painter = new Painter();
                controller controller = new controller(painter);
                Timer timer = new Timer();
                timer.Interval = 100;
                timer.Tick += timer_tick;
                timer.Start();
                switch(type)
                {
                    case 's':
                        Form f = new frmScreen(painter.getPaper());
                        controller.init();
                        Application.Run(f);
                        break;
                    case 'p':
                        new otherWindow(int.Parse(args[1]), painter.getPaper());
                        Application.Run();
                        break;
                }
            }
        }

        private static void timer_tick(object sender, EventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("Test");
            controller.main.paint();
            switch(type)
            {
                case 's':
                    frmScreen.scr.paper = Painter.painter.getPaper();
                    frmScreen.scr.Refresh();
                    break;
                case 'p':
                    otherWindow.other.paper = Painter.painter.getPaper();
                    if(otherWindow.other.show())Application.Exit();
                    break;
            }
        }
    }
}
