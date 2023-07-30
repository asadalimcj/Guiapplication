
namespace GuiAplication
{
    partial class SignIn
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnSIgnIn = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.BackColor = System.Drawing.Color.Transparent;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.ForeColor = System.Drawing.Color.Thistle;
            this.lblTrain.Location = new System.Drawing.Point(224, 28);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(364, 39);
            this.lblTrain.TabIndex = 0;
            this.lblTrain.Text = "ORANGE LINE TRAIN";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(231, 154);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(231, 209);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(173, 20);
            this.txtPass.TabIndex = 2;
            // 
            // lblSignIn
            // 
            this.lblSignIn.AutoSize = true;
            this.lblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignIn.ForeColor = System.Drawing.Color.Thistle;
            this.lblSignIn.Location = new System.Drawing.Point(349, 83);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(131, 39);
            this.lblSignIn.TabIndex = 3;
            this.lblSignIn.Text = "Sign In";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(132, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(132, 212);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(69, 17);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // btnSIgnIn
            // 
            this.btnSIgnIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSIgnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSIgnIn.ForeColor = System.Drawing.Color.Thistle;
            this.btnSIgnIn.Location = new System.Drawing.Point(401, 279);
            this.btnSIgnIn.Name = "btnSIgnIn";
            this.btnSIgnIn.Size = new System.Drawing.Size(107, 45);
            this.btnSIgnIn.TabIndex = 6;
            this.btnSIgnIn.Text = "Log In";
            this.btnSIgnIn.UseVisualStyleBackColor = false;
            this.btnSIgnIn.Click += new System.EventHandler(this.btnSIgnIn_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(244, 279);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 45);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSIgnIn);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSignIn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTrain);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnSIgnIn;
        private System.Windows.Forms.Button btnBack;
    }
}