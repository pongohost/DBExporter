namespace DataExporter
{
    partial class nav_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nav_menu));
            this.btn_query = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_role = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_query
            // 
            this.btn_query.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_query.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_query.Location = new System.Drawing.Point(4, 11);
            this.btn_query.Margin = new System.Windows.Forms.Padding(6);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(175, 50);
            this.btn_query.TabIndex = 0;
            this.btn_query.Text = "Query Manager";
            this.btn_query.UseVisualStyleBackColor = false;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Location = new System.Drawing.Point(4, 73);
            this.btn_user.Margin = new System.Windows.Forms.Padding(6);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(175, 50);
            this.btn_user.TabIndex = 1;
            this.btn_user.Text = "User Manager";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log.Location = new System.Drawing.Point(4, 197);
            this.btn_log.Margin = new System.Windows.Forms.Padding(6);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(175, 50);
            this.btn_log.TabIndex = 2;
            this.btn_log.Text = "Log Viewer";
            this.btn_log.UseVisualStyleBackColor = false;
            // 
            // btn_role
            // 
            this.btn_role.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_role.Location = new System.Drawing.Point(4, 135);
            this.btn_role.Margin = new System.Windows.Forms.Padding(6);
            this.btn_role.Name = "btn_role";
            this.btn_role.Size = new System.Drawing.Size(175, 50);
            this.btn_role.TabIndex = 3;
            this.btn_role.Text = "Role Manager";
            this.btn_role.UseVisualStyleBackColor = false;
            this.btn_role.Click += new System.EventHandler(this.btn_role_Click);
            // 
            // nav_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 484);
            this.CloseButtonVisible = false;
            this.Controls.Add(this.btn_role);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.btn_query);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "nav_menu";
            this.TabText = "MENU";
            this.Tag = "";
            this.Text = "nav_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_role;
    }
}