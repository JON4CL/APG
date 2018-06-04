using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace APG
{
    public partial class FrmPlayer : Form
    {
        internal SSFile ssFile;

        //FORM FULLSCREEN PERSISTENCE
        private bool isFullScreen = false;
        private Point formLocation;
        private Size formSize;
        private FormWindowState formState;

        //FILE NAME
        internal string fileName;
        internal string fileSize;

        //MOUSE COORDS
        private int mouseX = 0;
        private int mouseY = 0;

        public FrmPlayer()
        {
            InitializeComponent();
        }
        
        private void tbPlayerBar_ValueChanged(object sender, EventArgs e)
        {
            pbPlayer.Image = ImageTools.ImageFromBase64(ssFile.GetFrameById(tbPlayerBar.Value).GetFrameData());
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            initPlayer();
            FrmPlayer_Resize(null, null);
        }

        private void initPlayer()
        {
            ssFile = new SSFile();

            fileName = "";

            //MenuBar
            newToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            captureToolStripMenuItem.Enabled = true;
            changeDisplayTimeToolStripMenuItem.Enabled = false;
            frameToolStripMenuItem.Enabled = false;
            fileInfoToolStripMenuItem.Enabled = false;

            //ButtonBar
            tsbNew.Enabled = false;
            tsbOpen.Enabled = true;
            tsbPlay.Enabled = false;
            tsbStop.Enabled = false;
            tsbLoop.Enabled = false;
            tsbLoop.Checked = true;
            tsbExpand.Enabled = false;
            tsbDeleteFrame.Enabled = false;
            tsbRecord.Enabled = true;
            tsbSave.Enabled = false;
            tsbFrameExport.Enabled = false;
            tsbFileInformation.Enabled = false;

            timerPlayer.Enabled = false;

            tbPlayerBar.Maximum = 0;

            pbPlayer.Image = null;
            pbPlayer.Size = new Size(0, 0);
            pbPlayer.Location = new Point(0, 0);
        }

        private void loadFileIntoPlayer()
        {
            //MenuBar
            newToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
            captureToolStripMenuItem.Enabled = false;
            changeDisplayTimeToolStripMenuItem.Enabled = true;
            frameToolStripMenuItem.Enabled = true;
            fileInfoToolStripMenuItem.Enabled = true;

            //ButtonBar
            tsbNew.Enabled = true;
            tsbOpen.Enabled = true;
            tsbPlay.Enabled = true;
            tsbStop.Enabled = true;
            tsbLoop.Enabled = true;
            tsbLoop.Checked = true;
            tsbExpand.Enabled = true;
            tsbDeleteFrame.Enabled = true;
            tsbRecord.Enabled = false;
            tsbSave.Enabled = true;
            tsbFrameExport.Enabled = true;
            tsbFileInformation.Enabled = false;

            timerPlayer.Enabled = false;

            tbPlayerBar.Maximum = ssFile.GetFramesCount() - 1;

            pbPlayer.Image = ImageTools.ImageFromBase64(ssFile.GetFrameById(0).GetFrameData());
            
            FrmPlayer_Resize(null, null);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (tbPlayerBar.Value == ssFile.GetFramesCount()-1)
            {
                if(tsbLoop.Checked)
                {
                    tbPlayerBar.Value = 0;
                }
                else
                {
                    tsbStop_Click(null, null);
                }
            }
            else
            {
                tbPlayerBar.Value++;
            }
        }

        //MENU BUTTONS
        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "APG files (*.apg)|*.apg";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream fileStream = null;
                    if ((fileStream = ofd.OpenFile()) != null)
                    {
                        using (fileStream)
                        {
                            ssFile = new SSFile(fileStream);
                            fileName = ofd.FileName;
                            fileSize = (new FileInfo(ofd.FileName)).Length.ToString();
                            loadFileIntoPlayer();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void tsbPlay_Click(object sender, EventArgs e)
        {
            timerPlayer.Interval = ssFile.GetTimeWaitBetweenFrames();
            timerPlayer.Enabled = true;
        }

        private void tsbStop_Click(object sender, EventArgs e)
        {
            if (timerPlayer.Enabled == true)
            {
                timerPlayer.Enabled = false;
            }
        }

        private void tsbRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            ssFile = new SSFile();
            ssFile.Capture(10, 1000, ImageFormat.Jpeg);
            loadFileIntoPlayer();
            this.Show();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "APG files (*.apg)|*.apg";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ssFile.SaveToAPGFile(sfd.FileName);
                MessageBox.Show("File Saved succesfully", "File Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            initPlayer();
        }

        private void tsbDeleteFrame_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void tsbHelp_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void tsbFileInformation_Click(object sender, EventArgs e)
        {
            FrmFileInfo fileInfoForm = new FrmFileInfo();
            fileInfoForm.ShowDialog(this);
        }

        private void tsbFrameExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG Image (.jpeg)|*.jpeg|Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|Png Image (.png)|*.png";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(ImageTools.ImageFromBase64(ssFile.GetFrameById(0).GetFrameData()));
                switch (sfd.FilterIndex)
                {
                    case 1:
                        image.Save(sfd.FileName, ImageFormat.Jpeg);
                        break;
                    case 2:
                        image.Save(sfd.FileName, ImageFormat.Bmp);
                        break;
                    case 3:
                        image.Save(sfd.FileName, ImageFormat.Gif);
                        break;
                    case 4:
                        image.Save(sfd.FileName, ImageFormat.Png);
                        break;
                }
                MessageBox.Show("File Saved succesfully", "File Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //{
                Application.Exit();
            //}
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbNew_Click(null, null);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbOpen_Click(null, null);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbSave_Click(null, null);
        }

        private void captureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbRecord_Click(null, null);
        }

        private void changeDisplayTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbFrameExport_Click(null, null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbDeleteFrame_Click(null, null);
        }

        private void fileInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbFileInformation_Click(null, null);
        }

        private void ShowFullScreen()
        {
            isFullScreen = !isFullScreen;
           
            if (isFullScreen)
            {
                formLocation = this.Location;
                formSize = this.Size;
                formState = this.WindowState;

                this.FormBorderStyle = FormBorderStyle.None;

                this.Location = new Point(0, 0);
                this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                this.WindowState = FormWindowState.Normal;

                msMainMenu.Hide();
                tbPlayerBar.Hide();
                tsButtonBar.Hide();
                ssStatusBar.Hide();
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;

                this.Location = formLocation;
                this.Size = formSize;
                this.WindowState = formState;
                
                msMainMenu.Show();
                tbPlayerBar.Show();
                tsButtonBar.Show();
                ssStatusBar.Show();
            }
        }

        private void FrmPlayer_Resize(object sender, EventArgs e)
        {
            if (pbPlayer.Image == null) return;

            int mainMenu = isFullScreen ? 0 : msMainMenu.Height;
            int playerBar = isFullScreen ? 0 : tbPlayerBar.Height;
            int buttonBar = isFullScreen ? 0 : tsButtonBar.Height;
            int statusBar = isFullScreen ? 0 : ssStatusBar.Height;

            int iW = pbPlayer.Image.Width;
            int iH = pbPlayer.Image.Height;
            int pW = this.ClientSize.Width;
            int pH = this.ClientSize.Height - mainMenu - playerBar - buttonBar - statusBar;

            pbPlayer.Height = tsbExpand.Checked ? pH : (iH > pH ? pH : iH);
            pbPlayer.Width = (int)((double)pbPlayer.Height * ((double)iW / (double)iH));

            if (pbPlayer.Width > pW)
            {
                pbPlayer.Width = pW;
                pbPlayer.Height = (int)((double)pbPlayer.Width * ((double)iH / (double)iW));
            }

            pbPlayer.Location = new Point(((pW - pbPlayer.Width) / 2), mainMenu + ((pH - pbPlayer.Height) / 2));
        }

        private void pbPlayer_DoubleClick(object sender, EventArgs e)
        {
            ShowFullScreen();
            FrmPlayer_Resize(null, null);            
        }

        private void tsbExpand_Click(object sender, EventArgs e)
        {
            FrmPlayer_Resize(null, null);
        }

        private void pbPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFullScreen && (mouseX != e.X || mouseY != e.Y))
            {
                mouseX = e.X;
                mouseY = e.Y;
                pbPlayer_MouseHover(null, null);
            }
        }

        private void timerMouseMove_Tick(object sender, EventArgs e)
        {
            timerMouseMove.Enabled = false;
            if(isFullScreen)
            { 
                tbPlayerBar.Hide();
                tsButtonBar.Hide();
            }
        }

        private void pbPlayer_MouseHover(object sender, EventArgs e)
        {
            if (isFullScreen)
            {
                timerMouseMove.Enabled = true;
                tbPlayerBar.Show();
                tsButtonBar.Show();
            }
        }

        private void pbPlayer_Click(object sender, EventArgs e)
        {
            if (timerPlayer.Enabled)
            {
                timerPlayer.Enabled = false;
            }
            else
            {
                tsbPlay_Click(null, null);
            }
        }
    }
}
