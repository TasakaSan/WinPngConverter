
namespace WinPngConverter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cBox_Format = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ActionCompress = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_DestinationFile = new System.Windows.Forms.Button();
            this.tb_DestinationFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_SearchFile = new System.Windows.Forms.Button();
            this.tb_SearchFile = new System.Windows.Forms.TextBox();
            this.cBox_Compress = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleBtn = new WinPngConverter.ToggleButton.ToggleButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "WinPNG Converter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 100);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.toggleBtn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cBox_Format);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_ActionCompress);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_DestinationFile);
            this.panel2.Controls.Add(this.tb_DestinationFile);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_SearchFile);
            this.panel2.Controls.Add(this.tb_SearchFile);
            this.panel2.Controls.Add(this.cBox_Compress);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(816, 269);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(68, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Select format :";
            // 
            // cBox_Format
            // 
            this.cBox_Format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Format.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Format.FormattingEnabled = true;
            this.cBox_Format.Location = new System.Drawing.Point(226, 160);
            this.cBox_Format.Name = "cBox_Format";
            this.cBox_Format.Size = new System.Drawing.Size(121, 28);
            this.cBox_Format.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(599, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "File / Folder";
            // 
            // btn_ActionCompress
            // 
            this.btn_ActionCompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActionCompress.Location = new System.Drawing.Point(603, 200);
            this.btn_ActionCompress.Name = "btn_ActionCompress";
            this.btn_ActionCompress.Size = new System.Drawing.Size(184, 35);
            this.btn_ActionCompress.TabIndex = 13;
            this.btn_ActionCompress.Text = "Convert / Compress";
            this.btn_ActionCompress.UseVisualStyleBackColor = true;
            this.btn_ActionCompress.Click += new System.EventHandler(this.btn_ActionCompress_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(32, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Compress quality :";
            // 
            // btn_DestinationFile
            // 
            this.btn_DestinationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DestinationFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_DestinationFile.Location = new System.Drawing.Point(721, 80);
            this.btn_DestinationFile.Name = "btn_DestinationFile";
            this.btn_DestinationFile.Size = new System.Drawing.Size(66, 26);
            this.btn_DestinationFile.TabIndex = 11;
            this.btn_DestinationFile.Text = "...";
            this.btn_DestinationFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_DestinationFile.UseVisualStyleBackColor = true;
            this.btn_DestinationFile.Click += new System.EventHandler(this.btn_DestinationFile_Click);
            // 
            // tb_DestinationFile
            // 
            this.tb_DestinationFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_DestinationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DestinationFile.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_DestinationFile.Location = new System.Drawing.Point(226, 80);
            this.tb_DestinationFile.Name = "tb_DestinationFile";
            this.tb_DestinationFile.Size = new System.Drawing.Size(489, 26);
            this.tb_DestinationFile.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(56, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Destination file :";
            // 
            // btn_SearchFile
            // 
            this.btn_SearchFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_SearchFile.Location = new System.Drawing.Point(721, 40);
            this.btn_SearchFile.Name = "btn_SearchFile";
            this.btn_SearchFile.Size = new System.Drawing.Size(66, 26);
            this.btn_SearchFile.TabIndex = 7;
            this.btn_SearchFile.Text = "...";
            this.btn_SearchFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SearchFile.UseVisualStyleBackColor = true;
            this.btn_SearchFile.Click += new System.EventHandler(this.btn_SearchFile_Click);
            // 
            // tb_SearchFile
            // 
            this.tb_SearchFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_SearchFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SearchFile.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_SearchFile.Location = new System.Drawing.Point(226, 40);
            this.tb_SearchFile.Name = "tb_SearchFile";
            this.tb_SearchFile.Size = new System.Drawing.Size(489, 26);
            this.tb_SearchFile.TabIndex = 6;
            // 
            // cBox_Compress
            // 
            this.cBox_Compress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Compress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_Compress.FormattingEnabled = true;
            this.cBox_Compress.Location = new System.Drawing.Point(226, 120);
            this.cBox_Compress.Name = "cBox_Compress";
            this.cBox_Compress.Size = new System.Drawing.Size(121, 28);
            this.cBox_Compress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(87, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Source file :";
            // 
            // toggleBtn
            // 
            this.toggleBtn.AutoSize = true;
            this.toggleBtn.Location = new System.Drawing.Point(742, 120);
            this.toggleBtn.MinimumSize = new System.Drawing.Size(45, 25);
            this.toggleBtn.Name = "toggleBtn";
            this.toggleBtn.Size = new System.Drawing.Size(45, 25);
            this.toggleBtn.TabIndex = 17;
            this.toggleBtn.UseVisualStyleBackColor = true;
            this.toggleBtn.CheckedChanged += new System.EventHandler(this.toggleBtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 369);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cBox_Compress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SearchFile;
        private System.Windows.Forms.TextBox tb_SearchFile;
        private System.Windows.Forms.Button btn_ActionCompress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_DestinationFile;
        private System.Windows.Forms.TextBox tb_DestinationFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBox_Format;
        private System.Windows.Forms.Label label3;
        private ToggleButton.ToggleButton toggleBtn;
    }
}

