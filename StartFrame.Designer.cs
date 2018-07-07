using System.Drawing;

namespace se.nightri.QC15_TV_Badge
{
    partial class StartFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartFrame));
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.baseDecLayer = new System.Windows.Forms.Label();
            this.headingCenter = new System.Windows.Forms.Label();
            this.baseEncLayer = new System.Windows.Forms.Label();
            this.serialPortRead = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(12, 12);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(75, 23);
            this.btnFullScreen.TabIndex = 0;
            this.btnFullScreen.Text = "&Start";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRestore.Location = new System.Drawing.Point(93, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "&Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // baseDecLayer
            // 
            this.baseDecLayer.AutoSize = true;
            this.baseDecLayer.BackColor = System.Drawing.Color.Transparent;
            this.baseDecLayer.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseDecLayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.baseDecLayer.Location = new System.Drawing.Point(51, 141);
            this.baseDecLayer.MaximumSize = new System.Drawing.Size(920, 30000);
            this.baseDecLayer.Name = "baseDecLayer";
            this.baseDecLayer.Size = new System.Drawing.Size(218, 18);
            this.baseDecLayer.TabIndex = 3;
            this.baseDecLayer.Text = "baseDecLayer0 0 0 0 0";
            // 
            // headingCenter
            // 
            this.headingCenter.BackColor = System.Drawing.Color.Transparent;
            this.headingCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.headingCenter.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingCenter.ForeColor = System.Drawing.Color.Lime;
            this.headingCenter.Location = new System.Drawing.Point(0, 0);
            this.headingCenter.Name = "headingCenter";
            this.headingCenter.Size = new System.Drawing.Size(1036, 39);
            this.headingCenter.TabIndex = 4;
            this.headingCenter.Text = "QC15 Badge Game";
            this.headingCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // baseEncLayer
            // 
            this.baseEncLayer.AutoSize = true;
            this.baseEncLayer.BackColor = System.Drawing.Color.Transparent;
            this.baseEncLayer.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseEncLayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.baseEncLayer.Location = new System.Drawing.Point(51, 141);
            this.baseEncLayer.MaximumSize = new System.Drawing.Size(920, 30000);
            this.baseEncLayer.Name = "baseEncLayer";
            this.baseEncLayer.Size = new System.Drawing.Size(208, 18);
            this.baseEncLayer.TabIndex = 5;
            this.baseEncLayer.Text = "baseEncLayer X X X X";
            // 
            // StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnRestore;
            this.ClientSize = new System.Drawing.Size(1036, 736);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.baseDecLayer);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.headingCenter);
            this.Controls.Add(this.baseEncLayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartFrame";
            this.Text = "QC TV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label baseDecLayer;
        private System.Windows.Forms.Label headingCenter;
        private System.Windows.Forms.Label baseEncLayer;
        private System.IO.Ports.SerialPort serialPortRead;
    }
}

