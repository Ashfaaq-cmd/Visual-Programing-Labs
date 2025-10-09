namespace Lab5Q7
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
            label4 = new Label();
            label5 = new Label();
            txth1 = new TextBox();
            txtr2 = new TextBox();
            txtr1 = new TextBox();
            txtheight1 = new TextBox();
            txtr = new TextBox();
            txtConcreteVolume = new TextBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter h:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 112);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter r1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 83);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Enter h1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 146);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Enter r2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 49);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 4;
            label5.Text = "Enter r:";
            // 
            // txth1
            // 
            txth1.Location = new Point(147, 14);
            txth1.Name = "txth1";
            txth1.Size = new Size(100, 23);
            txth1.TabIndex = 5;
            // 
            // txtr2
            // 
            txtr2.Location = new Point(147, 138);
            txtr2.Name = "txtr2";
            txtr2.Size = new Size(100, 23);
            txtr2.TabIndex = 6;
            // 
            // txtr1
            // 
            txtr1.Location = new Point(147, 109);
            txtr1.Name = "txtr1";
            txtr1.Size = new Size(100, 23);
            txtr1.TabIndex = 7;
            // 
            // txtheight1
            // 
            txtheight1.Location = new Point(147, 75);
            txtheight1.Name = "txtheight1";
            txtheight1.Size = new Size(100, 23);
            txtheight1.TabIndex = 8;
            // 
            // txtr
            // 
            txtr.Location = new Point(147, 46);
            txtr.Name = "txtr";
            txtr.Size = new Size(100, 23);
            txtr.TabIndex = 9;
            // 
            // txtConcreteVolume
            // 
            txtConcreteVolume.Location = new Point(49, 179);
            txtConcreteVolume.Name = "txtConcreteVolume";
            txtConcreteVolume.ReadOnly = true;
            txtConcreteVolume.Size = new Size(198, 23);
            txtConcreteVolume.TabIndex = 10;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(51, 222);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(180, 23);
            btnCalc.TabIndex = 11;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 261);
            Controls.Add(btnCalc);
            Controls.Add(txtConcreteVolume);
            Controls.Add(txtr);
            Controls.Add(txtheight1);
            Controls.Add(txtr1);
            Controls.Add(txtr2);
            Controls.Add(txth1);
            Controls.Add(label5);
            Controls.Add(label4);
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
        private Label label4;
        private Label label5;
        private TextBox txth1;
        private TextBox txtr2;
        private TextBox txtr1;
        private TextBox txtheight1;
        private TextBox txtr;
        private TextBox txtConcreteVolume;
        private Button btnCalc;
    }
}
