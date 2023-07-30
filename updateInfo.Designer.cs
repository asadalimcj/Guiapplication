
namespace GuiAplication.bl
{
    partial class updateInfo
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
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.txtAboutUs = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.BackColor = System.Drawing.Color.Transparent;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTrain.Location = new System.Drawing.Point(64, 9);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(807, 63);
            this.lblTrain.TabIndex = 4;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUpdate.Location = new System.Drawing.Point(322, 72);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(248, 39);
            this.lblUpdate.TabIndex = 5;
            this.lblUpdate.Text = "UPDATE INFO";
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.AutoSize = true;
            this.lblAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.Location = new System.Drawing.Point(191, 154);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(87, 17);
            this.lblAboutUs.TabIndex = 6;
            this.lblAboutUs.Text = "ABOUT US";
            // 
            // txtAboutUs
            // 
            this.txtAboutUs.Location = new System.Drawing.Point(392, 153);
            this.txtAboutUs.Multiline = true;
            this.txtAboutUs.Name = "txtAboutUs";
            this.txtAboutUs.Size = new System.Drawing.Size(193, 74);
            this.txtAboutUs.TabIndex = 7;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(191, 256);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(132, 17);
            this.lblContact.TabIndex = 8;
            this.lblContact.Text = "CONTACT US AT";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(392, 256);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(193, 20);
            this.txtContact.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(191, 326);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(392, 323);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(495, 393);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(392, 393);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // updateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.trail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 526);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtAboutUs);
            this.Controls.Add(this.lblAboutUs);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblTrain);
            this.DoubleBuffered = true;
            this.Name = "updateInfo";
            this.Text = "updateInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.TextBox txtAboutUs;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
    }
}