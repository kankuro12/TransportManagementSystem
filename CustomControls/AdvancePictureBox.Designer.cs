namespace CustomControls
{
    partial class AdvancePictureBox
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.materialButtoncamera = new CustomControls.MaterialButton();
            this.materialButtonfile = new CustomControls.MaterialButton();
            this.materialButtonreset = new CustomControls.MaterialButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Controls.Add(this.materialButtoncamera);
            this.flowLayoutPanel.Controls.Add(this.materialButtonfile);
            this.flowLayoutPanel.Controls.Add(this.materialButtonreset);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 136);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(180, 63);
            this.flowLayoutPanel.TabIndex = 1;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // materialButtoncamera
            // 
            this.materialButtoncamera.BackgroundImage = global::CustomControls.Properties.Resources.camera_1;
            this.materialButtoncamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButtoncamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtoncamera.FlatAppearance.BorderSize = 0;
            this.materialButtoncamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtoncamera.Location = new System.Drawing.Point(142, 6);
            this.materialButtoncamera.Margin = new System.Windows.Forms.Padding(6);
            this.materialButtoncamera.Name = "materialButtoncamera";
            this.materialButtoncamera.role = 0;
            this.materialButtoncamera.Size = new System.Drawing.Size(30, 30);
            this.materialButtoncamera.TabIndex = 0;
            this.materialButtoncamera.Totext = null;
            this.materialButtoncamera.userole = false;
            this.materialButtoncamera.UseVisualStyleBackColor = true;
            this.materialButtoncamera.Click += new System.EventHandler(this.materialButtoncamera_Click);
            // 
            // materialButtonfile
            // 
            this.materialButtonfile.BackgroundImage = global::CustomControls.Properties.Resources.folder_file;
            this.materialButtonfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButtonfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonfile.FlatAppearance.BorderSize = 0;
            this.materialButtonfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonfile.Location = new System.Drawing.Point(100, 6);
            this.materialButtonfile.Margin = new System.Windows.Forms.Padding(6);
            this.materialButtonfile.Name = "materialButtonfile";
            this.materialButtonfile.role = 0;
            this.materialButtonfile.Size = new System.Drawing.Size(30, 30);
            this.materialButtonfile.TabIndex = 1;
            this.materialButtonfile.Totext = null;
            this.materialButtonfile.userole = false;
            this.materialButtonfile.UseVisualStyleBackColor = true;
            this.materialButtonfile.Click += new System.EventHandler(this.materialButtonfile_Click);
            // 
            // materialButtonreset
            // 
            this.materialButtonreset.BackgroundImage = global::CustomControls.Properties.Resources.close;
            this.materialButtonreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.materialButtonreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButtonreset.FlatAppearance.BorderSize = 0;
            this.materialButtonreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButtonreset.Location = new System.Drawing.Point(58, 6);
            this.materialButtonreset.Margin = new System.Windows.Forms.Padding(6);
            this.materialButtonreset.Name = "materialButtonreset";
            this.materialButtonreset.role = 0;
            this.materialButtonreset.Size = new System.Drawing.Size(30, 30);
            this.materialButtonreset.TabIndex = 2;
            this.materialButtonreset.Totext = null;
            this.materialButtonreset.userole = false;
            this.materialButtonreset.UseVisualStyleBackColor = true;
            this.materialButtonreset.Click += new System.EventHandler(this.materialButtonreset_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(180, 136);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // AdvancePictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdvancePictureBox";
            this.Size = new System.Drawing.Size(180, 199);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AdvancePictureBox_Paint);
            this.flowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private MaterialButton materialButtoncamera;
        private MaterialButton materialButtonfile;
        private MaterialButton materialButtonreset;
    }
}
