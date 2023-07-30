
namespace GuiAplication
{
    partial class CheckFare
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
            this.dtagrdViewFare = new System.Windows.Forms.DataGridView();
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblCheckFare = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdViewFare)).BeginInit();
            this.SuspendLayout();
            // 
            // dtagrdViewFare
            // 
            this.dtagrdViewFare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtagrdViewFare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagrdViewFare.Location = new System.Drawing.Point(244, 130);
            this.dtagrdViewFare.Name = "dtagrdViewFare";
            this.dtagrdViewFare.Size = new System.Drawing.Size(423, 283);
            this.dtagrdViewFare.TabIndex = 0;
            this.dtagrdViewFare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridFare_CellContentClick);
            // 
            // lblTrain
            // 
            this.lblTrain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrain.AutoSize = true;
            this.lblTrain.BackColor = System.Drawing.Color.Transparent;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTrain.Location = new System.Drawing.Point(43, -2);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(807, 63);
            this.lblTrain.TabIndex = 2;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblCheckFare
            // 
            this.lblCheckFare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCheckFare.AutoSize = true;
            this.lblCheckFare.BackColor = System.Drawing.Color.Transparent;
            this.lblCheckFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckFare.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCheckFare.Location = new System.Drawing.Point(339, 88);
            this.lblCheckFare.Name = "lblCheckFare";
            this.lblCheckFare.Size = new System.Drawing.Size(239, 39);
            this.lblCheckFare.TabIndex = 3;
            this.lblCheckFare.Text = "CHECK FARE";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(592, 452);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CheckFare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.trail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(897, 504);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCheckFare);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.dtagrdViewFare);
            this.DoubleBuffered = true;
            this.Name = "CheckFare";
            this.Text = "CheckFare";
            this.Load += new System.EventHandler(this.CheckFare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdViewFare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtagrdViewFare;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblCheckFare;
        private System.Windows.Forms.Button btnBack;
    }
}