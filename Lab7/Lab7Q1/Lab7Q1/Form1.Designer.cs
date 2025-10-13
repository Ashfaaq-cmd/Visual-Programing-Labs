namespace Lab7Q1
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
            groupBox1 = new GroupBox();
            txtChildren = new TextBox();
            txtAdult = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            radEvening = new RadioButton();
            radAfternoon = new RadioButton();
            radMorning = new RadioButton();
            label4 = new Label();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            txtTot = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveBorder;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(78, 28);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 0;
            label1.Text = "Movie TIcket Dispenser";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtChildren);
            groupBox1.Controls.Add(txtAdult);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(179, 113);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets Required";
            // 
            // txtChildren
            // 
            txtChildren.Location = new Point(83, 71);
            txtChildren.Name = "txtChildren";
            txtChildren.Size = new Size(75, 23);
            txtChildren.TabIndex = 3;
            // 
            // txtAdult
            // 
            txtAdult.Location = new Point(71, 37);
            txtAdult.Name = "txtAdult";
            txtAdult.Size = new Size(87, 23);
            txtAdult.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 74);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 1;
            label3.Text = "Children:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 37);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Adults:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radEvening);
            groupBox2.Controls.Add(radAfternoon);
            groupBox2.Controls.Add(radMorning);
            groupBox2.Location = new Point(217, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(108, 126);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Session";
            // 
            // radEvening
            // 
            radEvening.AutoSize = true;
            radEvening.Location = new Point(19, 94);
            radEvening.Name = "radEvening";
            radEvening.Size = new Size(67, 19);
            radEvening.TabIndex = 2;
            radEvening.TabStop = true;
            radEvening.Text = "Evening";
            radEvening.UseVisualStyleBackColor = true;
            // 
            // radAfternoon
            // 
            radAfternoon.AutoSize = true;
            radAfternoon.Location = new Point(19, 59);
            radAfternoon.Name = "radAfternoon";
            radAfternoon.Size = new Size(79, 19);
            radAfternoon.TabIndex = 1;
            radAfternoon.TabStop = true;
            radAfternoon.Text = "Afternoon";
            radAfternoon.UseVisualStyleBackColor = true;
            // 
            // radMorning
            // 
            radMorning.AutoSize = true;
            radMorning.Location = new Point(19, 25);
            radMorning.Name = "radMorning";
            radMorning.Size = new Size(71, 19);
            radMorning.TabIndex = 0;
            radMorning.TabStop = true;
            radMorning.Text = "Morning";
            radMorning.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 241);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 2;
            label4.Text = "Total Due:";
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(45, 292);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(142, 292);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(239, 292);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtTot
            // 
            txtTot.Location = new Point(117, 238);
            txtTot.Name = "txtTot";
            txtTot.ReadOnly = true;
            txtTot.Size = new Size(100, 23);
            txtTot.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(txtTot);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Movie Tickets";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radEvening;
        private RadioButton radAfternoon;
        private RadioButton radMorning;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
        private TextBox txtChildren;
        private TextBox txtAdult;
        private TextBox txtTot;
    }
}
