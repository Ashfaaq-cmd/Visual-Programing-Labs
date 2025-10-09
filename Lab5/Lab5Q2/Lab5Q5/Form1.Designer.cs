namespace Lab5Q5
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
            txtDistance = new TextBox();
            txtAvgLitre = new TextBox();
            label1 = new Label();
            txtKmPerLitre = new TextBox();
            label2 = new Label();
            txtLitresNeeded = new TextBox();
            btnCalculate = new Button();
            btnClose = new Button();
            txtTotalCost = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(29, 31);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(85, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Enter Distance:";
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(140, 23);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(100, 23);
            txtDistance.TabIndex = 1;
            // 
            // txtAvgLitre
            // 
            txtAvgLitre.Location = new Point(150, 89);
            txtAvgLitre.Name = "txtAvgLitre";
            txtAvgLitre.Size = new Size(100, 23);
            txtAvgLitre.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter Avg Distance/Litres:";
            // 
            // txtKmPerLitre
            // 
            txtKmPerLitre.Location = new Point(140, 56);
            txtKmPerLitre.Name = "txtKmPerLitre";
            txtKmPerLitre.Size = new Size(100, 23);
            txtKmPerLitre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 64);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter Km/Litres:";
            // 
            // txtLitresNeeded
            // 
            txtLitresNeeded.Location = new Point(22, 133);
            txtLitresNeeded.Name = "txtLitresNeeded";
            txtLitresNeeded.ReadOnly = true;
            txtLitresNeeded.Size = new Size(228, 23);
            txtLitresNeeded.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(22, 212);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(165, 212);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Location = new Point(22, 173);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.ReadOnly = true;
            txtTotalCost.Size = new Size(228, 23);
            txtTotalCost.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 285);
            Controls.Add(txtTotalCost);
            Controls.Add(btnClose);
            Controls.Add(btnCalculate);
            Controls.Add(txtLitresNeeded);
            Controls.Add(txtKmPerLitre);
            Controls.Add(label2);
            Controls.Add(txtAvgLitre);
            Controls.Add(label1);
            Controls.Add(txtDistance);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtDistance;
        private TextBox txtAvgLitre;
        private Label label1;
        private TextBox txtKmPerLitre;
        private Label label2;
        private TextBox txtLitresNeeded;
        private Button btnCalculate;
        private Button btnClose;
        private TextBox txtTotalCost;
    }
}
