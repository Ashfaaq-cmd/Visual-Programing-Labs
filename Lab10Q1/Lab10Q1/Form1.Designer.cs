namespace Lab10Q1
{
    partial class Array_Ages
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
            txtMin = new TextBox();
            txtMax = new TextBox();
            txtAvg = new TextBox();
            lstAge = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 23);
            label1.Name = "label1";
            label1.Size = new Size(167, 21);
            label1.TabIndex = 0;
            label1.Text = "US Presidential Ages";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 132);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Maximum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 75);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Minimum:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 188);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Average:";
            // 
            // txtMin
            // 
            txtMin.Location = new Point(203, 72);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(69, 23);
            txtMin.TabIndex = 4;
            // 
            // txtMax
            // 
            txtMax.Location = new Point(203, 132);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(69, 23);
            txtMax.TabIndex = 5;
            // 
            // txtAvg
            // 
            txtAvg.Location = new Point(203, 185);
            txtAvg.Name = "txtAvg";
            txtAvg.ReadOnly = true;
            txtAvg.Size = new Size(69, 23);
            txtAvg.TabIndex = 6;
            // 
            // lstAge
            // 
            lstAge.FormattingEnabled = true;
            lstAge.ItemHeight = 15;
            lstAge.Location = new Point(23, 74);
            lstAge.Name = "lstAge";
            lstAge.Size = new Size(105, 154);
            lstAge.TabIndex = 7;
            // 
            // Array_Ages
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(lstAge);
            Controls.Add(txtAvg);
            Controls.Add(txtMax);
            Controls.Add(txtMin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Array_Ages";
            Text = "Array Presidential Ages";
            Load += Array_Ages_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMin;
        private TextBox txtMax;
        private TextBox txtAvg;
        private ListBox lstAge;
    }
}
