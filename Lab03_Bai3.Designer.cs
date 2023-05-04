namespace Lab3
{
    partial class Lab03_Bai3
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
            TCPServer = new Button();
            TCPClient = new Button();
            SuspendLayout();
            // 
            // TCPServer
            // 
            TCPServer.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TCPServer.Location = new Point(118, 29);
            TCPServer.Name = "TCPServer";
            TCPServer.Size = new Size(441, 60);
            TCPServer.TabIndex = 0;
            TCPServer.Text = "Open TCP server";
            TCPServer.UseVisualStyleBackColor = true;
            TCPServer.Click += TCPServer_Click;
            // 
            // TCPClient
            // 
            TCPClient.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TCPClient.Location = new Point(118, 135);
            TCPClient.Name = "TCPClient";
            TCPClient.Size = new Size(441, 60);
            TCPClient.TabIndex = 1;
            TCPClient.Text = "Open new TCP client";
            TCPClient.UseVisualStyleBackColor = true;
            TCPClient.Click += TCPClient_Click;
            // 
            // Lab03_Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 250);
            Controls.Add(TCPClient);
            Controls.Add(TCPServer);
            Name = "Lab03_Bai3";
            Text = "Lab03_Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button TCPServer;
        private Button TCPClient;
    }
}