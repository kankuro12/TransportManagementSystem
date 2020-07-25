namespace CustomControls
{
    partial class Alert
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_close = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_msg = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.label_title);
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 50);
            this.panel1.TabIndex = 0;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Location = new System.Drawing.Point(269, 6);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(17, 19);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(5, 20);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(65, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "label1";
            // 
            // label_msg
            // 
            this.label_msg.AutoSize = true;
            this.label_msg.Location = new System.Drawing.Point(7, 61);
            this.label_msg.MaximumSize = new System.Drawing.Size(290, 0);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(287, 57);
            this.label_msg.TabIndex = 1;
            this.label_msg.Text = "label1akdsfhashfsadflsadf\r\nasdfsadfsadfasdfasdfsakdflsahflshdlfkhasldkfhlksahdflk" +
    "hsaldkfhalskdfhlkashdflksadfha";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Alert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_title;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_msg;
        public System.Windows.Forms.Timer timer;
    }
}