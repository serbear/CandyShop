namespace CandyShop
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFish = new System.Windows.Forms.TextBox();
            this.tbChocolate = new System.Windows.Forms.TextBox();
            this.tbLollipop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSumma = new System.Windows.Forms.TextBox();
            this.tbFishTotal = new System.Windows.Forms.TextBox();
            this.tbChocolateTotal = new System.Windows.Forms.TextBox();
            this.tbLollipopTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFish);
            this.groupBox1.Controls.Add(this.tbChocolate);
            this.groupBox1.Controls.Add(this.tbLollipop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Candy";
            // 
            // tbFish
            // 
            this.tbFish.Location = new System.Drawing.Point(96, 81);
            this.tbFish.Name = "tbFish";
            this.tbFish.Size = new System.Drawing.Size(100, 20);
            this.tbFish.TabIndex = 6;
            this.tbFish.Text = "1";
            this.tbFish.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbChocolate
            // 
            this.tbChocolate.Location = new System.Drawing.Point(96, 55);
            this.tbChocolate.Name = "tbChocolate";
            this.tbChocolate.Size = new System.Drawing.Size(100, 20);
            this.tbChocolate.TabIndex = 4;
            this.tbChocolate.Text = "1";
            this.tbChocolate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLollipop
            // 
            this.tbLollipop.Location = new System.Drawing.Point(96, 29);
            this.tbLollipop.Name = "tbLollipop";
            this.tbLollipop.Size = new System.Drawing.Size(100, 20);
            this.tbLollipop.TabIndex = 2;
            this.tbLollipop.Text = "1";
            this.tbLollipop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "&Fish:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "C&hocolate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Lollipop:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSumma);
            this.groupBox2.Controls.Add(this.tbFishTotal);
            this.groupBox2.Controls.Add(this.tbChocolateTotal);
            this.groupBox2.Controls.Add(this.tbLollipopTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(248, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 147);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Totals";
            // 
            // tbSumma
            // 
            this.tbSumma.Location = new System.Drawing.Point(98, 108);
            this.tbSumma.Name = "tbSumma";
            this.tbSumma.ReadOnly = true;
            this.tbSumma.Size = new System.Drawing.Size(100, 20);
            this.tbSumma.TabIndex = 18;
            this.tbSumma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFishTotal
            // 
            this.tbFishTotal.Location = new System.Drawing.Point(98, 82);
            this.tbFishTotal.Name = "tbFishTotal";
            this.tbFishTotal.ReadOnly = true;
            this.tbFishTotal.Size = new System.Drawing.Size(100, 20);
            this.tbFishTotal.TabIndex = 16;
            this.tbFishTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbChocolateTotal
            // 
            this.tbChocolateTotal.Location = new System.Drawing.Point(98, 56);
            this.tbChocolateTotal.Name = "tbChocolateTotal";
            this.tbChocolateTotal.ReadOnly = true;
            this.tbChocolateTotal.Size = new System.Drawing.Size(100, 20);
            this.tbChocolateTotal.TabIndex = 14;
            this.tbChocolateTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbLollipopTotal
            // 
            this.tbLollipopTotal.Location = new System.Drawing.Point(98, 30);
            this.tbLollipopTotal.Name = "tbLollipopTotal";
            this.tbLollipopTotal.ReadOnly = true;
            this.tbLollipopTotal.Size = new System.Drawing.Size(100, 20);
            this.tbLollipopTotal.TabIndex = 12;
            this.tbLollipopTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(27, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fish:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Chocolate:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lollipop:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(125, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(206, 181);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 38);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "C&aclculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(287, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 231);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Candy Shop Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLollipop;
        private System.Windows.Forms.TextBox tbChocolate;
        private System.Windows.Forms.TextBox tbFish;
        private System.Windows.Forms.TextBox tbLollipopTotal;
        private System.Windows.Forms.TextBox tbChocolateTotal;
        private System.Windows.Forms.TextBox tbFishTotal;
        private System.Windows.Forms.TextBox tbSumma;

        #endregion
    }
}