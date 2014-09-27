namespace SalaryCalculationApp
{
    partial class SalaryCalculationUI
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
            this.Employeenamelabel = new System.Windows.Forms.Label();
            this.Basicamountlabel = new System.Windows.Forms.Label();
            this.Houserenrlabel = new System.Windows.Forms.Label();
            this.Medicallabel = new System.Windows.Forms.Label();
            this.EmployeetextBox = new System.Windows.Forms.TextBox();
            this.BasicamounttextBox = new System.Windows.Forms.TextBox();
            this.HouserenttextBox = new System.Windows.Forms.TextBox();
            this.MedicaltextBox = new System.Windows.Forms.TextBox();
            this.showbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employeenamelabel
            // 
            this.Employeenamelabel.AutoSize = true;
            this.Employeenamelabel.Location = new System.Drawing.Point(81, 25);
            this.Employeenamelabel.Name = "Employeenamelabel";
            this.Employeenamelabel.Size = new System.Drawing.Size(84, 13);
            this.Employeenamelabel.TabIndex = 0;
            this.Employeenamelabel.Text = "Employee Name";
            // 
            // Basicamountlabel
            // 
            this.Basicamountlabel.AutoSize = true;
            this.Basicamountlabel.Location = new System.Drawing.Point(81, 89);
            this.Basicamountlabel.Name = "Basicamountlabel";
            this.Basicamountlabel.Size = new System.Drawing.Size(72, 13);
            this.Basicamountlabel.TabIndex = 1;
            this.Basicamountlabel.Text = "Basic Amount";
            // 
            // Houserenrlabel
            // 
            this.Houserenrlabel.AutoSize = true;
            this.Houserenrlabel.Location = new System.Drawing.Point(81, 137);
            this.Houserenrlabel.Name = "Houserenrlabel";
            this.Houserenrlabel.Size = new System.Drawing.Size(64, 13);
            this.Houserenrlabel.TabIndex = 2;
            this.Houserenrlabel.Text = "House Rent";
            // 
            // Medicallabel
            // 
            this.Medicallabel.AutoSize = true;
            this.Medicallabel.Location = new System.Drawing.Point(81, 202);
            this.Medicallabel.Name = "Medicallabel";
            this.Medicallabel.Size = new System.Drawing.Size(97, 13);
            this.Medicallabel.TabIndex = 3;
            this.Medicallabel.Text = "Mediclal allowance";
            // 
            // EmployeetextBox
            // 
            this.EmployeetextBox.Location = new System.Drawing.Point(339, 34);
            this.EmployeetextBox.Name = "EmployeetextBox";
            this.EmployeetextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeetextBox.TabIndex = 4;
            // 
            // BasicamounttextBox
            // 
            this.BasicamounttextBox.Location = new System.Drawing.Point(339, 89);
            this.BasicamounttextBox.Name = "BasicamounttextBox";
            this.BasicamounttextBox.Size = new System.Drawing.Size(100, 20);
            this.BasicamounttextBox.TabIndex = 5;
            // 
            // HouserenttextBox
            // 
            this.HouserenttextBox.Location = new System.Drawing.Point(339, 137);
            this.HouserenttextBox.Name = "HouserenttextBox";
            this.HouserenttextBox.Size = new System.Drawing.Size(100, 20);
            this.HouserenttextBox.TabIndex = 6;
            // 
            // MedicaltextBox
            // 
            this.MedicaltextBox.Location = new System.Drawing.Point(339, 195);
            this.MedicaltextBox.Name = "MedicaltextBox";
            this.MedicaltextBox.Size = new System.Drawing.Size(100, 20);
            this.MedicaltextBox.TabIndex = 7;
            // 
            // showbutton
            // 
            this.showbutton.Location = new System.Drawing.Point(290, 260);
            this.showbutton.Name = "showbutton";
            this.showbutton.Size = new System.Drawing.Size(283, 23);
            this.showbutton.TabIndex = 8;
            this.showbutton.Text = "Show Me Salary";
            this.showbutton.UseVisualStyleBackColor = true;
            this.showbutton.Click += new System.EventHandler(this.showbutton_Click);
            // 
            // SalaryCalculationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 369);
            this.Controls.Add(this.showbutton);
            this.Controls.Add(this.MedicaltextBox);
            this.Controls.Add(this.HouserenttextBox);
            this.Controls.Add(this.BasicamounttextBox);
            this.Controls.Add(this.EmployeetextBox);
            this.Controls.Add(this.Medicallabel);
            this.Controls.Add(this.Houserenrlabel);
            this.Controls.Add(this.Basicamountlabel);
            this.Controls.Add(this.Employeenamelabel);
            this.Name = "SalaryCalculationUI";
            this.Text = "SalaryCalculationUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Employeenamelabel;
        private System.Windows.Forms.Label Basicamountlabel;
        private System.Windows.Forms.Label Houserenrlabel;
        private System.Windows.Forms.Label Medicallabel;
        private System.Windows.Forms.TextBox EmployeetextBox;
        private System.Windows.Forms.TextBox BasicamounttextBox;
        private System.Windows.Forms.TextBox HouserenttextBox;
        private System.Windows.Forms.TextBox MedicaltextBox;
        private System.Windows.Forms.Button showbutton;
    }
}

