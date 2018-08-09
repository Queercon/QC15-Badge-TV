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
            this.critical0 = new System.Windows.Forms.Label();
            this.timeRefresh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(186, 23);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(150, 44);
            this.btnFullScreen.TabIndex = 0;
            this.btnFullScreen.Text = "&Full Screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            this.btnFullScreen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRestore.Location = new System.Drawing.Point(24, 23);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(0);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(150, 44);
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
            this.headingCenter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headingCenter.Name = "headingCenter";
            this.headingCenter.Size = new System.Drawing.Size(3808, 75);
            this.headingCenter.TabIndex = 4;
            this.headingCenter.Text = "QUEERCON v.15 NETWORK HEALTH";
            this.headingCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWindow
            // 
            this.btnWindow.Location = new System.Drawing.Point(348, 23);
            this.btnWindow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnWindow.Name = "btnWindow";
            this.btnWindow.Size = new System.Drawing.Size(150, 44);
            this.btnWindow.TabIndex = 5;
            this.btnWindow.Text = "&Windowed";
            this.btnWindow.UseVisualStyleBackColor = true;
            this.btnWindow.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnSql
            // 
            this.btnSql.Location = new System.Drawing.Point(598, 23);
            this.btnSql.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(150, 44);
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
            this.demoSelect.Location = new System.Drawing.Point(884, 23);
            this.demoSelect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.demoSelect.Name = "demoSelect";
            this.demoSelect.Size = new System.Drawing.Size(238, 33);
            this.demoSelect.TabIndex = 7;
            this.demoSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // decryptValue
            // 
            this.decryptValue.AutoSize = true;
            this.decryptValue.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptValue.ForeColor = System.Drawing.Color.Lime;
            this.decryptValue.Location = new System.Drawing.Point(1014, 75);
            this.decryptValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.decryptValue.Name = "decryptValue";
            this.decryptValue.Size = new System.Drawing.Size(386, 79);
            this.decryptValue.TabIndex = 8;
            this.decryptValue.Text = "000.0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(172, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(870, 79);
            this.label1.TabIndex = 9;
            this.label1.Text = "Decrypted In Range:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1378, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 79);
            this.label2.TabIndex = 10;
            this.label2.Text = "%";
            // 
            // LeaderHeader
            // 
            this.LeaderHeader.AutoSize = true;
            this.LeaderHeader.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderHeader.ForeColor = System.Drawing.Color.Lime;
            this.LeaderHeader.Location = new System.Drawing.Point(2720, 75);
            this.LeaderHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LeaderHeader.Name = "LeaderHeader";
            this.LeaderHeader.Size = new System.Drawing.Size(782, 79);
            this.LeaderHeader.TabIndex = 11;
            this.LeaderHeader.Text = "Critical Entities";
            this.LeaderHeader.Click += new System.EventHandler(this.label3_Click);
            // 
            // critical1
            // 
            this.critical1.AutoSize = true;
            this.critical1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical1.ForeColor = System.Drawing.Color.Lime;
            this.critical1.Location = new System.Drawing.Point(2378, 285);
            this.critical1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical1.Name = "critical1";
            this.critical1.Size = new System.Drawing.Size(738, 79);
            this.critical1.TabIndex = 12;
            this.critical1.Text = "Skippy 113 Links";
            this.critical1.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // critical2
            // 
            this.critical2.AutoSize = true;
            this.critical2.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical2.ForeColor = System.Drawing.Color.Lime;
            this.critical2.Location = new System.Drawing.Point(2378, 360);
            this.critical2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical2.Name = "critical2";
            this.critical2.Size = new System.Drawing.Size(738, 79);
            this.critical2.TabIndex = 13;
            this.critical2.Text = "Skippy 113 Links";
            // 
            // critical3
            // 
            this.critical3.AutoSize = true;
            this.critical3.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical3.ForeColor = System.Drawing.Color.Lime;
            this.critical3.Location = new System.Drawing.Point(2378, 435);
            this.critical3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical3.Name = "critical3";
            this.critical3.Size = new System.Drawing.Size(738, 79);
            this.critical3.TabIndex = 14;
            this.critical3.Text = "Skippy 113 Links";
            // 
            // critical4
            // 
            this.critical4.AutoSize = true;
            this.critical4.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical4.ForeColor = System.Drawing.Color.Lime;
            this.critical4.Location = new System.Drawing.Point(2378, 510);
            this.critical4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical4.Name = "critical4";
            this.critical4.Size = new System.Drawing.Size(738, 79);
            this.critical4.TabIndex = 15;
            this.critical4.Text = "Skippy 113 Links";
            // 
            // critical5
            // 
            this.critical5.AutoSize = true;
            this.critical5.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical5.ForeColor = System.Drawing.Color.Lime;
            this.critical5.Location = new System.Drawing.Point(2378, 585);
            this.critical5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical5.Name = "critical5";
            this.critical5.Size = new System.Drawing.Size(738, 79);
            this.critical5.TabIndex = 16;
            this.critical5.Text = "Skippy 113 Links";
            // 
            // critical6
            // 
            this.critical6.AutoSize = true;
            this.critical6.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical6.ForeColor = System.Drawing.Color.Lime;
            this.critical6.Location = new System.Drawing.Point(2378, 660);
            this.critical6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical6.Name = "critical6";
            this.critical6.Size = new System.Drawing.Size(738, 79);
            this.critical6.TabIndex = 17;
            this.critical6.Text = "Skippy 113 Links";
            // 
            // critical7
            // 
            this.critical7.AutoSize = true;
            this.critical7.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical7.ForeColor = System.Drawing.Color.Lime;
            this.critical7.Location = new System.Drawing.Point(2378, 735);
            this.critical7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical7.Name = "critical7";
            this.critical7.Size = new System.Drawing.Size(738, 79);
            this.critical7.TabIndex = 18;
            this.critical7.Text = "Skippy 113 Links";
            // 
            // critical8
            // 
            this.critical8.AutoSize = true;
            this.critical8.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical8.ForeColor = System.Drawing.Color.Lime;
            this.critical8.Location = new System.Drawing.Point(2378, 810);
            this.critical8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical8.Name = "critical8";
            this.critical8.Size = new System.Drawing.Size(1222, 79);
            this.critical8.TabIndex = 24;
            this.critical8.Text = "Horationion [SEC] 127 Links";
            // 
            // top8
            // 
            this.top8.AutoSize = true;
            this.top8.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top8.ForeColor = System.Drawing.Color.Lime;
            this.top8.Location = new System.Drawing.Point(2378, 1580);
            this.top8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.top8.Name = "top8";
            this.top8.Size = new System.Drawing.Size(1222, 79);
            this.top8.TabIndex = 34;
            this.top8.Text = "Horationion [SEC] 127 Links";
            // 
            // top7
            // 
            this.top7.AutoSize = true;
            this.top7.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top7.ForeColor = System.Drawing.Color.Lime;
            this.top7.Location = new System.Drawing.Point(2378, 1505);
            this.top7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.top7.Name = "top7";
            this.top7.Size = new System.Drawing.Size(738, 79);
            this.top7.TabIndex = 32;
            this.top7.Text = "Skippy 113 Links";
            // 
            // top6
            // 
            this.top6.AutoSize = true;
            this.top6.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top6.ForeColor = System.Drawing.Color.Lime;
            this.top6.Location = new System.Drawing.Point(2378, 1430);
            this.top6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.top6.Name = "top6";
            this.top6.Size = new System.Drawing.Size(738, 79);
            this.top6.TabIndex = 31;
            this.top6.Text = "Skippy 113 Links";
            // 
            // top5
            // 
            this.top5.AutoSize = true;
            this.top5.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top5.ForeColor = System.Drawing.Color.Lime;
            this.top5.Location = new System.Drawing.Point(2378, 1355);
            this.top5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.top5.Name = "top5";
            this.top5.Size = new System.Drawing.Size(738, 79);
            this.top5.TabIndex = 30;
            this.top5.Text = "Skippy 113 Links";
            // 
            // top4
            // 
            this.top4.AutoSize = true;
            this.top4.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top4.ForeColor = System.Drawing.Color.Lime;
            this.top4.Location = new System.Drawing.Point(2378, 1280);
            this.top4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.top4.Name = "top4";
            this.top4.Size = new System.Drawing.Size(738, 79);
            this.top4.TabIndex = 29;
            this.top4.Text = "Skippy 113 Links";
            // 
            // top3
            // 
            this.top3.AutoSize = true;
            this.top3.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top3.ForeColor = System.Drawing.Color.Lime;
            this.top3.Location = new System.Drawing.Point(2378, 1205);
            this.top3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(738, 79);
            this.top3.TabIndex = 28;
            this.top3.Text = "Skippy 113 Links";
            // 
            // top2
            // 
            this.top2.AutoSize = true;
            this.top2.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top2.ForeColor = System.Drawing.Color.Lime;
            this.top2.Location = new System.Drawing.Point(2378, 1130);
            this.top2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(738, 79);
            this.top2.TabIndex = 27;
            this.top2.Text = "Skippy 113 Links";
            // 
            // top1
            // 
            this.top1.AutoSize = true;
            this.top1.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top1.ForeColor = System.Drawing.Color.Lime;
            this.top1.Location = new System.Drawing.Point(2378, 1055);
            this.top1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(738, 79);
            this.top1.TabIndex = 26;
            this.top1.Text = "Skippy 113 Links";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Lime;
            this.label21.Location = new System.Drawing.Point(2864, 938);
            this.label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(562, 79);
            this.label21.TabIndex = 25;
            this.label21.Text = "Top In Range";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(2654, 1777);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1041, 180);
            this.label3.TabIndex = 35;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // sqlIp
            // 
            this.sqlIp.Location = new System.Drawing.Point(2704, 23);
            this.sqlIp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sqlIp.Name = "sqlIp";
            this.sqlIp.Size = new System.Drawing.Size(148, 31);
            this.sqlIp.TabIndex = 36;
            this.sqlIp.Text = "127.0.0.1";
            // 
            // critical0
            // 
            this.critical0.AutoSize = true;
            this.critical0.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical0.ForeColor = System.Drawing.Color.Lime;
            this.critical0.Location = new System.Drawing.Point(2378, 206);
            this.critical0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical0.Name = "critical0";
            this.critical0.Size = new System.Drawing.Size(738, 79);
            this.critical0.TabIndex = 37;
            this.critical0.Text = "Skippy 113 Links";
            // 
            // timeRefresh
            // 
            this.timeRefresh.Location = new System.Drawing.Point(2996, 22);
            this.timeRefresh.Name = "timeRefresh";
            this.timeRefresh.Size = new System.Drawing.Size(100, 31);
            this.timeRefresh.TabIndex = 38;
            this.timeRefresh.Text = "30";
            // 
            // StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnRestore;
            this.ClientSize = new System.Drawing.Size(3808, 2002);
            this.Controls.Add(this.timeRefresh);
            this.Controls.Add(this.critical0);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private System.Windows.Forms.Label critical0;
        private System.Windows.Forms.TextBox timeRefresh;
    }
}

