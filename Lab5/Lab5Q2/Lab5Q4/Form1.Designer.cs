
namespace Lab5Q4
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
            lbnumOfHours = new Label();
            txtnumOfHours = new TextBox();
            lbl2 = new Label();
            txtRate = new TextBox();
            btnConvert = new Button();
            txtOutput = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lbnumOfHours
            // 
            lbnumOfHours.AutoSize = true;
            lbnumOfHours.Location = new Point(12, 18);
            lbnumOfHours.Name = "lbnumOfHours";
            lbnumOfHours.Size = new Size(178, 15);
            lbnumOfHours.TabIndex = 0;
            lbnumOfHours.Text = "Input Number of Hours Worked:";
            lbnumOfHours.Click += label1_Click;
            // 
            // txtnumOfHours
            // 
            txtnumOfHours.Location = new Point(193, 15);
            txtnumOfHours.Name = "txtnumOfHours";
            txtnumOfHours.Size = new Size(79, 23);
            txtnumOfHours.TabIndex = 2;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(12, 59);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(64, 15);
            lbl2.TabIndex = 3;
            lbl2.Text = "Input Rate:";
            // 
            // txtRate
            // 
            txtRate.Location = new Point(193, 59);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(79, 23);
            txtRate.TabIndex = 4;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(31, 144);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(44, 98);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(206, 23);
            txtOutput.TabIndex = 6;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(154, 144);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
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
            Controls.Add(txtOutput);
            Controls.Add(btnConvert);
            Controls.Add(txtRate);
            Controls.Add(lbl2);
            Controls.Add(txtnumOfHours);
            Controls.Add(lbnumOfHours);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lbnumOfHours;
        private TextBox txtnumOfHours;
        private Label lbl2;
        private TextBox txtRate;
        private Button btnConvert;
        private TextBox txtOutput;
        private Button btnClose;
    }
}
