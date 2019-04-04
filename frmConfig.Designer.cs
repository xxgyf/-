namespace screen
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbShowText = new System.Windows.Forms.CheckBox();
            this.cbShowHello = new System.Windows.Forms.CheckBox();
            this.cbShowNowTime = new System.Windows.Forms.CheckBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.SelectFile = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SelectFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbShowText
            // 
            this.cbShowText.AutoSize = true;
            this.cbShowText.Checked = true;
            this.cbShowText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowText.Location = new System.Drawing.Point(120, 84);
            this.cbShowText.Name = "cbShowText";
            this.cbShowText.Size = new System.Drawing.Size(72, 16);
            this.cbShowText.TabIndex = 0;
            this.cbShowText.Text = "显示文字";
            this.cbShowText.UseVisualStyleBackColor = true;
            this.cbShowText.CheckedChanged += new System.EventHandler(this.cbShowText_CheckedChanged);
            // 
            // cbShowHello
            // 
            this.cbShowHello.AutoSize = true;
            this.cbShowHello.Location = new System.Drawing.Point(120, 62);
            this.cbShowHello.Name = "cbShowHello";
            this.cbShowHello.Size = new System.Drawing.Size(108, 16);
            this.cbShowHello.TabIndex = 1;
            this.cbShowHello.Text = "显示helloworld";
            this.cbShowHello.UseVisualStyleBackColor = true;
            // 
            // cbShowNowTime
            // 
            this.cbShowNowTime.AutoSize = true;
            this.cbShowNowTime.Location = new System.Drawing.Point(234, 62);
            this.cbShowNowTime.Name = "cbShowNowTime";
            this.cbShowNowTime.Size = new System.Drawing.Size(72, 16);
            this.cbShowNowTime.TabIndex = 2;
            this.cbShowNowTime.Text = "显示时间";
            this.cbShowNowTime.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(3, 3);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(188, 21);
            this.txtFilePath.TabIndex = 3;
            // 
            // SelectFile
            // 
            this.SelectFile.Controls.Add(this.txtFilePath);
            this.SelectFile.Controls.Add(this.btnSelectFile);
            this.SelectFile.Location = new System.Drawing.Point(120, 106);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(297, 29);
            this.SelectFile.TabIndex = 4;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(197, 3);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 4;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.Location = new System.Drawing.Point(120, 146);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(34, 23);
            this.btnSelectColor.TabIndex = 5;
            this.btnSelectColor.UseVisualStyleBackColor = true;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "背景色";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectColor);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.cbShowNowTime);
            this.Controls.Add(this.cbShowHello);
            this.Controls.Add(this.cbShowText);
            this.Name = "frmConfig";
            this.ShowIcon = false;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.SelectFile.ResumeLayout(false);
            this.SelectFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox cbShowText;
        private System.Windows.Forms.CheckBox cbShowHello;
        private System.Windows.Forms.CheckBox cbShowNowTime;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.FlowLayoutPanel SelectFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}