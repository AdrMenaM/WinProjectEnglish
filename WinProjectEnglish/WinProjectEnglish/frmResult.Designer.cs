namespace WinProjectEnglish
{
    partial class frmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.btnExit = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.picMid1 = new System.Windows.Forms.PictureBox();
            this.picRetry1 = new System.Windows.Forms.PictureBox();
            this.picCongrats2 = new System.Windows.Forms.PictureBox();
            this.picCongrats1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTryAgain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCongrats2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCongrats1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(544, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 45);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(459, 21);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(51, 59);
            this.txtResult.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 51);
            this.label6.TabIndex = 32;
            this.label6.Text = "Your result is:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(545, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 49);
            this.lblTotal.TabIndex = 35;
            // 
            // picMid1
            // 
            this.picMid1.Image = global::WinProjectEnglish.Properties.Resources.gifTryAgain;
            this.picMid1.Location = new System.Drawing.Point(16, 90);
            this.picMid1.Name = "picMid1";
            this.picMid1.Size = new System.Drawing.Size(494, 366);
            this.picMid1.TabIndex = 39;
            this.picMid1.TabStop = false;
            this.picMid1.Visible = false;
            // 
            // picRetry1
            // 
            this.picRetry1.Image = global::WinProjectEnglish.Properties.Resources.gifMidFace;
            this.picRetry1.Location = new System.Drawing.Point(94, 113);
            this.picRetry1.Name = "picRetry1";
            this.picRetry1.Size = new System.Drawing.Size(320, 308);
            this.picRetry1.TabIndex = 38;
            this.picRetry1.TabStop = false;
            this.picRetry1.Visible = false;
            // 
            // picCongrats2
            // 
            this.picCongrats2.Image = global::WinProjectEnglish.Properties.Resources.gifGuitar;
            this.picCongrats2.Location = new System.Drawing.Point(261, 213);
            this.picCongrats2.Name = "picCongrats2";
            this.picCongrats2.Size = new System.Drawing.Size(209, 177);
            this.picCongrats2.TabIndex = 37;
            this.picCongrats2.TabStop = false;
            this.picCongrats2.Visible = false;
            // 
            // picCongrats1
            // 
            this.picCongrats1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCongrats1.Image = global::WinProjectEnglish.Properties.Resources.baloon;
            this.picCongrats1.Location = new System.Drawing.Point(35, 98);
            this.picCongrats1.Name = "picCongrats1";
            this.picCongrats1.Size = new System.Drawing.Size(220, 351);
            this.picCongrats1.TabIndex = 36;
            this.picCongrats1.TabStop = false;
            this.picCongrats1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 52);
            this.label1.TabIndex = 40;
            this.label1.Text = "/";
            // 
            // lblTryAgain
            // 
            this.lblTryAgain.AutoSize = true;
            this.lblTryAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblTryAgain.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTryAgain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTryAgain.Location = new System.Drawing.Point(526, 191);
            this.lblTryAgain.Name = "lblTryAgain";
            this.lblTryAgain.Size = new System.Drawing.Size(189, 52);
            this.lblTryAgain.TabIndex = 41;
            this.lblTryAgain.Text = "Try Again";
            this.lblTryAgain.Visible = false;
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(742, 461);
            this.Controls.Add(this.lblTryAgain);
            this.Controls.Add(this.picCongrats2);
            this.Controls.Add(this.picCongrats1);
            this.Controls.Add(this.picRetry1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picMid1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.frmResult_Act4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCongrats2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCongrats1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox picCongrats1;
        private System.Windows.Forms.PictureBox picCongrats2;
        private System.Windows.Forms.PictureBox picRetry1;
        private System.Windows.Forms.PictureBox picMid1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTryAgain;
    }
}