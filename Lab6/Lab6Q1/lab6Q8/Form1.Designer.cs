namespace lab6Q8
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
            txtGrade = new TextBox();
            txtOutput = new TextBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Student's Mark";
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(162, 26);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(47, 129);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(215, 23);
            txtOutput.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(96, 78);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(108, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 201);
            Controls.Add(btnCalc);
            Controls.Add(txtOutput);
            Controls.Add(txtGrade);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtGrade;
        private TextBox txtOutput;
        private Button btnCalc;
    }
}
