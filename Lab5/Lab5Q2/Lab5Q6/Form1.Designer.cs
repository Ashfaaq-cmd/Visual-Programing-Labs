namespace Lab5Q6
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
            label3 = new Label();
            label5 = new Label();
            txtx1 = new TextBox();
            txty2 = new TextBox();
            txtOutput2 = new TextBox();
            txtOutput1 = new TextBox();
            txty1 = new TextBox();
            txtx2 = new TextBox();
            btnCalc = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter x1:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter y1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 51);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter x2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 122);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Enter y2:";
            // 
            // txtx1
            // 
            txtx1.Location = new Point(126, 19);
            txtx1.Name = "txtx1";
            txtx1.Size = new Size(100, 23);
            txtx1.TabIndex = 5;
            // 
            // txty2
            // 
            txty2.Location = new Point(126, 122);
            txty2.Name = "txty2";
            txty2.Size = new Size(100, 23);
            txty2.TabIndex = 6;
            // 
            // txtOutput2
            // 
            txtOutput2.Location = new Point(47, 199);
            txtOutput2.Name = "txtOutput2";
            txtOutput2.ReadOnly = true;
            txtOutput2.Size = new Size(197, 23);
            txtOutput2.TabIndex = 7;
            // 
            // txtOutput1
            // 
            txtOutput1.Location = new Point(47, 170);
            txtOutput1.Name = "txtOutput1";
            txtOutput1.ReadOnly = true;
            txtOutput1.Size = new Size(197, 23);
            txtOutput1.TabIndex = 8;
            // 
            // txty1
            // 
            txty1.Location = new Point(126, 88);
            txty1.Name = "txty1";
            txty1.Size = new Size(100, 23);
            txty1.TabIndex = 10;
            // 
            // txtx2
            // 
            txtx2.Location = new Point(124, 51);
            txtx2.Name = "txtx2";
            txtx2.Size = new Size(100, 23);
            txtx2.TabIndex = 11;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(42, 242);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 12;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(180, 242);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 279);
            Controls.Add(btnClose);
            Controls.Add(btnCalc);
            Controls.Add(txtx2);
            Controls.Add(txty1);
            Controls.Add(txtOutput1);
            Controls.Add(txtOutput2);
            Controls.Add(txty2);
            Controls.Add(txtx1);
            Controls.Add(label5);
            Controls.Add(label3);
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
        private Label label3;
        private Label label5;
        private TextBox txtx1;
        private TextBox txty2;
        private TextBox txtOutput2;
        private TextBox txtOutput1;
        private TextBox txty1;
        private TextBox txtx2;
        private Button btnCalc;
        private Button btnClose;
    }
}
