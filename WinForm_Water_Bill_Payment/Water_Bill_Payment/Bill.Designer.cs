namespace Water_Bill_Payment
{
    partial class Bill
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxCurrCharges = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCurrRead = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrevRead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAccountNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrevBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Azure;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(145, 236);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(83, 30);
            this.buttonBack.TabIndex = 34;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.Salmon;
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPay.Location = new System.Drawing.Point(20, 236);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(85, 30);
            this.buttonPay.TabIndex = 33;
            this.buttonPay.Text = "PAY";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxCurrCharges
            // 
            this.textBoxCurrCharges.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCurrCharges.Location = new System.Drawing.Point(130, 194);
            this.textBoxCurrCharges.Name = "textBoxCurrCharges";
            this.textBoxCurrCharges.ReadOnly = true;
            this.textBoxCurrCharges.Size = new System.Drawing.Size(104, 22);
            this.textBoxCurrCharges.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Current Charges";
            // 
            // textBoxCurrRead
            // 
            this.textBoxCurrRead.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCurrRead.Location = new System.Drawing.Point(130, 85);
            this.textBoxCurrRead.Name = "textBoxCurrRead";
            this.textBoxCurrRead.ReadOnly = true;
            this.textBoxCurrRead.Size = new System.Drawing.Size(104, 22);
            this.textBoxCurrRead.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Current Read";
            // 
            // textBoxPrevRead
            // 
            this.textBoxPrevRead.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPrevRead.Location = new System.Drawing.Point(130, 49);
            this.textBoxPrevRead.Name = "textBoxPrevRead";
            this.textBoxPrevRead.ReadOnly = true;
            this.textBoxPrevRead.Size = new System.Drawing.Size(104, 22);
            this.textBoxPrevRead.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Previous Read";
            // 
            // textBoxAccountNo
            // 
            this.textBoxAccountNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAccountNo.Location = new System.Drawing.Point(130, 14);
            this.textBoxAccountNo.Name = "textBoxAccountNo";
            this.textBoxAccountNo.ReadOnly = true;
            this.textBoxAccountNo.Size = new System.Drawing.Size(104, 22);
            this.textBoxAccountNo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Account Number";
            // 
            // textBoxUsage
            // 
            this.textBoxUsage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUsage.Location = new System.Drawing.Point(130, 120);
            this.textBoxUsage.Name = "textBoxUsage";
            this.textBoxUsage.ReadOnly = true;
            this.textBoxUsage.Size = new System.Drawing.Size(104, 22);
            this.textBoxUsage.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Usage";
            // 
            // textBoxPrevBalance
            // 
            this.textBoxPrevBalance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPrevBalance.Location = new System.Drawing.Point(130, 156);
            this.textBoxPrevBalance.Name = "textBoxPrevBalance";
            this.textBoxPrevBalance.ReadOnly = true;
            this.textBoxPrevBalance.Size = new System.Drawing.Size(104, 22);
            this.textBoxPrevBalance.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Previous Balance";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 285);
            this.Controls.Add(this.textBoxPrevBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxUsage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.textBoxCurrCharges);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCurrRead);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrevRead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAccountNo);
            this.Controls.Add(this.label1);
            this.Name = "Bill";
            this.Text = "Billing Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.TextBox textBoxCurrCharges;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCurrRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrevRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAccountNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrevBalance;
        private System.Windows.Forms.Label label6;
    }
}