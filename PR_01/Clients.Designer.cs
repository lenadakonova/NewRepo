namespace PR_01
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Gostname = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Zakaz = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.clientname = new System.Windows.Forms.ToolStripButton();
            this.Text_Search = new System.Windows.Forms.ToolStripTextBox();
            this.Search = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Ub = new System.Windows.Forms.ToolStripButton();
            this.Voz = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Zakaz,
            this.toolStripButton1,
            this.Gostname,
            this.Text_Search,
            this.Search,
            this.toolStripLabel1,
            this.Ub,
            this.Voz,
            this.clientname});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1056, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Gostname
            // 
            this.Gostname.Name = "Gostname";
            this.Gostname.Size = new System.Drawing.Size(0, 28);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 491);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Zakaz
            // 
            this.Zakaz.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zakaz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Zakaz.Image = ((System.Drawing.Image)(resources.GetObject("Zakaz.Image")));
            this.Zakaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Zakaz.Name = "Zakaz";
            this.Zakaz.Size = new System.Drawing.Size(94, 28);
            this.Zakaz.Text = "Заказать";
            this.Zakaz.Click += new System.EventHandler(this.Zakaz_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(77, 28);
            this.toolStripButton1.Text = "Назад";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // clientname
            // 
            this.clientname.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clientname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.clientname.Image = ((System.Drawing.Image)(resources.GetObject("clientname.Image")));
            this.clientname.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clientname.Name = "clientname";
            this.clientname.Size = new System.Drawing.Size(29, 28);
            // 
            // Text_Search
            // 
            this.Text_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Text_Search.Name = "Text_Search";
            this.Text_Search.Size = new System.Drawing.Size(100, 31);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(80, 28);
            this.Search.Text = "Найти";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(133, 28);
            this.toolStripLabel1.Text = "Сортировать ПО:";
            // 
            // Ub
            // 
            this.Ub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Ub.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Ub.Image = ((System.Drawing.Image)(resources.GetObject("Ub.Image")));
            this.Ub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ub.Name = "Ub";
            this.Ub.Size = new System.Drawing.Size(135, 28);
            this.Ub.Text = "Убыванию Цены";
            this.Ub.Click += new System.EventHandler(this.Ub_Click);
            // 
            // Voz
            // 
            this.Voz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Voz.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Voz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Voz.Image = ((System.Drawing.Image)(resources.GetObject("Voz.Image")));
            this.Voz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Voz.Name = "Voz";
            this.Voz.Size = new System.Drawing.Size(153, 28);
            this.Voz.Text = "Возрастанию Цены";
            this.Voz.Click += new System.EventHandler(this.Voz_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 523);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Zakaz;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton clientname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel Gostname;
        private System.Windows.Forms.ToolStripTextBox Text_Search;
        private System.Windows.Forms.ToolStripButton Search;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton Ub;
        private System.Windows.Forms.ToolStripButton Voz;
    }
}