
namespace GuiAplication
{
    partial class PayBill
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
            this.lblPaybilll = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
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
            this.lblTrain.Location = new System.Drawing.Point(90, 9);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(807, 63);
            this.lblTrain.TabIndex = 2;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblPaybilll
            // 
            this.lblPaybilll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaybilll.AutoSize = true;
            this.lblPaybilll.BackColor = System.Drawing.Color.Transparent;
            this.lblPaybilll.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaybilll.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPaybilll.Location = new System.Drawing.Point(326, 72);
            this.lblPaybilll.Name = "lblPaybilll";
            this.lblPaybilll.Size = new System.Drawing.Size(424, 63);
            this.lblPaybilll.TabIndex = 3;
            this.lblPaybilll.Text = "PAY BILL HERE";
            // 
            // lblMoney
            // 
            this.lblMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(117, 175);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(256, 17);
            this.lblMoney.TabIndex = 4;
            this.lblMoney.Text = "ENTER THE AMOUNT  YOU HAVE";
            // 
            // txtmoney
            // 
            this.txtmoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmoney.Location = new System.Drawing.Point(479, 174);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(100, 20);
            this.txtmoney.TabIndex = 5;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnconfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.Location = new System.Drawing.Point(504, 263);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 6;
            this.btnconfirm.Text = "PAY";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(307, 263);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.route;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 521);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.txtmoney);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblPaybilll);
            this.Controls.Add(this.lblTrain);
            this.Name = "PayBill";
            this.Text = "PayBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblPaybilll;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnBack;
    }
}