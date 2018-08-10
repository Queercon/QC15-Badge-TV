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
            this.label3 = new System.Windows.Forms.Label();
            this.sqlIp = new System.Windows.Forms.TextBox();
            this.critical0 = new System.Windows.Forms.Label();
            this.timeRefresh = new System.Windows.Forms.TextBox();
            this.critical16 = new System.Windows.Forms.Label();
            this.critical15 = new System.Windows.Forms.Label();
            this.critical14 = new System.Windows.Forms.Label();
            this.critical13 = new System.Windows.Forms.Label();
            this.critical12 = new System.Windows.Forms.Label();
            this.critical11 = new System.Windows.Forms.Label();
            this.critical10 = new System.Windows.Forms.Label();
            this.critical9 = new System.Windows.Forms.Label();
            this.LastSeen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(186, 23);
            this.btnFullScreen.Margin = new System.Windows.Forms.Padding(6);
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
            this.headingCenter.Size = new System.Drawing.Size(3244, 75);
            this.headingCenter.TabIndex = 4;
            this.headingCenter.Text = "QUEERCON v.15 NETWORK HEALTH";
            this.headingCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWindow
            // 
            this.btnWindow.Location = new System.Drawing.Point(348, 23);
            this.btnWindow.Margin = new System.Windows.Forms.Padding(6);
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
            this.btnSql.Margin = new System.Windows.Forms.Padding(6);
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
            this.demoSelect.Margin = new System.Windows.Forms.Padding(6);
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
            this.decryptValue.Location = new System.Drawing.Point(828, 75);
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
            this.label1.Size = new System.Drawing.Size(694, 79);
            this.label1.TabIndex = 9;
            this.label1.Text = "File Decrypted:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1191, 75);
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
            this.sqlIp.Margin = new System.Windows.Forms.Padding(6);
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
            this.timeRefresh.Text = "1200";
            // 
            // critical16
            // 
            this.critical16.AutoSize = true;
            this.critical16.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical16.ForeColor = System.Drawing.Color.Lime;
            this.critical16.Location = new System.Drawing.Point(2378, 1405);
            this.critical16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical16.Name = "critical16";
            this.critical16.Size = new System.Drawing.Size(1222, 79);
            this.critical16.TabIndex = 46;
            this.critical16.Text = "Horationion [SEC] 127 Links";
            // 
            // critical15
            // 
            this.critical15.AutoSize = true;
            this.critical15.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical15.ForeColor = System.Drawing.Color.Lime;
            this.critical15.Location = new System.Drawing.Point(2378, 1330);
            this.critical15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical15.Name = "critical15";
            this.critical15.Size = new System.Drawing.Size(738, 79);
            this.critical15.TabIndex = 45;
            this.critical15.Text = "Skippy 113 Links";
            // 
            // critical14
            // 
            this.critical14.AutoSize = true;
            this.critical14.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical14.ForeColor = System.Drawing.Color.Lime;
            this.critical14.Location = new System.Drawing.Point(2378, 1255);
            this.critical14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical14.Name = "critical14";
            this.critical14.Size = new System.Drawing.Size(738, 79);
            this.critical14.TabIndex = 44;
            this.critical14.Text = "Skippy 113 Links";
            // 
            // critical13
            // 
            this.critical13.AutoSize = true;
            this.critical13.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical13.ForeColor = System.Drawing.Color.Lime;
            this.critical13.Location = new System.Drawing.Point(2378, 1180);
            this.critical13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical13.Name = "critical13";
            this.critical13.Size = new System.Drawing.Size(738, 79);
            this.critical13.TabIndex = 43;
            this.critical13.Text = "Skippy 113 Links";
            // 
            // critical12
            // 
            this.critical12.AutoSize = true;
            this.critical12.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical12.ForeColor = System.Drawing.Color.Lime;
            this.critical12.Location = new System.Drawing.Point(2378, 1105);
            this.critical12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical12.Name = "critical12";
            this.critical12.Size = new System.Drawing.Size(738, 79);
            this.critical12.TabIndex = 42;
            this.critical12.Text = "Skippy 113 Links";
            // 
            // critical11
            // 
            this.critical11.AutoSize = true;
            this.critical11.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical11.ForeColor = System.Drawing.Color.Lime;
            this.critical11.Location = new System.Drawing.Point(2378, 1030);
            this.critical11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical11.Name = "critical11";
            this.critical11.Size = new System.Drawing.Size(738, 79);
            this.critical11.TabIndex = 41;
            this.critical11.Text = "Skippy 113 Links";
            // 
            // critical10
            // 
            this.critical10.AutoSize = true;
            this.critical10.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical10.ForeColor = System.Drawing.Color.Lime;
            this.critical10.Location = new System.Drawing.Point(2378, 955);
            this.critical10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical10.Name = "critical10";
            this.critical10.Size = new System.Drawing.Size(738, 79);
            this.critical10.TabIndex = 40;
            this.critical10.Text = "Skippy 113 Links";
            // 
            // critical9
            // 
            this.critical9.AutoSize = true;
            this.critical9.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.critical9.ForeColor = System.Drawing.Color.Lime;
            this.critical9.Location = new System.Drawing.Point(2378, 880);
            this.critical9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.critical9.Name = "critical9";
            this.critical9.Size = new System.Drawing.Size(738, 79);
            this.critical9.TabIndex = 39;
            this.critical9.Text = "Skippy 113 Links";
            // 
            // LastSeen
            // 
            this.LastSeen.AutoSize = true;
            this.LastSeen.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastSeen.ForeColor = System.Drawing.Color.Lime;
            this.LastSeen.Location = new System.Drawing.Point(2186, 1921);
            this.LastSeen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LastSeen.Name = "LastSeen";
            this.LastSeen.Size = new System.Drawing.Size(167, 36);
            this.LastSeen.TabIndex = 47;
            this.LastSeen.Text = "LastSeen";
            // 
            // StartFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnRestore;
            this.ClientSize = new System.Drawing.Size(3244, 2002);
            this.Controls.Add(this.LastSeen);
            this.Controls.Add(this.critical16);
            this.Controls.Add(this.critical15);
            this.Controls.Add(this.critical14);
            this.Controls.Add(this.critical13);
            this.Controls.Add(this.critical12);
            this.Controls.Add(this.critical11);
            this.Controls.Add(this.critical10);
            this.Controls.Add(this.critical9);
            this.Controls.Add(this.timeRefresh);
            this.Controls.Add(this.critical0);
            this.Controls.Add(this.sqlIp);
            this.Controls.Add(this.label3);
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
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sqlIp;
        private System.Windows.Forms.Label critical0;
        private System.Windows.Forms.TextBox timeRefresh;
        private System.Windows.Forms.Label critical16;
        private System.Windows.Forms.Label critical15;
        private System.Windows.Forms.Label critical14;
        private System.Windows.Forms.Label critical13;
        private System.Windows.Forms.Label critical12;
        private System.Windows.Forms.Label critical11;
        private System.Windows.Forms.Label critical10;
        private System.Windows.Forms.Label critical9;
        private System.Windows.Forms.Label LastSeen;
    }
}

