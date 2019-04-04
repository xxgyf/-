using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace screen
{
    public partial class frmConfig : Form
    {
        public static String keypath = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Screensavers\\" + Application.ProductName;
        public frmConfig()
        {
            InitializeComponent();
        }
         
        private void frmConfig_Load(object sender, EventArgs e)
        {
            cbShowHello.Checked = bool.Parse((String)Registry.GetValue(keypath, "showHello", true));
            cbShowNowTime.Checked = bool.Parse((String)Registry.GetValue(keypath, "showNowTime", true));
            cbShowText.Checked = bool.Parse((String)Registry.GetValue(keypath, "ShowText", false));
            txtFilePath.Text= (String)Registry.GetValue(keypath,"textFile","C://user");
            btnSelectColor.BackColor = Color.FromArgb((int)Registry.GetValue(keypath, "backGroundColor", Color.Green.ToArgb()));
             //colorDialog1.Color = Color.Green;
            openFileDialog1.Filter = "文本文件|*.txt";
        }
         
        private void cbShowText_CheckedChanged(object sender, EventArgs e)
        {
            SelectFile.Enabled = cbShowText.Checked;
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnSelectColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Registry.SetValue(keypath, "showHello", cbShowHello.Checked);
            Registry.SetValue(keypath, "showNowTime", cbShowNowTime.Checked);
            Registry.SetValue(keypath, "showText", cbShowText.Checked);
            Registry.SetValue(keypath, "textFile", txtFilePath.Text);
            Registry.SetValue(keypath, "backGroundColor", btnSelectColor.BackColor.ToArgb(),RegistryValueKind.DWord);
        }
    }
}
