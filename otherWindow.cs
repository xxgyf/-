using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace screen
{

    class otherWindow
    {
        public static otherWindow other;
        public Bitmap paper;
        Graphics graphics;
        IntPtr h;
        RECT rect;
        [DllImport("user32")]
        public static extern bool GetClientRect(IntPtr hwnd, out RECT rect);
        [DllImport("user32")]
        public static extern bool IsWindow(IntPtr hwnd);

        IntPtr hin;
        UInt16 atom;
        public otherWindow(int hwnd, Bitmap paper)
        {
            hin = System.Diagnostics.Process.GetCurrentProcess().Handle;
            h = new IntPtr(hwnd);
            rect = new RECT();
            bool result = GetClientRect(h, out rect);
            rc();
            h = WinAPI.CreateWindowEx2((WindowStylesEx)0, atom, Application.ProductName, WindowStyles.WS_CHILD|WindowStyles.WS_VISIBLE, 0, 0, rect.Right, rect.Bottom, h, IntPtr.Zero, hin, IntPtr.Zero);
            //MessageBox.Show(h.ToString());
            Console.WriteLine(h);
            this.paper = paper;
            graphics = Graphics.FromHwnd(h);
            other = this;
        }

        string classname = "MyScreen";

        private void rc()
        {
            WNDCLASS nw = new WNDCLASS();
            nw.hInstance = hin;
            nw.lpszClassName = classname;
            nw.hCursor = WinAPI.LoadCursor(IntPtr.Zero,0);
            nw.hIcon = IntPtr.Zero;
            nw.lpfnWndProc = proc;
            nw.lpszMenuName = "";
            nw.style =  ClassStyles.HorizontalRedraw|ClassStyles.VerticalRedraw|ClassStyles.ParentDC|ClassStyles.GlobalClass;
            nw.hbrBackground = WinAPI.GetStockObject(StockObjects.WHITE_BRUSH);
            nw.cbClsExtra = 0;
            nw.cbWndExtra = 0;
            Console.WriteLine(atom=WinAPI.RegisterClass(ref nw));
        }
        static IntPtr proc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
        {
            IntPtr hdc;
            PAINTSTRUCT ps;
            RECT rect;
            //switch ((WM) message)
            //{
            //    WinAPI.BeginPaint(hWnd, out ps);
            //    break;
            //}
            switch ((WM)msg)
            {
                case WM.DESTROY:
                    WinAPI.PostQuitMessage(0);
                    return IntPtr.Zero;
                    //break;
            }

            return WinAPI.DefWindowProc(hWnd, (WM)msg, wParam, lParam);
        }
        public bool show()
        {
            if(!IsWindow(h))
            {
                return true;
            }
            graphics.DrawImage(paper, rect.Left, rect.Top, rect.Right, rect.Bottom);
            return false;
        }
    }
}
