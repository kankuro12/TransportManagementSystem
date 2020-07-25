namespace TransportManagementSystem.Finances
{
    partial class Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cancel = new CustomControls.MaterialButton();
            this.txt_email = new CustomControls.BetterTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phone = new CustomControls.BetterTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new CustomControls.BetterTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new CustomControls.BetterTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_save = new CustomControls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 40);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edit ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_phone);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_address);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 211);
            this.panel2.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Blue;
            this.btn_cancel.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.fontIncrement = 0F;
            this.btn_cancel.FontStyle = null;
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_cancel.hoverforefont = null;
            this.btn_cancel.hoverimage = null;
            this.btn_cancel.Location = new System.Drawing.Point(322, 166);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.role = 0;
            this.btn_cancel.Size = new System.Drawing.Size(97, 34);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.tempforecolor = System.Drawing.Color.Empty;
            this.btn_cancel.tempforefont = null;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Totext = null;
            this.btn_cancel.userole = false;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_email
            // 
            this.txt_email.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.intVal = 0;
            this.txt_email.Location = new System.Drawing.Point(85, 131);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(334, 26);
            this.txt_email.TabIndex = 18;
            this.txt_email.textboxType = CustomControls.TextboxType.Text;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // txt_phone
            // 
            this.txt_phone.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.intVal = 0;
            this.txt_phone.Location = new System.Drawing.Point(85, 92);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(334, 26);
            this.txt_phone.TabIndex = 16;
            this.txt_phone.textboxType = CustomControls.TextboxType.Text;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Phone";
            // 
            // txt_address
            // 
            this.txt_address.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.intVal = 0;
            this.txt_address.Location = new System.Drawing.Point(85, 49);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(334, 26);
            this.txt_address.TabIndex = 14;
            this.txt_address.textboxType = CustomControls.TextboxType.Text;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Address";
            // 
            // txt_name
            // 
            this.txt_name.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.intVal = 0;
            this.txt_name.Location = new System.Drawing.Point(85, 9);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(334, 26);
            this.txt_name.TabIndex = 12;
            this.txt_name.textboxType = CustomControls.TextboxType.Text;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Red;
            this.btn_save.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.fontIncrement = 0F;
            this.btn_save.FontStyle = null;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_save.hoverforefont = null;
            this.btn_save.hoverimage = null;
            this.btn_save.Location = new System.Drawing.Point(85, 166);
            this.btn_save.Name = "btn_save";
            this.btn_save.role = 0;
            this.btn_save.Size = new System.Drawing.Size(97, 34);
            this.btn_save.TabIndex = 10;
            this.btn_save.tempforecolor = System.Drawing.Color.Empty;
            this.btn_save.tempforefont = null;
            this.btn_save.Text = "Save";
            this.btn_save.Totext = null;
            this.btn_save.userole = false;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 251);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.MaterialButton btn_cancel;
        private CustomControls.BetterTextBox txt_email;
        private System.Windows.Forms.Label label4;
        private CustomControls.BetterTextBox txt_phone;
        private System.Windows.Forms.Label label3;
        private CustomControls.BetterTextBox txt_address;
        private System.Windows.Forms.Label label2;
        private CustomControls.BetterTextBox txt_name;
        private System.Windows.Forms.Label label5;
        private CustomControls.MaterialButton btn_save;
    }
}