namespace Shorcut_Virus_Remover.UI
{
    partial class History
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
            this.LogHistorybutton1 = new System.Windows.Forms.Button();
            this.ScanHistorybutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogHistorybutton1
            // 
            this.LogHistorybutton1.Location = new System.Drawing.Point(157, 114);
            this.LogHistorybutton1.Name = "LogHistorybutton1";
            this.LogHistorybutton1.Size = new System.Drawing.Size(121, 36);
            this.LogHistorybutton1.TabIndex = 0;
            this.LogHistorybutton1.Text = "Log History";
            this.LogHistorybutton1.UseVisualStyleBackColor = true;
            // 
            // ScanHistorybutton2
            // 
            this.ScanHistorybutton2.Location = new System.Drawing.Point(305, 114);
            this.ScanHistorybutton2.Name = "ScanHistorybutton2";
            this.ScanHistorybutton2.Size = new System.Drawing.Size(121, 36);
            this.ScanHistorybutton2.TabIndex = 1;
            this.ScanHistorybutton2.Text = "Scan History";
            this.ScanHistorybutton2.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 278);
            this.Controls.Add(this.ScanHistorybutton2);
            this.Controls.Add(this.LogHistorybutton1);
            this.Name = "History";
            this.Text = "History";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogHistorybutton1;
        private System.Windows.Forms.Button ScanHistorybutton2;
    }
}