
namespace Lab3
{
    partial class Lab3_Bai4
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
            this.client = new System.Windows.Forms.Button();
            this.server1 = new System.Windows.Forms.Button();
            this.server2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.BackColor = System.Drawing.Color.MidnightBlue;
            this.client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.client.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.client.Location = new System.Drawing.Point(265, 48);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(293, 59);
            this.client.TabIndex = 0;
            this.client.Text = "Client";
            this.client.UseVisualStyleBackColor = false;
            this.client.Click += new System.EventHandler(this.client_Click);
            // 
            // server1
            // 
            this.server1.BackColor = System.Drawing.Color.MidnightBlue;
            this.server1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.server1.Location = new System.Drawing.Point(265, 135);
            this.server1.Name = "server1";
            this.server1.Size = new System.Drawing.Size(293, 59);
            this.server1.TabIndex = 1;
            this.server1.Text = "Server 1";
            this.server1.UseVisualStyleBackColor = false;
            this.server1.Click += new System.EventHandler(this.server1_Click);
            // 
            // server2
            // 
            this.server2.BackColor = System.Drawing.Color.MidnightBlue;
            this.server2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.server2.Location = new System.Drawing.Point(265, 233);
            this.server2.Name = "server2";
            this.server2.Size = new System.Drawing.Size(293, 59);
            this.server2.TabIndex = 2;
            this.server2.Text = "Server 2";
            this.server2.UseVisualStyleBackColor = false;
            this.server2.Click += new System.EventHandler(this.server2_Click);
            // 
            // Lab3_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.server2);
            this.Controls.Add(this.server1);
            this.Controls.Add(this.client);
            this.Name = "Lab3_Bai4";
            this.Text = "Lab3_Bai4";
            this.Load += new System.EventHandler(this.Lab3_Bai4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button client;
        private System.Windows.Forms.Button server1;
        private System.Windows.Forms.Button server2;
    }
}