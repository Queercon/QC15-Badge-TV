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
            this.headingCenter = new System.Windows.Forms.Label();
            this.btnWindow = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.demoSelect = new System.Windows.Forms.ComboBox();
            this.decryptValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(93, 12);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(75, 23);
            this.btnFullScreen.TabIndex = 0;
            this.btnFullScreen.Text = "&Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRestore.Location = new System.Drawing.Point(12, 12);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 23);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "&Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // headingCenter
            // 
            this.headingCenter.BackColor = System.Drawing.Color.Transparent;
            this.headingCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.headingCenter.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingCenter.ForeColor = System.Drawing.Color.Lime;
            this.headingCenter.Location = new System.Drawing.Point(0, 0);
            this.headingCenter.Name = "headingCenter";
            this.headingCenter.Size = new System.Drawing.Size(1904, 39);
            this.headingCenter.TabIndex = 4;
            this.headingCenter.Text = "QC15 Badge Game";
            this.headingCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWindow
            // 
            this.btnWindow.Location = new System.Drawing.Point(174, 12);
            this.btnWindow.Name = "btnWindow";
            this.btnWindow.Size = new System.Drawing.Size(75, 23);
            this.btnWindow.TabIndex = 5;
            this.btnWindow.Text = "&Windowed";
            this.btnWindow.UseVisualStyleBackColor = true;
            this.btnWindow.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnSql
            // 
            this.btnSql.Location = new System.Drawing.Point(299, 12);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(75, 23);
            this.btnSql.TabIndex = 6;
            this.btnSql.Text = "Test SQL";
            this.btnSql.UseVisualStyleBackColor = true;
            this.btnSql.Click += new System.EventHandler(this.sql_Click);
            // 
            // demoSelect
            // 
            this.demoSelect.FormattingEnabled = true;
            this.demoSelect.Items.AddRange(new object[] {
            "Demo Off",
            "Demo On"});
            this.demoSelect.Location = new System.Drawing.Point(442, 12);
            this.demoSelect.Name = "demoSelect";
            this.demoSelect.Size = new System.Drawing.Size(121, 21);
            this.demoSelect.TabIndex = 7;
            this.demoSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // decryptValue
            // 
            this.decryptValue.AutoSize = true;
            this.decryptValue.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptValue.ForeColor = System.Drawing.Color.Lime;
            this.decryptValue.Location = new System.Drawing.Point(414, 39);
            this.decryptValue.Name = "decryptValue";
            this.decryptValue.Size = new System.Drawing.Size(193, 39);
            this.decryptValue.TabIndex = 8;
            this.decryptValue.Text = "000.0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(86, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "File Decrypted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(594, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "%";
            // 
            // StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnRestore;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decryptValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.demoSelect);
            this.Controls.Add(this.btnSql);
            this.Controls.Add(this.btnWindow);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.headingCenter);
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
        private System.Windows.Forms.Label headingCenter;
        private System.Windows.Forms.Button btnWindow;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.ComboBox demoSelect;
        private System.Windows.Forms.Label decryptValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

