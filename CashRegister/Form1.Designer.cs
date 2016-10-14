namespace CashRegister
{
    partial class cashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.neworderButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.friesBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drinksBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.receiptLabel1 = new System.Windows.Forms.Label();
            this.receiptLabel2 = new System.Windows.Forms.Label();
            this.receiptLabel4 = new System.Windows.Forms.Label();
            this.receiptLabel3 = new System.Windows.Forms.Label();
            this.receiptLabel5 = new System.Windows.Forms.Label();
            this.receiptLabel6 = new System.Windows.Forms.Label();
            this.receiptLabel7 = new System.Windows.Forms.Label();
            this.receiptLabel8 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.Color.Blue;
            this.totalButton.Location = new System.Drawing.Point(34, 138);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(123, 34);
            this.totalButton.TabIndex = 1;
            this.totalButton.Text = "Click To Calculate Total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Blue;
            this.changeButton.Location = new System.Drawing.Point(13, 340);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(120, 41);
            this.changeButton.TabIndex = 2;
            this.changeButton.Text = "Click To Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Blue;
            this.receiptButton.Location = new System.Drawing.Point(191, 347);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(117, 34);
            this.receiptButton.TabIndex = 3;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // neworderButton
            // 
            this.neworderButton.BackColor = System.Drawing.Color.Blue;
            this.neworderButton.Location = new System.Drawing.Point(314, 345);
            this.neworderButton.Name = "neworderButton";
            this.neworderButton.Size = new System.Drawing.Size(110, 36);
            this.neworderButton.TabIndex = 4;
            this.neworderButton.Text = "New Order";
            this.neworderButton.UseVisualStyleBackColor = false;
            this.neworderButton.Click += new System.EventHandler(this.neworderButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number Of Burgers;";
            // 
            // burgerBox
            // 
            this.burgerBox.Location = new System.Drawing.Point(146, 17);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(41, 20);
            this.burgerBox.TabIndex = 6;
            // 
            // friesBox
            // 
            this.friesBox.Location = new System.Drawing.Point(146, 55);
            this.friesBox.Name = "friesBox";
            this.friesBox.Size = new System.Drawing.Size(41, 20);
            this.friesBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number Of Fries;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // drinksBox
            // 
            this.drinksBox.Location = new System.Drawing.Point(146, 95);
            this.drinksBox.Name = "drinksBox";
            this.drinksBox.Size = new System.Drawing.Size(41, 20);
            this.drinksBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number Of Drinks;";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sub Total;";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tax;";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total;";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tendered;";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(128, 188);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(0, 13);
            this.subtotalLabel.TabIndex = 18;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(129, 217);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(0, 13);
            this.taxLabel.TabIndex = 19;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(126, 239);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 13);
            this.totalLabel.TabIndex = 20;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(115, 277);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(62, 20);
            this.tenderedInput.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(10, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Change;";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(112, 308);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 13);
            this.changeLabel.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Burger= $2.49";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Fries= $1.89";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Drinks= $0.99";
            // 
            // receiptLabel1
            // 
            this.receiptLabel1.AutoSize = true;
            this.receiptLabel1.BackColor = System.Drawing.Color.White;
            this.receiptLabel1.Location = new System.Drawing.Point(224, 33);
            this.receiptLabel1.Name = "receiptLabel1";
            this.receiptLabel1.Size = new System.Drawing.Size(0, 13);
            this.receiptLabel1.TabIndex = 27;
            // 
            // receiptLabel2
            // 
            this.receiptLabel2.AutoSize = true;
            this.receiptLabel2.BackColor = System.Drawing.Color.White;
            this.receiptLabel2.Location = new System.Drawing.Point(224, 60);
            this.receiptLabel2.Name = "receiptLabel2";
            this.receiptLabel2.Size = new System.Drawing.Size(0, 13);
            this.receiptLabel2.TabIndex = 28;
            // 
            // receiptLabel4
            // 
            this.receiptLabel4.AutoSize = true;
            this.receiptLabel4.BackColor = System.Drawing.Color.White;
            this.receiptLabel4.Location = new System.Drawing.Point(225, 116);
            this.receiptLabel4.Name = "receiptLabel4";
            this.receiptLabel4.Size = new System.Drawing.Size(0, 13);
            this.receiptLabel4.TabIndex = 30;
            // 
            // receiptLabel3
            // 
            this.receiptLabel3.AutoSize = true;
            this.receiptLabel3.BackColor = System.Drawing.Color.White;
            this.receiptLabel3.Location = new System.Drawing.Point(225, 89);
            this.receiptLabel3.Name = "receiptLabel3";
            this.receiptLabel3.Size = new System.Drawing.Size(0, 13);
            this.receiptLabel3.TabIndex = 29;
            // 
            // receiptLabel5
            // 
            this.receiptLabel5.AutoSize = true;
            this.receiptLabel5.BackColor = System.Drawing.Color.White;
            this.receiptLabel5.Location = new System.Drawing.Point(226, 143);
            this.receiptLabel5.Name = "receiptLabel5";
            this.receiptLabel5.Size = new System.Drawing.Size(0, 13);
            this.receiptLabel5.TabIndex = 31;
            // 
            // receiptLabel6
            // 
            this.receiptLabel6.AutoSize = true;
            this.receiptLabel6.BackColor = System.Drawing.Color.White;
            this.receiptLabel6.Location = new System.Drawing.Point(226, 167);
            this.receiptLabel6.Name = "receiptLabel6";
            this.receiptLabel6.Size = new System.Drawing.Size(0, 13);
            this.receiptLabel6.TabIndex = 32;
            // 
            // receiptLabel7
            // 
            this.receiptLabel7.AutoSize = true;
            this.receiptLabel7.BackColor = System.Drawing.Color.White;
            this.receiptLabel7.Location = new System.Drawing.Point(226, 195);
            this.receiptLabel7.Name = "receiptLabel7";
            this.receiptLabel7.Size = new System.Drawing.Size(0, 13);
            this.receiptLabel7.TabIndex = 33;
            // 
            // receiptLabel8
            // 
            this.receiptLabel8.AutoSize = true;
            this.receiptLabel8.BackColor = System.Drawing.Color.White;
            this.receiptLabel8.Location = new System.Drawing.Point(224, 213);
            this.receiptLabel8.Name = "receiptLabel8";
            this.receiptLabel8.Size = new System.Drawing.Size(0, 13);
            this.receiptLabel8.TabIndex = 34;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(28, 261);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 35;
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(427, 382);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.receiptLabel8);
            this.Controls.Add(this.receiptLabel7);
            this.Controls.Add(this.receiptLabel6);
            this.Controls.Add(this.receiptLabel5);
            this.Controls.Add(this.receiptLabel4);
            this.Controls.Add(this.receiptLabel3);
            this.Controls.Add(this.receiptLabel2);
            this.Controls.Add(this.receiptLabel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.drinksBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.friesBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.neworderButton);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cashRegister";
            this.Text = "cashRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Button neworderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.TextBox friesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox drinksBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label receiptLabel1;
        private System.Windows.Forms.Label receiptLabel2;
        private System.Windows.Forms.Label receiptLabel4;
        private System.Windows.Forms.Label receiptLabel3;
        private System.Windows.Forms.Label receiptLabel5;
        private System.Windows.Forms.Label receiptLabel6;
        private System.Windows.Forms.Label receiptLabel7;
        private System.Windows.Forms.Label receiptLabel8;
        private System.Windows.Forms.Label errorLabel;
    }
}

