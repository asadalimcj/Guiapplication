
namespace GuiAplication
{
    partial class GiveFeedback
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblFeedBack = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
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
            this.lblTrain.Location = new System.Drawing.Point(-2, -2);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(807, 63);
            this.lblTrain.TabIndex = 2;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUser.Location = new System.Drawing.Point(145, 61);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(506, 39);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "GIVE YOUR FEEDBACK HERE";
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(179, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "ENTER YOUR NAME";
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeedBack.AutoSize = true;
            this.lblFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedBack.Location = new System.Drawing.Point(179, 168);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(189, 17);
            this.lblFeedBack.TabIndex = 5;
            this.lblFeedBack.Text = "WRITE FEEDBACK HERE";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(414, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtFeedback
            // 
            this.txtFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFeedback.Location = new System.Drawing.Point(414, 168);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(180, 117);
            this.txtFeedback.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(518, 337);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(354, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GiveFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.route;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblFeedBack);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblTrain);
            this.Name = "GiveFeedback";
            this.Text = "GiveFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFeedBack;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
    }
}