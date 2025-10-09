namespace Lab5Q2
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
            lbl1 = new Label();
            btnConvert = new Button();
            btnClose = new Button();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(29, 28);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(73, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Input radius:";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(51, 124);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(178, 124);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(153, 28);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(42, 80);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(211, 23);
            txtOutput.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 205);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnClose);
            Controls.Add(btnConvert);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Demo2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button btnConvert;
        private Button btnClose;
        private TextBox txtInput;
        private TextBox txtOutput;
    }
}
