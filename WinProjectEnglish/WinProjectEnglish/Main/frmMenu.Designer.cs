namespace WinProjectEnglish
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSports = new System.Windows.Forms.Button();
            this.btnOccupations = new System.Windows.Forms.Button();
            this.btnTransportation = new System.Windows.Forms.Button();
            this.btnDailyActivities = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(824, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 61);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(99, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(79, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(6, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 35);
            this.button6.TabIndex = 0;
            this.button6.Text = "Help";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnSports
            // 
            this.btnSports.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSports.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSports.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSports.Location = new System.Drawing.Point(814, 462);
            this.btnSports.Name = "btnSports";
            this.btnSports.Size = new System.Drawing.Size(175, 113);
            this.btnSports.TabIndex = 9;
            this.btnSports.Text = "Sports";
            this.btnSports.UseVisualStyleBackColor = true;
            this.btnSports.Click += new System.EventHandler(this.btnSports_Click);
            // 
            // btnOccupations
            // 
            this.btnOccupations.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnOccupations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOccupations.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccupations.Location = new System.Drawing.Point(550, 464);
            this.btnOccupations.Name = "btnOccupations";
            this.btnOccupations.Size = new System.Drawing.Size(203, 110);
            this.btnOccupations.TabIndex = 8;
            this.btnOccupations.Text = "Occupations";
            this.btnOccupations.UseVisualStyleBackColor = true;
            this.btnOccupations.Click += new System.EventHandler(this.btnOccupations_Click);
            // 
            // btnTransportation
            // 
            this.btnTransportation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTransportation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTransportation.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransportation.Location = new System.Drawing.Point(268, 463);
            this.btnTransportation.Name = "btnTransportation";
            this.btnTransportation.Size = new System.Drawing.Size(217, 110);
            this.btnTransportation.TabIndex = 7;
            this.btnTransportation.Text = "Modes of Transportation";
            this.btnTransportation.UseVisualStyleBackColor = true;
            this.btnTransportation.Click += new System.EventHandler(this.btnTransportation_Click_1);
            // 
            // btnDailyActivities
            // 
            this.btnDailyActivities.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDailyActivities.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDailyActivities.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyActivities.Location = new System.Drawing.Point(28, 461);
            this.btnDailyActivities.Name = "btnDailyActivities";
            this.btnDailyActivities.Size = new System.Drawing.Size(175, 113);
            this.btnDailyActivities.TabIndex = 6;
            this.btnDailyActivities.Text = "Daily Activities";
            this.btnDailyActivities.UseVisualStyleBackColor = true;
            this.btnDailyActivities.Click += new System.EventHandler(this.btnDailyActivities_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinProjectEnglish.Properties.Resources.FondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSports);
            this.Controls.Add(this.btnOccupations);
            this.Controls.Add(this.btnTransportation);
            this.Controls.Add(this.btnDailyActivities);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "I Love English";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSports;
        private System.Windows.Forms.Button btnOccupations;
        private System.Windows.Forms.Button btnTransportation;
        private System.Windows.Forms.Button btnDailyActivities;
    }
}

