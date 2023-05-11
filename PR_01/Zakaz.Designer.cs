namespace PR_01
{
    partial class Zakaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zakaz));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Qiantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.post = new System.Windows.Forms.ComboBox();
            this.Zakazat = new System.Windows.Forms.Button();
            this.ClientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(112, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите Название продукта*";
            // 
            // Name
            // 
            this.Name.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Name.FormattingEnabled = true;
            this.Name.Items.AddRange(new object[] {
            "Поплин «Розовый жемчуг»",
            "Муслин «Bej»",
            "Муслин «Gri»",
            "Бязь детская «Совята»",
            "Полотно вафельное «8 марта»",
            "Сатин «Миндальный» однотонный",
            "Плюш розовый гладкий",
            "Поплин Мокко",
            "Фланель черная",
            "Плюш белый в клетку",
            "Фланель однотонная светлая",
            "Поплин Морская волна",
            "Сатин «Дымчатая роза» однотонный",
            "Фланель рубашечная",
            "Ткань поплин «Натурель»",
            "Поплин Голубой",
            "Фланель рубашечная",
            "Фланель детская H483D9",
            "Ткань для скатертей под рогожку",
            "Сатин «Серо-бежевый» однотонный",
            "Муслин белый горошек на однотонном фоне",
            "Ситец детский",
            "Ткань поплин «Лакшери»",
            "Поплин «Густав»",
            "Ситец детский",
            "Сатин «Фисташковый» однотонный",
            "Бязь детская «Самолеты»",
            "Полотно вафельное «Кухня»",
            "Ткань поплин «Вивьен»"});
            this.Name.Location = new System.Drawing.Point(12, 84);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(308, 31);
            this.Name.TabIndex = 2;
            this.Name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество";
            // 
            // Qiantity
            // 
            this.Qiantity.BackColor = System.Drawing.Color.White;
            this.Qiantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Qiantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Qiantity.Location = new System.Drawing.Point(14, 160);
            this.Qiantity.Multiline = true;
            this.Qiantity.Name = "Qiantity";
            this.Qiantity.Size = new System.Drawing.Size(306, 34);
            this.Qiantity.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите свое ФИО";
            // 
            // FIO
            // 
            this.FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.FIO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.FIO.Location = new System.Drawing.Point(12, 235);
            this.FIO.Multiline = true;
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(306, 34);
            this.FIO.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Выберите пункт выдачи*";
            // 
            // post
            // 
            this.post.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F);
            this.post.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.post.FormattingEnabled = true;
            this.post.Items.AddRange(new object[] {
            "ул., Чехова, 1",
            "ул., Степная, 30",
            "ул., Коммунистическая, 25",
            "ул., Шоссейная, 40",
            "ул., Партизанская, 49",
            "ул., Победы, 46",
            "ул., Молодежная, 50",
            "ул., Новая, 19",
            "ул.,Садовая, 4",
            "ул., Комсомольская, 26",
            "ул., Чехова, 3",
            " ул., Дзержинского, 28",
            "ул., Набережная, 30",
            "ул., Фрунзе, 43",
            "ул.,  Школьная, 50",
            "ул., 8 Марта, 32",
            "ул., Зеленая, 47",
            "ул., Маяковского, 46",
            "ул.,  Цветочная, 1"});
            this.post.Location = new System.Drawing.Point(12, 314);
            this.post.Name = "post";
            this.post.Size = new System.Drawing.Size(308, 31);
            this.post.TabIndex = 8;
            // 
            // Zakazat
            // 
            this.Zakazat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Zakazat.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Zakazat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.Zakazat.Location = new System.Drawing.Point(69, 354);
            this.Zakazat.Name = "Zakazat";
            this.Zakazat.Size = new System.Drawing.Size(201, 53);
            this.Zakazat.TabIndex = 9;
            this.Zakazat.Text = "Заказать";
            this.Zakazat.UseVisualStyleBackColor = false;
            this.Zakazat.Click += new System.EventHandler(this.Zakazat_Click);
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientName.ForeColor = System.Drawing.SystemColors.Control;
            this.ClientName.Location = new System.Drawing.Point(218, 9);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(0, 16);
            this.ClientName.TabIndex = 10;
            // 
            // Zakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 421);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.Zakazat);
            this.Controls.Add(this.post);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Qiantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Text = "Zakaz";
            this.Load += new System.EventHandler(this.Zakaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Qiantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox post;
        private System.Windows.Forms.Button Zakazat;
        private System.Windows.Forms.Label ClientName;
    }
}