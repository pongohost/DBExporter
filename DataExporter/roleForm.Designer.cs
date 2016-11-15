namespace DataExporter
{
    partial class roleForm
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
            this.dgv_role = new System.Windows.Forms.DataGridView();
            this.Group = new System.Windows.Forms.GroupBox();
            this.in_groupnote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.in_groupname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowgroup = new System.Windows.Forms.FlowLayoutPanel();
            this.dgv_gQuery = new System.Windows.Forms.DataGridView();
            this.cb_group = new System.Windows.Forms.CheckBox();
            this.btn_role_save = new System.Windows.Forms.Button();
            this.btn_role_clear = new System.Windows.Forms.Button();
            this.btn_role_delete = new System.Windows.Forms.Button();
            this.role_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).BeginInit();
            this.Group.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_role
            // 
            this.dgv_role.AllowUserToAddRows = false;
            this.dgv_role.AllowUserToDeleteRows = false;
            this.dgv_role.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_role.Location = new System.Drawing.Point(0, 0);
            this.dgv_role.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_role.Name = "dgv_role";
            this.dgv_role.ReadOnly = true;
            this.dgv_role.RowHeadersVisible = false;
            this.dgv_role.Size = new System.Drawing.Size(200, 462);
            this.dgv_role.TabIndex = 0;
            this.dgv_role.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_querylist_CellClick);
            // 
            // Group
            // 
            this.Group.Controls.Add(this.in_groupnote);
            this.Group.Controls.Add(this.label3);
            this.Group.Controls.Add(this.in_groupname);
            this.Group.Controls.Add(this.label2);
            this.Group.Location = new System.Drawing.Point(208, -1);
            this.Group.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Group.Name = "Group";
            this.Group.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Group.Size = new System.Drawing.Size(572, 88);
            this.Group.TabIndex = 1;
            this.Group.TabStop = false;
            this.Group.Text = "Group";
            // 
            // in_groupnote
            // 
            this.in_groupnote.Location = new System.Drawing.Point(117, 53);
            this.in_groupnote.Name = "in_groupnote";
            this.in_groupnote.Size = new System.Drawing.Size(446, 26);
            this.in_groupnote.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note:";
            // 
            // in_groupname
            // 
            this.in_groupname.Location = new System.Drawing.Point(117, 21);
            this.in_groupname.Name = "in_groupname";
            this.in_groupname.Size = new System.Drawing.Size(446, 26);
            this.in_groupname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Group Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowgroup);
            this.groupBox1.Controls.Add(this.dgv_gQuery);
            this.groupBox1.Location = new System.Drawing.Point(207, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 333);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role";
            // 
            // flowgroup
            // 
            this.flowgroup.Location = new System.Drawing.Point(277, 25);
            this.flowgroup.Margin = new System.Windows.Forms.Padding(0);
            this.flowgroup.Name = "flowgroup";
            this.flowgroup.Size = new System.Drawing.Size(290, 302);
            this.flowgroup.TabIndex = 4;
            // 
            // dgv_gQuery
            // 
            this.dgv_gQuery.AllowUserToAddRows = false;
            this.dgv_gQuery.AllowUserToDeleteRows = false;
            this.dgv_gQuery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_gQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_gQuery.Location = new System.Drawing.Point(6, 25);
            this.dgv_gQuery.Name = "dgv_gQuery";
            this.dgv_gQuery.ReadOnly = true;
            this.dgv_gQuery.RowHeadersVisible = false;
            this.dgv_gQuery.Size = new System.Drawing.Size(268, 302);
            this.dgv_gQuery.TabIndex = 0;
            this.dgv_gQuery.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_gQuery_CellDoubleClick);
            // 
            // cb_group
            // 
            this.cb_group.AutoSize = true;
            this.cb_group.Location = new System.Drawing.Point(370, 432);
            this.cb_group.Name = "cb_group";
            this.cb_group.Size = new System.Drawing.Size(71, 24);
            this.cb_group.TabIndex = 3;
            this.cb_group.Text = "Active";
            this.cb_group.UseVisualStyleBackColor = true;
            // 
            // btn_role_save
            // 
            this.btn_role_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_role_save.Location = new System.Drawing.Point(208, 432);
            this.btn_role_save.Name = "btn_role_save";
            this.btn_role_save.Size = new System.Drawing.Size(75, 30);
            this.btn_role_save.TabIndex = 4;
            this.btn_role_save.Text = "Save";
            this.btn_role_save.UseVisualStyleBackColor = true;
            this.btn_role_save.Click += new System.EventHandler(this.btn_role_save_Click);
            // 
            // btn_role_clear
            // 
            this.btn_role_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_role_clear.Location = new System.Drawing.Point(289, 432);
            this.btn_role_clear.Name = "btn_role_clear";
            this.btn_role_clear.Size = new System.Drawing.Size(75, 30);
            this.btn_role_clear.TabIndex = 5;
            this.btn_role_clear.Text = "Clear";
            this.btn_role_clear.UseVisualStyleBackColor = true;
            this.btn_role_clear.Click += new System.EventHandler(this.btn_role_clear_Click);
            // 
            // btn_role_delete
            // 
            this.btn_role_delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_role_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_role_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_role_delete.Location = new System.Drawing.Point(705, 432);
            this.btn_role_delete.Name = "btn_role_delete";
            this.btn_role_delete.Size = new System.Drawing.Size(75, 30);
            this.btn_role_delete.TabIndex = 6;
            this.btn_role_delete.Text = "Delete";
            this.btn_role_delete.UseVisualStyleBackColor = false;
            this.btn_role_delete.Click += new System.EventHandler(this.btn_role_delete_Click);
            // 
            // role_id
            // 
            this.role_id.AutoSize = true;
            this.role_id.Location = new System.Drawing.Point(678, 432);
            this.role_id.Name = "role_id";
            this.role_id.Size = new System.Drawing.Size(21, 20);
            this.role_id.TabIndex = 4;
            this.role_id.Text = "id";
            this.role_id.Visible = false;
            // 
            // roleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.role_id);
            this.Controls.Add(this.btn_role_delete);
            this.Controls.Add(this.btn_role_clear);
            this.Controls.Add(this.btn_role_save);
            this.Controls.Add(this.cb_group);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.dgv_role);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "roleForm";
            this.Text = "Role Manager";
            this.Load += new System.EventHandler(this.roleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).EndInit();
            this.Group.ResumeLayout(false);
            this.Group.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_gQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_role;
        private System.Windows.Forms.GroupBox Group;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_gQuery;
        private System.Windows.Forms.TextBox in_groupnote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox in_groupname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowgroup;
        private System.Windows.Forms.CheckBox cb_group;
        private System.Windows.Forms.Button btn_role_save;
        private System.Windows.Forms.Button btn_role_clear;
        private System.Windows.Forms.Button btn_role_delete;
        private System.Windows.Forms.Label role_id;
    }
}