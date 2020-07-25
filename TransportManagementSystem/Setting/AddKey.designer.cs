namespace TransportManagementSystem.Setting
{
    partial class AddKey
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
            this.key_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.forgetpass_txt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            //this.notificationMAnager1 = new RetailControls.NotificationMAnager(this.components);
            this.SuspendLayout();
            // 
            // key_txt
            // 
            this.key_txt.Location = new System.Drawing.Point(12, 32);
            this.key_txt.Name = "key_txt";
            this.key_txt.Size = new System.Drawing.Size(267, 24);
            this.key_txt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "User Key";
            // 
            // forgetpass_txt
            // 
            this.forgetpass_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.forgetpass_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(138)))));
            this.forgetpass_txt.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.forgetpass_txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetpass_txt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpass_txt.ForeColor = System.Drawing.Color.White;
            this.forgetpass_txt.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.forgetpass_txt.Location = new System.Drawing.Point(39, 68);
            this.forgetpass_txt.Name = "forgetpass_txt";
            this.forgetpass_txt.Size = new System.Drawing.Size(186, 40);
            this.forgetpass_txt.TabIndex = 19;
            this.forgetpass_txt.Text = "Add Key";
            this.forgetpass_txt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.forgetpass_txt.UseVisualStyleBackColor = false;
            this.forgetpass_txt.Click += new System.EventHandler(this.forgetpass_txt_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(259, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 120);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.forgetpass_txt);
            this.Controls.Add(this.key_txt);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(99)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddKey";
            this.Load += new System.EventHandler(this.AddKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox key_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button forgetpass_txt;
        private System.Windows.Forms.Button button1;
      
    }
}