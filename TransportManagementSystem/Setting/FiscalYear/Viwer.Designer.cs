namespace TransportManagementSystem.FiscalYear
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.betterTextBox_name = new CustomControls.BetterTextBox();
            this.nepaliCalender_startdate = new CustomControls.NepaliCalender();
            this.nepaliCalender_endate = new CustomControls.NepaliCalender();
            this.label3 = new System.Windows.Forms.Label();
            this.materialButton_save = new CustomControls.MaterialButton();
            this.materialButton_setDefault = new CustomControls.MaterialButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start Date";
            // 
            // betterTextBox_name
            // 
           // this.betterTextBox_name.append = "";
            this.betterTextBox_name.decVal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.betterTextBox_name.intVal = 0;
            this.betterTextBox_name.Location = new System.Drawing.Point(92, 12);
            this.betterTextBox_name.Name = "betterTextBox_name";
           // this.betterTextBox_name.prepend = "";
           // this.betterTextBox_name.Rules = null;
            this.betterTextBox_name.Size = new System.Drawing.Size(211, 25);
            this.betterTextBox_name.TabIndex = 0;
            this.betterTextBox_name.textboxType = CustomControls.TextboxType.Text;
            // 
            // nepaliCalender_startdate
            // 
            this.nepaliCalender_startdate.BackColor = System.Drawing.Color.Transparent;
            this.nepaliCalender_startdate.Datestamp = 20760802;
            this.nepaliCalender_startdate.DateTime = new System.DateTime(2019, 11, 18, 0, 0, 0, 0);
            this.nepaliCalender_startdate.Location = new System.Drawing.Point(87, 40);
            this.nepaliCalender_startdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nepaliCalender_startdate.Name = "nepaliCalender_startdate";
            this.nepaliCalender_startdate.Size = new System.Drawing.Size(222, 31);
            this.nepaliCalender_startdate.TabIndex = 1;
            // 
            // nepaliCalender_endate
            // 
            this.nepaliCalender_endate.BackColor = System.Drawing.Color.Transparent;
            this.nepaliCalender_endate.Datestamp = 20760802;
            this.nepaliCalender_endate.DateTime = new System.DateTime(2019, 11, 18, 0, 0, 0, 0);
            this.nepaliCalender_endate.Location = new System.Drawing.Point(86, 80);
            this.nepaliCalender_endate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.nepaliCalender_endate.Name = "nepaliCalender_endate";
            this.nepaliCalender_endate.Size = new System.Drawing.Size(223, 33);
            this.nepaliCalender_endate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date";
            // 
            // materialButton_save
            // 
            this.materialButton_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialButton_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_save.FlatAppearance.BorderSize = 0;
            this.materialButton_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_save.ForeColor = System.Drawing.Color.White;
            this.materialButton_save.Location = new System.Drawing.Point(219, 121);
            this.materialButton_save.Name = "materialButton_save";
            this.materialButton_save.role = 0;
            this.materialButton_save.Size = new System.Drawing.Size(82, 27);
            this.materialButton_save.TabIndex = 3;
            this.materialButton_save.Text = "Save";
            this.materialButton_save.Totext = null;
            this.materialButton_save.userole = false;
            this.materialButton_save.UseVisualStyleBackColor = false;
            this.materialButton_save.Click += new System.EventHandler(this.materialButton_save_Click);
            // 
            // materialButton_setDefault
            // 
            this.materialButton_setDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_setDefault.FlatAppearance.BorderSize = 0;
            this.materialButton_setDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_setDefault.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_setDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.materialButton_setDefault.Location = new System.Drawing.Point(16, 121);
            this.materialButton_setDefault.Name = "materialButton_setDefault";
            this.materialButton_setDefault.role = 0;
            this.materialButton_setDefault.Size = new System.Drawing.Size(199, 28);
            this.materialButton_setDefault.TabIndex = 4;
            this.materialButton_setDefault.Text = "Set Current Fiscal Year";
            this.materialButton_setDefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialButton_setDefault.Totext = null;
            this.materialButton_setDefault.userole = false;
            this.materialButton_setDefault.UseVisualStyleBackColor = true;
            this.materialButton_setDefault.Click += new System.EventHandler(this.materialButton_setDefault_Click);
            // 
            // Viwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.materialButton_setDefault);
            this.Controls.Add(this.materialButton_save);
            this.Controls.Add(this.nepaliCalender_endate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nepaliCalender_startdate);
            this.Controls.Add(this.betterTextBox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Viwer";
            this.Size = new System.Drawing.Size(319, 165);
            this.Load += new System.EventHandler(this.Viwer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.BetterTextBox betterTextBox_name;
        private CustomControls.NepaliCalender nepaliCalender_startdate;
        private CustomControls.NepaliCalender nepaliCalender_endate;
        private System.Windows.Forms.Label label3;
        private CustomControls.MaterialButton materialButton_save;
        private CustomControls.MaterialButton materialButton_setDefault;
    }
}
