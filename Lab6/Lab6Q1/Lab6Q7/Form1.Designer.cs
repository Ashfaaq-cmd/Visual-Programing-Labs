namespace Lab6Q7
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
            txtSpeed = new TextBox();
            txtOutput = new TextBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Speed:";
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(135, 33);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(100, 23);
            txtSpeed.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(44, 144);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(216, 23);
            txtOutput.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(115, 81);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(284, 201);
            Controls.Add(btnCalc);
            Controls.Add(txtOutput);
            Controls.Add(txtSpeed);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSpeed;
        private TextBox txtOutput;
        private Button btnCalc;
    }
}
