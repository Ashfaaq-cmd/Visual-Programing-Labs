namespace Lab6Q5
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
            txtStudMarks = new TextBox();
            txtOutput = new TextBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Input Student Mark:";
            // 
            // txtStudMarks
            // 
            txtStudMarks.Location = new Point(148, 26);
            txtStudMarks.Name = "txtStudMarks";
            txtStudMarks.Size = new Size(100, 23);
            txtStudMarks.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(39, 149);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(209, 23);
            txtOutput.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(70, 86);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(148, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate Student Grade";
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
            Controls.Add(txtStudMarks);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudMarks;
        private TextBox txtOutput;
        private Button btnCalc;
    }
}
