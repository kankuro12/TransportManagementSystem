namespace TransportManagementSystem.Vehicles.Type
{
    partial class Viwer
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
            this.betterTextBox1 = new CustomControls.BetterTextBox();
            this.materialButton2 = new CustomControls.MaterialButton();
            this.materialButton1 = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // betterTextBox1
            // 
            this.betterTextBox1.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox1.intVal = 0;
            this.betterTextBox1.Location = new System.Drawing.Point(11, 5);
            this.betterTextBox1.Name = "betterTextBox1";
            this.betterTextBox1.Size = new System.Drawing.Size(255, 20);
            this.betterTextBox1.TabIndex = 6;
            this.betterTextBox1.textboxType = CustomControls.TextboxType.Text;
            // 
            // materialButton2
            // 
            this.materialButton2.BackColor = System.Drawing.Color.Navy;
            this.materialButton2.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton2.FlatAppearance.BorderSize = 0;
            this.materialButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton2.fontIncrement = 0F;
            this.materialButton2.FontStyle = null;
            this.materialButton2.ForeColor = System.Drawing.Color.White;
            this.materialButton2.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton2.hoverforefont = null;
            this.materialButton2.hoverimage = null;
            this.materialButton2.Location = new System.Drawing.Point(281, 3);
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.role = 0;
            this.materialButton2.Size = new System.Drawing.Size(93, 25);
            this.materialButton2.TabIndex = 5;
            this.materialButton2.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton2.tempforefont = null;
            this.materialButton2.Text = "SAVE";
            this.materialButton2.Totext = null;
            this.materialButton2.userole = false;
            this.materialButton2.UseVisualStyleBackColor = false;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.Navy;
            this.materialButton1.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.fontIncrement = 0F;
            this.materialButton1.FontStyle = null;
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton1.hoverforefont = null;
            this.materialButton1.hoverimage = null;
            this.materialButton1.Location = new System.Drawing.Point(380, 1);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.role = 0;
            this.materialButton1.Size = new System.Drawing.Size(93, 25);
            this.materialButton1.TabIndex = 4;
            this.materialButton1.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton1.tempforefont = null;
            this.materialButton1.Text = "DELETE";
            this.materialButton1.Totext = null;
            this.materialButton1.userole = false;
            this.materialButton1.UseVisualStyleBackColor = false;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // Viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.betterTextBox1);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Name = "Viwer";
            this.Size = new System.Drawing.Size(559, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.BetterTextBox betterTextBox1;
        private CustomControls.MaterialButton materialButton2;
        private CustomControls.MaterialButton materialButton1;
    }
}
