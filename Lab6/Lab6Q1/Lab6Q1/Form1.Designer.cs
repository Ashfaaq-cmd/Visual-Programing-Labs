namespace Lab6Q1
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtOutput = new TextBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Number 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 55);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter Number 2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(136, 15);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(107, 23);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(136, 55);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(107, 23);
            txtNum2.TabIndex = 4;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(39, 126);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(204, 23);
            txtOutput.TabIndex = 5;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(62, 97);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(148, 23);
            btnCalc.TabIndex = 6;
            btnCalc.Text = "Calculate Large Num";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(btnCalc);
            Controls.Add(txtOutput);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
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
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtOutput;
        private Button btnCalc;
    }
}
