namespace PayrollGUI
{
    partial class PayrollCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayTextBox = new System.Windows.Forms.TextBox();
            this.hoursTextBox = new System.Windows.Forms.TextBox();
            this.payrollLabel = new System.Windows.Forms.Label();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.socialTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Social security number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly pay rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hours worked:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(45, 216);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(45, 288);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(159, 24);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(149, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // hourlyPayTextBox
            // 
            this.hourlyPayTextBox.Location = new System.Drawing.Point(159, 96);
            this.hourlyPayTextBox.Name = "hourlyPayTextBox";
            this.hourlyPayTextBox.Size = new System.Drawing.Size(74, 20);
            this.hourlyPayTextBox.TabIndex = 8;
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(159, 134);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(74, 20);
            this.hoursTextBox.TabIndex = 9;
            // 
            // payrollLabel
            // 
            this.payrollLabel.AutoSize = true;
            this.payrollLabel.Location = new System.Drawing.Point(196, 216);
            this.payrollLabel.Name = "payrollLabel";
            this.payrollLabel.Size = new System.Drawing.Size(84, 13);
            this.payrollLabel.TabIndex = 10;
            this.payrollLabel.Text = "Payroll Summary";
            this.payrollLabel.Visible = false;
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(196, 244);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(0, 13);
            this.grossPayLabel.TabIndex = 11;
            this.grossPayLabel.Visible = false;
            // 
            // socialTextBox
            // 
            this.socialTextBox.Location = new System.Drawing.Point(159, 59);
            this.socialTextBox.Name = "socialTextBox";
            this.socialTextBox.Size = new System.Drawing.Size(100, 20);
            this.socialTextBox.TabIndex = 12;
            // 
            // PayrollCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 335);
            this.Controls.Add(this.socialTextBox);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.payrollLabel);
            this.Controls.Add(this.hoursTextBox);
            this.Controls.Add(this.hourlyPayTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PayrollCalculator";
            this.Text = "Payroll Calculator";
            this.Load += new System.EventHandler(this.PayrollCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox hourlyPayTextBox;
        private System.Windows.Forms.TextBox hoursTextBox;
        private System.Windows.Forms.Label payrollLabel;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.TextBox socialTextBox;
    }
}

