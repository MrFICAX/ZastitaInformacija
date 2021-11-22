
namespace _17503_FILIP_TRAJKOVIC_1_ZADATAK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.FSW_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TEXT_CR_DECR_Tbx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SAVEFILE_Button = new System.Windows.Forms.Button();
            this.cRdCr_Button = new System.Windows.Forms.Button();
            this.LOADFILE_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TARGETBROWSE_Button = new System.Windows.Forms.Button();
            this.TARGET_NAME_Lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DESTBROWSE_Button = new System.Windows.Forms.Button();
            this.DEST_NAME_Lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KEY_Tbx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rdbCrypt = new System.Windows.Forms.RadioButton();
            this.rdbDecrypt = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "A5/1 CRYPTOGRAPHY MACHINE";
            // 
            // FSW_Button
            // 
            this.FSW_Button.BackColor = System.Drawing.Color.Firebrick;
            this.FSW_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSW_Button.Location = new System.Drawing.Point(33, 148);
            this.FSW_Button.Name = "FSW_Button";
            this.FSW_Button.Size = new System.Drawing.Size(250, 45);
            this.FSW_Button.TabIndex = 1;
            this.FSW_Button.Text = "TURN ON";
            this.FSW_Button.UseVisualStyleBackColor = false;
            this.FSW_Button.Click += new System.EventHandler(this.FSW_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "FILE SYSTEM WATCHER";
            // 
            // TEXT_CR_DECR_Tbx
            // 
            this.TEXT_CR_DECR_Tbx.Location = new System.Drawing.Point(19, 67);
            this.TEXT_CR_DECR_Tbx.Multiline = true;
            this.TEXT_CR_DECR_Tbx.Name = "TEXT_CR_DECR_Tbx";
            this.TEXT_CR_DECR_Tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TEXT_CR_DECR_Tbx.Size = new System.Drawing.Size(438, 471);
            this.TEXT_CR_DECR_Tbx.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.SAVEFILE_Button);
            this.groupBox1.Controls.Add(this.cRdCr_Button);
            this.groupBox1.Controls.Add(this.LOADFILE_Button);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TEXT_CR_DECR_Tbx);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(508, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 555);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRYPT/DECRYPT";
            // 
            // SAVEFILE_Button
            // 
            this.SAVEFILE_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.SAVEFILE_Button.Location = new System.Drawing.Point(463, 193);
            this.SAVEFILE_Button.Name = "SAVEFILE_Button";
            this.SAVEFILE_Button.Size = new System.Drawing.Size(222, 60);
            this.SAVEFILE_Button.TabIndex = 7;
            this.SAVEFILE_Button.Text = "SAVE FILE";
            this.SAVEFILE_Button.UseVisualStyleBackColor = false;
            this.SAVEFILE_Button.Click += new System.EventHandler(this.SAVEFILE_Button_Click);
            // 
            // cRdCr_Button
            // 
            this.cRdCr_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.cRdCr_Button.Location = new System.Drawing.Point(469, 478);
            this.cRdCr_Button.Name = "cRdCr_Button";
            this.cRdCr_Button.Size = new System.Drawing.Size(222, 60);
            this.cRdCr_Button.TabIndex = 6;
            this.cRdCr_Button.Text = "CRYPT/DECRYPT";
            this.cRdCr_Button.UseVisualStyleBackColor = false;
            this.cRdCr_Button.Click += new System.EventHandler(this.cRdCr_Button_Click);
            // 
            // LOADFILE_Button
            // 
            this.LOADFILE_Button.BackColor = System.Drawing.SystemColors.Highlight;
            this.LOADFILE_Button.Location = new System.Drawing.Point(463, 117);
            this.LOADFILE_Button.Name = "LOADFILE_Button";
            this.LOADFILE_Button.Size = new System.Drawing.Size(222, 60);
            this.LOADFILE_Button.TabIndex = 5;
            this.LOADFILE_Button.Text = "LOAD FILE";
            this.LOADFILE_Button.UseVisualStyleBackColor = false;
            this.LOADFILE_Button.Click += new System.EventHandler(this.LOADFILE_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "TEXT:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TARGETBROWSE_Button);
            this.groupBox2.Controls.Add(this.TARGET_NAME_Lbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(33, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 255);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TARGET FOLDER";
            // 
            // TARGETBROWSE_Button
            // 
            this.TARGETBROWSE_Button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TARGETBROWSE_Button.Location = new System.Drawing.Point(56, 178);
            this.TARGETBROWSE_Button.Name = "TARGETBROWSE_Button";
            this.TARGETBROWSE_Button.Size = new System.Drawing.Size(333, 48);
            this.TARGETBROWSE_Button.TabIndex = 2;
            this.TARGETBROWSE_Button.Text = "BROWSE";
            this.TARGETBROWSE_Button.UseVisualStyleBackColor = true;
            this.TARGETBROWSE_Button.Click += new System.EventHandler(this.TARGETBROWSE_Button_Click);
            // 
            // TARGET_NAME_Lbl
            // 
            this.TARGET_NAME_Lbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TARGET_NAME_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TARGET_NAME_Lbl.Location = new System.Drawing.Point(21, 49);
            this.TARGET_NAME_Lbl.Name = "TARGET_NAME_Lbl";
            this.TARGET_NAME_Lbl.Size = new System.Drawing.Size(419, 126);
            this.TARGET_NAME_Lbl.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "TARGET FOLDER PATH:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DESTBROWSE_Button);
            this.groupBox3.Controls.Add(this.DEST_NAME_Lbl);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(33, 514);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 257);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DESTINATION FOLDER";
            // 
            // DESTBROWSE_Button
            // 
            this.DESTBROWSE_Button.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DESTBROWSE_Button.Location = new System.Drawing.Point(56, 178);
            this.DESTBROWSE_Button.Name = "DESTBROWSE_Button";
            this.DESTBROWSE_Button.Size = new System.Drawing.Size(333, 48);
            this.DESTBROWSE_Button.TabIndex = 2;
            this.DESTBROWSE_Button.Text = "BROWSE";
            this.DESTBROWSE_Button.UseVisualStyleBackColor = true;
            this.DESTBROWSE_Button.Click += new System.EventHandler(this.DESTBROWSE_Button_Click);
            // 
            // DEST_NAME_Lbl
            // 
            this.DEST_NAME_Lbl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DEST_NAME_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEST_NAME_Lbl.Location = new System.Drawing.Point(21, 49);
            this.DEST_NAME_Lbl.Name = "DEST_NAME_Lbl";
            this.DEST_NAME_Lbl.Size = new System.Drawing.Size(419, 117);
            this.DEST_NAME_Lbl.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "DESTINATION FOLDER PATH:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(905, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "UNESITE 64-BIT KLJUC:";
            // 
            // KEY_Tbx
            // 
            this.KEY_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KEY_Tbx.Location = new System.Drawing.Point(560, 116);
            this.KEY_Tbx.Name = "KEY_Tbx";
            this.KEY_Tbx.Size = new System.Drawing.Size(616, 26);
            this.KEY_Tbx.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(926, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "SET KEY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(560, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "SET DEFAULT KEY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rdbCrypt
            // 
            this.rdbCrypt.AutoSize = true;
            this.rdbCrypt.Location = new System.Drawing.Point(36, 12);
            this.rdbCrypt.Name = "rdbCrypt";
            this.rdbCrypt.Size = new System.Drawing.Size(80, 24);
            this.rdbCrypt.TabIndex = 8;
            this.rdbCrypt.TabStop = true;
            this.rdbCrypt.Text = "CRYPT";
            this.rdbCrypt.UseVisualStyleBackColor = true;
            // 
            // rdbDecrypt
            // 
            this.rdbDecrypt.AutoSize = true;
            this.rdbDecrypt.Location = new System.Drawing.Point(36, 50);
            this.rdbDecrypt.Name = "rdbDecrypt";
            this.rdbDecrypt.Size = new System.Drawing.Size(103, 24);
            this.rdbDecrypt.TabIndex = 9;
            this.rdbDecrypt.TabStop = true;
            this.rdbDecrypt.Text = "DECRYPT";
            this.rdbDecrypt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbCrypt);
            this.panel1.Controls.Add(this.rdbDecrypt);
            this.panel1.Location = new System.Drawing.Point(497, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 89);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 783);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KEY_Tbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FSW_Button);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "A5/1 MACHINE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FSW_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TEXT_CR_DECR_Tbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SAVEFILE_Button;
        private System.Windows.Forms.Button cRdCr_Button;
        private System.Windows.Forms.Button LOADFILE_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TARGETBROWSE_Button;
        private System.Windows.Forms.Label TARGET_NAME_Lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DESTBROWSE_Button;
        private System.Windows.Forms.Label DEST_NAME_Lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KEY_Tbx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbCrypt;
        private System.Windows.Forms.RadioButton rdbDecrypt;
    }
}

