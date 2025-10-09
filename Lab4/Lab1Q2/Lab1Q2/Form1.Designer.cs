namespace Lab1Q2
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
            lbtitle = new Label();
            comboBox1 = new ComboBox();
            cmbbx = new GroupBox();
            label1 = new Label();
            Radiobtn = new GroupBox();
            radioopt1 = new RadioButton();
            radioopt2 = new RadioButton();
            radioopt3 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            chkBox1 = new GroupBox();
            chk1 = new CheckBox();
            ScrollBar = new GroupBox();
            hScrollBar1 = new HScrollBar();
            lbScroll = new Label();
            LstBox = new GroupBox();
            ltBox1 = new ListBox();
            btnclose = new Button();
            label4 = new Label();
            VScrollBar = new GroupBox();
            vScrollBar1 = new VScrollBar();
            label5 = new Label();
            cmbbx.SuspendLayout();
            Radiobtn.SuspendLayout();
            chkBox1.SuspendLayout();
            ScrollBar.SuspendLayout();
            LstBox.SuspendLayout();
            VScrollBar.SuspendLayout();
            SuspendLayout();
            // 
            // lbtitle
            // 
            lbtitle.AutoSize = true;
            lbtitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtitle.Location = new Point(195, 26);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(384, 32);
            lbtitle.TabIndex = 0;
            lbtitle.Text = "Experiment with These Controls!";
            lbtitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Choose a Pet";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbbx
            // 
            cmbbx.Controls.Add(comboBox1);
            cmbbx.Location = new Point(44, 89);
            cmbbx.Name = "cmbbx";
            cmbbx.Size = new Size(190, 79);
            cmbbx.TabIndex = 2;
            cmbbx.TabStop = false;
            cmbbx.Text = "ComboBox";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 183);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 3;
            label1.Text = "You Selected: ";
            label1.Click += label1_Click;
            // 
            // Radiobtn
            // 
            Radiobtn.Controls.Add(radioopt3);
            Radiobtn.Controls.Add(radioopt2);
            Radiobtn.Controls.Add(radioopt1);
            Radiobtn.Location = new Point(44, 224);
            Radiobtn.Name = "Radiobtn";
            Radiobtn.Size = new Size(200, 100);
            Radiobtn.TabIndex = 4;
            Radiobtn.TabStop = false;
            Radiobtn.Text = "RadioButtons";
            // 
            // radioopt1
            // 
            radioopt1.AutoSize = true;
            radioopt1.Location = new Point(18, 22);
            radioopt1.Name = "radioopt1";
            radioopt1.Size = new Size(68, 19);
            radioopt1.TabIndex = 0;
            radioopt1.TabStop = true;
            radioopt1.Text = "Option1";
            radioopt1.UseVisualStyleBackColor = true;
            // 
            // radioopt2
            // 
            radioopt2.AutoSize = true;
            radioopt2.Location = new Point(18, 47);
            radioopt2.Name = "radioopt2";
            radioopt2.Size = new Size(68, 19);
            radioopt2.TabIndex = 1;
            radioopt2.TabStop = true;
            radioopt2.Text = "Option2";
            radioopt2.UseVisualStyleBackColor = true;
            // 
            // radioopt3
            // 
            radioopt3.AutoSize = true;
            radioopt3.Location = new Point(18, 72);
            radioopt3.Name = "radioopt3";
            radioopt3.Size = new Size(68, 19);
            radioopt3.TabIndex = 2;
            radioopt3.TabStop = true;
            radioopt3.Text = "Option3";
            radioopt3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 362);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 347);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 6;
            label3.Text = "You Selected: ";
            // 
            // chkBox1
            // 
            chkBox1.Controls.Add(chk1);
            chkBox1.Location = new Point(282, 89);
            chkBox1.Name = "chkBox1";
            chkBox1.Size = new Size(230, 79);
            chkBox1.TabIndex = 7;
            chkBox1.TabStop = false;
            chkBox1.Text = "CheckBox";
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.Location = new Point(22, 23);
            chk1.Name = "chk1";
            chk1.Size = new Size(183, 19);
            chk1.TabIndex = 0;
            chk1.Text = "The Check Box is un-Checked";
            chk1.UseVisualStyleBackColor = true;
            // 
            // ScrollBar
            // 
            ScrollBar.Controls.Add(hScrollBar1);
            ScrollBar.Location = new Point(304, 224);
            ScrollBar.Name = "ScrollBar";
            ScrollBar.Size = new Size(241, 100);
            ScrollBar.TabIndex = 8;
            ScrollBar.TabStop = false;
            ScrollBar.Text = "HScrollBar";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(25, 32);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(183, 24);
            hScrollBar1.TabIndex = 0;
            // 
            // lbScroll
            // 
            lbScroll.AutoSize = true;
            lbScroll.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbScroll.Location = new Point(329, 347);
            lbScroll.Name = "lbScroll";
            lbScroll.Size = new Size(123, 15);
            lbScroll.TabIndex = 9;
            lbScroll.Text = "Move the Scroll Bar";
            // 
            // LstBox
            // 
            LstBox.Controls.Add(ltBox1);
            LstBox.Location = new Point(562, 89);
            LstBox.Name = "LstBox";
            LstBox.Size = new Size(179, 109);
            LstBox.TabIndex = 10;
            LstBox.TabStop = false;
            LstBox.Text = "ListBox";
            // 
            // ltBox1
            // 
            ltBox1.FormattingEnabled = true;
            ltBox1.ItemHeight = 15;
            ltBox1.Items.AddRange(new object[] { "Beans", "Carrot", "Cabbage", "Lettuce", "Broccoli", "Pineapple", "Apple" });
            ltBox1.Location = new Point(6, 22);
            ltBox1.Name = "ltBox1";
            ltBox1.Size = new Size(120, 64);
            ltBox1.TabIndex = 0;
            // 
            // btnclose
            // 
            btnclose.BackColor = SystemColors.Control;
            btnclose.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclose.Location = new Point(357, 431);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(75, 32);
            btnclose.TabIndex = 11;
            btnclose.Text = "Close";
            btnclose.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(568, 212);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 12;
            label4.Text = "You Selected: ";
            // 
            // VScrollBar
            // 
            VScrollBar.Controls.Add(vScrollBar1);
            VScrollBar.Location = new Point(568, 246);
            VScrollBar.Name = "VScrollBar";
            VScrollBar.Size = new Size(156, 131);
            VScrollBar.TabIndex = 13;
            VScrollBar.TabStop = false;
            VScrollBar.Text = "VScrollBar";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(39, 38);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(25, 80);
            vScrollBar1.TabIndex = 0;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(587, 395);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 14;
            label5.Text = "Move the Scroll Bar";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(label5);
            Controls.Add(VScrollBar);
            Controls.Add(label4);
            Controls.Add(btnclose);
            Controls.Add(LstBox);
            Controls.Add(lbScroll);
            Controls.Add(ScrollBar);
            Controls.Add(chkBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Radiobtn);
            Controls.Add(label1);
            Controls.Add(cmbbx);
            Controls.Add(lbtitle);
            Name = "Form1";
            Text = "Controls Demo";
            cmbbx.ResumeLayout(false);
            Radiobtn.ResumeLayout(false);
            Radiobtn.PerformLayout();
            chkBox1.ResumeLayout(false);
            chkBox1.PerformLayout();
            ScrollBar.ResumeLayout(false);
            LstBox.ResumeLayout(false);
            VScrollBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtitle;
        private ComboBox comboBox1;
        private GroupBox cmbbx;
        private Label label1;
        private GroupBox Radiobtn;
        private RadioButton radioopt1;
        private RadioButton radioopt3;
        private RadioButton radioopt2;
        private Label label2;
        private Label label3;
        private GroupBox chkBox1;
        private CheckBox chk1;
        private GroupBox ScrollBar;
        private HScrollBar hScrollBar1;
        private Label lbScroll;
        private GroupBox LstBox;
        private ListBox ltBox1;
        private Button btnclose;
        private Label label4;
        private GroupBox VScrollBar;
        private VScrollBar vScrollBar1;
        private Label label5;
    }
}
