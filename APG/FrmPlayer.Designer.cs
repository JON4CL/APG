namespace APG
{
    partial class FrmPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlayer));
            this.timerPlayer = new System.Windows.Forms.Timer(this.components);
            this.ssStatusBar = new System.Windows.Forms.StatusStrip();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.captureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDisplayTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.frameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.fileInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsButtonBar = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbLoop = new System.Windows.Forms.ToolStripButton();
            this.tsbExpand = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteFrame = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRecord = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbFrameExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFileInformation = new System.Windows.Forms.ToolStripButton();
            this.tsbHelp = new System.Windows.Forms.ToolStripButton();
            this.tbPlayerBar = new System.Windows.Forms.TrackBar();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.timerMouseMove = new System.Windows.Forms.Timer(this.components);
            this.msMainMenu.SuspendLayout();
            this.tsButtonBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlayerBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPlayer
            // 
            this.timerPlayer.Interval = 1;
            this.timerPlayer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ssStatusBar
            // 
            this.ssStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatusBar.Location = new System.Drawing.Point(0, 533);
            this.ssStatusBar.Name = "ssStatusBar";
            this.ssStatusBar.Size = new System.Drawing.Size(782, 22);
            this.ssStatusBar.SizingGrip = false;
            this.ssStatusBar.TabIndex = 3;
            // 
            // msMainMenu
            // 
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(782, 28);
            this.msMainMenu.TabIndex = 4;
            this.msMainMenu.Text = "msMainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::APG.Properties.Resources.File_New;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::APG.Properties.Resources.File_Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::APG.Properties.Resources.File_Save;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.captureToolStripMenuItem,
            this.changeDisplayTimeToolStripMenuItem,
            this.toolStripMenuItem3,
            this.frameToolStripMenuItem,
            this.toolStripMenuItem4,
            this.fileInfoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // captureToolStripMenuItem
            // 
            this.captureToolStripMenuItem.Image = global::APG.Properties.Resources.Edit_Capture;
            this.captureToolStripMenuItem.Name = "captureToolStripMenuItem";
            this.captureToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.captureToolStripMenuItem.Text = "&Capture";
            this.captureToolStripMenuItem.Click += new System.EventHandler(this.captureToolStripMenuItem_Click);
            // 
            // changeDisplayTimeToolStripMenuItem
            // 
            this.changeDisplayTimeToolStripMenuItem.Name = "changeDisplayTimeToolStripMenuItem";
            this.changeDisplayTimeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changeDisplayTimeToolStripMenuItem.Text = "Change Display &Time";
            this.changeDisplayTimeToolStripMenuItem.Click += new System.EventHandler(this.changeDisplayTimeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 6);
            // 
            // frameToolStripMenuItem
            // 
            this.frameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.frameToolStripMenuItem.Name = "frameToolStripMenuItem";
            this.frameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.frameToolStripMenuItem.Text = "&Frame";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Image = global::APG.Properties.Resources.Edit_FrameExport;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exportToolStripMenuItem.Text = "&Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::APG.Properties.Resources.Edit_FrameDelete;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 6);
            // 
            // fileInfoToolStripMenuItem
            // 
            this.fileInfoToolStripMenuItem.Image = global::APG.Properties.Resources.Edit_FileInfo;
            this.fileInfoToolStripMenuItem.Name = "fileInfoToolStripMenuItem";
            this.fileInfoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fileInfoToolStripMenuItem.Text = "File &Info";
            this.fileInfoToolStripMenuItem.Click += new System.EventHandler(this.fileInfoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = global::APG.Properties.Resources.Help_About;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.helpToolStripMenuItem1.Text = "&About";
            // 
            // tsButtonBar
            // 
            this.tsButtonBar.BackColor = System.Drawing.Color.White;
            this.tsButtonBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsButtonBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsButtonBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsButtonBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.toolStripSeparator1,
            this.tsbPlay,
            this.tsbStop,
            this.tsbLoop,
            this.tsbExpand,
            this.tsbDeleteFrame,
            this.toolStripSeparator2,
            this.tsbRecord,
            this.tsbSave,
            this.tsbFrameExport,
            this.toolStripSeparator3,
            this.tsbFileInformation,
            this.tsbHelp});
            this.tsButtonBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsButtonBar.Location = new System.Drawing.Point(0, 504);
            this.tsButtonBar.Name = "tsButtonBar";
            this.tsButtonBar.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.tsButtonBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsButtonBar.Size = new System.Drawing.Size(782, 29);
            this.tsButtonBar.TabIndex = 9;
            this.tsButtonBar.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::APG.Properties.Resources.File_New;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(24, 24);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::APG.Properties.Resources.File_Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(24, 24);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::APG.Properties.Resources.File_Play;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(24, 24);
            this.tsbPlay.Text = "Play";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = global::APG.Properties.Resources.File_Stop;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(24, 24);
            this.tsbStop.Text = "Stop";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbLoop
            // 
            this.tsbLoop.BackColor = System.Drawing.Color.White;
            this.tsbLoop.CheckOnClick = true;
            this.tsbLoop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoop.Image = global::APG.Properties.Resources.File_Loop;
            this.tsbLoop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoop.Name = "tsbLoop";
            this.tsbLoop.Size = new System.Drawing.Size(24, 24);
            this.tsbLoop.Text = "Loop";
            this.tsbLoop.ToolTipText = "Loop";
            // 
            // tsbExpand
            // 
            this.tsbExpand.CheckOnClick = true;
            this.tsbExpand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExpand.Image = global::APG.Properties.Resources.Edit_Expand;
            this.tsbExpand.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExpand.Name = "tsbExpand";
            this.tsbExpand.Size = new System.Drawing.Size(24, 24);
            this.tsbExpand.Text = "Expand";
            this.tsbExpand.Click += new System.EventHandler(this.tsbExpand_Click);
            // 
            // tsbDeleteFrame
            // 
            this.tsbDeleteFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteFrame.Image = global::APG.Properties.Resources.Edit_FrameDelete;
            this.tsbDeleteFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteFrame.Name = "tsbDeleteFrame";
            this.tsbDeleteFrame.Size = new System.Drawing.Size(24, 24);
            this.tsbDeleteFrame.Text = "Delete Frame";
            this.tsbDeleteFrame.Click += new System.EventHandler(this.tsbDeleteFrame_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbRecord
            // 
            this.tsbRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecord.Image = global::APG.Properties.Resources.Edit_Capture;
            this.tsbRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecord.Name = "tsbRecord";
            this.tsbRecord.Size = new System.Drawing.Size(24, 24);
            this.tsbRecord.Text = "Capture";
            this.tsbRecord.Click += new System.EventHandler(this.tsbRecord_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::APG.Properties.Resources.File_Save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(24, 24);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbFrameExport
            // 
            this.tsbFrameExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFrameExport.Image = global::APG.Properties.Resources.Edit_FrameExport;
            this.tsbFrameExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFrameExport.Name = "tsbFrameExport";
            this.tsbFrameExport.Size = new System.Drawing.Size(24, 24);
            this.tsbFrameExport.Text = "Frame Export";
            this.tsbFrameExport.Click += new System.EventHandler(this.tsbFrameExport_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // tsbFileInformation
            // 
            this.tsbFileInformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFileInformation.Image = global::APG.Properties.Resources.Edit_FileInfo;
            this.tsbFileInformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFileInformation.Name = "tsbFileInformation";
            this.tsbFileInformation.Size = new System.Drawing.Size(24, 24);
            this.tsbFileInformation.Text = "File Information";
            this.tsbFileInformation.Click += new System.EventHandler(this.tsbFileInformation_Click);
            // 
            // tsbHelp
            // 
            this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHelp.Image = global::APG.Properties.Resources.Help_About;
            this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelp.Name = "tsbHelp";
            this.tsbHelp.Size = new System.Drawing.Size(24, 24);
            this.tsbHelp.Text = "Help";
            this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
            // 
            // tbPlayerBar
            // 
            this.tbPlayerBar.BackColor = System.Drawing.Color.White;
            this.tbPlayerBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPlayerBar.LargeChange = 0;
            this.tbPlayerBar.Location = new System.Drawing.Point(0, 448);
            this.tbPlayerBar.Margin = new System.Windows.Forms.Padding(0);
            this.tbPlayerBar.Maximum = 0;
            this.tbPlayerBar.Name = "tbPlayerBar";
            this.tbPlayerBar.Size = new System.Drawing.Size(782, 56);
            this.tbPlayerBar.TabIndex = 10;
            this.tbPlayerBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbPlayerBar.ValueChanged += new System.EventHandler(this.tbPlayerBar_ValueChanged);
            // 
            // pbPlayer
            // 
            this.pbPlayer.BackColor = System.Drawing.Color.Black;
            this.pbPlayer.Location = new System.Drawing.Point(313, 170);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(100, 100);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 11;
            this.pbPlayer.TabStop = false;
            this.pbPlayer.Click += new System.EventHandler(this.pbPlayer_Click);
            this.pbPlayer.DoubleClick += new System.EventHandler(this.pbPlayer_DoubleClick);
            this.pbPlayer.MouseHover += new System.EventHandler(this.pbPlayer_MouseHover);
            this.pbPlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPlayer_MouseMove);
            // 
            // timerMouseMove
            // 
            this.timerMouseMove.Interval = 3000;
            this.timerMouseMove.Tick += new System.EventHandler(this.timerMouseMove_Tick);
            // 
            // FrmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.tbPlayerBar);
            this.Controls.Add(this.tsButtonBar);
            this.Controls.Add(this.ssStatusBar);
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.pbPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APG PLAYER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.FrmPlayer_Resize);
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tsButtonBar.ResumeLayout(false);
            this.tsButtonBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlayerBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerPlayer;
        private System.Windows.Forms.StatusStrip ssStatusBar;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem captureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem changeDisplayTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fileInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem frameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStrip tsButtonBar;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbLoop;
        private System.Windows.Forms.ToolStripButton tsbDeleteFrame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRecord;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbFrameExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbFileInformation;
        private System.Windows.Forms.ToolStripButton tsbHelp;
        private System.Windows.Forms.TrackBar tbPlayerBar;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.ToolStripButton tsbExpand;
        private System.Windows.Forms.Timer timerMouseMove;
    }
}

