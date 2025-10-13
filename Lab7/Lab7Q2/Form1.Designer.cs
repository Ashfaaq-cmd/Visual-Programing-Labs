namespace Lab7Q2
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
            txtSum = new TextBox();
            txtPremium = new TextBox();
            groupBox1 = new GroupBox();
            chkFire = new CheckBox();
            chkTheft = new CheckBox();
            chkRiot = new CheckBox();
            btnCalc = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Sum Insured:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 217);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Premium:";
            // 
            // txtSum
            // 
            txtSum.Location = new Point(131, 29);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(100, 23);
            txtSum.TabIndex = 2;
            // 
            // txtPremium
            // 
            txtPremium.Location = new Point(131, 214);
            txtPremium.Name = "txtPremium";
            txtPremium.ReadOnly = true;
            txtPremium.Size = new Size(100, 23);
            txtPremium.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkFire);
            groupBox1.Controls.Add(chkTheft);
            groupBox1.Controls.Add(chkRiot);
            groupBox1.Location = new Point(45, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Additional Benefits";
            // 
            // chkFire
            // 
            chkFire.AutoSize = true;
            chkFire.Location = new Point(16, 72);
            chkFire.Name = "chkFire";
            chkFire.Size = new Size(95, 19);
            chkFire.TabIndex = 2;
            chkFire.Text = "Fire (Rs 3750)";
            chkFire.UseVisualStyleBackColor = true;
            // 
            // chkTheft
            // 
            chkTheft.AutoSize = true;
            chkTheft.Location = new Point(16, 47);
            chkTheft.Name = "chkTheft";
            chkTheft.Size = new Size(104, 19);
            chkTheft.TabIndex = 1;
            chkTheft.Text = "Theft (Rs 4500)";
            chkTheft.UseVisualStyleBackColor = true;
            // 
            // chkRiot
            // 
            chkRiot.AutoSize = true;
            chkRiot.Location = new Point(16, 25);
            chkRiot.Name = "chkRiot";
            chkRiot.Size = new Size(97, 19);
            chkRiot.TabIndex = 0;
            chkRiot.Text = "Riot (Rs 2000)";
            chkRiot.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(89, 185);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            Controls.Add(btnCalc);
            Controls.Add(groupBox1);
            Controls.Add(txtPremium);
            Controls.Add(txtSum);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Comprehensive Cover Calculator";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSum;
        private TextBox txtPremium;
        private GroupBox groupBox1;
        private CheckBox chkFire;
        private CheckBox chkTheft;
        private CheckBox chkRiot;
        private Button btnCalc;
    }
}
