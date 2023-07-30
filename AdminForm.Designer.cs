
namespace GuiAplication
{
    partial class AdminForm
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
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnFare = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnStation = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnSeatrecord = new System.Windows.Forms.Button();
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
            this.lblTrain.Location = new System.Drawing.Point(-4, 5);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(807, 63);
            this.lblTrain.TabIndex = 0;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAdmin.Location = new System.Drawing.Point(150, 68);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(521, 39);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "WELLCOME TO ADMIN MENUE";
            // 
            // btnFare
            // 
            this.btnFare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFare.BackColor = System.Drawing.Color.Transparent;
            this.btnFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFare.Location = new System.Drawing.Point(290, 110);
            this.btnFare.Name = "btnFare";
            this.btnFare.Size = new System.Drawing.Size(247, 29);
            this.btnFare.TabIndex = 2;
            this.btnFare.Text = "UPDATE FARE";
            this.btnFare.UseVisualStyleBackColor = false;
            this.btnFare.Click += new System.EventHandler(this.btnFare_Click);
            // 
            // btnBills
            // 
            this.btnBills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBills.BackColor = System.Drawing.Color.Transparent;
            this.btnBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBills.Location = new System.Drawing.Point(290, 145);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(247, 29);
            this.btnBills.TabIndex = 3;
            this.btnBills.Text = "BILL AND DISCOUNT";
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAboutUs.Location = new System.Drawing.Point(290, 180);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(247, 29);
            this.btnAboutUs.TabIndex = 4;
            this.btnAboutUs.Text = "ABOUT US";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnStation
            // 
            this.btnStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStation.BackColor = System.Drawing.Color.Transparent;
            this.btnStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStation.Location = new System.Drawing.Point(290, 215);
            this.btnStation.Name = "btnStation";
            this.btnStation.Size = new System.Drawing.Size(247, 29);
            this.btnStation.TabIndex = 5;
            this.btnStation.Text = "ADD STATION";
            this.btnStation.UseVisualStyleBackColor = false;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFeedback.Location = new System.Drawing.Point(290, 250);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(247, 29);
            this.btnFeedback.TabIndex = 6;
            this.btnFeedback.Text = "VIEW FEEDBACK";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnSeatrecord
            // 
            this.btnSeatrecord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeatrecord.BackColor = System.Drawing.Color.Transparent;
            this.btnSeatrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeatrecord.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeatrecord.Location = new System.Drawing.Point(290, 285);
            this.btnSeatrecord.Name = "btnSeatrecord";
            this.btnSeatrecord.Size = new System.Drawing.Size(247, 29);
            this.btnSeatrecord.TabIndex = 7;
            this.btnSeatrecord.Text = "SEAT RECORD";
            this.btnSeatrecord.UseVisualStyleBackColor = false;
            this.btnSeatrecord.Click += new System.EventHandler(this.btnSeatrecord_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(222, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 29);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.trail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSeatrecord);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnStation);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnBills);
            this.Controls.Add(this.btnFare);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblTrain);
            this.DoubleBuffered = true;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnFare;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnStation;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnSeatrecord;
        private System.Windows.Forms.Button btnBack;
    }
}