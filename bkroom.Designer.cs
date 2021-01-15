namespace WindowsFormsApp8
{
    partial class bkroom
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
            this.label5 = new System.Windows.Forms.Label();
            this.btn_bkrm = new System.Windows.Forms.Button();
            this.grid_tables = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tables)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Available Rooms";
            // 
            // btn_bkrm
            // 
            this.btn_bkrm.Location = new System.Drawing.Point(134, 277);
            this.btn_bkrm.Name = "btn_bkrm";
            this.btn_bkrm.Size = new System.Drawing.Size(120, 23);
            this.btn_bkrm.TabIndex = 32;
            this.btn_bkrm.Text = "Book Room";
            this.btn_bkrm.UseVisualStyleBackColor = true;
            this.btn_bkrm.Click += new System.EventHandler(this.btn_bkrm_Click);
            // 
            // grid_tables
            // 
            this.grid_tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tables.Location = new System.Drawing.Point(63, 110);
            this.grid_tables.Name = "grid_tables";
            this.grid_tables.Size = new System.Drawing.Size(240, 134);
            this.grid_tables.TabIndex = 33;
            this.grid_tables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tables_CellContentClick);
            this.grid_tables.SelectionChanged += new System.EventHandler(this.grid_tables_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(381, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // bkroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 356);
            this.Controls.Add(this.grid_tables);
            this.Controls.Add(this.btn_bkrm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bkroom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "bkroom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bkroom_FormClosing);
            this.Load += new System.EventHandler(this.bkroom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tables)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_bkrm;
        private System.Windows.Forms.DataGridView grid_tables;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}