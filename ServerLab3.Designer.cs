namespace Lab3
{
    partial class ServerLab3
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
            Listen = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // Listen
            // 
            Listen.Font = new Font("Segoe UI Variable Display", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Listen.Location = new Point(620, 35);
            Listen.Name = "Listen";
            Listen.Size = new Size(134, 47);
            Listen.TabIndex = 0;
            Listen.Text = "Listen";
            Listen.UseVisualStyleBackColor = true;
            Listen.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 99);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(722, 433);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // ServerLab3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 563);
            Controls.Add(richTextBox1);
            Controls.Add(Listen);
            Name = "ServerLab3";
            Text = "ServerLab3";
            Load += ServerLab3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Listen;
        private RichTextBox richTextBox1;
    }
}