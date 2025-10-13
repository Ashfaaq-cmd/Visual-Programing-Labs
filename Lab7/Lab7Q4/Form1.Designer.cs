namespace Lab7Q4
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
            lstCollection = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCompute = new Button();
            txtQty = new TextBox();
            txtTot = new TextBox();
            txtUnitPrice = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 25);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 0;
            label1.Text = "Katty Fried Chicken";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstCollection);
            groupBox1.Location = new Point(25, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Make a Selection";
            // 
            // lstCollection
            // 
            lstCollection.FormattingEnabled = true;
            lstCollection.ItemHeight = 15;
            lstCollection.Items.AddRange(new object[] { "Zinger", "Large Piece", "Strips", "Wedges" });
            lstCollection.Location = new Point(6, 22);
            lstCollection.Name = "lstCollection";
            lstCollection.Size = new Size(120, 64);
            lstCollection.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 73);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 142);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Unit Price:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 173);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 4;
            label4.Text = "Total:";
            // 
            // btnCompute
            // 
            btnCompute.Location = new Point(226, 110);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(87, 23);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(272, 70);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(100, 23);
            txtQty.TabIndex = 6;
            // 
            // txtTot
            // 
            txtTot.Location = new Point(265, 168);
            txtTot.Name = "txtTot";
            txtTot.ReadOnly = true;
            txtTot.Size = new Size(100, 23);
            txtTot.TabIndex = 7;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(265, 139);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(100, 23);
            txtUnitPrice.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtTot);
            Controls.Add(txtQty);
            Controls.Add(btnCompute);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "KFC Order Form";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ListBox lstCollection;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCompute;
        private TextBox txtQty;
        private TextBox txtTot;
        private TextBox txtUnitPrice;
    }
}
