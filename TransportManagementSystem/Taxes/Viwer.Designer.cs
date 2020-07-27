namespace TransportManagementSystem.Taxes
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
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_edit = new CustomControls.MaterialButton();
            this.materialButton1 = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.BackColor = System.Drawing.Color.White;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(13, 5);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(63, 17);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "category";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.White;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(303, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(30, 17);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "title";
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(206)))));
            this.btn_edit.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.fontIncrement = 0F;
            this.btn_edit.FontStyle = null;
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.hoverforecolor = System.Drawing.Color.Empty;
            this.btn_edit.hoverforefont = null;
            this.btn_edit.hoverimage = null;
            this.btn_edit.Location = new System.Drawing.Point(575, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.role = 0;
            this.btn_edit.Size = new System.Drawing.Size(96, 20);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.tempforecolor = System.Drawing.Color.Empty;
            this.btn_edit.tempforefont = null;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.Totext = null;
            this.btn_edit.userole = false;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.BackColor = System.Drawing.Color.Red;
            this.materialButton1.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.FlatAppearance.BorderSize = 0;
            this.materialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.fontIncrement = 0F;
            this.materialButton1.FontStyle = null;
            this.materialButton1.ForeColor = System.Drawing.Color.White;
            this.materialButton1.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton1.hoverforefont = null;
            this.materialButton1.hoverimage = null;
            this.materialButton1.Location = new System.Drawing.Point(694, 4);
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.role = 0;
            this.materialButton1.Size = new System.Drawing.Size(96, 20);
            this.materialButton1.TabIndex = 3;
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
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_category);
            this.Name = "Viwer";
            this.Size = new System.Drawing.Size(817, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_title;
        private CustomControls.MaterialButton btn_edit;
        private CustomControls.MaterialButton materialButton1;
    }
}
