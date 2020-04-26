namespace stationMeteo
{
    partial class UserCreation
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
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.bt_addUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            this.dgv_users.AllowUserToResizeColumns = false;
            this.dgv_users.AllowUserToResizeRows = false;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(12, 13);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.RowHeadersVisible = false;
            this.dgv_users.Size = new System.Drawing.Size(564, 425);
            this.dgv_users.TabIndex = 0;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(599, 58);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(157, 20);
            this.tb_username.TabIndex = 1;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(599, 97);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(157, 20);
            this.tb_password.TabIndex = 2;
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Location = new System.Drawing.Point(599, 136);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(157, 21);
            this.cb_role.TabIndex = 3;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(596, 42);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(84, 13);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "Nom d\'utilisateur";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(596, 81);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(71, 13);
            this.lb_password.TabIndex = 5;
            this.lb_password.Text = "Mot de passe";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Location = new System.Drawing.Point(596, 120);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(29, 13);
            this.lb_role.TabIndex = 6;
            this.lb_role.Text = "Rôle";
            // 
            // bt_addUser
            // 
            this.bt_addUser.Location = new System.Drawing.Point(625, 181);
            this.bt_addUser.Name = "bt_addUser";
            this.bt_addUser.Size = new System.Drawing.Size(95, 38);
            this.bt_addUser.TabIndex = 7;
            this.bt_addUser.Text = "Ajouter";
            this.bt_addUser.UseVisualStyleBackColor = true;
            this.bt_addUser.Click += new System.EventHandler(this.createuser);
            // 
            // UserCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_addUser);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.dgv_users);
            this.Name = "UserCreation";
            this.Text = "UserCreation";
            this.Load += new System.EventHandler(this.UserCreation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Button bt_addUser;
    }
}