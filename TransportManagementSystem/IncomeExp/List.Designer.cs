namespace TransportManagementSystem.IncomeExp
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
            this.materialButton_close = new CustomControls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_exp = new System.Windows.Forms.TabControl();
            this.tabPage_income = new System.Windows.Forms.TabPage();
            this.tabPage_exp = new System.Windows.Forms.TabPage();
            this.tabPage_otherexp = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl_exp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.materialButton_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 50);
            this.panel1.TabIndex = 1;
            // 
            // materialButton_close
            // 
            this.materialButton_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton_close.ButtonSizeIncrement = new System.Drawing.Size(0, 0);
            this.materialButton_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton_close.FlatAppearance.BorderSize = 0;
            this.materialButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialButton_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton_close.fontIncrement = 0F;
            this.materialButton_close.FontStyle = null;
            this.materialButton_close.ForeColor = System.Drawing.Color.White;
            this.materialButton_close.hoverforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.hoverforefont = null;
            this.materialButton_close.hoverimage = null;
            this.materialButton_close.Location = new System.Drawing.Point(923, 4);
            this.materialButton_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialButton_close.Name = "materialButton_close";
            this.materialButton_close.role = 0;
            this.materialButton_close.Size = new System.Drawing.Size(40, 37);
            this.materialButton_close.TabIndex = 1;
            this.materialButton_close.tempforecolor = System.Drawing.Color.Empty;
            this.materialButton_close.tempforefont = null;
            this.materialButton_close.Text = "X";
            this.materialButton_close.Totext = null;
            this.materialButton_close.userole = false;
            this.materialButton_close.UseVisualStyleBackColor = true;
            this.materialButton_close.Click += new System.EventHandler(this.materialButton_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income and Expenses";
            // 
            // tabControl_exp
            // 
            this.tabControl_exp.Controls.Add(this.tabPage_income);
            this.tabControl_exp.Controls.Add(this.tabPage_exp);
            this.tabControl_exp.Controls.Add(this.tabPage_otherexp);
            this.tabControl_exp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_exp.Location = new System.Drawing.Point(0, 50);
            this.tabControl_exp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl_exp.Name = "tabControl_exp";
            this.tabControl_exp.SelectedIndex = 0;
            this.tabControl_exp.Size = new System.Drawing.Size(967, 615);
            this.tabControl_exp.TabIndex = 28;
            // 
            // tabPage_income
            // 
            this.tabPage_income.Location = new System.Drawing.Point(4, 25);
            this.tabPage_income.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_income.Name = "tabPage_income";
            this.tabPage_income.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_income.Size = new System.Drawing.Size(959, 586);
            this.tabPage_income.TabIndex = 0;
            this.tabPage_income.Text = "Income Report";
            this.tabPage_income.UseVisualStyleBackColor = true;
            // 
            // tabPage_exp
            // 
            this.tabPage_exp.Location = new System.Drawing.Point(4, 22);
            this.tabPage_exp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_exp.Name = "tabPage_exp";
            this.tabPage_exp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_exp.Size = new System.Drawing.Size(1408, 577);
            this.tabPage_exp.TabIndex = 1;
            this.tabPage_exp.Text = "Expenses Report";
            this.tabPage_exp.UseVisualStyleBackColor = true;
            // 
            // tabPage_otherexp
            // 
            this.tabPage_otherexp.Location = new System.Drawing.Point(4, 25);
            this.tabPage_otherexp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_otherexp.Name = "tabPage_otherexp";
            this.tabPage_otherexp.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_otherexp.Size = new System.Drawing.Size(959, 586);
            this.tabPage_otherexp.TabIndex = 2;
            this.tabPage_otherexp.Text = "Other Expense Report";
            this.tabPage_otherexp.UseVisualStyleBackColor = true;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(967, 665);
            this.Controls.Add(this.tabControl_exp);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "List";
            this.Text = "List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl_exp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.MaterialButton materialButton_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_exp;
        private System.Windows.Forms.TabPage tabPage_income;
        private System.Windows.Forms.TabPage tabPage_exp;
        private System.Windows.Forms.TabPage tabPage_otherexp;
    }
}