
namespace GuiAplication.bl
{
    partial class UpdateCompanyInfo
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
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblCompanyInfo = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.txtAboutUs = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblChoice = new System.Windows.Forms.Label();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrain
            // 
            this.lblTrain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrain.AutoSize = true;
            this.lblTrain.BackColor = System.Drawing.Color.Transparent;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTrain.Location = new System.Drawing.Point(-1, 9);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(807, 63);
            this.lblTrain.TabIndex = 3;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblCompanyInfo
            // 
            this.lblCompanyInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCompanyInfo.AutoSize = true;
            this.lblCompanyInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCompanyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCompanyInfo.Location = new System.Drawing.Point(269, 72);
            this.lblCompanyInfo.Name = "lblCompanyInfo";
            this.lblCompanyInfo.Size = new System.Drawing.Size(280, 39);
            this.lblCompanyInfo.TabIndex = 4;
            this.lblCompanyInfo.Text = "COMPNAY INFO";
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.Location = new System.Drawing.Point(162, 117);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(87, 17);
            this.lblAboutUs.TabIndex = 5;
            this.lblAboutUs.Text = "ABOUT US";
            this.lblAboutUs.Click += new System.EventHandler(this.lblAboutUs_Click);
            // 
            // txtAboutUs
            // 
            this.txtAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAboutUs.Location = new System.Drawing.Point(356, 117);
            this.txtAboutUs.Multiline = true;
            this.txtAboutUs.Name = "txtAboutUs";
            this.txtAboutUs.Size = new System.Drawing.Size(193, 74);
            this.txtAboutUs.TabIndex = 6;
            this.txtAboutUs.TextChanged += new System.EventHandler(this.txtAboutUs_TextChanged);
            // 
            // lblContact
            // 
            this.lblContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(162, 214);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(132, 17);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "CONTACT US AT";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // txtContact
            // 
            this.txtContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContact.Location = new System.Drawing.Point(356, 214);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(193, 20);
            this.txtContact.TabIndex = 8;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(162, 258);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 17);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "EMAIL:";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(356, 258);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblChoice
            // 
            this.lblChoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChoice.AutoSize = true;
            this.lblChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice.Location = new System.Drawing.Point(162, 323);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(213, 17);
            this.lblChoice.TabIndex = 11;
            this.lblChoice.Text = "DO YOU WANT TO UPDATE";
            // 
            // radioYes
            // 
            this.radioYes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioYes.AutoSize = true;
            this.radioYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYes.Location = new System.Drawing.Point(463, 323);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(56, 21);
            this.radioYes.TabIndex = 12;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "YES";
            this.radioYes.UseVisualStyleBackColor = true;
            this.radioYes.CheckedChanged += new System.EventHandler(this.radioYes_CheckedChanged);
            // 
            // radioNo
            // 
            this.radioNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioNo.AutoSize = true;
            this.radioNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNo.Location = new System.Drawing.Point(544, 323);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(49, 21);
            this.radioNo.TabIndex = 13;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "NO";
            this.radioNo.UseVisualStyleBackColor = true;
            this.radioNo.CheckedChanged += new System.EventHandler(this.radioNo_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(492, 376);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UpdateCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.trail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.radioNo);
            this.Controls.Add(this.radioYes);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtAboutUs);
            this.Controls.Add(this.lblAboutUs);
            this.Controls.Add(this.lblCompanyInfo);
            this.Controls.Add(this.lblTrain);
            this.DoubleBuffered = true;
            this.Name = "UpdateCompanyInfo";
            this.Text = "CompanyInfo";
            this.Load += new System.EventHandler(this.UpdateCompanyInfo_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblCompanyInfo;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.TextBox txtAboutUs;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Button btnBack;
    }
}