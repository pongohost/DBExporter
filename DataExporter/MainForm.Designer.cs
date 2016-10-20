namespace DataExporter
{
    partial class MainForm
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
            this.menu_top = new System.Windows.Forms.MenuStrip();
            this.dBConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gv_data = new System.Windows.Forms.DataGridView();
            this.cb_query = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.PictureBox();
            this.flow_holder = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_excel = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menu_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_top
            // 
            this.menu_top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBConfigurationToolStripMenuItem});
            this.menu_top.Location = new System.Drawing.Point(0, 0);
            this.menu_top.Name = "menu_top";
            this.menu_top.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menu_top.Size = new System.Drawing.Size(426, 25);
            this.menu_top.TabIndex = 0;
            this.menu_top.Text = "menuStrip1";
            // 
            // dBConfigurationToolStripMenuItem
            // 
            this.dBConfigurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dBToolStripMenuItem});
            this.dBConfigurationToolStripMenuItem.Name = "dBConfigurationToolStripMenuItem";
            this.dBConfigurationToolStripMenuItem.Size = new System.Drawing.Size(93, 19);
            this.dBConfigurationToolStripMenuItem.Text = "Configuration";
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(89, 22);
            this.dBToolStripMenuItem.Text = "DB";
            this.dBToolStripMenuItem.Click += new System.EventHandler(this.dBToolStripMenuItem_Click);
            // 
            // gv_data
            // 
            this.gv_data.AllowUserToAddRows = false;
            this.gv_data.AllowUserToDeleteRows = false;
            this.gv_data.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_data.Location = new System.Drawing.Point(13, 266);
            this.gv_data.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gv_data.Name = "gv_data";
            this.gv_data.Size = new System.Drawing.Size(400, 337);
            this.gv_data.TabIndex = 1;
            // 
            // cb_query
            // 
            this.cb_query.FormattingEnabled = true;
            this.cb_query.Location = new System.Drawing.Point(13, 32);
            this.cb_query.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_query.Name = "cb_query";
            this.cb_query.Size = new System.Drawing.Size(356, 28);
            this.cb_query.TabIndex = 3;
            this.cb_query.SelectionChangeCommitted += new System.EventHandler(this.cb_query_SelectionChangeCommitted);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Image = global::DataExporter.Properties.Resources.arrow_refresh;
            this.btn_refresh.Location = new System.Drawing.Point(383, 30);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(30, 30);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.TabStop = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // flow_holder
            // 
            this.flow_holder.AutoScroll = true;
            this.flow_holder.Location = new System.Drawing.Point(13, 68);
            this.flow_holder.Name = "flow_holder";
            this.flow_holder.Size = new System.Drawing.Size(400, 154);
            this.flow_holder.TabIndex = 5;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(13, 228);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(79, 30);
            this.btn_load.TabIndex = 6;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.Location = new System.Drawing.Point(98, 229);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(134, 29);
            this.btn_excel.TabIndex = 7;
            this.btn_excel.Text = "Export to Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "File Excel|*.xlsx";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 612);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.flow_holder);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.cb_query);
            this.Controls.Add(this.gv_data);
            this.Controls.Add(this.menu_top);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menu_top;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "DataExporter";
            this.menu_top.ResumeLayout(false);
            this.menu_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_top;
        private System.Windows.Forms.ToolStripMenuItem dBConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        private System.Windows.Forms.DataGridView gv_data;
        private System.Windows.Forms.ComboBox cb_query;
        private System.Windows.Forms.PictureBox btn_refresh;
        private System.Windows.Forms.FlowLayoutPanel flow_holder;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

