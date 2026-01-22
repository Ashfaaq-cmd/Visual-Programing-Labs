namespace Lab11Q2
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
            txtwidth = new TextBox();
            txtlength = new TextBox();
            txtarea = new TextBox();
            btnarea = new Button();
            btnperimeter = new Button();
            txtperimeter = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 31);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Width:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 72);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Length";
            // 
            // txtwidth
            // 
            txtwidth.Location = new Point(135, 31);
            txtwidth.Name = "txtwidth";
            txtwidth.Size = new Size(100, 23);
            txtwidth.TabIndex = 2;
            // 
            // txtlength
            // 
            txtlength.Location = new Point(135, 72);
            txtlength.Name = "txtlength";
            txtlength.Size = new Size(100, 23);
            txtlength.TabIndex = 3;
            // 
            // txtarea
            // 
            txtarea.Location = new Point(46, 163);
            txtarea.Name = "txtarea";
            txtarea.ReadOnly = true;
            txtarea.Size = new Size(99, 23);
            txtarea.TabIndex = 4;
            // 
            // btnarea
            // 
            btnarea.Location = new Point(30, 117);
            btnarea.Name = "btnarea";
            btnarea.Size = new Size(91, 23);
            btnarea.TabIndex = 5;
            btnarea.Text = "Calculate Area";
            btnarea.UseVisualStyleBackColor = true;
            btnarea.Click += btnarea_Click;
            // 
            // btnperimeter
            // 
            btnperimeter.Location = new Point(135, 117);
            btnperimeter.Name = "btnperimeter";
            btnperimeter.Size = new Size(130, 23);
            btnperimeter.TabIndex = 6;
            btnperimeter.Text = "Calculate Perimeter";
            btnperimeter.UseVisualStyleBackColor = true;
            btnperimeter.Click += btnperimeter_Click;
            // 
            // txtperimeter
            // 
            txtperimeter.Location = new Point(166, 163);
            txtperimeter.Name = "txtperimeter";
            txtperimeter.ReadOnly = true;
            txtperimeter.Size = new Size(99, 23);
            txtperimeter.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 211);
            Controls.Add(txtperimeter);
            Controls.Add(btnperimeter);
            Controls.Add(btnarea);
            Controls.Add(txtarea);
            Controls.Add(txtlength);
            Controls.Add(txtwidth);
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
        private TextBox txtwidth;
        private TextBox txtlength;
        private TextBox txtarea;
        private Button btnarea;
        private Button btnperimeter;
        private TextBox txtperimeter;
    }
}
