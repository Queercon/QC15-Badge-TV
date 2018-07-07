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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartFrame));
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.displayFile = new System.Windows.Forms.Label();
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
            // displayFile
            // 
            this.displayFile.AutoSize = true;
            this.displayFile.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.displayFile.Location = new System.Drawing.Point(51, 100);
            this.displayFile.MaximumSize = new System.Drawing.Size(920, 30000);
            this.displayFile.Name = "displayFile";
            this.displayFile.Size = new System.Drawing.Size(918, 576);
            this.displayFile.TabIndex = 3;
            this.displayFile.Text = resources.GetString("displayFile.Text");
            // 
            // StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnRestore;
            this.ClientSize = new System.Drawing.Size(1036, 736);
            this.Controls.Add(this.displayFile);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnFullScreen);
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
        private System.Windows.Forms.Label displayFile;
    }
}

