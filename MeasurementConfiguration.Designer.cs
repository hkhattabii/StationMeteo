namespace stationMeteo
{
    partial class MeasurementConfiguration
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
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_ID = new System.Windows.Forms.ComboBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.lb_max = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_load = new System.Windows.Forms.Button();
            this.nu_min = new System.Windows.Forms.NumericUpDown();
            this.nu_max = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nu_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_max)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(158, 51);
            this.cb_type.Margin = new System.Windows.Forms.Padding(2);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(156, 21);
            this.cb_type.TabIndex = 1;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.onSelectedTypeChanged);
            // 
            // cb_ID
            // 
            this.cb_ID.FormattingEnabled = true;
            this.cb_ID.Location = new System.Drawing.Point(62, 51);
            this.cb_ID.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ID.Name = "cb_ID";
            this.cb_ID.Size = new System.Drawing.Size(92, 21);
            this.cb_ID.TabIndex = 6;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(58, 24);
            this.lb_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(26, 20);
            this.lb_id.TabIndex = 7;
            this.lb_id.Text = "ID";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.Location = new System.Drawing.Point(154, 24);
            this.lb_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(43, 20);
            this.lb_type.TabIndex = 8;
            this.lb_type.Text = "Type";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_min.Location = new System.Drawing.Point(315, 24);
            this.lb_min.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(34, 20);
            this.lb_min.TabIndex = 9;
            this.lb_min.Text = "Min";
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_max.Location = new System.Drawing.Point(388, 24);
            this.lb_max.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(38, 20);
            this.lb_max.TabIndex = 10;
            this.lb_max.Text = "Max";
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(192, 138);
            this.bt_delete.Margin = new System.Windows.Forms.Padding(2);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(151, 37);
            this.bt_delete.TabIndex = 12;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // bt_load
            // 
            this.bt_load.Location = new System.Drawing.Point(17, 138);
            this.bt_load.Margin = new System.Windows.Forms.Padding(2);
            this.bt_load.Name = "bt_load";
            this.bt_load.Size = new System.Drawing.Size(151, 37);
            this.bt_load.TabIndex = 13;
            this.bt_load.Text = "Load";
            this.bt_load.UseVisualStyleBackColor = true;
            this.bt_load.Click += new System.EventHandler(this.onLoadMeasure);
            // 
            // nu_min
            // 
            this.nu_min.Location = new System.Drawing.Point(319, 52);
            this.nu_min.Name = "nu_min";
            this.nu_min.Size = new System.Drawing.Size(67, 20);
            this.nu_min.TabIndex = 14;
            // 
            // nu_max
            // 
            this.nu_max.Location = new System.Drawing.Point(392, 52);
            this.nu_max.Name = "nu_max";
            this.nu_max.Size = new System.Drawing.Size(67, 20);
            this.nu_max.TabIndex = 18;
            // 
            // MeasurementConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 193);
            this.Controls.Add(this.nu_max);
            this.Controls.Add(this.nu_min);
            this.Controls.Add(this.bt_load);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.lb_max);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.cb_ID);
            this.Controls.Add(this.cb_type);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MeasurementConfiguration";
            this.Text = "MeasurementConfiguration";
            this.Load += new System.EventHandler(this.MeasurementConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nu_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_max)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_ID;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label lb_max;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_load;
        private System.Windows.Forms.NumericUpDown nu_min;
        private System.Windows.Forms.NumericUpDown nu_max;
    }
}