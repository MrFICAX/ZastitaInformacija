using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17503_FILIP_TRAJKOVIC_1_ZADATAK
{
    public partial class Form1 : Form
    {
        bool tmp_flag = true;
        FSWatcher fs;
        private FolderBrowserDialog fbdChooseFolder;
        string destinationBrowseFolder;
        string targetBrowseFolder;
        string key;
        bool keySet;

        byte[] _ucitanFajl;

        private A51Algorithm a51;


        public Form1()
        {
            fs = new FSWatcher();
            targetBrowseFolder = "";
            destinationBrowseFolder = "";
            this.fbdChooseFolder = new FolderBrowserDialog();
            keySet = false;
            InitializeComponent();
        }

        private void TurnOnOrOffButtons(bool value)
        {
            //this.cRdCr_Button.Enabled = value;
            this.DESTBROWSE_Button.Enabled = value;
            this.TARGETBROWSE_Button.Enabled = value;
            this.button2.Enabled = value;
            this.button1.Enabled = value;
            this.LOADFILE_Button.Enabled = value;
            this.SAVEFILE_Button.Enabled = value;
            this.cRdCr_Button.Enabled = value;
        }

        private void FSW_Button_Click(object sender, EventArgs e)
        {
            if (!fs.IsWatcherSystemOn())
            {
                try
                {
                    fs.TurnOnFileSystemWatcher();
                    FSW_Button.Text = "TURN OFF";
                    FSW_Button.BackColor = Color.RoyalBlue;
                    TurnOnOrOffButtons(false);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Couldn't turn on File Watcher System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                fs.TurnOffFileSystemWatcher();
                FSW_Button.Text = "TURN ON";
                FSW_Button.BackColor = Color.Red;
                TurnOnOrOffButtons(true);
            }
        }

        private void TARGETBROWSE_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fbdChooseFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (fs.SetWatchedDirectory(fbdChooseFolder.SelectedPath))
                {
                    targetBrowseFolder = fbdChooseFolder.SelectedPath;
                    TARGET_NAME_Lbl.Text = targetBrowseFolder;
                }
                else
                    MessageBox.Show("ERROR! DIRECTORY NOT SET!", "ERROR MESSAGE", MessageBoxButtons.OK );
            }
        }

        private void DESTBROWSE_Button_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fbdChooseFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (fs.SetOutputDirectory(fbdChooseFolder.SelectedPath))
                {
                    destinationBrowseFolder = fbdChooseFolder.SelectedPath;
                    DEST_NAME_Lbl.Text = destinationBrowseFolder;
                }
                else
                    MessageBox.Show("ERROR! DIRECTORY NOT SET!", "ERROR MESSAGE", MessageBoxButtons.OK);

            }
        }

        private void LOADFILE_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text|*.txt|All|*.*";
            dialog.InitialDirectory = "C:\\Users\\Legion\\Desktop";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String putanja = dialog.FileName;
                FileStream fajlZaCitanje = null;
                try
                {
                    fajlZaCitanje = new FileStream(putanja, FileMode.Open);
                    int velicina = (int)fajlZaCitanje.Length;
                    byte[] nizBajtova = new byte[velicina];
                    fajlZaCitanje.Read(nizBajtova, 0, velicina);
                    _ucitanFajl = nizBajtova;
                    TEXT_CR_DECR_Tbx.Text = Encoding.ASCII.GetString(_ucitanFajl);
                }
                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString(),
                "Error",
                 MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                }
                finally
                {
                    fajlZaCitanje.Close();
                }
                return;
            }
            MessageBox.Show("TXT FILE NOT SELECTED.",
                         "Notification",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
        }

        private void SAVEFILE_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog folderDialog = new SaveFileDialog();
            folderDialog.Filter = "Text|*.txt|All|*.*";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fajlZaUpis = null;
                try
                {
                    byte[] tekstZaUpis = new byte[this.TEXT_CR_DECR_Tbx.TextLength];
                    tekstZaUpis = Encoding.UTF8.GetBytes(this.TEXT_CR_DECR_Tbx.Text);

                    fajlZaUpis = new FileStream(folderDialog.FileName, FileMode.Create);
                    fajlZaUpis.Write(tekstZaUpis, 0, tekstZaUpis.Length);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    fajlZaUpis.Close();
                }
                return;
            }
            MessageBox.Show("FOLDER ISN'T SELECTED.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        private void cRdCr_Button_Click(object sender, EventArgs e)
        {          
            if(!keySet)
            {
                MessageBox.Show("Please set the key!",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            if(this.TEXT_CR_DECR_Tbx.Text.Length == 0)
            {
                MessageBox.Show("Please input the text for crypting.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }

            if (!RadioButtonsChecked())
            {
                MessageBox.Show("Please check radio buttons.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            SetTmpFlag();

            this.TEXT_CR_DECR_Tbx.Text = keySet ? tmp_flag ? a51.Crypt(this.TEXT_CR_DECR_Tbx.Text)
                                                    : a51.DeCrypt(this.TEXT_CR_DECR_Tbx.Text) : "";
        }

        private bool RadioButtonsChecked()
        {
            if (rdbCrypt.Checked == true || rdbDecrypt.Checked == true)
                return true;
            else
                return false;
        }

        private void SetTmpFlag()
        {
            if (rdbCrypt.Checked == true)
                tmp_flag = true;
            else
                tmp_flag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KEY_Tbx.Text.Length != 64)
            {
                MessageBox.Show("YOU DIDN'T INPUT 64 BITS.",
                        "Notification",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                return;
            }
            this.key = KEY_Tbx.Text;
            keySet = true;
            a51 = new A51Algorithm(this.key);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //set default key
            a51 = new A51Algorithm();
            this.key = a51.Key;
            this.KEY_Tbx.Text = this.key;
            keySet = true;
        }
    }
}
