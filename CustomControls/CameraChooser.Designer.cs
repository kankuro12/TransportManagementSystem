namespace CustomControls
{
    partial class CameraChooser
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textButton1 = new CustomControls.TextButton();
            this.textButton2 = new CustomControls.TextButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 46);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(447, 25);
            this.comboBox.TabIndex = 0;
            // 
            // textButton1
            // 
            this.textButton1.AutoSize = true;
            this.textButton1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textButton1.HoverColor = System.Drawing.Color.Empty;
            this.textButton1.Location = new System.Drawing.Point(363, 86);
            this.textButton1.Name = "textButton1";
            this.textButton1.Size = new System.Drawing.Size(42, 19);
            this.textButton1.TabIndex = 1;
            this.textButton1.Text = "Load";
            this.textButton1.Click += new System.EventHandler(this.textButton1_Click);
            // 
            // textButton2
            // 
            this.textButton2.AutoSize = true;
            this.textButton2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.textButton2.HoverColor = System.Drawing.Color.Empty;
            this.textButton2.Location = new System.Drawing.Point(411, 86);
            this.textButton2.Name = "textButton2";
            this.textButton2.Size = new System.Drawing.Size(45, 19);
            this.textButton2.TabIndex = 2;
            this.textButton2.Text = "Close";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Camera";
            // 
            // CameraChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.ClientSize = new System.Drawing.Size(468, 114);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textButton2);
            this.Controls.Add(this.textButton1);
            this.Controls.Add(this.comboBox);
            this.Name = "CameraChooser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private TextButton textButton1;
        private TextButton textButton2;
        private System.Windows.Forms.Label label1;
    }
}
