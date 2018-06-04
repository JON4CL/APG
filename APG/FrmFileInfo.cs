using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APG
{
    public partial class FrmFileInfo : Form
    {
        public FrmFileInfo()
        {
            InitializeComponent();
        }

        private void FrmFileInfo_Load(object sender, EventArgs e)
        {
            FrmPlayer pf = ((FrmPlayer)this.ParentForm);
            txtFileName.Text = pf.fileName;
            txtFileSize.Text = pf.fileSize;
            txtCreationTime.Text = pf.ssFile.GetCreationTime();
            txtLatestModification.Text = pf.ssFile.GetLatestModificationTime();

            txtImageFormat.Text = pf.ssFile.GetImageType();
            txtImageResolution.Text = pf.ssFile.GetImageResolution();
            txtCaptureTime.Text = pf.ssFile.GetTimeWaitBetweenFrames().ToString();
            txtTotalFrames.Text = pf.ssFile.GetFramesCount().ToString();
        }
    }
}
