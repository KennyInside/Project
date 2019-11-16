namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTaddString = new System.Windows.Forms.Button();
            this.TBnameFruit = new System.Windows.Forms.TextBox();
            this.TBcountFruit = new System.Windows.Forms.TextBox();
            this.TBpriceFruit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTaddString
            // 
            this.BTaddString.Location = new System.Drawing.Point(187, 152);
            this.BTaddString.Name = "BTaddString";
            this.BTaddString.Size = new System.Drawing.Size(75, 23);
            this.BTaddString.TabIndex = 0;
            this.BTaddString.Text = "Add string";
            this.BTaddString.UseVisualStyleBackColor = true;
            this.BTaddString.Click += new System.EventHandler(this.BTaddString_Click);
            // 
            // TBnameFruit
            // 
            this.TBnameFruit.Location = new System.Drawing.Point(116, 38);
            this.TBnameFruit.Name = "TBnameFruit";
            this.TBnameFruit.Size = new System.Drawing.Size(146, 20);
            this.TBnameFruit.TabIndex = 1;
            // 
            // TBcountFruit
            // 
            this.TBcountFruit.Location = new System.Drawing.Point(116, 117);
            this.TBcountFruit.Name = "TBcountFruit";
            this.TBcountFruit.Size = new System.Drawing.Size(146, 20);
            this.TBcountFruit.TabIndex = 2;
            // 
            // TBpriceFruit
            // 
            this.TBpriceFruit.Location = new System.Drawing.Point(116, 76);
            this.TBpriceFruit.Name = "TBpriceFruit";
            this.TBpriceFruit.Size = new System.Drawing.Size(146, 20);
            this.TBpriceFruit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fruit Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 207);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBpriceFruit);
            this.Controls.Add(this.TBcountFruit);
            this.Controls.Add(this.TBnameFruit);
            this.Controls.Add(this.BTaddString);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTaddString;
        private System.Windows.Forms.TextBox TBnameFruit;
        private System.Windows.Forms.TextBox TBcountFruit;
        private System.Windows.Forms.TextBox TBpriceFruit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}