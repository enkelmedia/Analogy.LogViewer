﻿namespace Analogy.Forms
{
    partial class UpdateForm
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
            this.lblCurrentVersion = new DevExpress.XtraEditors.LabelControl();
            this.lblLatestVersion = new DevExpress.XtraEditors.LabelControl();
            this.sbtnCheck = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBoxRelease = new System.Windows.Forms.RichTextBox();
            this.sbtnDownloadPage = new DevExpress.XtraEditors.SimpleButton();
            this.hyperLinkEditLatest = new DevExpress.XtraEditors.HyperLinkEdit();
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditLatest.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblCurrentVersion.Appearance.Options.UseFont = true;
            this.lblCurrentVersion.AutoEllipsis = true;
            this.lblCurrentVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCurrentVersion.Location = new System.Drawing.Point(12, 16);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(607, 23);
            this.lblCurrentVersion.TabIndex = 0;
            this.lblCurrentVersion.Text = "Your current version is: ";
            // 
            // lblLatestVersion
            // 
            this.lblLatestVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLatestVersion.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLatestVersion.Appearance.Options.UseFont = true;
            this.lblLatestVersion.AutoEllipsis = true;
            this.lblLatestVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLatestVersion.Location = new System.Drawing.Point(12, 55);
            this.lblLatestVersion.Name = "lblLatestVersion";
            this.lblLatestVersion.Size = new System.Drawing.Size(607, 23);
            this.lblLatestVersion.TabIndex = 0;
            this.lblLatestVersion.Text = "Latest version is:  not checked";
            // 
            // sbtnCheck
            // 
            this.sbtnCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnCheck.Location = new System.Drawing.Point(642, 18);
            this.sbtnCheck.Name = "sbtnCheck";
            this.sbtnCheck.Size = new System.Drawing.Size(127, 26);
            this.sbtnCheck.TabIndex = 1;
            this.sbtnCheck.Text = "Check Now";
            this.sbtnCheck.Click += new System.EventHandler(this.sbtnCheck_Click);
            // 
            // richTextBoxRelease
            // 
            this.richTextBoxRelease.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRelease.Location = new System.Drawing.Point(12, 97);
            this.richTextBoxRelease.Name = "richTextBoxRelease";
            this.richTextBoxRelease.Size = new System.Drawing.Size(757, 204);
            this.richTextBoxRelease.TabIndex = 2;
            this.richTextBoxRelease.Text = "";
            // 
            // sbtnDownloadPage
            // 
            this.sbtnDownloadPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnDownloadPage.Location = new System.Drawing.Point(627, 329);
            this.sbtnDownloadPage.Name = "sbtnDownloadPage";
            this.sbtnDownloadPage.Size = new System.Drawing.Size(142, 26);
            this.sbtnDownloadPage.TabIndex = 3;
            this.sbtnDownloadPage.Text = "Open download page";
            this.sbtnDownloadPage.Visible = false;
            // 
            // hyperLinkEditLatest
            // 
            this.hyperLinkEditLatest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hyperLinkEditLatest.EditValue = "";
            this.hyperLinkEditLatest.Location = new System.Drawing.Point(12, 307);
            this.hyperLinkEditLatest.Name = "hyperLinkEditLatest";
            this.hyperLinkEditLatest.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.hyperLinkEditLatest.Size = new System.Drawing.Size(757, 22);
            this.hyperLinkEditLatest.TabIndex = 4;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 367);
            this.Controls.Add(this.hyperLinkEditLatest);
            this.Controls.Add(this.sbtnDownloadPage);
            this.Controls.Add(this.richTextBoxRelease);
            this.Controls.Add(this.sbtnCheck);
            this.Controls.Add(this.lblLatestVersion);
            this.Controls.Add(this.lblCurrentVersion);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hyperLinkEditLatest.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCurrentVersion;
        private DevExpress.XtraEditors.LabelControl lblLatestVersion;
        private DevExpress.XtraEditors.SimpleButton sbtnCheck;
        private System.Windows.Forms.RichTextBox richTextBoxRelease;
        private DevExpress.XtraEditors.SimpleButton sbtnDownloadPage;
        private DevExpress.XtraEditors.HyperLinkEdit hyperLinkEditLatest;
    }
}