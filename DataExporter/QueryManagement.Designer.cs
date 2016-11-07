namespace DataExporter
{
    partial class QueryManagement
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
            this.dgv_querylist = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.query_id = new System.Windows.Forms.Label();
            this.cb_query = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.in_query = new System.Windows.Forms.TextBox();
            this.in_query_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addparam = new System.Windows.Forms.Button();
            this.flowparam = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_paramtype = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_querylist)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_querylist
            // 
            this.dgv_querylist.AllowUserToAddRows = false;
            this.dgv_querylist.AllowUserToDeleteRows = false;
            this.dgv_querylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_querylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_querylist.Location = new System.Drawing.Point(0, 0);
            this.dgv_querylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_querylist.Name = "dgv_querylist";
            this.dgv_querylist.ReadOnly = true;
            this.dgv_querylist.RowHeadersVisible = false;
            this.dgv_querylist.Size = new System.Drawing.Size(218, 458);
            this.dgv_querylist.TabIndex = 0;
            this.dgv_querylist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_querylist_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.query_id);
            this.groupBox1.Controls.Add(this.cb_query);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.in_query);
            this.groupBox1.Controls.Add(this.in_query_title);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(226, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(555, 144);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query Properties";
            // 
            // query_id
            // 
            this.query_id.AutoSize = true;
            this.query_id.Location = new System.Drawing.Point(158, 117);
            this.query_id.Name = "query_id";
            this.query_id.Size = new System.Drawing.Size(21, 20);
            this.query_id.TabIndex = 6;
            this.query_id.Text = "id";
            this.query_id.Visible = false;
            // 
            // cb_query
            // 
            this.cb_query.AutoSize = true;
            this.cb_query.Location = new System.Drawing.Point(104, 116);
            this.cb_query.Name = "cb_query";
            this.cb_query.Size = new System.Drawing.Size(48, 24);
            this.cb_query.TabIndex = 5;
            this.cb_query.Text = "No";
            this.cb_query.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Active :";
            // 
            // in_query
            // 
            this.in_query.Location = new System.Drawing.Point(104, 56);
            this.in_query.Multiline = true;
            this.in_query.Name = "in_query";
            this.in_query.Size = new System.Drawing.Size(441, 54);
            this.in_query.TabIndex = 3;
            // 
            // in_query_title
            // 
            this.in_query_title.Location = new System.Drawing.Point(104, 21);
            this.in_query_title.Name = "in_query_title";
            this.in_query_title.Size = new System.Drawing.Size(441, 26);
            this.in_query_title.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Query :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Script Title :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_addparam);
            this.groupBox2.Controls.Add(this.flowparam);
            this.groupBox2.Controls.Add(this.cb_paramtype);
            this.groupBox2.Location = new System.Drawing.Point(226, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 267);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Parameter";
            // 
            // btn_addparam
            // 
            this.btn_addparam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addparam.Location = new System.Drawing.Point(308, 25);
            this.btn_addparam.Name = "btn_addparam";
            this.btn_addparam.Size = new System.Drawing.Size(105, 28);
            this.btn_addparam.TabIndex = 1;
            this.btn_addparam.Text = "Add Param";
            this.btn_addparam.UseVisualStyleBackColor = true;
            this.btn_addparam.Click += new System.EventHandler(this.btn_addparam_Click);
            // 
            // flowparam
            // 
            this.flowparam.AutoScroll = true;
            this.flowparam.Location = new System.Drawing.Point(11, 59);
            this.flowparam.Name = "flowparam";
            this.flowparam.Size = new System.Drawing.Size(534, 202);
            this.flowparam.TabIndex = 3;
            // 
            // cb_paramtype
            // 
            this.cb_paramtype.FormattingEnabled = true;
            this.cb_paramtype.Items.AddRange(new object[] {
            "Text Box",
            "Drop Down"});
            this.cb_paramtype.Location = new System.Drawing.Point(11, 25);
            this.cb_paramtype.Name = "cb_paramtype";
            this.cb_paramtype.Size = new System.Drawing.Size(291, 28);
            this.cb_paramtype.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(226, 427);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(83, 31);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(315, 427);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(83, 31);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Maroon;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(698, 427);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 31);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // QueryManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(786, 462);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_querylist);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QueryManagement";
            this.Text = "QueryManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_querylist)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_querylist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_query;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox in_query;
        private System.Windows.Forms.TextBox in_query_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addparam;
        private System.Windows.Forms.ComboBox cb_paramtype;
        private System.Windows.Forms.FlowLayoutPanel flowparam;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label query_id;
    }
}