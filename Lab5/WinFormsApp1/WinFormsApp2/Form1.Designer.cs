namespace WinFormsApp2
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
            groupBox1 = new GroupBox();
            radChild = new RadioButton();
            radMinor = new RadioButton();
            radAdult = new RadioButton();
            radSenior = new RadioButton();
            btnFee = new Button();
            label1 = new Label();
            txtFee = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radSenior);
            groupBox1.Controls.Add(radAdult);
            groupBox1.Controls.Add(radMinor);
            groupBox1.Controls.Add(radChild);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(105, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Age";
            // 
            // radChild
            // 
            radChild.AutoSize = true;
            radChild.Location = new Point(6, 22);
            radChild.Name = "radChild";
            radChild.Size = new Size(78, 19);
            radChild.TabIndex = 0;
            radChild.TabStop = true;
            radChild.Text = "Child (<6)";
            radChild.UseVisualStyleBackColor = true;
            // 
            // radMinor
            // 
            radMinor.AutoSize = true;
            radMinor.Location = new Point(6, 47);
            radMinor.Name = "radMinor";
            radMinor.Size = new Size(91, 19);
            radMinor.TabIndex = 1;
            radMinor.TabStop = true;
            radMinor.Text = "Minor (6-17)";
            radMinor.UseVisualStyleBackColor = true;
            // 
            // radAdult
            // 
            radAdult.AutoSize = true;
            radAdult.Location = new Point(6, 72);
            radAdult.Name = "radAdult";
            radAdult.Size = new Size(94, 19);
            radAdult.TabIndex = 2;
            radAdult.TabStop = true;
            radAdult.Text = "Adult (18-64)";
            radAdult.UseVisualStyleBackColor = true;
            // 
            // radSenior
            // 
            radSenior.AutoSize = true;
            radSenior.Location = new Point(6, 97);
            radSenior.Name = "radSenior";
            radSenior.Size = new Size(89, 19);
            radSenior.TabIndex = 3;
            radSenior.TabStop = true;
            radSenior.Text = "Senior (65+)";
            radSenior.UseVisualStyleBackColor = true;
            // 
            // btnFee
            // 
            btnFee.Location = new Point(161, 19);
            btnFee.Name = "btnFee";
            btnFee.Size = new Size(123, 34);
            btnFee.TabIndex = 1;
            btnFee.Text = "Determine Fee";
            btnFee.UseVisualStyleBackColor = true;
            btnFee.Click += btnFee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(157, 78);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 2;
            label1.Text = "Fee: ";
            // 
            // txtFee
            // 
            txtFee.Location = new Point(192, 77);
            txtFee.Name = "txtFee";
            txtFee.ReadOnly = true;
            txtFee.Size = new Size(100, 23);
            txtFee.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 170);
            Controls.Add(txtFee);
            Controls.Add(label1);
            Controls.Add(btnFee);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Admission Fee";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radSenior;
        private RadioButton radAdult;
        private RadioButton radMinor;
        private RadioButton radChild;
        private Button btnFee;
        private Label label1;
        private TextBox txtFee;
    }
}
