namespace SiteEmlakProgramı
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
            this.label1Gayrimenkul = new System.Windows.Forms.Label();
            this.label2Site = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3satkira = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4oda = new System.Windows.Forms.Label();
            this.label5metrekare = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6fiyat = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label11blok = new System.Windows.Forms.Label();
            this.label12Kat = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13Sema = new System.Windows.Forms.Label();
            this.btnZambak = new System.Windows.Forms.Button();
            this.btnGunes = new System.Windows.Forms.Button();
            this.btnAydın = new System.Windows.Forms.Button();
            this.btnAbant = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1Gayrimenkul
            // 
            this.label1Gayrimenkul.AutoSize = true;
            this.label1Gayrimenkul.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1Gayrimenkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1Gayrimenkul.Location = new System.Drawing.Point(24, 22);
            this.label1Gayrimenkul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1Gayrimenkul.Name = "label1Gayrimenkul";
            this.label1Gayrimenkul.Size = new System.Drawing.Size(127, 16);
            this.label1Gayrimenkul.TabIndex = 0;
            this.label1Gayrimenkul.Text = "Gayrimenkul Bilgiler";
            // 
            // label2Site
            // 
            this.label2Site.AutoSize = true;
            this.label2Site.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label2Site.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2Site.Location = new System.Drawing.Point(26, 94);
            this.label2Site.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2Site.Name = "label2Site";
            this.label2Site.Size = new System.Drawing.Size(39, 16);
            this.label2Site.TabIndex = 1;
            this.label2Site.Text = "Site:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Güneş Sitesi",
            "Aydın Sitesi",
            "Zambak Sitesi",
            "Abant Sitesi"});
            this.comboBox1.Location = new System.Drawing.Point(154, 90);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.comboBox2.Location = new System.Drawing.Point(154, 121);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(118, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // label3satkira
            // 
            this.label3satkira.AutoSize = true;
            this.label3satkira.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label3satkira.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3satkira.Location = new System.Drawing.Point(26, 127);
            this.label3satkira.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3satkira.Name = "label3satkira";
            this.label3satkira.Size = new System.Drawing.Size(103, 16);
            this.label3satkira.TabIndex = 3;
            this.label3satkira.Text = "Satılık/Kiralık:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1+0",
            "1+1",
            "2+1",
            "3+1"});
            this.comboBox3.Location = new System.Drawing.Point(154, 157);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(118, 21);
            this.comboBox3.TabIndex = 6;
            // 
            // label4oda
            // 
            this.label4oda.AutoSize = true;
            this.label4oda.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label4oda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4oda.Location = new System.Drawing.Point(26, 163);
            this.label4oda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4oda.Name = "label4oda";
            this.label4oda.Size = new System.Drawing.Size(88, 16);
            this.label4oda.TabIndex = 5;
            this.label4oda.Text = "Oda Sayısı:";
            // 
            // label5metrekare
            // 
            this.label5metrekare.AutoSize = true;
            this.label5metrekare.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label5metrekare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5metrekare.Location = new System.Drawing.Point(24, 196);
            this.label5metrekare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5metrekare.Name = "label5metrekare";
            this.label5metrekare.Size = new System.Drawing.Size(99, 16);
            this.label5metrekare.TabIndex = 7;
            this.label5metrekare.Text = "Metre Karesi:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 196);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 18);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 234);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 18);
            this.textBox2.TabIndex = 10;
            // 
            // label6fiyat
            // 
            this.label6fiyat.AutoSize = true;
            this.label6fiyat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6fiyat.Location = new System.Drawing.Point(24, 234);
            this.label6fiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6fiyat.Name = "label6fiyat";
            this.label6fiyat.Size = new System.Drawing.Size(46, 16);
            this.label6fiyat.TabIndex = 9;
            this.label6fiyat.Text = "Fiyat:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(469, 140);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 112);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(251, -163);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 18);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(251, -121);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 18);
            this.textBox5.TabIndex = 17;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.comboBox4.Location = new System.Drawing.Point(154, 267);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(118, 21);
            this.comboBox4.TabIndex = 19;
            // 
            // label11blok
            // 
            this.label11blok.AutoSize = true;
            this.label11blok.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label11blok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11blok.Location = new System.Drawing.Point(26, 272);
            this.label11blok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11blok.Name = "label11blok";
            this.label11blok.Size = new System.Drawing.Size(43, 16);
            this.label11blok.TabIndex = 18;
            this.label11blok.Text = "Blok:";
            // 
            // label12Kat
            // 
            this.label12Kat.AutoSize = true;
            this.label12Kat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label12Kat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12Kat.Location = new System.Drawing.Point(26, 308);
            this.label12Kat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12Kat.Name = "label12Kat";
            this.label12Kat.Size = new System.Drawing.Size(34, 16);
            this.label12Kat.TabIndex = 20;
            this.label12Kat.Text = "Kat:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(154, 303);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(118, 18);
            this.textBox6.TabIndex = 21;
            // 
            // label13Sema
            // 
            this.label13Sema.AutoSize = true;
            this.label13Sema.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label13Sema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13Sema.Location = new System.Drawing.Point(778, 196);
            this.label13Sema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13Sema.Name = "label13Sema";
            this.label13Sema.Size = new System.Drawing.Size(38, 16);
            this.label13Sema.TabIndex = 22;
            this.label13Sema.Text = "SİTE";
            // 
            // btnZambak
            // 
            this.btnZambak.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnZambak.Location = new System.Drawing.Point(674, 182);
            this.btnZambak.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnZambak.Name = "btnZambak";
            this.btnZambak.Size = new System.Drawing.Size(83, 48);
            this.btnZambak.TabIndex = 25;
            this.btnZambak.Text = "Zambak";
            this.btnZambak.UseVisualStyleBackColor = false;
            // 
            // btnGunes
            // 
            this.btnGunes.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnGunes.Location = new System.Drawing.Point(752, 235);
            this.btnGunes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGunes.Name = "btnGunes";
            this.btnGunes.Size = new System.Drawing.Size(83, 48);
            this.btnGunes.TabIndex = 26;
            this.btnGunes.Text = "Güneş";
            this.btnGunes.UseVisualStyleBackColor = false;
            // 
            // btnAydın
            // 
            this.btnAydın.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAydın.Location = new System.Drawing.Point(752, 133);
            this.btnAydın.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAydın.Name = "btnAydın";
            this.btnAydın.Size = new System.Drawing.Size(83, 48);
            this.btnAydın.TabIndex = 27;
            this.btnAydın.Text = "Aydın";
            this.btnAydın.UseVisualStyleBackColor = false;
            // 
            // btnAbant
            // 
            this.btnAbant.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnAbant.Location = new System.Drawing.Point(832, 182);
            this.btnAbant.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAbant.Name = "btnAbant";
            this.btnAbant.Size = new System.Drawing.Size(83, 48);
            this.btnAbant.TabIndex = 28;
            this.btnAbant.Text = "Abant";
            this.btnAbant.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 348);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(710, 166);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Site";
            this.columnHeader2.Width = 51;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oda Sayısı";
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Metre";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Fiyat";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Blok";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "No";
            this.columnHeader7.Width = 48;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ad Soyad";
            this.columnHeader8.Width = 72;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Telefon";
            this.columnHeader9.Width = 73;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Ek Açıklama";
            this.columnHeader10.Width = 87;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Satlk/Kira";
            this.columnHeader11.Width = 68;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoruntule.Location = new System.Drawing.Point(781, 348);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(75, 23);
            this.btnGoruntule.TabIndex = 30;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseMnemonic = false;
            this.btnGoruntule.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(781, 391);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 31;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseMnemonic = false;
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(781, 433);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 32;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseMnemonic = false;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(781, 477);
            this.btnSil.Name = "btnSil";
            this.btnSil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 33;
            this.btnSil.Text = "Sil";
            this.btnSil.UseMnemonic = false;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "label3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(930, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAbant);
            this.Controls.Add(this.btnAydın);
            this.Controls.Add(this.btnGunes);
            this.Controls.Add(this.btnZambak);
            this.Controls.Add(this.label13Sema);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label12Kat);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label11blok);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6fiyat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5metrekare);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4oda);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3satkira);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2Site);
            this.Controls.Add(this.label1Gayrimenkul);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form2";
            this.Text = "Gayrimenkul";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Gayrimenkul;
        private System.Windows.Forms.Label label2Site;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3satkira;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4oda;
        private System.Windows.Forms.Label label5metrekare;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6fiyat;
        private System.Windows.Forms.TextBox textBox3;
   
        private System.Windows.Forms.TextBox textBox4;
    
        private System.Windows.Forms.TextBox textBox5;
       
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label11blok;
        private System.Windows.Forms.Label label12Kat;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13Sema;
        private System.Windows.Forms.Button btnZambak;
        private System.Windows.Forms.Button btnGunes;
        private System.Windows.Forms.Button btnAydın;
        private System.Windows.Forms.Button btnAbant;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}