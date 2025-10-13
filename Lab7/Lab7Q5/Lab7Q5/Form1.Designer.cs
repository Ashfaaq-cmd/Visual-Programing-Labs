namespace Lab7Q5
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
            gpFlavour = new GroupBox();
            radStrawberry = new RadioButton();
            radVanilla = new RadioButton();
            radChocolate = new RadioButton();
            gpAddOns = new GroupBox();
            chkFreshFruits = new CheckBox();
            chkCookieCandy = new CheckBox();
            chkNuts = new CheckBox();
            chkChocoChips = new CheckBox();
            gpSIze = new GroupBox();
            radSmall = new RadioButton();
            radLarge = new RadioButton();
            txtPrice = new TextBox();
            gpFlavour.SuspendLayout();
            gpAddOns.SuspendLayout();
            gpSIze.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 31);
            label1.Name = "label1";
            label1.Size = new Size(151, 18);
            label1.TabIndex = 0;
            label1.Text = "Zimis Ice-Cream";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 362);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            // 
            // gpFlavour
            // 
            gpFlavour.Controls.Add(radStrawberry);
            gpFlavour.Controls.Add(radVanilla);
            gpFlavour.Controls.Add(radChocolate);
            gpFlavour.Location = new Point(30, 99);
            gpFlavour.Name = "gpFlavour";
            gpFlavour.Size = new Size(104, 100);
            gpFlavour.TabIndex = 2;
            gpFlavour.TabStop = false;
            gpFlavour.Text = "Flavour";
            // 
            // radStrawberry
            // 
            radStrawberry.AutoSize = true;
            radStrawberry.Location = new Point(9, 71);
            radStrawberry.Name = "radStrawberry";
            radStrawberry.Size = new Size(81, 19);
            radStrawberry.TabIndex = 2;
            radStrawberry.TabStop = true;
            radStrawberry.Text = "Strawberry";
            radStrawberry.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            radVanilla.AutoSize = true;
            radVanilla.Location = new Point(9, 46);
            radVanilla.Name = "radVanilla";
            radVanilla.Size = new Size(59, 19);
            radVanilla.TabIndex = 1;
            radVanilla.TabStop = true;
            radVanilla.Text = "Vanilla";
            radVanilla.UseVisualStyleBackColor = true;
            // 
            // radChocolate
            // 
            radChocolate.AutoSize = true;
            radChocolate.Location = new Point(9, 23);
            radChocolate.Name = "radChocolate";
            radChocolate.Size = new Size(79, 19);
            radChocolate.TabIndex = 0;
            radChocolate.TabStop = true;
            radChocolate.Text = "Chocolate";
            radChocolate.UseVisualStyleBackColor = true;
            // 
            // gpAddOns
            // 
            gpAddOns.Controls.Add(chkFreshFruits);
            gpAddOns.Controls.Add(chkCookieCandy);
            gpAddOns.Controls.Add(chkNuts);
            gpAddOns.Controls.Add(chkChocoChips);
            gpAddOns.Location = new Point(166, 104);
            gpAddOns.Name = "gpAddOns";
            gpAddOns.Size = new Size(156, 215);
            gpAddOns.TabIndex = 3;
            gpAddOns.TabStop = false;
            gpAddOns.Text = "Add-Ons";
            // 
            // chkFreshFruits
            // 
            chkFreshFruits.AutoSize = true;
            chkFreshFruits.Location = new Point(19, 173);
            chkFreshFruits.Name = "chkFreshFruits";
            chkFreshFruits.Size = new Size(86, 19);
            chkFreshFruits.TabIndex = 3;
            chkFreshFruits.Text = "Fresh Fruits";
            chkFreshFruits.UseVisualStyleBackColor = true;
            // 
            // chkCookieCandy
            // 
            chkCookieCandy.AutoSize = true;
            chkCookieCandy.Location = new Point(19, 86);
            chkCookieCandy.Name = "chkCookieCandy";
            chkCookieCandy.Size = new Size(116, 19);
            chkCookieCandy.TabIndex = 2;
            chkCookieCandy.Text = "Cookies & Candies";
            chkCookieCandy.UseVisualStyleBackColor = true;
            // 
            // chkNuts
            // 
            chkNuts.AutoSize = true;
            chkNuts.Location = new Point(19, 127);
            chkNuts.Name = "chkNuts";
            chkNuts.Size = new Size(51, 19);
            chkNuts.TabIndex = 1;
            chkNuts.Text = "Nuts";
            chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkChocoChips
            // 
            chkChocoChips.AutoSize = true;
            chkChocoChips.Location = new Point(19, 38);
            chkChocoChips.Name = "chkChocoChips";
            chkChocoChips.Size = new Size(113, 19);
            chkChocoChips.TabIndex = 0;
            chkChocoChips.Text = "Chocolate Chips";
            chkChocoChips.UseVisualStyleBackColor = true;
            // 
            // gpSIze
            // 
            gpSIze.Controls.Add(radSmall);
            gpSIze.Controls.Add(radLarge);
            gpSIze.Location = new Point(30, 219);
            gpSIze.Name = "gpSIze";
            gpSIze.Size = new Size(104, 100);
            gpSIze.TabIndex = 3;
            gpSIze.TabStop = false;
            gpSIze.Text = "Size";
            // 
            // radSmall
            // 
            radSmall.AutoSize = true;
            radSmall.Location = new Point(7, 31);
            radSmall.Name = "radSmall";
            radSmall.Size = new Size(54, 19);
            radSmall.TabIndex = 3;
            radSmall.TabStop = true;
            radSmall.Text = "Small";
            radSmall.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            radLarge.AutoSize = true;
            radLarge.Location = new Point(7, 65);
            radLarge.Name = "radLarge";
            radLarge.Size = new Size(54, 19);
            radLarge.TabIndex = 4;
            radLarge.TabStop = true;
            radLarge.Text = "Large";
            radLarge.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(124, 359);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 4;
           
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(txtPrice);
            Controls.Add(gpSIze);
            Controls.Add(gpAddOns);
            Controls.Add(gpFlavour);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Zimis Fresh Ice Cream";
            gpFlavour.ResumeLayout(false);
            gpFlavour.PerformLayout();
            gpAddOns.ResumeLayout(false);
            gpAddOns.PerformLayout();
            gpSIze.ResumeLayout(false);
            gpSIze.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox gpFlavour;
        private GroupBox gpAddOns;
        private GroupBox gpSIze;
        private RadioButton radStrawberry;
        private RadioButton radVanilla;
        private RadioButton radChocolate;
        private CheckBox chkFreshFruits;
        private CheckBox chkCookieCandy;
        private CheckBox chkNuts;
        private CheckBox chkChocoChips;
        private RadioButton radSmall;
        private RadioButton radLarge;
        private TextBox txtPrice;
    }
}
