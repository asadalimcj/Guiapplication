
namespace GuiAplication
{
    partial class UserForm
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
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSuggestion = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
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
            this.lblTrain.Location = new System.Drawing.Point(-2, 0);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(807, 63);
            this.lblTrain.TabIndex = 1;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUser.Location = new System.Drawing.Point(128, 63);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(506, 39);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "WELLCOME TO USER MENUE";
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheck.Location = new System.Drawing.Point(268, 105);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(247, 29);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "CHECK FARE";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSuggestion
            // 
            this.btnSuggestion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuggestion.BackColor = System.Drawing.Color.Transparent;
            this.btnSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuggestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSuggestion.Location = new System.Drawing.Point(268, 140);
            this.btnSuggestion.Name = "btnSuggestion";
            this.btnSuggestion.Size = new System.Drawing.Size(247, 29);
            this.btnSuggestion.TabIndex = 4;
            this.btnSuggestion.Text = "GAVE FEEDBACK";
            this.btnSuggestion.UseVisualStyleBackColor = false;
            this.btnSuggestion.Click += new System.EventHandler(this.btnSuggestion_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInfo.Location = new System.Drawing.Point(268, 175);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(247, 29);
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "VIEW COMPANY INFO";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBooking.BackColor = System.Drawing.Color.Transparent;
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBooking.Location = new System.Drawing.Point(268, 210);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(247, 29);
            this.btnBooking.TabIndex = 6;
            this.btnBooking.Text = "BOOK SEAT";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPay.BackColor = System.Drawing.Color.Transparent;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPay.Location = new System.Drawing.Point(268, 245);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(247, 29);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "PAY BILL";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(187, 297);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 29);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.trail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 505);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSuggestion);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTrain);
            this.DoubleBuffered = true;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSuggestion;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBack;
    }
}