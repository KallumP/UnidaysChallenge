namespace UnidaysChallenge {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.basketNames_listBox = new System.Windows.Forms.ListBox();
            this.addItemA_btn = new System.Windows.Forms.Button();
            this.addItemB_btn = new System.Windows.Forms.Button();
            this.addItemC_btn = new System.Windows.Forms.Button();
            this.addItemD_btn = new System.Windows.Forms.Button();
            this.addItemE_btn = new System.Windows.Forms.Button();
            this.instructions_lbl = new System.Windows.Forms.Label();
            this.basketPrices_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // basketNames_listBox
            // 
            this.basketNames_listBox.FormattingEnabled = true;
            this.basketNames_listBox.Location = new System.Drawing.Point(510, 13);
            this.basketNames_listBox.Name = "basketNames_listBox";
            this.basketNames_listBox.Size = new System.Drawing.Size(120, 277);
            this.basketNames_listBox.TabIndex = 0;
            // 
            // addItemA_btn
            // 
            this.addItemA_btn.Location = new System.Drawing.Point(165, 147);
            this.addItemA_btn.Name = "addItemA_btn";
            this.addItemA_btn.Size = new System.Drawing.Size(75, 23);
            this.addItemA_btn.TabIndex = 1;
            this.addItemA_btn.Text = "Item A";
            this.addItemA_btn.UseVisualStyleBackColor = true;
            this.addItemA_btn.Click += new System.EventHandler(this.addItemA_btn_Click);
            // 
            // addItemB_btn
            // 
            this.addItemB_btn.Location = new System.Drawing.Point(165, 205);
            this.addItemB_btn.Name = "addItemB_btn";
            this.addItemB_btn.Size = new System.Drawing.Size(75, 23);
            this.addItemB_btn.TabIndex = 7;
            this.addItemB_btn.Text = "Item B";
            this.addItemB_btn.UseVisualStyleBackColor = true;
            this.addItemB_btn.Click += new System.EventHandler(this.addItemB_btn_Click);
            // 
            // addItemC_btn
            // 
            this.addItemC_btn.Location = new System.Drawing.Point(164, 270);
            this.addItemC_btn.Name = "addItemC_btn";
            this.addItemC_btn.Size = new System.Drawing.Size(75, 23);
            this.addItemC_btn.TabIndex = 8;
            this.addItemC_btn.Text = "Item C";
            this.addItemC_btn.UseVisualStyleBackColor = true;
            this.addItemC_btn.Click += new System.EventHandler(this.addItemC_btn_Click);
            // 
            // addItemD_btn
            // 
            this.addItemD_btn.Location = new System.Drawing.Point(164, 337);
            this.addItemD_btn.Name = "addItemD_btn";
            this.addItemD_btn.Size = new System.Drawing.Size(75, 23);
            this.addItemD_btn.TabIndex = 9;
            this.addItemD_btn.Text = "Item D";
            this.addItemD_btn.UseVisualStyleBackColor = true;
            this.addItemD_btn.Click += new System.EventHandler(this.addItemD_btn_Click);
            // 
            // addItemE_btn
            // 
            this.addItemE_btn.Location = new System.Drawing.Point(165, 401);
            this.addItemE_btn.Name = "addItemE_btn";
            this.addItemE_btn.Size = new System.Drawing.Size(75, 23);
            this.addItemE_btn.TabIndex = 10;
            this.addItemE_btn.Text = "Item E";
            this.addItemE_btn.UseVisualStyleBackColor = true;
            this.addItemE_btn.Click += new System.EventHandler(this.addItemE_btn_Click);
            // 
            // instructions_lbl
            // 
            this.instructions_lbl.Location = new System.Drawing.Point(35, 13);
            this.instructions_lbl.Name = "instructions_lbl";
            this.instructions_lbl.Size = new System.Drawing.Size(324, 95);
            this.instructions_lbl.TabIndex = 11;
            this.instructions_lbl.Text = "label1";
            this.instructions_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // basketPrices_listBox
            // 
            this.basketPrices_listBox.FormattingEnabled = true;
            this.basketPrices_listBox.Location = new System.Drawing.Point(636, 12);
            this.basketPrices_listBox.Name = "basketPrices_listBox";
            this.basketPrices_listBox.Size = new System.Drawing.Size(120, 277);
            this.basketPrices_listBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.basketPrices_listBox);
            this.Controls.Add(this.instructions_lbl);
            this.Controls.Add(this.addItemE_btn);
            this.Controls.Add(this.addItemD_btn);
            this.Controls.Add(this.addItemC_btn);
            this.Controls.Add(this.addItemB_btn);
            this.Controls.Add(this.addItemA_btn);
            this.Controls.Add(this.basketNames_listBox);
            this.Name = "Form1";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox basketNames_listBox;
        private System.Windows.Forms.Button addItemA_btn;
        private System.Windows.Forms.Button addItemB_btn;
        private System.Windows.Forms.Button addItemC_btn;
        private System.Windows.Forms.Button addItemD_btn;
        private System.Windows.Forms.Button addItemE_btn;
        private System.Windows.Forms.Label instructions_lbl;
        private System.Windows.Forms.ListBox basketPrices_listBox;
    }
}

