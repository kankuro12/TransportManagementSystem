namespace TransportManagementSystem.Other_Expenses
{
    partial class Add
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
            this.betterTextBox1 = new CustomControls.BetterTextBox();
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
            this.betterTextBox1.Location = new System.Drawing.Point(588, 159);
            this.betterTextBox1.Name = "betterTextBox1";
            this.betterTextBox1.Size = new System.Drawing.Size(100, 20);
            this.betterTextBox1.TabIndex = 0;
            this.betterTextBox1.textboxType = CustomControls.TextboxType.Text;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.betterTextBox1);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.BetterTextBox betterTextBox1;
    }
}