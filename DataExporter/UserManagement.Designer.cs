namespace DataExporter
{
    partial class UserManagement
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
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.in_user_pass = new System.Windows.Forms.TextBox();
            this.in_user_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flow_user = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_permission = new System.Windows.Forms.DataGridView();
            this.btn_user_save = new System.Windows.Forms.Button();
            this.btn_usr_clear = new System.Windows.Forms.Button();
            this.btn_usr_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flow_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permission)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_user
            // 
            this.dgv_user.AllowUserToAddRows = false;
            this.dgv_user.AllowUserToDeleteRows = false;
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(0, 0);
            this.dgv_user.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersVisible = false;
            this.dgv_user.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_user.Size = new System.Drawing.Size(200, 462);
            this.dgv_user.TabIndex = 0;
            this.dgv_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.in_user_pass);
            this.groupBox1.Controls.Add(this.in_user_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Detail";
            // 
            // in_user_pass
            // 
            this.in_user_pass.Location = new System.Drawing.Point(109, 51);
            this.in_user_pass.Name = "in_user_pass";
            this.in_user_pass.PasswordChar = '*';
            this.in_user_pass.Size = new System.Drawing.Size(437, 26);
            this.in_user_pass.TabIndex = 3;
            // 
            // in_user_name
            // 
            this.in_user_name.Location = new System.Drawing.Point(109, 19);
            this.in_user_name.Name = "in_user_name";
            this.in_user_name.Size = new System.Drawing.Size(439, 26);
            this.in_user_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flow_user);
            this.groupBox2.Controls.Add(this.dgv_permission);
            this.groupBox2.Location = new System.Drawing.Point(218, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(554, 294);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group Permission";
            // 
            // flow_user
            // 
            this.flow_user.Controls.Add(this.label3);
            this.flow_user.Controls.Add(this.label4);
            this.flow_user.Location = new System.Drawing.Point(216, 25);
            this.flow_user.Name = "flow_user";
            this.flow_user.Size = new System.Drawing.Size(330, 263);
            this.flow_user.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Permission";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(295, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Act";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_permission
            // 
            this.dgv_permission.AllowUserToAddRows = false;
            this.dgv_permission.AllowUserToDeleteRows = false;
            this.dgv_permission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_permission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_permission.Location = new System.Drawing.Point(10, 25);
            this.dgv_permission.Name = "dgv_permission";
            this.dgv_permission.ReadOnly = true;
            this.dgv_permission.RowHeadersVisible = false;
            this.dgv_permission.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_permission.Size = new System.Drawing.Size(200, 263);
            this.dgv_permission.TabIndex = 0;
            this.dgv_permission.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_permission_CellDoubleClick);
            // 
            // btn_user_save
            // 
            this.btn_user_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_save.Location = new System.Drawing.Point(218, 417);
            this.btn_user_save.Name = "btn_user_save";
            this.btn_user_save.Size = new System.Drawing.Size(75, 33);
            this.btn_user_save.TabIndex = 3;
            this.btn_user_save.Text = "Save";
            this.btn_user_save.UseVisualStyleBackColor = true;
            this.btn_user_save.Click += new System.EventHandler(this.btn_user_save_Click);
            // 
            // btn_usr_clear
            // 
            this.btn_usr_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usr_clear.Location = new System.Drawing.Point(299, 417);
            this.btn_usr_clear.Name = "btn_usr_clear";
            this.btn_usr_clear.Size = new System.Drawing.Size(75, 33);
            this.btn_usr_clear.TabIndex = 4;
            this.btn_usr_clear.Text = "Clear";
            this.btn_usr_clear.UseVisualStyleBackColor = true;
            this.btn_usr_clear.Click += new System.EventHandler(this.btn_usr_clear_Click);
            // 
            // btn_usr_del
            // 
            this.btn_usr_del.BackColor = System.Drawing.Color.Maroon;
            this.btn_usr_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usr_del.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_usr_del.Location = new System.Drawing.Point(697, 417);
            this.btn_usr_del.Name = "btn_usr_del";
            this.btn_usr_del.Size = new System.Drawing.Size(75, 33);
            this.btn_usr_del.TabIndex = 5;
            this.btn_usr_del.Text = "Delete";
            this.btn_usr_del.UseVisualStyleBackColor = false;
            this.btn_usr_del.Click += new System.EventHandler(this.btn_usr_del_Click);
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.btn_usr_del);
            this.Controls.Add(this.btn_usr_clear);
            this.Controls.Add(this.btn_user_save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_user);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserManagement";
            this.Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flow_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox in_user_pass;
        private System.Windows.Forms.TextBox in_user_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flow_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_permission;
        private System.Windows.Forms.Button btn_user_save;
        private System.Windows.Forms.Button btn_usr_clear;
        private System.Windows.Forms.Button btn_usr_del;
    }
}