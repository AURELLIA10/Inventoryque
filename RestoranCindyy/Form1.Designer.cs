namespace RestoranCindyy
{
    partial class Form1
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
            this.NEW = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.harga = new System.Windows.Forms.TextBox();
            this.EDIT = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.TextBox();
            this.LOAD_DATA = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stok = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NEW
            // 
            this.NEW.Location = new System.Drawing.Point(316, 328);
            this.NEW.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(91, 35);
            this.NEW.TabIndex = 0;
            this.NEW.Text = "NEW";
            this.NEW.UseVisualStyleBackColor = true;
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 428);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(959, 226);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Barang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.harga);
            this.panel1.Controls.Add(this.EDIT);
            this.panel1.Controls.Add(this.DELETE);
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.LOAD_DATA);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.NEW);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.stok);
            this.panel1.Controls.Add(this.kategori);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nama);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 412);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 18;
            // 
            // harga
            // 
            this.harga.Location = new System.Drawing.Point(316, 275);
            this.harga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(443, 26);
            this.harga.TabIndex = 17;
            this.harga.TextChanged += new System.EventHandler(this.harga_Changed);
            // 
            // EDIT
            // 
            this.EDIT.Location = new System.Drawing.Point(668, 328);
            this.EDIT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(91, 35);
            this.EDIT.TabIndex = 9;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // DELETE
            // 
            this.DELETE.Location = new System.Drawing.Point(552, 328);
            this.DELETE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(91, 35);
            this.DELETE.TabIndex = 11;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(316, 223);
            this.stock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(443, 26);
            this.stock.TabIndex = 16;
            this.stock.TextChanged += new System.EventHandler(this.stock_TextChanged);
            // 
            // LOAD_DATA
            // 
            this.LOAD_DATA.Location = new System.Drawing.Point(433, 328);
            this.LOAD_DATA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LOAD_DATA.Name = "LOAD_DATA";
            this.LOAD_DATA.Size = new System.Drawing.Size(91, 35);
            this.LOAD_DATA.TabIndex = 8;
            this.LOAD_DATA.Text = "LOAD DATA";
            this.LOAD_DATA.UseVisualStyleBackColor = true;
            this.LOAD_DATA.Click += new System.EventHandler(this.LOAD_DATA_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Harga";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.Location = new System.Drawing.Point(316, 70);
            this.id.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(443, 26);
            this.id.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(197, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "ID Barang";
            this.label11.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Schofield Outline", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(357, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 50);
            this.label4.TabIndex = 12;
            this.label4.Text = "Inventory Beaustyle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // stok
            // 
            this.stok.AutoSize = true;
            this.stok.Location = new System.Drawing.Point(197, 226);
            this.stok.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(50, 20);
            this.stok.TabIndex = 6;
            this.stok.Text = "Stock";
            this.stok.Click += new System.EventHandler(this.stok_Click);
            // 
            // kategori
            // 
            this.kategori.Location = new System.Drawing.Point(316, 173);
            this.kategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(443, 26);
            this.kategori.TabIndex = 5;
            this.kategori.TextChanged += new System.EventHandler(this.harga_jual_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategori";
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.SystemColors.Window;
            this.nama.Location = new System.Drawing.Point(316, 122);
            this.nama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(443, 26);
            this.nama.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1000, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NEW;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stok;
        private System.Windows.Forms.TextBox kategori;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button LOAD_DATA;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.TextBox stock;
        private System.Windows.Forms.Label label5;
    }
}

