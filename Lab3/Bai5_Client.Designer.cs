
namespace Lab3
{
    partial class Bai5_Client
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 303);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tb_Message
            // 
            this.tb_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Message.Location = new System.Drawing.Point(139, 390);
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(481, 30);
            this.tb_Message.TabIndex = 1;
            this.tb_Message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Message_KeyPress);
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(670, 389);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(81, 31);
            this.btn_Send.TabIndex = 2;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(139, 344);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(94, 30);
            this.tb_Name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tin nhắn";
            // 
            // Bai5_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Bai5_Client";
            this.Text = "Bai5_Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bai5_Client_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}