namespace Lab5Q1
{
    partial class Demo1
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
            txtBox = new TextBox();
            btnConvert = new Button();
            btnClose = new Button();
            txtOutput = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(35, 33);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(46, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Input:";
            // 
            // txtBox
            // 
            txtBox.Location = new Point(139, 33);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(100, 23);
            txtBox.TabIndex = 1;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(46, 120);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(192, 120);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(46, 77);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(221, 23);
            txtOutput.TabIndex = 4;
            // 
            // Demo1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 193);
            Controls.Add(txtOutput);
            Controls.Add(btnClose);
            Controls.Add(btnConvert);
            Controls.Add(txtBox);
            Controls.Add(lbl1);
            Name = "Demo1";
            Text = "Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtBox;
        private Button btnConvert;
        private Button btnClose;
        private TextBox txtOutput;
    }
}
