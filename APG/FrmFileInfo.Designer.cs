namespace APG
{
    partial class FrmFileInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFileInfo));
            this.grbFileInfo = new System.Windows.Forms.GroupBox();
            this.grbGraphicInfo = new System.Windows.Forms.GroupBox();
            this.lblFileInfo_FileName = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.lblLatestModification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCaptureTime = new System.Windows.Forms.Label();
            this.lblImageResolution = new System.Windows.Forms.Label();
            this.lblImageFormat = new System.Windows.Forms.Label();
            this.txtLatestModification = new System.Windows.Forms.TextBox();
            this.txtCreationTime = new System.Windows.Forms.TextBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtTotalFrames = new System.Windows.Forms.TextBox();
            this.txtCaptureTime = new System.Windows.Forms.TextBox();
            this.txtImageResolution = new System.Windows.Forms.TextBox();
            this.txtImageFormat = new System.Windows.Forms.TextBox();
            this.grbFileInfo.SuspendLayout();
            this.grbGraphicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFileInfo
            // 
            this.grbFileInfo.Controls.Add(this.txtLatestModification);
            this.grbFileInfo.Controls.Add(this.txtCreationTime);
            this.grbFileInfo.Controls.Add(this.txtFileSize);
            this.grbFileInfo.Controls.Add(this.txtFileName);
            this.grbFileInfo.Controls.Add(this.lblLatestModification);
            this.grbFileInfo.Controls.Add(this.lblCreationTime);
            this.grbFileInfo.Controls.Add(this.lblFileSize);
            this.grbFileInfo.Controls.Add(this.lblFileInfo_FileName);
            this.grbFileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFileInfo.Location = new System.Drawing.Point(12, 12);
            this.grbFileInfo.Name = "grbFileInfo";
            this.grbFileInfo.Size = new System.Drawing.Size(425, 139);
            this.grbFileInfo.TabIndex = 0;
            this.grbFileInfo.TabStop = false;
            this.grbFileInfo.Text = "File Info";
            // 
            // grbGraphicInfo
            // 
            this.grbGraphicInfo.Controls.Add(this.txtTotalFrames);
            this.grbGraphicInfo.Controls.Add(this.txtCaptureTime);
            this.grbGraphicInfo.Controls.Add(this.txtImageResolution);
            this.grbGraphicInfo.Controls.Add(this.txtImageFormat);
            this.grbGraphicInfo.Controls.Add(this.label1);
            this.grbGraphicInfo.Controls.Add(this.lblCaptureTime);
            this.grbGraphicInfo.Controls.Add(this.lblImageResolution);
            this.grbGraphicInfo.Controls.Add(this.lblImageFormat);
            this.grbGraphicInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGraphicInfo.Location = new System.Drawing.Point(12, 157);
            this.grbGraphicInfo.Name = "grbGraphicInfo";
            this.grbGraphicInfo.Size = new System.Drawing.Size(425, 134);
            this.grbGraphicInfo.TabIndex = 1;
            this.grbGraphicInfo.TabStop = false;
            this.grbGraphicInfo.Text = "Graphic Info";
            // 
            // lblFileInfo_FileName
            // 
            this.lblFileInfo_FileName.AutoSize = true;
            this.lblFileInfo_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileInfo_FileName.Location = new System.Drawing.Point(6, 24);
            this.lblFileInfo_FileName.Name = "lblFileInfo_FileName";
            this.lblFileInfo_FileName.Size = new System.Drawing.Size(71, 17);
            this.lblFileInfo_FileName.TabIndex = 0;
            this.lblFileInfo_FileName.Text = "File Name";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.Location = new System.Drawing.Point(6, 52);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(61, 17);
            this.lblFileSize.TabIndex = 1;
            this.lblFileSize.Text = "File Size";
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationTime.Location = new System.Drawing.Point(6, 80);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(96, 17);
            this.lblCreationTime.TabIndex = 2;
            this.lblCreationTime.Text = "Creation Time";
            // 
            // lblLatestModification
            // 
            this.lblLatestModification.AutoSize = true;
            this.lblLatestModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatestModification.Location = new System.Drawing.Point(6, 108);
            this.lblLatestModification.Name = "lblLatestModification";
            this.lblLatestModification.Size = new System.Drawing.Size(126, 17);
            this.lblLatestModification.TabIndex = 3;
            this.lblLatestModification.Text = "Latest Modification";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total Frames";
            // 
            // lblCaptureTime
            // 
            this.lblCaptureTime.AutoSize = true;
            this.lblCaptureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptureTime.Location = new System.Drawing.Point(6, 77);
            this.lblCaptureTime.Name = "lblCaptureTime";
            this.lblCaptureTime.Size = new System.Drawing.Size(93, 17);
            this.lblCaptureTime.TabIndex = 14;
            this.lblCaptureTime.Text = "Capture Time";
            // 
            // lblImageResolution
            // 
            this.lblImageResolution.AutoSize = true;
            this.lblImageResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageResolution.Location = new System.Drawing.Point(6, 49);
            this.lblImageResolution.Name = "lblImageResolution";
            this.lblImageResolution.Size = new System.Drawing.Size(117, 17);
            this.lblImageResolution.TabIndex = 13;
            this.lblImageResolution.Text = "Image Resolution";
            // 
            // lblImageFormat
            // 
            this.lblImageFormat.AutoSize = true;
            this.lblImageFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageFormat.Location = new System.Drawing.Point(6, 21);
            this.lblImageFormat.Name = "lblImageFormat";
            this.lblImageFormat.Size = new System.Drawing.Size(94, 17);
            this.lblImageFormat.TabIndex = 12;
            this.lblImageFormat.Text = "Image Format";
            // 
            // txtLatestModification
            // 
            this.txtLatestModification.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLatestModification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLatestModification.Location = new System.Drawing.Point(133, 109);
            this.txtLatestModification.Name = "txtLatestModification";
            this.txtLatestModification.Size = new System.Drawing.Size(286, 15);
            this.txtLatestModification.TabIndex = 7;
            // 
            // txtCreationTime
            // 
            this.txtCreationTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCreationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreationTime.Location = new System.Drawing.Point(133, 81);
            this.txtCreationTime.Name = "txtCreationTime";
            this.txtCreationTime.Size = new System.Drawing.Size(286, 15);
            this.txtCreationTime.TabIndex = 6;
            // 
            // txtFileSize
            // 
            this.txtFileSize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFileSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileSize.Location = new System.Drawing.Point(133, 53);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(286, 15);
            this.txtFileSize.TabIndex = 5;
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFileName.Location = new System.Drawing.Point(83, 25);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(336, 15);
            this.txtFileName.TabIndex = 4;
            // 
            // txtTotalFrames
            // 
            this.txtTotalFrames.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalFrames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalFrames.Location = new System.Drawing.Point(133, 105);
            this.txtTotalFrames.Name = "txtTotalFrames";
            this.txtTotalFrames.Size = new System.Drawing.Size(286, 15);
            this.txtTotalFrames.TabIndex = 19;
            // 
            // txtCaptureTime
            // 
            this.txtCaptureTime.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCaptureTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaptureTime.Location = new System.Drawing.Point(133, 77);
            this.txtCaptureTime.Name = "txtCaptureTime";
            this.txtCaptureTime.Size = new System.Drawing.Size(286, 15);
            this.txtCaptureTime.TabIndex = 18;
            // 
            // txtImageResolution
            // 
            this.txtImageResolution.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtImageResolution.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageResolution.Location = new System.Drawing.Point(133, 49);
            this.txtImageResolution.Name = "txtImageResolution";
            this.txtImageResolution.Size = new System.Drawing.Size(286, 15);
            this.txtImageResolution.TabIndex = 17;
            // 
            // txtImageFormat
            // 
            this.txtImageFormat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtImageFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImageFormat.Location = new System.Drawing.Point(133, 21);
            this.txtImageFormat.Name = "txtImageFormat";
            this.txtImageFormat.Size = new System.Drawing.Size(286, 15);
            this.txtImageFormat.TabIndex = 16;
            // 
            // FrmFileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 303);
            this.Controls.Add(this.grbGraphicInfo);
            this.Controls.Add(this.grbFileInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFileInfo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Info";
            this.Load += new System.EventHandler(this.FrmFileInfo_Load);
            this.grbFileInfo.ResumeLayout(false);
            this.grbFileInfo.PerformLayout();
            this.grbGraphicInfo.ResumeLayout(false);
            this.grbGraphicInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFileInfo;
        private System.Windows.Forms.Label lblLatestModification;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileInfo_FileName;
        private System.Windows.Forms.GroupBox grbGraphicInfo;
        private System.Windows.Forms.TextBox txtLatestModification;
        private System.Windows.Forms.TextBox txtCreationTime;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCaptureTime;
        private System.Windows.Forms.Label lblImageResolution;
        private System.Windows.Forms.Label lblImageFormat;
        private System.Windows.Forms.TextBox txtTotalFrames;
        private System.Windows.Forms.TextBox txtCaptureTime;
        private System.Windows.Forms.TextBox txtImageResolution;
        private System.Windows.Forms.TextBox txtImageFormat;
    }
}