namespace CustomControls
{
    partial class Notify
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textButtonclose = new CustomControls.TextButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.MaximumSize = new System.Drawing.Size(260, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1 sadfasdf asdfasd  sadf asdf  asdfasdf  asdfasdfasdf sadfasdf asdfas";
            // 
            // textButtonclose
            // 
            this.textButtonclose.AutoSize = true;
            this.textButtonclose.BackColor = System.Drawing.Color.Transparent;
            this.textButtonclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textButtonclose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButtonclose.ForeColor = System.Drawing.Color.White;
            this.textButtonclose.HoverColor = System.Drawing.Color.WhiteSmoke;
            this.textButtonclose.Location = new System.Drawing.Point(272, 5);
            this.textButtonclose.Name = "textButtonclose";
            this.textButtonclose.Size = new System.Drawing.Size(20, 21);
            this.textButtonclose.TabIndex = 1;
            this.textButtonclose.Text = "X";
            this.textButtonclose.Click += new System.EventHandler(this.textButtonclose_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textButtonclose);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Notify";
            this.Size = new System.Drawing.Size(300, 40);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Notify_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TextButton textButtonclose;
        private System.Windows.Forms.Timer timer;
    }
}
