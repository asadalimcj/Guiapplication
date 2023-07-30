
namespace GuiAplication
{
    partial class viewFeedback
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
            this.dtagrdViewFeedback = new System.Windows.Forms.DataGridView();
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblfeedBack = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdViewFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // dtagrdViewFeedback
            // 
            this.dtagrdViewFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtagrdViewFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagrdViewFeedback.Location = new System.Drawing.Point(87, 136);
            this.dtagrdViewFeedback.Name = "dtagrdViewFeedback";
            this.dtagrdViewFeedback.Size = new System.Drawing.Size(766, 321);
            this.dtagrdViewFeedback.TabIndex = 0;
            this.dtagrdViewFeedback.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtagrdViewFeedback_CellContentClick);
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
            this.lblTrain.TabIndex = 3;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblfeedBack
            // 
            this.lblfeedBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblfeedBack.AutoSize = true;
            this.lblfeedBack.BackColor = System.Drawing.Color.Transparent;
            this.lblfeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfeedBack.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblfeedBack.Location = new System.Drawing.Point(361, 70);
            this.lblfeedBack.Name = "lblfeedBack";
            this.lblfeedBack.Size = new System.Drawing.Size(226, 39);
            this.lblfeedBack.TabIndex = 4;
            this.lblfeedBack.Text = "FEEDBACKS";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(621, 489);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // viewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.trail;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 524);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblfeedBack);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.dtagrdViewFeedback);
            this.DoubleBuffered = true;
            this.Name = "viewFeedback";
            this.Text = "viewFeedback";
            ((System.ComponentModel.ISupportInitialize)(this.dtagrdViewFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtagrdViewFeedback;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblfeedBack;
        private System.Windows.Forms.Button btnBack;
    }
}