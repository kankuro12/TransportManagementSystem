namespace TransportManagementSystem.Taxes
{
    partial class List
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialButton_year = new CustomControls.MaterialButton();
            this.txt_search = new CustomControls.BetterTextBox();
            this.btn_add = new CustomControls.MaterialButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FlowLayoutPanel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.materialButton_close = new CustomControls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 46);
            this.panel1.TabIndex = 0;
            // 
            // materialButton_year
            // 
            this.materialButton_year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_year.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.materialButton_year.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_year.FlatAppearance.BorderSize = 0;
            this.materialButton_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_year.fontIncrement = 0F;
            this.materialButton_year.FontStyle = null;
            this.materialButton_year.ForeColor = System.Drawing.Color.White;
            this.materialButton_year.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_year.hoverforefont = null;
            this.materialButton_year.hoverimage = null;
            this.materialButton_year.Location = new System.Drawing.Point(845, 2);
            this.materialButton_year.Name = "materialButton_year";
            this.materialButton_year.role = 0;
            this.materialButton_year.Size = new System.Drawing.Size(146, 35);
            this.materialButton_year.TabIndex = 5;
            this.materialButton_year.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_year.tempforefont = null;
            this.materialButton_year.Text = "Manage Year";
            this.materialButton_year.Totext = null;
            this.materialButton_year.userole = false;
            this.materialButton_year.UseVisualStyleBackColor = false;
            this.materialButton_year.Click += new System.EventHandler(this.materialButton_year_Click);
            // 
            // txt_search
            // 
            this.txt_search.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.intVal = 0;
            this.txt_search.Location = new System.Drawing.Point(798, 9);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(202, 26);
            this.txt_search.TabIndex = 0;
            this.txt_search.textboxType = CustomControls.TextboxType.Text;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.btn_add.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.fontIncrement = 0F;
            this.btn_add.FontStyle = null;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_add.hoverforefont = null;
            this.btn_add.hoverimage = null;
            this.btn_add.Location = new System.Drawing.Point(711, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.role = 0;
            this.btn_add.Size = new System.Drawing.Size(123, 35);
            this.btn_add.TabIndex = 4;
            this.btn_add.tempforecolor = System.Drawing.Color.Empty;
            this.btn_add.tempforefont = null;
            this.btn_add.Text = "Add New";
            this.btn_add.Totext = null;
            this.btn_add.userole = false;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(302, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(1, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tax Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tax List ";
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(0, 86);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(1003, 410);
            this.FlowLayoutPanel1.TabIndex = 1;
            this.FlowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.panel3.Controls.Add(this.materialButton_year);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Controls.Add(this.materialButton_close);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1003, 40);
            this.panel3.TabIndex = 5;
            // 
            // materialButton_close
            // 
            this.materialButton_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.materialButton_close.BackgroundImage = global::TransportManagementSystem.Properties.Resources.back_641;
            this.materialButton_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.materialButton_close.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            this.materialButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_close.fontIncrement = 0F;
            this.materialButton_close.FontStyle = null;
            this.materialButton_close.ForeColor = System.Drawing.Color.White;
            this.materialButton_close.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.hoverforefont = null;
            this.materialButton_close.hoverimage = null;
            this.materialButton_close.Location = new System.Drawing.Point(5, 3);
            this.materialButton_close.Name = "materialButton_close";
            this.materialButton_close.role = 0;
            this.materialButton_close.Size = new System.Drawing.Size(30, 30);
            this.materialButton_close.TabIndex = 6;
            this.materialButton_close.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.tempforefont = null;
            this.materialButton_close.Totext = null;
            this.materialButton_close.userole = false;
            this.materialButton_close.UseVisualStyleBackColor = false;
            this.materialButton_close.Click += new System.EventHandler(this.materialButton_close_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 496);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.BetterTextBox txt_search;
        private CustomControls.MaterialButton btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel FlowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.MaterialButton materialButton_year;
        private CustomControls.MaterialButton materialButton_close;
    }
}