namespace TargetPromotionProjectV3
{
    partial class FaceAnalysis
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
            this.richTxtResult = new System.Windows.Forms.RichTextBox();
            this.pnlVideo = new System.Windows.Forms.Panel();
            this.richTxtEmergencyMessage = new System.Windows.Forms.RichTextBox();
            this.txtDetectionStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTxtResult
            // 
            this.richTxtResult.Location = new System.Drawing.Point(0, 339);
            this.richTxtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTxtResult.Name = "richTxtResult";
            this.richTxtResult.Size = new System.Drawing.Size(478, 487);
            this.richTxtResult.TabIndex = 0;
            this.richTxtResult.Text = "";
            // 
            // pnlVideo
            // 
            this.pnlVideo.BackColor = System.Drawing.Color.Black;
            this.pnlVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVideo.Location = new System.Drawing.Point(0, 0);
            this.pnlVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlVideo.Name = "pnlVideo";
            this.pnlVideo.Size = new System.Drawing.Size(2590, 1284);
            this.pnlVideo.TabIndex = 5;
            // 
            // richTxtEmergencyMessage
            // 
            this.richTxtEmergencyMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtEmergencyMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.richTxtEmergencyMessage.Location = new System.Drawing.Point(0, 0);
            this.richTxtEmergencyMessage.Name = "richTxtEmergencyMessage";
            this.richTxtEmergencyMessage.Size = new System.Drawing.Size(2590, 1284);
            this.richTxtEmergencyMessage.TabIndex = 6;
            this.richTxtEmergencyMessage.Text = "";
            // 
            // txtDetectionStatus
            // 
            this.txtDetectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDetectionStatus.Location = new System.Drawing.Point(0, 1304);
            this.txtDetectionStatus.Multiline = true;
            this.txtDetectionStatus.Name = "txtDetectionStatus";
            this.txtDetectionStatus.Size = new System.Drawing.Size(388, 77);
            this.txtDetectionStatus.TabIndex = 0;
            // 
            // FaceAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2590, 1284);
            this.Controls.Add(this.txtDetectionStatus);
            this.Controls.Add(this.pnlVideo);
            this.Controls.Add(this.richTxtEmergencyMessage);
            this.Controls.Add(this.richTxtResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FaceAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FaceAnalysis_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtResult;
        private System.Windows.Forms.Panel pnlVideo;
        private System.Windows.Forms.TextBox txtDetectionStatus;
        private System.Windows.Forms.RichTextBox richTxtEmergencyMessage;
    }
}

