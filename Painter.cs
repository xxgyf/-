using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using Microsoft.Win32;

namespace screen
{
    partial class Painter
    {
        Bitmap paper;
        public static Painter painter;
        Graphics graphics;

        Font font;
        String[] texts;
        String filename;
        bool showHello, showNowTime, showText;
        Color backcolor;
        Random rand = new Random();
        SizeF sizeF;
        public Painter()
        {
            paper = new Bitmap(1920,1048);
            painter = this;

            showHello = bool.Parse((String)Registry.GetValue(frmConfig.keypath, "showHello", true));
            showNowTime = bool.Parse((String)Registry.GetValue(frmConfig.keypath, "showNowTime", true));
            showText = bool.Parse((String)Registry.GetValue(frmConfig.keypath, "ShowText", false));
            filename = (String)Registry.GetValue(frmConfig.keypath, "textFile", "C://user");
            backcolor = Color.FromArgb((int)Registry.GetValue(frmConfig.keypath, "backGroundColor", Color.Green.ToArgb()));
            font = new Font("黑体", 30);

            graphics = Graphics.FromImage(paper);
            if (showText)
            {
                if (File.Exists(filename))
                {
                    texts = File.ReadAllLines(filename);
                }
                else
                {
                    texts = new String[] { "Hello world" };
                    File.WriteAllLines(filename, texts);
                }
                text = texts[rand.Next()%texts.Length];
                sizeF= graphics.MeasureString(text, font);
                x = rand.Next() % (int)(paper.Width-sizeF.Width);
                y = rand.Next() % (int)(paper.Height-sizeF.Height);
            }
        }
        public Bitmap getPaper()
        {
            return paper;
        }
        double t = 0;
        String text;
        int x, y;
        public void paint()
        {
            //int r = t & 0xff;
            //t >>= 8;
            //int g = t & 0xff;
            //t >>= 8;
            //int b = t & 0xff;
            graphics.Clear(backcolor);
            double sint = Math.Sin(t);

            if (showText)
            {
                if (sint >= 0)
                {
                    graphics.DrawString(text, font, new Pen(Color.FromArgb((int)(backcolor.R * (1 - sint)), (int)(backcolor.G * (1 - sint)), (int)(backcolor.B * (1 - sint)))).Brush, x, y);
                    t+=0.1;
                }
                else
                {
                    t = 0;
                    text = texts[rand.Next() % texts.Length];
                    sizeF = graphics.MeasureString(text, font);
                    x = rand.Next() % (int)(paper.Width - sizeF.Width);
                    y = rand.Next() % (int)(paper.Height - sizeF.Height);
                }

            }
            if(showHello)graphics.DrawString("hello world", font, Brushes.Black, 0, 0);
            if(showNowTime)graphics.DrawString(DateTime.Now.ToString(), font, Brushes.Black, 0, font.Height);
        }
    }
}
