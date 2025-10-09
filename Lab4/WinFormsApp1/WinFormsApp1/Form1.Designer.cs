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
            lblname = new Label();
            btnok = new Button();
            txtame = new TextBox();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(12, 22);
            lblname.Name = "lblname";
            lblname.Size = new Size(70, 15);
            lblname.TabIndex = 0;
            lblname.Text = "Enter name:";
            // 
            // btnok
            // 
            btnok.Location = new Point(70, 84);
            btnok.Name = "btnok";
            btnok.Size = new Size(118, 23);
            btnok.TabIndex = 1;
            btnok.Text = "ok";
            btnok.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            txtame.Location = new Point(88, 22);
            txtame.Name = "txtname";
            txtame.Size = new Size(126, 23);
            txtame.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 137);
            Controls.Add(txtame);
            Controls.Add(btnok);
            Controls.Add(lblname);
            Name = "Form1";
            Text = "Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private Button btnok;
        private TextBox txtame;
    }
}
