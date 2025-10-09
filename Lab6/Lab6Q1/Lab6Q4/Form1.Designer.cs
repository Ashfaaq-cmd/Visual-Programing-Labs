namespace Lab6Q4
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
            label3 = new Label();
            txtHours = new TextBox();
            txtRate = new TextBox();
            txtGrossPay = new TextBox();
            btnCalc = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of Hours Worked";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 59);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Hourly Pay Rate";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(171, 24);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(100, 23);
            txtHours.TabIndex = 3;
            // 
            // txtRate
            // 
            txtRate.Location = new Point(171, 59);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(100, 23);
            txtRate.TabIndex = 4;
            // 
            // txtGrossPay
            // 
            txtGrossPay.Location = new Point(48, 110);
            txtGrossPay.Name = "txtGrossPay";
            txtGrossPay.ReadOnly = true;
            txtGrossPay.Size = new Size(197, 23);
            txtGrossPay.TabIndex = 5;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(21, 149);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(115, 40);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calculate Gross Pay";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(152, 149);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(93, 40);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 201);
            Controls.Add(btnClose);
            Controls.Add(btnCalc);
            Controls.Add(txtGrossPay);
            Controls.Add(txtRate);
            Controls.Add(txtHours);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtHours;
        private TextBox txtRate;
        private TextBox txtGrossPay;
        private Button btnCalc;
        private Button btnClose;
    }
}
