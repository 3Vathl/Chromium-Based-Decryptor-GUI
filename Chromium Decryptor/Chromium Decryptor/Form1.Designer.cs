namespace Chromium_Decryptor
{
    partial class Decryptor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Gx = new Button();
            Opera = new Button();
            Chrome = new Button();
            Edge = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Gx
            // 
            Gx.Location = new Point(103, 291);
            Gx.Name = "Gx";
            Gx.Size = new Size(103, 52);
            Gx.TabIndex = 0;
            Gx.Text = "Opera Gx";
            Gx.UseVisualStyleBackColor = true;
            Gx.Click += Gx_Click;
            // 
            // Opera
            // 
            Opera.Location = new Point(232, 291);
            Opera.Name = "Opera";
            Opera.Size = new Size(103, 52);
            Opera.TabIndex = 1;
            Opera.Text = "Opera";
            Opera.UseVisualStyleBackColor = true;
            Opera.Click += Opera_Click;
            // 
            // Chrome
            // 
            Chrome.Location = new Point(361, 291);
            Chrome.Name = "Chrome";
            Chrome.Size = new Size(103, 52);
            Chrome.TabIndex = 2;
            Chrome.Text = "Google Chrome";
            Chrome.UseVisualStyleBackColor = true;
            Chrome.Click += Chrome_Click;
            // 
            // Edge
            // 
            Edge.Location = new Point(490, 291);
            Edge.Name = "Edge";
            Edge.Size = new Size(103, 52);
            Edge.TabIndex = 3;
            Edge.Text = "Microsoft Edge";
            Edge.UseVisualStyleBackColor = true;
            Edge.Click += Edge_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.ForeColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(160, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 143);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(30, 98);
            label5.Name = "label5";
            label5.Size = new Size(123, 21);
            label5.TabIndex = 4;
            label5.Text = "0 CC`S Extracted";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(201, 61);
            label3.Name = "label3";
            label3.Size = new Size(168, 21);
            label3.TabIndex = 3;
            label3.Text = "0 BookMarks Extracted";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(201, 24);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 1;
            label2.Text = "0 Passwords Extracted";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 0;
            label1.Text = "0 Cookies Extracted";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(30, 61);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 2;
            label4.Text = "0 History Extracted";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(201, 98);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 5;
            label6.Text = "0 AutoFills Extracted";
            // 
            // Decryptor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 431);
            ControlBox = false;
            Controls.Add(Edge);
            Controls.Add(Chrome);
            Controls.Add(Opera);
            Controls.Add(Gx);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Decryptor";
            Text = "h";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Gx;
        private Button Opera;
        private Button Chrome;
        private Button Edge;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
    }
}
