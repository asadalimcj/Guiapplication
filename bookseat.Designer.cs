
namespace GuiAplication
{
    partial class bookseat
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
            this.lblBooking = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.lblSeat = new System.Windows.Forms.Label();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.btnBooking = new System.Windows.Forms.Button();
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
            this.lblTrain.Location = new System.Drawing.Point(62, 9);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(807, 63);
            this.lblTrain.TabIndex = 1;
            this.lblTrain.Text = "ORANGE LINE TRAIN LAHORE";
            // 
            // lblBooking
            // 
            this.lblBooking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBooking.AutoSize = true;
            this.lblBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooking.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBooking.Location = new System.Drawing.Point(395, 72);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(214, 39);
            this.lblBooking.TabIndex = 2;
            this.lblBooking.Text = "BOOK SEAT";
            // 
            // lblStation
            // 
            this.lblStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(215, 144);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(181, 17);
            this.lblStation.TabIndex = 3;
            this.lblStation.Text = "ENTER YOUR STATION";
            // 
            // txtStation
            // 
            this.txtStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStation.Location = new System.Drawing.Point(402, 141);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(170, 20);
            this.txtStation.TabIndex = 4;
            // 
            // lblDay
            // 
            this.lblDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(215, 195);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(96, 17);
            this.lblDay.TabIndex = 5;
            this.lblDay.Text = "ENTER DAY";
            // 
            // txtDay
            // 
            this.txtDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDay.Location = new System.Drawing.Point(402, 192);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(170, 20);
            this.txtDay.TabIndex = 6;
            // 
            // lblSeat
            // 
            this.lblSeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeat.AutoSize = true;
            this.lblSeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeat.Location = new System.Drawing.Point(215, 247);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(143, 17);
            this.lblSeat.TabIndex = 7;
            this.lblSeat.Text = "ENTER NO SEATS";
            // 
            // txtSeat
            // 
            this.txtSeat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeat.Location = new System.Drawing.Point(402, 244);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(170, 20);
            this.txtSeat.TabIndex = 8;
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(494, 325);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(172, 23);
            this.btnBooking.TabIndex = 9;
            this.btnBooking.Text = "CONFIRM BOOKING";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(283, 325);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookseat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiAplication.Properties.Resources.route;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 505);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.lblSeat);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblBooking);
            this.Controls.Add(this.lblTrain);
            this.Name = "bookseat";
            this.Text = "bookseat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblBooking;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.TextBox txtSeat;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnBack;
    }
}