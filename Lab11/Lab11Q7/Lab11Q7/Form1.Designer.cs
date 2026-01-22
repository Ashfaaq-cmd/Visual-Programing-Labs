namespace Lab11Q7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtHoursWorked = new TextBox();
            txtRate = new TextBox();
            txtResult = new TextBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Hours Worked:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 61);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Pay Rate";
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(131, 32);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(100, 23);
            txtHoursWorked.TabIndex = 2;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(131, 61);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 3;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(67, 140);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(100, 23);
            txtResult.TabIndex = 4;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(67, 100);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(133, 23);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Calculate Gross Pay";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 184);
            Controls.Add(btnCalc);
            Controls.Add(txtResult);
            Controls.Add(txtRate);
            Controls.Add(txtHoursWorked);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoursWorked;
        private TextBox txtRate;
        private TextBox txtResult;
        private Button btnCalc;
    }
}
