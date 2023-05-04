
namespace Lab3
{
    partial class MainForm
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
            this.bt_Bai5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Bai5
            // 
            this.bt_Bai5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Bai5.Location = new System.Drawing.Point(196, 272);
            this.bt_Bai5.Name = "bt_Bai5";
            this.bt_Bai5.Size = new System.Drawing.Size(138, 63);
            this.bt_Bai5.TabIndex = 2;
            this.bt_Bai5.Text = "Bài 5";
            this.bt_Bai5.UseVisualStyleBackColor = true;
            this.bt_Bai5.Click += new System.EventHandler(this.bt_Bai5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "1 Server - Multi Client\r\nSử dụng kết nối TCP";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 406);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_Bai5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Bai5;
        private System.Windows.Forms.Label label5;
    }
}