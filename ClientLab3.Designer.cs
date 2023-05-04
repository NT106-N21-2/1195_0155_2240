namespace Lab3
{
    partial class ClientLab3
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
            Connect = new Button();
            Send = new Button();
            Disconnect = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // Connect
            // 
            Connect.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Connect.Location = new Point(601, 30);
            Connect.Name = "Connect";
            Connect.Size = new Size(162, 54);
            Connect.TabIndex = 0;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // Send
            // 
            Send.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Send.Location = new Point(601, 109);
            Send.Name = "Send";
            Send.Size = new Size(162, 54);
            Send.TabIndex = 1;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Disconnect
            // 
            Disconnect.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Disconnect.Location = new Point(601, 188);
            Disconnect.Name = "Disconnect";
            Disconnect.Size = new Size(162, 54);
            Disconnect.TabIndex = 2;
            Disconnect.Text = "Disconnect";
            Disconnect.UseVisualStyleBackColor = true;
            Disconnect.Click += Disconnect_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(25, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(557, 214);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // ClientLab3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 295);
            Controls.Add(richTextBox1);
            Controls.Add(Disconnect);
            Controls.Add(Send);
            Controls.Add(Connect);
            Name = "ClientLab3";
            Text = "Client";
            ResumeLayout(false);
        }

        #endregion

        private Button Connect;
        private Button Send;
        private Button Disconnect;
        private RichTextBox richTextBox1;
    }
}