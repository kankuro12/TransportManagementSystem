namespace CustomControls
{
    partial class MaterialTextBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.betterTextBox1 = new CustomControls.BetterTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 1);
            this.panel1.TabIndex = 2;
            // 
            // betterTextBox1
            // 
            this.betterTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.betterTextBox1.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.betterTextBox1.intVal = 0;
            this.betterTextBox1.Location = new System.Drawing.Point(0, 2);
            this.betterTextBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.betterTextBox1.Name = "betterTextBox1";
            this.betterTextBox1.Size = new System.Drawing.Size(408, 13);
            this.betterTextBox1.TabIndex = 0;
            this.betterTextBox1.textboxType = CustomControls.TextboxType.Text;
            this.betterTextBox1.Enter += new System.EventHandler(this.betterTextBox1_Enter);
            this.betterTextBox1.Leave += new System.EventHandler(this.betterTextBox1_Leave);
            // 
            // MaterialTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.betterTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "MaterialTextBox";
            this.Size = new System.Drawing.Size(408, 16);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MaterialTextBox_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public BetterTextBox betterTextBox1;
        public System.Windows.Forms.Label label1;
    }
}
