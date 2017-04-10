namespace Water_Bill_Payment
{
    partial class FormRegistration
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
            this.groupBoxAccountType = new System.Windows.Forms.GroupBox();
            this.radioButtonOrganization = new System.Windows.Forms.RadioButton();
            this.radioButtonHome = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAccountNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrevRead = new System.Windows.Forms.TextBox();
            this.textBoxCurrRead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxPaid = new System.Windows.Forms.ListBox();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxAccountType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAccountType
            // 
            this.groupBoxAccountType.Controls.Add(this.radioButtonOrganization);
            this.groupBoxAccountType.Controls.Add(this.radioButtonHome);
            this.groupBoxAccountType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxAccountType.Location = new System.Drawing.Point(4, 56);
            this.groupBoxAccountType.Name = "groupBoxAccountType";
            this.groupBoxAccountType.Size = new System.Drawing.Size(214, 55);
            this.groupBoxAccountType.TabIndex = 14;
            this.groupBoxAccountType.TabStop = false;
            this.groupBoxAccountType.Text = "Account Type";
            // 
            // radioButtonOrganization
            // 
            this.radioButtonOrganization.AutoSize = true;
            this.radioButtonOrganization.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonOrganization.Location = new System.Drawing.Point(107, 22);
            this.radioButtonOrganization.Name = "radioButtonOrganization";
            this.radioButtonOrganization.Size = new System.Drawing.Size(99, 20);
            this.radioButtonOrganization.TabIndex = 3;
            this.radioButtonOrganization.TabStop = true;
            this.radioButtonOrganization.Text = "Organization";
            this.radioButtonOrganization.UseVisualStyleBackColor = true;
            // 
            // radioButtonHome
            // 
            this.radioButtonHome.AutoSize = true;
            this.radioButtonHome.Checked = true;
            this.radioButtonHome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonHome.Location = new System.Drawing.Point(10, 22);
            this.radioButtonHome.Name = "radioButtonHome";
            this.radioButtonHome.Size = new System.Drawing.Size(60, 20);
            this.radioButtonHome.TabIndex = 0;
            this.radioButtonHome.TabStop = true;
            this.radioButtonHome.Text = "Home";
            this.radioButtonHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Account No";
            // 
            // textBoxAccountNo
            // 
            this.textBoxAccountNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAccountNo.Location = new System.Drawing.Point(89, 21);
            this.textBoxAccountNo.Name = "textBoxAccountNo";
            this.textBoxAccountNo.Size = new System.Drawing.Size(68, 22);
            this.textBoxAccountNo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(7, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Curr Read";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Prev Read";
            // 
            // textBoxPrevRead
            // 
            this.textBoxPrevRead.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxPrevRead.Location = new System.Drawing.Point(89, 131);
            this.textBoxPrevRead.Name = "textBoxPrevRead";
            this.textBoxPrevRead.Size = new System.Drawing.Size(68, 22);
            this.textBoxPrevRead.TabIndex = 21;
            // 
            // textBoxCurrRead
            // 
            this.textBoxCurrRead.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCurrRead.Location = new System.Drawing.Point(89, 167);
            this.textBoxCurrRead.Name = "textBoxCurrRead";
            this.textBoxCurrRead.Size = new System.Drawing.Size(68, 22);
            this.textBoxCurrRead.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(422, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "All Payments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(284, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "All Accounts";
            // 
            // listBoxPaid
            // 
            this.listBoxPaid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxPaid.FormattingEnabled = true;
            this.listBoxPaid.ItemHeight = 16;
            this.listBoxPaid.Location = new System.Drawing.Point(405, 28);
            this.listBoxPaid.Name = "listBoxPaid";
            this.listBoxPaid.Size = new System.Drawing.Size(125, 228);
            this.listBoxPaid.TabIndex = 17;
            this.listBoxPaid.DoubleClick += new System.EventHandler(this.listBoxPaid_DoubleClick);
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.ItemHeight = 16;
            this.listBoxAccounts.Location = new System.Drawing.Point(263, 28);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(122, 228);
            this.listBoxAccounts.TabIndex = 16;
            this.listBoxAccounts.DoubleClick += new System.EventHandler(this.listBoxAccounts_DoubleClick);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSave.Location = new System.Drawing.Point(12, 218);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(99, 38);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.Location = new System.Drawing.Point(141, 218);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(101, 38);
            this.buttonExit.TabIndex = 24;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 276);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxAccountType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAccountNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrevRead);
            this.Controls.Add(this.textBoxCurrRead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxPaid);
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormRegistration";
            this.Text = "Waterworks Department Registration";
            this.Load += new System.EventHandler(this.FormRegistration_Load);
            this.groupBoxAccountType.ResumeLayout(false);
            this.groupBoxAccountType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAccountType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAccountNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrevRead;
        private System.Windows.Forms.TextBox textBoxCurrRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listBoxPaid;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.RadioButton radioButtonHome;
        public System.Windows.Forms.RadioButton radioButtonOrganization;
        private System.Windows.Forms.Button buttonExit;
    }
}

