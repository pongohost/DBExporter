namespace DataExporter
{
    partial class logViewer
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
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_now = new System.Windows.Forms.TextBox();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cb_limit = new MetroFramework.Controls.MetroComboBox();
            this.dgv_log = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_log)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_total
            // 
            this.txt_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Location = new System.Drawing.Point(660, 8);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(40, 26);
            this.txt_total.TabIndex = 17;
            // 
            // txt_now
            // 
            this.txt_now.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_now.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_now.Location = new System.Drawing.Point(599, 8);
            this.txt_now.Name = "txt_now";
            this.txt_now.Size = new System.Drawing.Size(40, 26);
            this.txt_now.TabIndex = 16;
            this.txt_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prev.BackgroundImage = global::DataExporter.Properties.Resources.Prev;
            this.btn_prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_prev.FlatAppearance.BorderSize = 0;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Location = new System.Drawing.Point(563, 7);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(30, 30);
            this.btn_prev.TabIndex = 14;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.BackgroundImage = global::DataExporter.Properties.Resources.Next;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(706, 8);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(30, 30);
            this.btn_next.TabIndex = 13;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_last.BackgroundImage = global::DataExporter.Properties.Resources.LastPage;
            this.btn_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_last.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_last.FlatAppearance.BorderSize = 0;
            this.btn_last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_last.Location = new System.Drawing.Point(742, 8);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(30, 30);
            this.btn_last.TabIndex = 12;
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_first
            // 
            this.btn_first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_first.BackgroundImage = global::DataExporter.Properties.Resources.FirstPage;
            this.btn_first.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_first.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_first.FlatAppearance.BorderSize = 0;
            this.btn_first.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first.Location = new System.Drawing.Point(527, 7);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(30, 30);
            this.btn_first.TabIndex = 11;
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_search.Location = new System.Drawing.Point(12, 10);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(256, 26);
            this.txt_search.TabIndex = 10;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BackgroundImage = global::DataExporter.Properties.Resources.search;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(274, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(30, 30);
            this.btn_search.TabIndex = 15;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackgroundImage = global::DataExporter.Properties.Resources.refresh;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Location = new System.Drawing.Point(310, 6);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(30, 30);
            this.btn_refresh.TabIndex = 18;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cb_limit
            // 
            this.cb_limit.FormattingEnabled = true;
            this.cb_limit.ItemHeight = 23;
            this.cb_limit.Items.AddRange(new object[] {
            "25",
            "50",
            "100",
            "500",
            "1000",
            "All"});
            this.cb_limit.Location = new System.Drawing.Point(346, 6);
            this.cb_limit.Name = "cb_limit";
            this.cb_limit.Size = new System.Drawing.Size(175, 29);
            this.cb_limit.TabIndex = 19;
            this.cb_limit.UseSelectable = true;
            // 
            // dgv_log
            // 
            this.dgv_log.AllowUserToAddRows = false;
            this.dgv_log.AllowUserToDeleteRows = false;
            this.dgv_log.AllowUserToOrderColumns = true;
            this.dgv_log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_log.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_log.Location = new System.Drawing.Point(12, 55);
            this.dgv_log.MultiSelect = false;
            this.dgv_log.Name = "dgv_log";
            this.dgv_log.ReadOnly = true;
            this.dgv_log.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_log.RowHeadersVisible = false;
            this.dgv_log.Size = new System.Drawing.Size(760, 395);
            this.dgv_log.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(645, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "/";
            // 
            // logViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_log);
            this.Controls.Add(this.cb_limit);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_now);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.txt_search);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "logViewer";
            this.Text = "Log Viewer";
            this.Load += new System.EventHandler(this.logViewer_load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_log)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_now;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_refresh;
        private MetroFramework.Controls.MetroComboBox cb_limit;
        private System.Windows.Forms.DataGridView dgv_log;
        private System.Windows.Forms.Label label1;
    }
}