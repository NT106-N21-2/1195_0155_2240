
namespace Lab3
{
    partial class Lab3_Bai2
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
            this.listen = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listen
            // 
            this.listen.BackColor = System.Drawing.Color.MidnightBlue;
            this.listen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listen.Location = new System.Drawing.Point(336, 48);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(196, 60);
            this.listen.TabIndex = 1;
            this.listen.Text = "Listen";
            this.listen.UseVisualStyleBackColor = false;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(138, 120);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(557, 272);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Lab3_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listen);
            this.Name = "Lab3_Bai2";
            this.Text = "Lab3_Bai2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.ListView listView1;
    }
}