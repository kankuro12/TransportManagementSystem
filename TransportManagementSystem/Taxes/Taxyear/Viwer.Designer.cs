namespace TransportManagementSystem.Taxes.Taxyear
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
            this.betterTextBox_title = new CustomControls.BetterTextBox();
            this.materialButton_save = new CustomControls.MaterialButton();
            this.materialButton_Delete = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // betterTextBox_title
            // 
            this.betterTextBox_title.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_title.intVal = 0;
            this.betterTextBox_title.Location = new System.Drawing.Point(9, 9);
            this.betterTextBox_title.Name = "betterTextBox_title";
            this.betterTextBox_title.Size = new System.Drawing.Size(255, 20);
            this.betterTextBox_title.TabIndex = 9;
            this.betterTextBox_title.textboxType = CustomControls.TextboxType.Text;
            // 
            // materialButton_save
            // 
            this.materialButton_save.BackColor = System.Drawing.Color.Navy;
            this.materialButton_save.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_save.FlatAppearance.BorderSize = 0;
            this.materialButton_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_save.fontIncrement = 0F;
            this.materialButton_save.FontStyle = null;
            this.materialButton_save.ForeColor = System.Drawing.Color.White;
            this.materialButton_save.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.hoverforefont = null;
            this.materialButton_save.hoverimage = null;
            this.materialButton_save.Location = new System.Drawing.Point(279, 7);
            this.materialButton_save.Name = "materialButton_save";
            this.materialButton_save.role = 0;
            this.materialButton_save.Size = new System.Drawing.Size(93, 25);
            this.materialButton_save.TabIndex = 8;
            this.materialButton_save.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_save.tempforefont = null;
            this.materialButton_save.Text = "SAVE";
            this.materialButton_save.Totext = null;
            this.materialButton_save.userole = false;
            this.materialButton_save.UseVisualStyleBackColor = false;
            this.materialButton_save.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialButton_Delete
            // 
            this.materialButton_Delete.BackColor = System.Drawing.Color.Navy;
            this.materialButton_Delete.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_Delete.FlatAppearance.BorderSize = 0;
            this.materialButton_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_Delete.fontIncrement = 0F;
            this.materialButton_Delete.FontStyle = null;
            this.materialButton_Delete.ForeColor = System.Drawing.Color.White;
            this.materialButton_Delete.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_Delete.hoverforefont = null;
            this.materialButton_Delete.hoverimage = null;
            this.materialButton_Delete.Location = new System.Drawing.Point(378, 5);
            this.materialButton_Delete.Name = "materialButton_Delete";
            this.materialButton_Delete.role = 0;
            this.materialButton_Delete.Size = new System.Drawing.Size(93, 25);
            this.materialButton_Delete.TabIndex = 7;
            this.materialButton_Delete.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_Delete.tempforefont = null;
            this.materialButton_Delete.Text = "DELETE";
            this.materialButton_Delete.Totext = null;
            this.materialButton_Delete.userole = false;
            this.materialButton_Delete.UseVisualStyleBackColor = false;
            this.materialButton_Delete.Click += new System.EventHandler(this.materialButton_Delete_Click);
            // 
            // Viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.betterTextBox_title);
            this.Controls.Add(this.materialButton_save);
            this.Controls.Add(this.materialButton_Delete);
            this.Name = "Viwer";
            this.Size = new System.Drawing.Size(572, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.BetterTextBox betterTextBox_title;
        private CustomControls.MaterialButton materialButton_save;
        private CustomControls.MaterialButton materialButton_Delete;
    }
}
