namespace THA_W5_APLIKASI_BAJU
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dgvmain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnall = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.comboboxfilter = new System.Windows.Forms.ComboBox();
            this.dgvkategori = new System.Windows.Forms.DataGridView();
            this.Kategori = new System.Windows.Forms.Label();
            this.btnaddkategori = new System.Windows.Forms.Button();
            this.btnremovekategori = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxnamabaru = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.comboboxkategori = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.lisa = new System.Windows.Forms.PictureBox();
            this.dgvfilter = new System.Windows.Forms.DataGridView();
            this.info = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gambar = new System.Windows.Forms.Button();
            this.jiso = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.stok = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiso)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmain
            // 
            this.dgvmain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmain.Location = new System.Drawing.Point(23, 49);
            this.dgvmain.Name = "dgvmain";
            this.dgvmain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmain.Size = new System.Drawing.Size(462, 242);
            this.dgvmain.TabIndex = 0;
            this.dgvmain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmain_CellClick);
            this.dgvmain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmain_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product :";
            // 
            // btnall
            // 
            this.btnall.Location = new System.Drawing.Point(236, 13);
            this.btnall.Name = "btnall";
            this.btnall.Size = new System.Drawing.Size(57, 23);
            this.btnall.TabIndex = 2;
            this.btnall.Text = "ALL";
            this.btnall.UseVisualStyleBackColor = true;
            this.btnall.Click += new System.EventHandler(this.btnall_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.Location = new System.Drawing.Point(299, 13);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(58, 23);
            this.btnfilter.TabIndex = 3;
            this.btnfilter.Text = "FILTER";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // comboboxfilter
            // 
            this.comboboxfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxfilter.Enabled = false;
            this.comboboxfilter.FormattingEnabled = true;
            this.comboboxfilter.Location = new System.Drawing.Point(364, 13);
            this.comboboxfilter.Name = "comboboxfilter";
            this.comboboxfilter.Size = new System.Drawing.Size(121, 21);
            this.comboboxfilter.TabIndex = 4;
            this.comboboxfilter.SelectedIndexChanged += new System.EventHandler(this.comboboxfilter_SelectedIndexChanged);
            this.comboboxfilter.SelectionChangeCommitted += new System.EventHandler(this.comboboxfilter_SelectionChangeCommitted);
            this.comboboxfilter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboboxfilter_MouseClick);
            // 
            // dgvkategori
            // 
            this.dgvkategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkategori.Location = new System.Drawing.Point(518, 49);
            this.dgvkategori.Name = "dgvkategori";
            this.dgvkategori.Size = new System.Drawing.Size(257, 152);
            this.dgvkategori.TabIndex = 5;
            this.dgvkategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkategori_CellClick);
            this.dgvkategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkategori_CellContentClick);
            // 
            // Kategori
            // 
            this.Kategori.AutoSize = true;
            this.Kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kategori.Location = new System.Drawing.Point(514, 16);
            this.Kategori.Name = "Kategori";
            this.Kategori.Size = new System.Drawing.Size(81, 20);
            this.Kategori.TabIndex = 6;
            this.Kategori.Text = "Product :";
            // 
            // btnaddkategori
            // 
            this.btnaddkategori.BackColor = System.Drawing.Color.Lime;
            this.btnaddkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddkategori.Location = new System.Drawing.Point(560, 245);
            this.btnaddkategori.Name = "btnaddkategori";
            this.btnaddkategori.Size = new System.Drawing.Size(94, 23);
            this.btnaddkategori.TabIndex = 7;
            this.btnaddkategori.Text = "ADD CATEGORY";
            this.btnaddkategori.UseVisualStyleBackColor = false;
            this.btnaddkategori.Click += new System.EventHandler(this.btnaddkategori_Click);
            // 
            // btnremovekategori
            // 
            this.btnremovekategori.BackColor = System.Drawing.Color.Red;
            this.btnremovekategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremovekategori.Location = new System.Drawing.Point(660, 245);
            this.btnremovekategori.Name = "btnremovekategori";
            this.btnremovekategori.Size = new System.Drawing.Size(115, 23);
            this.btnremovekategori.TabIndex = 8;
            this.btnremovekategori.Text = "REMOVE CATEGORY";
            this.btnremovekategori.UseVisualStyleBackColor = false;
            this.btnremovekategori.Click += new System.EventHandler(this.btnremovekategori_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama :";
            // 
            // txtboxnamabaru
            // 
            this.txtboxnamabaru.Location = new System.Drawing.Point(563, 219);
            this.txtboxnamabaru.Name = "txtboxnamabaru";
            this.txtboxnamabaru.Size = new System.Drawing.Size(212, 20);
            this.txtboxnamabaru.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kategori :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Harga :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stok :";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(81, 309);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(212, 20);
            this.txtnama.TabIndex = 15;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(81, 363);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(212, 20);
            this.txtharga.TabIndex = 17;
            this.txtharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtharga_KeyPress);
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(81, 389);
            this.txtstok.Name = "txtstok";
            this.txtstok.Size = new System.Drawing.Size(212, 20);
            this.txtstok.TabIndex = 18;
            this.txtstok.TextChanged += new System.EventHandler(this.txtstok_TextChanged);
            this.txtstok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstok_KeyPress);
            // 
            // comboboxkategori
            // 
            this.comboboxkategori.FormattingEnabled = true;
            this.comboboxkategori.Location = new System.Drawing.Point(81, 335);
            this.comboboxkategori.Name = "comboboxkategori";
            this.comboboxkategori.Size = new System.Drawing.Size(212, 21);
            this.comboboxkategori.TabIndex = 19;
            this.comboboxkategori.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboboxkategori_KeyPress);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Lime;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(309, 319);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(70, 38);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "ADD PRODUCT";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Fuchsia;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(385, 319);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(70, 38);
            this.btnedit.TabIndex = 21;
            this.btnedit.Text = "EDIT PRODUCT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Red;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(309, 363);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(70, 38);
            this.btnremove.TabIndex = 22;
            this.btnremove.Text = "REMOVE PRODUCT";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // lisa
            // 
            this.lisa.Image = ((System.Drawing.Image)(resources.GetObject("lisa.Image")));
            this.lisa.InitialImage = ((System.Drawing.Image)(resources.GetObject("lisa.InitialImage")));
            this.lisa.Location = new System.Drawing.Point(573, 284);
            this.lisa.Name = "lisa";
            this.lisa.Size = new System.Drawing.Size(174, 181);
            this.lisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lisa.TabIndex = 23;
            this.lisa.TabStop = false;
            // 
            // dgvfilter
            // 
            this.dgvfilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfilter.Enabled = false;
            this.dgvfilter.Location = new System.Drawing.Point(23, 49);
            this.dgvfilter.Name = "dgvfilter";
            this.dgvfilter.Size = new System.Drawing.Size(462, 242);
            this.dgvfilter.TabIndex = 24;
            this.dgvfilter.Visible = false;
            this.dgvfilter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfilter_CellContentClick);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(309, 408);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(35, 13);
            this.info.TabIndex = 25;
            this.info.Text = "label7";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 21);
            this.button1.TabIndex = 26;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gambar
            // 
            this.gambar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.gambar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gambar.Location = new System.Drawing.Point(385, 363);
            this.gambar.Name = "gambar";
            this.gambar.Size = new System.Drawing.Size(70, 38);
            this.gambar.TabIndex = 27;
            this.gambar.Text = "GANTI GAMBAR";
            this.gambar.UseVisualStyleBackColor = false;
            this.gambar.Click += new System.EventHandler(this.gambar_Click);
            // 
            // jiso
            // 
            this.jiso.Image = ((System.Drawing.Image)(resources.GetObject("jiso.Image")));
            this.jiso.InitialImage = ((System.Drawing.Image)(resources.GetObject("jiso.InitialImage")));
            this.jiso.Location = new System.Drawing.Point(573, 284);
            this.jiso.Name = "jiso";
            this.jiso.Size = new System.Drawing.Size(174, 181);
            this.jiso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jiso.TabIndex = 28;
            this.jiso.TabStop = false;
            this.jiso.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(210, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 21);
            this.button2.TabIndex = 29;
            this.button2.Text = "HOME";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stok
            // 
            this.stok.Location = new System.Drawing.Point(27, 456);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(266, 23);
            this.stok.TabIndex = 30;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(838, 534);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.jiso);
            this.Controls.Add(this.gambar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.dgvfilter);
            this.Controls.Add(this.lisa);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.comboboxkategori);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxnamabaru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnremovekategori);
            this.Controls.Add(this.btnaddkategori);
            this.Controls.Add(this.Kategori);
            this.Controls.Add(this.dgvkategori);
            this.Controls.Add(this.comboboxfilter);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.btnall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvmain);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvmain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnall;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.ComboBox comboboxfilter;
        private System.Windows.Forms.DataGridView dgvkategori;
        private System.Windows.Forms.Label Kategori;
        private System.Windows.Forms.Button btnaddkategori;
        private System.Windows.Forms.Button btnremovekategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxnamabaru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txtstok;
        private System.Windows.Forms.ComboBox comboboxkategori;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.PictureBox lisa;
        private System.Windows.Forms.DataGridView dgvfilter;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button gambar;
        private System.Windows.Forms.PictureBox jiso;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar stok;
    }
}