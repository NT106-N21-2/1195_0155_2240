
namespace Lab3
{
    partial class Lab3_Bai1
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
            this.udpServer = new System.Windows.Forms.Button();
            this.udpClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // udpServer
            // 
            this.udpServer.BackColor = System.Drawing.Color.MidnightBlue;
            this.udpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpServer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.udpServer.Location = new System.Drawing.Point(87, 50);
            this.udpServer.Name = "udpServer";
            this.udpServer.Size = new System.Drawing.Size(249, 63);
            this.udpServer.TabIndex = 0;
            this.udpServer.Text = "UDP Server";
            this.udpServer.UseVisualStyleBackColor = false;
            this.udpServer.Click += new System.EventHandler(this.udpServer_Click);
            // 
            // udpClient
            // 
            this.udpClient.BackColor = System.Drawing.Color.MidnightBlue;
            this.udpClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.udpClient.Location = new System.Drawing.Point(451, 50);
            this.udpClient.Name = "udpClient";
            this.udpClient.Size = new System.Drawing.Size(249, 63);
            this.udpClient.TabIndex = 0;
            this.udpClient.Text = "UDP Client";
            this.udpClient.UseVisualStyleBackColor = false;
            this.udpClient.Click += new System.EventHandler(this.udpClient_Click);
            // 
            // Lab3_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 161);
            this.Controls.Add(this.udpClient);
            this.Controls.Add(this.udpServer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Lab3_Bai1";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button udpServer;
        private System.Windows.Forms.Button udpClient;
    }
}