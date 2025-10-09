namespace WinFormsApp1
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
            txtInput = new TextBox();
            txtGrade = new TextBox();
            btnGrade = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 29);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter grade:";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(134, 21);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 1;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(54, 120);
            txtGrade.Name = "txtGrade";
            txtGrade.ReadOnly = true;
            txtGrade.Size = new Size(180, 23);
            txtGrade.TabIndex = 2;
            // 
            // btnGrade
            // 
            btnGrade.Location = new Point(105, 72);
            btnGrade.Name = "btnGrade";
            btnGrade.Size = new Size(75, 23);
            btnGrade.TabIndex = 3;
            btnGrade.Text = "Grade";
            btnGrade.UseVisualStyleBackColor = true;
            btnGrade.Click += btnGrade_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 182);
            Controls.Add(btnGrade);
            Controls.Add(txtGrade);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private TextBox txtGrade;
        private Button btnGrade;
    }
}
