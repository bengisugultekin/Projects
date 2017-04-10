namespace Water_Bill_Payment
{
    partial class AccountInfo
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
            this.textBoxTotalAmountPaid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTotalAmountPaid
            // 
            this.textBoxTotalAmountPaid.Location = new System.Drawing.Point(152, 76);
            this.textBoxTotalAmountPaid.Name = "textBoxTotalAmountPaid";
            this.textBoxTotalAmountPaid.ReadOnly = true;
            this.textBoxTotalAmountPaid.Size = new System.Drawing.Size(156, 20);
            this.textBoxTotalAmountPaid.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Total Payment";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Honeydew;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBack.Location = new System.Drawing.Point(16, 118);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(292, 31);
            this.buttonBack.TabIndex = 43;
            this.buttonBack.Text = "BACK";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Location = new System.Drawing.Point(152, 49);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.ReadOnly = true;
            this.textBoxPaidAmount.Size = new System.Drawing.Size(156, 20);
            this.textBoxPaidAmount.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Payment (Paid)";
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(152, 18);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.ReadOnly = true;
            this.textBoxAccountNumber.Size = new System.Drawing.Size(156, 20);
            this.textBoxAccountNumber.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Account Number";
            // 
            // AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 164);
            this.Controls.Add(this.textBoxTotalAmountPaid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxPaidAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAccountNumber);
            this.Controls.Add(this.label1);
            this.Name = "AccountInfo";
            this.Text = "AccountInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTotalAmountPaid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.Label label1;
    }
}