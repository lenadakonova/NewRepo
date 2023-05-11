namespace PR_01
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.clientname = new System.Windows.Forms.Label();
            this.ProductImage = new System.Windows.Forms.PictureBox();
            this.PropuctName = new System.Windows.Forms.Label();
            this.Discription = new System.Windows.Forms.Label();
            this.Manuf = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.ProductQuantity = new System.Windows.Forms.Label();
            this.NamePhoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // clientname
            // 
            this.clientname.AutoSize = true;
            this.clientname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientname.Location = new System.Drawing.Point(563, 10);
            this.clientname.Name = "clientname";
            this.clientname.Size = new System.Drawing.Size(0, 20);
            this.clientname.TabIndex = 1;
            // 
            // ProductImage
            // 
            this.ProductImage.Location = new System.Drawing.Point(25, 84);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(186, 156);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductImage.TabIndex = 2;
            this.ProductImage.TabStop = false;
            // 
            // PropuctName
            // 
            this.PropuctName.AutoSize = true;
            this.PropuctName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PropuctName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.PropuctName.Location = new System.Drawing.Point(222, 80);
            this.PropuctName.Name = "PropuctName";
            this.PropuctName.Size = new System.Drawing.Size(224, 25);
            this.PropuctName.TabIndex = 3;
            this.PropuctName.Text = "Наименование товара:";
            // 
            // Discription
            // 
            this.Discription.AutoSize = true;
            this.Discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Discription.Location = new System.Drawing.Point(220, 118);
            this.Discription.Name = "Discription";
            this.Discription.Size = new System.Drawing.Size(108, 25);
            this.Discription.TabIndex = 4;
            this.Discription.Text = "Описание:";
            // 
            // Manuf
            // 
            this.Manuf.AutoSize = true;
            this.Manuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Manuf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Manuf.Location = new System.Drawing.Point(222, 155);
            this.Manuf.Name = "Manuf";
            this.Manuf.Size = new System.Drawing.Size(165, 25);
            this.Manuf.TabIndex = 5;
            this.Manuf.Text = "Производитель:";
            this.Manuf.Click += new System.EventHandler(this.Manuf_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Price.Location = new System.Drawing.Point(222, 194);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(64, 25);
            this.Price.TabIndex = 6;
            this.Price.Text = "Цена:";
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.AutoSize = true;
            this.ProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.ProductQuantity.Location = new System.Drawing.Point(222, 229);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(194, 25);
            this.ProductQuantity.TabIndex = 7;
            this.ProductQuantity.Text = "Остаток на складе:";
            // 
            // NamePhoto
            // 
            this.NamePhoto.AutoSize = true;
            this.NamePhoto.Location = new System.Drawing.Point(31, 257);
            this.NamePhoto.Name = "NamePhoto";
            this.NamePhoto.Size = new System.Drawing.Size(0, 16);
            this.NamePhoto.TabIndex = 8;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 571);
            this.Controls.Add(this.NamePhoto);
            this.Controls.Add(this.ProductQuantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Manuf);
            this.Controls.Add(this.Discription);
            this.Controls.Add(this.PropuctName);
            this.Controls.Add(this.ProductImage);
            this.Controls.Add(this.clientname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "ООО Ткани";
            this.Load += new System.EventHandler(this.Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientname;
        private System.Windows.Forms.PictureBox ProductImage;
        private System.Windows.Forms.Label PropuctName;
        private System.Windows.Forms.Label Discription;
        private System.Windows.Forms.Label Manuf;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label ProductQuantity;
        private System.Windows.Forms.Label NamePhoto;
    }
}