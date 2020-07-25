namespace CustomControls
{
    partial class Accordion
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.materialButton_toogle = new CustomControls.MaterialButton();
            this.label_title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_middle = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.materialButton_toogle);
            this.panel_top.Controls.Add(this.label_title);
            this.panel_top.Controls.Add(this.panel3);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(987, 40);
            this.panel_top.TabIndex = 0;
            // 
            // materialButton_toogle
            // 
            this.materialButton_toogle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_toogle.Dock = System.Windows.Forms.DockStyle.Right;
            this.materialButton_toogle.FlatAppearance.BorderSize = 0;
            this.materialButton_toogle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.materialButton_toogle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.materialButton_toogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_toogle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_toogle.Location = new System.Drawing.Point(948, 0);
            this.materialButton_toogle.Name = "materialButton_toogle";
            this.materialButton_toogle.role = 0;
            this.materialButton_toogle.Size = new System.Drawing.Size(39, 39);
            this.materialButton_toogle.TabIndex = 2;
            this.materialButton_toogle.Text = "+";
            this.materialButton_toogle.Totext = null;
            this.materialButton_toogle.userole = false;
            this.materialButton_toogle.UseVisualStyleBackColor = true;
            this.materialButton_toogle.Click += new System.EventHandler(this.materialButton_toogle_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(22, 10);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(57, 21);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(206)))), ((int)(((byte)(219)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(987, 1);
            this.panel3.TabIndex = 0;
            // 
            // panel_middle
            // 
            this.panel_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_middle.Location = new System.Drawing.Point(0, 40);
            this.panel_middle.Name = "panel_middle";
            this.panel_middle.Size = new System.Drawing.Size(987, 212);
            this.panel_middle.TabIndex = 1;
            this.panel_middle.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.panel_middle_ControlAdded);
            this.panel_middle.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel_middle_ControlRemoved);
            // 
            // Accordion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_middle);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Name = "Accordion";
            this.Size = new System.Drawing.Size(987, 252);
            this.Load += new System.EventHandler(this.Accordion_Load);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label_title;
        public System.Windows.Forms.Panel panel_top;
        public System.Windows.Forms.Panel panel_middle;
        public MaterialButton materialButton_toogle;
    }
}
