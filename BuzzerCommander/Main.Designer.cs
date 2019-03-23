namespace BuzzerCommander
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.imgLeft = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.imgRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRight)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLeft
            // 
            this.imgLeft.BackgroundImage = global::BuzzerCommander.Properties.Resources.off;
            this.imgLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLeft.Location = new System.Drawing.Point(3, 3);
            this.imgLeft.Name = "imgLeft";
            this.imgLeft.Size = new System.Drawing.Size(494, 659);
            this.imgLeft.TabIndex = 0;
            this.imgLeft.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 2;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.Controls.Add(this.imgRight, 1, 0);
            this.pnlMain.Controls.Add(this.imgLeft, 0, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 1;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(1000, 665);
            this.pnlMain.TabIndex = 0;
            // 
            // imgRight
            // 
            this.imgRight.BackgroundImage = global::BuzzerCommander.Properties.Resources.off;
            this.imgRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgRight.Location = new System.Drawing.Point(503, 3);
            this.imgRight.Name = "imgRight";
            this.imgRight.Size = new System.Drawing.Size(494, 659);
            this.imgRight.TabIndex = 1;
            this.imgRight.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 665);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Buzzer Commander";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLeft)).EndInit();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLeft;
        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.PictureBox imgRight;
    }
}

