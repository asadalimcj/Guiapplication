
namespace GuiAplication
{
    partial class AddStation
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
            this.lblFare = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFare = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblAddStation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFare
            // 
            this.lblFare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFare.AutoSize = true;
            this.lblFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFare.Location = new System.Drawing.Point(237, 187);
            this.lblFare.Name = "lblFare";
            this.lblFare.Size = new System.Drawing.Size(71, 17);
            this.lblFare.TabIndex = 4;
            this.lblFare.Text = "Enter fare";
            this.lblFare.Click += new System.EventHandler(this.lblFare_Click);
            // 
            // lblStation
            // 
            this.lblStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(179, 124);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(129, 17);
            this.lblStation.TabIndex = 3;
            this.lblStation.Text = "Enter station Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(442, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtFare
            // 
            this.txtFare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFare.Location = new System.Drawing.Point(417, 187);
            this.txtFare.Name = "txtFare";
            this.txtFare.Size = new System.Drawing.Size(100, 20);
            this.txtFare.TabIndex = 7;
            // 
            // txtStation
            // 
            this.txtStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStation.Location = new System.Drawing.Point(417, 121);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(100, 20);
            this.txtStation.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(241, 273);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTrain
            // 
            this.lblTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTrain.AutoSize = true;
            this.lblTrain.BackColor = System.Drawing.Color.Transparent;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTrain.Location = new System.Drawing.Point(-6, 9);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(807, 63);
            this.lblTrain.TabIndex = 13;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblAddStation
            // 
            this.lblAddStation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddStation.AutoSize = true;
            this.lblAddStation.BackColor = System.Drawing.Color.Transparent;
            this.lblAddStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStation.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAddStation.Location = new System.Drawing.Point(234, 63);
            this.lblAddStation.Name = "lblAddStation";
            this.lblAddStation.Size = new System.Drawing.Size(431, 39);
            this.lblAddStation.TabIndex = 14;
            this.lblAddStation.Text = "ADD STATION AND FARE";
            // 
            // AddStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.route;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAddStation);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFare);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.lblFare);
            this.Controls.Add(this.lblStation);
            this.Name = "AddStation";
            this.Text = "AddStation";
            this.Load += new System.EventHandler(this.AddStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFare;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFare;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblAddStation;
    }
}