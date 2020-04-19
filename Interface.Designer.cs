namespace stationMeteo
{
    partial class Interface
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
            this.trame_timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_measures = new System.Windows.Forms.TabPage();
            this.dgv_measures = new System.Windows.Forms.DataGridView();
            this.tab_chart = new System.Windows.Forms.TabPage();
            this.tab_idSystem = new System.Windows.Forms.TabPage();
            this.dgv_systemID = new System.Windows.Forms.DataGridView();
            this.tab_configurations = new System.Windows.Forms.TabPage();
            this.dgv_configurations = new System.Windows.Forms.DataGridView();
            this.tab_alarms = new System.Windows.Forms.TabPage();
            this.dgv_alarm = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_deleteAlarm = new System.Windows.Forms.Button();
            this.bt_loadAlarm = new System.Windows.Forms.Button();
            this.lb_alarmUp = new System.Windows.Forms.Label();
            this.lb_alarmBelow = new System.Windows.Forms.Label();
            this.lb_alarmID = new System.Windows.Forms.Label();
            this.lb_maxMeasure = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_alarmUp = new System.Windows.Forms.TextBox();
            this.lb_minMeasure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_alarmBelow = new System.Windows.Forms.TextBox();
            this.cb_alarmID = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchdog_timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tab_measures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_measures)).BeginInit();
            this.tab_idSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_systemID)).BeginInit();
            this.tab_configurations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_configurations)).BeginInit();
            this.tab_alarms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alarm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trame_timer
            // 
            this.trame_timer.Enabled = true;
            this.trame_timer.Interval = 1000;
            this.trame_timer.Tick += new System.EventHandler(this.sendTrame);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_measures);
            this.tabControl1.Controls.Add(this.tab_chart);
            this.tabControl1.Controls.Add(this.tab_idSystem);
            this.tabControl1.Controls.Add(this.tab_configurations);
            this.tabControl1.Controls.Add(this.tab_alarms);
            this.tabControl1.Location = new System.Drawing.Point(9, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 544);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_measures
            // 
            this.tab_measures.Controls.Add(this.dgv_measures);
            this.tab_measures.Location = new System.Drawing.Point(4, 22);
            this.tab_measures.Margin = new System.Windows.Forms.Padding(2);
            this.tab_measures.Name = "tab_measures";
            this.tab_measures.Padding = new System.Windows.Forms.Padding(2);
            this.tab_measures.Size = new System.Drawing.Size(924, 518);
            this.tab_measures.TabIndex = 0;
            this.tab_measures.Text = "Measures";
            this.tab_measures.UseVisualStyleBackColor = true;
            // 
            // dgv_measures
            // 
            this.dgv_measures.AllowUserToAddRows = false;
            this.dgv_measures.AllowUserToDeleteRows = false;
            this.dgv_measures.AllowUserToResizeColumns = false;
            this.dgv_measures.AllowUserToResizeRows = false;
            this.dgv_measures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_measures.Location = new System.Drawing.Point(-3, 0);
            this.dgv_measures.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_measures.Name = "dgv_measures";
            this.dgv_measures.RowHeadersVisible = false;
            this.dgv_measures.RowHeadersWidth = 51;
            this.dgv_measures.RowTemplate.Height = 24;
            this.dgv_measures.Size = new System.Drawing.Size(929, 434);
            this.dgv_measures.TabIndex = 0;
            // 
            // tab_chart
            // 
            this.tab_chart.Location = new System.Drawing.Point(4, 22);
            this.tab_chart.Margin = new System.Windows.Forms.Padding(2);
            this.tab_chart.Name = "tab_chart";
            this.tab_chart.Padding = new System.Windows.Forms.Padding(2);
            this.tab_chart.Size = new System.Drawing.Size(924, 518);
            this.tab_chart.TabIndex = 1;
            this.tab_chart.Text = "Chart";
            this.tab_chart.UseVisualStyleBackColor = true;
            // 
            // tab_idSystem
            // 
            this.tab_idSystem.Controls.Add(this.dgv_systemID);
            this.tab_idSystem.Location = new System.Drawing.Point(4, 22);
            this.tab_idSystem.Margin = new System.Windows.Forms.Padding(2);
            this.tab_idSystem.Name = "tab_idSystem";
            this.tab_idSystem.Size = new System.Drawing.Size(924, 518);
            this.tab_idSystem.TabIndex = 2;
            this.tab_idSystem.Text = "ID System";
            this.tab_idSystem.UseVisualStyleBackColor = true;
            // 
            // dgv_systemID
            // 
            this.dgv_systemID.AllowUserToAddRows = false;
            this.dgv_systemID.AllowUserToDeleteRows = false;
            this.dgv_systemID.AllowUserToResizeColumns = false;
            this.dgv_systemID.AllowUserToResizeRows = false;
            this.dgv_systemID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_systemID.Location = new System.Drawing.Point(3, 3);
            this.dgv_systemID.Name = "dgv_systemID";
            this.dgv_systemID.RowHeadersVisible = false;
            this.dgv_systemID.Size = new System.Drawing.Size(918, 512);
            this.dgv_systemID.TabIndex = 0;
            // 
            // tab_configurations
            // 
            this.tab_configurations.Controls.Add(this.dgv_configurations);
            this.tab_configurations.Location = new System.Drawing.Point(4, 22);
            this.tab_configurations.Margin = new System.Windows.Forms.Padding(2);
            this.tab_configurations.Name = "tab_configurations";
            this.tab_configurations.Size = new System.Drawing.Size(924, 518);
            this.tab_configurations.TabIndex = 3;
            this.tab_configurations.Text = "Configurations";
            this.tab_configurations.UseVisualStyleBackColor = true;
            // 
            // dgv_configurations
            // 
            this.dgv_configurations.AllowUserToAddRows = false;
            this.dgv_configurations.AllowUserToDeleteRows = false;
            this.dgv_configurations.AllowUserToResizeColumns = false;
            this.dgv_configurations.AllowUserToResizeRows = false;
            this.dgv_configurations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_configurations.Location = new System.Drawing.Point(-3, 0);
            this.dgv_configurations.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_configurations.Name = "dgv_configurations";
            this.dgv_configurations.RowHeadersVisible = false;
            this.dgv_configurations.RowHeadersWidth = 51;
            this.dgv_configurations.RowTemplate.Height = 24;
            this.dgv_configurations.Size = new System.Drawing.Size(927, 553);
            this.dgv_configurations.TabIndex = 0;
            // 
            // tab_alarms
            // 
            this.tab_alarms.Controls.Add(this.dgv_alarm);
            this.tab_alarms.Controls.Add(this.groupBox1);
            this.tab_alarms.Location = new System.Drawing.Point(4, 22);
            this.tab_alarms.Margin = new System.Windows.Forms.Padding(2);
            this.tab_alarms.Name = "tab_alarms";
            this.tab_alarms.Size = new System.Drawing.Size(924, 518);
            this.tab_alarms.TabIndex = 4;
            this.tab_alarms.Text = "Alarms";
            this.tab_alarms.UseVisualStyleBackColor = true;
            // 
            // dgv_alarm
            // 
            this.dgv_alarm.AllowUserToAddRows = false;
            this.dgv_alarm.AllowUserToDeleteRows = false;
            this.dgv_alarm.AllowUserToResizeColumns = false;
            this.dgv_alarm.AllowUserToResizeRows = false;
            this.dgv_alarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alarm.Location = new System.Drawing.Point(3, 124);
            this.dgv_alarm.Name = "dgv_alarm";
            this.dgv_alarm.RowHeadersVisible = false;
            this.dgv_alarm.Size = new System.Drawing.Size(918, 391);
            this.dgv_alarm.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.bt_deleteAlarm);
            this.groupBox1.Controls.Add(this.bt_loadAlarm);
            this.groupBox1.Controls.Add(this.lb_alarmUp);
            this.groupBox1.Controls.Add(this.lb_alarmBelow);
            this.groupBox1.Controls.Add(this.lb_alarmID);
            this.groupBox1.Controls.Add(this.lb_maxMeasure);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_alarmUp);
            this.groupBox1.Controls.Add(this.lb_minMeasure);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_alarmBelow);
            this.groupBox1.Controls.Add(this.cb_alarmID);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configutation";
            // 
            // bt_deleteAlarm
            // 
            this.bt_deleteAlarm.Location = new System.Drawing.Point(256, 79);
            this.bt_deleteAlarm.Name = "bt_deleteAlarm";
            this.bt_deleteAlarm.Size = new System.Drawing.Size(86, 30);
            this.bt_deleteAlarm.TabIndex = 11;
            this.bt_deleteAlarm.Text = "Delete";
            this.bt_deleteAlarm.UseVisualStyleBackColor = true;
            // 
            // bt_loadAlarm
            // 
            this.bt_loadAlarm.Location = new System.Drawing.Point(164, 79);
            this.bt_loadAlarm.Name = "bt_loadAlarm";
            this.bt_loadAlarm.Size = new System.Drawing.Size(86, 30);
            this.bt_loadAlarm.TabIndex = 10;
            this.bt_loadAlarm.Text = "Load";
            this.bt_loadAlarm.UseVisualStyleBackColor = true;
            this.bt_loadAlarm.Click += new System.EventHandler(this.onAlarmLoaded);
            // 
            // lb_alarmUp
            // 
            this.lb_alarmUp.AutoSize = true;
            this.lb_alarmUp.Location = new System.Drawing.Point(531, 24);
            this.lb_alarmUp.Name = "lb_alarmUp";
            this.lb_alarmUp.Size = new System.Drawing.Size(54, 13);
            this.lb_alarmUp.TabIndex = 9;
            this.lb_alarmUp.Text = "Alarm up :";
            // 
            // lb_alarmBelow
            // 
            this.lb_alarmBelow.AutoSize = true;
            this.lb_alarmBelow.Location = new System.Drawing.Point(253, 24);
            this.lb_alarmBelow.Name = "lb_alarmBelow";
            this.lb_alarmBelow.Size = new System.Drawing.Size(70, 13);
            this.lb_alarmBelow.TabIndex = 8;
            this.lb_alarmBelow.Text = "Alarm below :";
            // 
            // lb_alarmID
            // 
            this.lb_alarmID.AutoSize = true;
            this.lb_alarmID.Location = new System.Drawing.Point(129, 24);
            this.lb_alarmID.Name = "lb_alarmID";
            this.lb_alarmID.Size = new System.Drawing.Size(18, 13);
            this.lb_alarmID.TabIndex = 7;
            this.lb_alarmID.Text = "ID";
            // 
            // lb_maxMeasure
            // 
            this.lb_maxMeasure.AutoSize = true;
            this.lb_maxMeasure.Location = new System.Drawing.Point(701, 53);
            this.lb_maxMeasure.Name = "lb_maxMeasure";
            this.lb_maxMeasure.Size = new System.Drawing.Size(67, 13);
            this.lb_maxMeasure.TabIndex = 6;
            this.lb_maxMeasure.Text = "maxMeasure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Low limit :";
            // 
            // tb_alarmUp
            // 
            this.tb_alarmUp.Location = new System.Drawing.Point(534, 47);
            this.tb_alarmUp.Name = "tb_alarmUp";
            this.tb_alarmUp.Size = new System.Drawing.Size(100, 20);
            this.tb_alarmUp.TabIndex = 4;
            // 
            // lb_minMeasure
            // 
            this.lb_minMeasure.AutoSize = true;
            this.lb_minMeasure.Location = new System.Drawing.Point(423, 50);
            this.lb_minMeasure.Name = "lb_minMeasure";
            this.lb_minMeasure.Size = new System.Drawing.Size(64, 13);
            this.lb_minMeasure.TabIndex = 3;
            this.lb_minMeasure.Text = "minMesaure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Low limit :";
            // 
            // tb_alarmBelow
            // 
            this.tb_alarmBelow.Location = new System.Drawing.Point(256, 44);
            this.tb_alarmBelow.Name = "tb_alarmBelow";
            this.tb_alarmBelow.Size = new System.Drawing.Size(100, 20);
            this.tb_alarmBelow.TabIndex = 1;
            // 
            // cb_alarmID
            // 
            this.cb_alarmID.FormattingEnabled = true;
            this.cb_alarmID.Location = new System.Drawing.Point(129, 43);
            this.cb_alarmID.Name = "cb_alarmID";
            this.cb_alarmID.Size = new System.Drawing.Size(121, 21);
            this.cb_alarmID.TabIndex = 0;
            this.cb_alarmID.SelectedValueChanged += new System.EventHandler(this.onSelectedAlarmIDChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // watchdog_timer
            // 
            this.watchdog_timer.Interval = 10000;
            this.watchdog_timer.Tick += new System.EventHandler(this.sendWatchdog);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(950, 593);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Interface";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_measures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_measures)).EndInit();
            this.tab_idSystem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_systemID)).EndInit();
            this.tab_configurations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_configurations)).EndInit();
            this.tab_alarms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alarm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer trame_timer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_measures;
        private System.Windows.Forms.TabPage tab_chart;
        private System.Windows.Forms.DataGridView dgv_measures;
        private System.Windows.Forms.TabPage tab_idSystem;
        private System.Windows.Forms.TabPage tab_configurations;
        private System.Windows.Forms.TabPage tab_alarms;
        private System.Windows.Forms.DataGridView dgv_configurations;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.Timer watchdog_timer;
        private System.Windows.Forms.DataGridView dgv_systemID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_minMeasure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_alarmBelow;
        private System.Windows.Forms.ComboBox cb_alarmID;
        private System.Windows.Forms.Label lb_maxMeasure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_alarmUp;
        private System.Windows.Forms.DataGridView dgv_alarm;
        private System.Windows.Forms.Label lb_alarmUp;
        private System.Windows.Forms.Label lb_alarmBelow;
        private System.Windows.Forms.Label lb_alarmID;
        private System.Windows.Forms.Button bt_deleteAlarm;
        private System.Windows.Forms.Button bt_loadAlarm;
    }
}