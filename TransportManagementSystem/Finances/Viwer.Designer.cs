namespace TransportManagementSystem.Finances
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_edit = new CustomControls.MaterialButton();
            this.btn_delete = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Blue;
            this.lbl_name.Location = new System.Drawing.Point(13, 6);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 16);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Blue;
            this.lbl_address.Location = new System.Drawing.Point(239, 6);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(59, 16);
            this.lbl_address.TabIndex = 1;
            this.lbl_address.Text = "Address";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.Blue;
            this.lbl_phone.Location = new System.Drawing.Point(430, 6);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(47, 16);
            this.lbl_phone.TabIndex = 2;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Blue;
            this.lbl_email.Location = new System.Drawing.Point(638, 6);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 16);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Blue;
            this.btn_edit.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.fontIncrement = 0F;
            this.btn_edit.FontStyle = null;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_edit.hoverforefont = null;
            this.btn_edit.hoverimage = null;
            this.btn_edit.Location = new System.Drawing.Point(829, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.role = 0;
            this.btn_edit.Size = new System.Drawing.Size(90, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.tempforecolor = System.Drawing.Color.Empty;
            this.btn_edit.tempforefont = null;
            this.btn_edit.Text = "Edit";
            this.btn_edit.Totext = null;
            this.btn_edit.userole = false;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_delete.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.fontIncrement = 0F;
            this.btn_delete.FontStyle = null;
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_delete.hoverforefont = null;
            this.btn_delete.hoverimage = null;
            this.btn_delete.Location = new System.Drawing.Point(925, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.role = 0;
            this.btn_delete.Size = new System.Drawing.Size(82, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.tempforecolor = System.Drawing.Color.Empty;
            this.btn_delete.tempforefont = null;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Totext = null;
            this.btn_delete.userole = false;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_name);
            this.Name = "Viwer";
            this.Size = new System.Drawing.Size(1134, 28);
            this.Load += new System.EventHandler(this.Viwer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_email;
        private CustomControls.MaterialButton btn_edit;
        private CustomControls.MaterialButton btn_delete;
    }
}
