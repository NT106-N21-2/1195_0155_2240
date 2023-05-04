
namespace Lab3
{
    partial class udpServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.listen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // port
            // 
            this.port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.Location = new System.Drawing.Point(130, 57);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(258, 39);
            this.port.TabIndex = 1;
            this.port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listen
            // 
            this.listen.BackColor = System.Drawing.Color.MidnightBlue;
            this.listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listen.Location = new System.Drawing.Point(490, 45);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(195, 62);
            this.listen.TabIndex = 2;
            this.listen.Text = "Listen";
            this.listen.UseVisualStyleBackColor = false;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recieved Message";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(63, 171);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(622, 267);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // udpServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.port);
            this.Controls.Add(this.label1);
            this.Name = "udpServer";
            this.Text = "UDP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

