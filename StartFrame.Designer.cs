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
            this.LeaderHeader = new System.Windows.Forms.Label();
            this.critical1 = new System.Windows.Forms.Label();
            this.critical2 = new System.Windows.Forms.Label();
            this.critical3 = new System.Windows.Forms.Label();
            this.critical4 = new System.Windows.Forms.Label();
            this.critical5 = new System.Windows.Forms.Label();
            this.critical6 = new System.Windows.Forms.Label();
            this.critical7 = new System.Windows.Forms.Label();
            this.critical8 = new System.Windows.Forms.Label();
            this.top8 = new System.Windows.Forms.Label();
            this.top7 = new System.Windows.Forms.Label();
            this.top6 = new System.Windows.Forms.Label();
            this.top5 = new System.Windows.Forms.Label();
            this.top4 = new System.Windows.Forms.Label();
            this.top3 = new System.Windows.Forms.Label();
            this.top2 = new System.Windows.Forms.Label();
            this.top1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlIp = new System.Windows.Forms.TextBox();
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
            this.headingCenter.Text = "QUEERCON v.15 NETWORK HEALTH";
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
            // LeaderHeader
            // 
            this.LeaderHeader.AutoSize = true;
            this.LeaderHeader.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderHeader.ForeColor = System.Drawing.Color.Lime;
            this.LeaderHeader.Location = new System.Drawing.Point(1360, 39);
            this.LeaderHeader.Name = "LeaderHeader";
            this.LeaderHeader.Size = new System.Drawing.Size(391, 39);
            this.LeaderHeader.TabIndex = 11;
            this.LeaderHeader.Text = "Critical Entities";
            this.LeaderHeader.Click += new System.EventHandler(this.label3_Click);
            // 
            // critical1
            // 
            this.critical1.AutoSize = true;
            this.critical1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical1.ForeColor = System.Drawing.Color.Lime;
            this.critical1.Location = new System.Drawing.Point(1231, 100);
            this.critical1.Name = "critical1";
            this.critical1.Size = new System.Drawing.Size(369, 39);
            this.critical1.TabIndex = 12;
            this.critical1.Text = "Skippy 113 Links";
            this.critical1.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // critical2
            // 
            this.critical2.AutoSize = true;
            this.critical2.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical2.ForeColor = System.Drawing.Color.Lime;
            this.critical2.Location = new System.Drawing.Point(1231, 139);
            this.critical2.Name = "critical2";
            this.critical2.Size = new System.Drawing.Size(369, 39);
            this.critical2.TabIndex = 13;
            this.critical2.Text = "Skippy 113 Links";
            // 
            // critical3
            // 
            this.critical3.AutoSize = true;
            this.critical3.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical3.ForeColor = System.Drawing.Color.Lime;
            this.critical3.Location = new System.Drawing.Point(1231, 178);
            this.critical3.Name = "critical3";
            this.critical3.Size = new System.Drawing.Size(369, 39);
            this.critical3.TabIndex = 14;
            this.critical3.Text = "Skippy 113 Links";
            // 
            // critical4
            // 
            this.critical4.AutoSize = true;
            this.critical4.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical4.ForeColor = System.Drawing.Color.Lime;
            this.critical4.Location = new System.Drawing.Point(1231, 217);
            this.critical4.Name = "critical4";
            this.critical4.Size = new System.Drawing.Size(369, 39);
            this.critical4.TabIndex = 15;
            this.critical4.Text = "Skippy 113 Links";
            // 
            // critical5
            // 
            this.critical5.AutoSize = true;
            this.critical5.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical5.ForeColor = System.Drawing.Color.Lime;
            this.critical5.Location = new System.Drawing.Point(1231, 256);
            this.critical5.Name = "critical5";
            this.critical5.Size = new System.Drawing.Size(369, 39);
            this.critical5.TabIndex = 16;
            this.critical5.Text = "Skippy 113 Links";
            // 
            // critical6
            // 
            this.critical6.AutoSize = true;
            this.critical6.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical6.ForeColor = System.Drawing.Color.Lime;
            this.critical6.Location = new System.Drawing.Point(1231, 295);
            this.critical6.Name = "critical6";
            this.critical6.Size = new System.Drawing.Size(369, 39);
            this.critical6.TabIndex = 17;
            this.critical6.Text = "Skippy 113 Links";
            // 
            // critical7
            // 
            this.critical7.AutoSize = true;
            this.critical7.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical7.ForeColor = System.Drawing.Color.Lime;
            this.critical7.Location = new System.Drawing.Point(1231, 334);
            this.critical7.Name = "critical7";
            this.critical7.Size = new System.Drawing.Size(369, 39);
            this.critical7.TabIndex = 18;
            this.critical7.Text = "Skippy 113 Links";
            // 
            // critical8
            // 
            this.critical8.AutoSize = true;
            this.critical8.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical8.ForeColor = System.Drawing.Color.Lime;
            this.critical8.Location = new System.Drawing.Point(1231, 373);
            this.critical8.Name = "critical8";
            this.critical8.Size = new System.Drawing.Size(611, 39);
            this.critical8.TabIndex = 24;
            this.critical8.Text = "Horationion [SEC] 127 Links";
            // 
            // top8
            // 
            this.top8.AutoSize = true;
            this.top8.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top8.ForeColor = System.Drawing.Color.Lime;
            this.top8.Location = new System.Drawing.Point(1231, 821);
            this.top8.Name = "top8";
            this.top8.Size = new System.Drawing.Size(611, 39);
            this.top8.TabIndex = 34;
            this.top8.Text = "Horationion [SEC] 127 Links";
            // 
            // top7
            // 
            this.top7.AutoSize = true;
            this.top7.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top7.ForeColor = System.Drawing.Color.Lime;
            this.top7.Location = new System.Drawing.Point(1231, 782);
            this.top7.Name = "top7";
            this.top7.Size = new System.Drawing.Size(369, 39);
            this.top7.TabIndex = 32;
            this.top7.Text = "Skippy 113 Links";
            // 
            // top6
            // 
            this.top6.AutoSize = true;
            this.top6.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top6.ForeColor = System.Drawing.Color.Lime;
            this.top6.Location = new System.Drawing.Point(1231, 743);
            this.top6.Name = "top6";
            this.top6.Size = new System.Drawing.Size(369, 39);
            this.top6.TabIndex = 31;
            this.top6.Text = "Skippy 113 Links";
            // 
            // top5
            // 
            this.top5.AutoSize = true;
            this.top5.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top5.ForeColor = System.Drawing.Color.Lime;
            this.top5.Location = new System.Drawing.Point(1231, 704);
            this.top5.Name = "top5";
            this.top5.Size = new System.Drawing.Size(369, 39);
            this.top5.TabIndex = 30;
            this.top5.Text = "Skippy 113 Links";
            // 
            // top4
            // 
            this.top4.AutoSize = true;
            this.top4.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top4.ForeColor = System.Drawing.Color.Lime;
            this.top4.Location = new System.Drawing.Point(1231, 665);
            this.top4.Name = "top4";
            this.top4.Size = new System.Drawing.Size(369, 39);
            this.top4.TabIndex = 29;
            this.top4.Text = "Skippy 113 Links";
            // 
            // top3
            // 
            this.top3.AutoSize = true;
            this.top3.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top3.ForeColor = System.Drawing.Color.Lime;
            this.top3.Location = new System.Drawing.Point(1231, 626);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(369, 39);
            this.top3.TabIndex = 28;
            this.top3.Text = "Skippy 113 Links";
            // 
            // top2
            // 
            this.top2.AutoSize = true;
            this.top2.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top2.ForeColor = System.Drawing.Color.Lime;
            this.top2.Location = new System.Drawing.Point(1231, 587);
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(369, 39);
            this.top2.TabIndex = 27;
            this.top2.Text = "Skippy 113 Links";
            // 
            // top1
            // 
            this.top1.AutoSize = true;
            this.top1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top1.ForeColor = System.Drawing.Color.Lime;
            this.top1.Location = new System.Drawing.Point(1231, 548);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(369, 39);
            this.top1.TabIndex = 26;
            this.top1.Text = "Skippy 113 Links";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Lime;
            this.label21.Location = new System.Drawing.Point(1432, 488);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(237, 39);
            this.label21.TabIndex = 25;
            this.label21.Text = "Top Recent";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(1327, 924);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(548, 90);
            this.label3.TabIndex = 35;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // sqlIp
            // 
            this.sqlIp.Location = new System.Drawing.Point(1352, 12);
            this.sqlIp.Name = "sqlIp";
            this.sqlIp.Size = new System.Drawing.Size(76, 20);
            this.sqlIp.TabIndex = 36;
            this.sqlIp.Text = "127.0.0.1";
            // 
            // StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnRestore;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.sqlIp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.top8);
            this.Controls.Add(this.top7);
            this.Controls.Add(this.top6);
            this.Controls.Add(this.top5);
            this.Controls.Add(this.top4);
            this.Controls.Add(this.top3);
            this.Controls.Add(this.top2);
            this.Controls.Add(this.top1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.critical8);
            this.Controls.Add(this.critical7);
            this.Controls.Add(this.critical6);
            this.Controls.Add(this.critical5);
            this.Controls.Add(this.critical4);
            this.Controls.Add(this.critical3);
            this.Controls.Add(this.critical2);
            this.Controls.Add(this.critical1);
            this.Controls.Add(this.LeaderHeader);
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
        private System.Windows.Forms.Label LeaderHeader;
        private System.Windows.Forms.Label critical1;
        private System.Windows.Forms.Label critical2;
        private System.Windows.Forms.Label critical3;
        private System.Windows.Forms.Label critical4;
        private System.Windows.Forms.Label critical5;
        private System.Windows.Forms.Label critical6;
        private System.Windows.Forms.Label critical7;
        private System.Windows.Forms.Label critical8;
        private System.Windows.Forms.Label top8;
        private System.Windows.Forms.Label top7;
        private System.Windows.Forms.Label top6;
        private System.Windows.Forms.Label top5;
        private System.Windows.Forms.Label top4;
        private System.Windows.Forms.Label top3;
        private System.Windows.Forms.Label top2;
        private System.Windows.Forms.Label top1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sqlIp;
    }
}

