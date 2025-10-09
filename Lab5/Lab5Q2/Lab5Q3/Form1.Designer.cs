namespace Lab5Q3
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
            txtCelcius = new TextBox();
            txtFarenheit = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(22, 29);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(73, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Input Depth:";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(20, 136);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(175, 136);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(127, 26);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 3;
            // 
            // txtCelcius
            // 
            txtCelcius.Location = new Point(22, 75);
            txtCelcius.Name = "txtCelcius";
            txtCelcius.ReadOnly = true;
            txtCelcius.Size = new Size(216, 23);
            txtCelcius.TabIndex = 4;
            // 
            // txtFarenheit
            // 
            txtFarenheit.Location = new Point(22, 107);
            txtFarenheit.Name = "txtFarenheit";
            txtFarenheit.ReadOnly = true;
            txtFarenheit.Size = new Size(216, 23);
            txtFarenheit.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 206);
            Controls.Add(txtFarenheit);
            Controls.Add(txtCelcius);
            Controls.Add(txtInput);
            Controls.Add(btnClose);
            Controls.Add(btnConvert);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Button btnConvert;
        private Button btnClose;
        private TextBox txtInput;
        private TextBox txtCelcius;
        private TextBox txtFarenheit;
    }
}
