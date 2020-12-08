namespace LatvanyossagokApplication
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
            this.varos_neve = new System.Windows.Forms.TextBox();
            this.Városok = new System.Windows.Forms.GroupBox();
            this.varos_torlese_gomb = new System.Windows.Forms.Button();
            this.varos_adat_modosit_gomb = new System.Windows.Forms.Button();
            this.varos_lakosaga_bemenet = new System.Windows.Forms.NumericUpDown();
            this.Varos_Felvetel_gomb = new System.Windows.Forms.Button();
            this.Látványosságok = new System.Windows.Forms.GroupBox();
            this.Latvanyossag_torlese_gomb = new System.Windows.Forms.Button();
            this.latvanyossagok_modositasa_gomb = new System.Windows.Forms.Button();
            this.latvanyossag_leirasa = new System.Windows.Forms.TextBox();
            this.latvanyossagok_felvetele_gomb = new System.Windows.Forms.Button();
            this.latvanyossag_nev = new System.Windows.Forms.TextBox();
            this.latvanyossag_ara = new System.Windows.Forms.NumericUpDown();
            this.varosok_lista_box = new System.Windows.Forms.ListBox();
            this.latvanyossagok_lista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Városok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varos_lakosaga_bemenet)).BeginInit();
            this.Látványosságok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossag_ara)).BeginInit();
            this.SuspendLayout();
            // 
            // varos_neve
            // 
            this.varos_neve.Location = new System.Drawing.Point(37, 33);
            this.varos_neve.Name = "varos_neve";
            this.varos_neve.Size = new System.Drawing.Size(100, 22);
            this.varos_neve.TabIndex = 0;
            this.varos_neve.TextChanged += new System.EventHandler(this.varos_neve_TextChanged);
            // 
            // Városok
            // 
            this.Városok.Controls.Add(this.label2);
            this.Városok.Controls.Add(this.label1);
            this.Városok.Controls.Add(this.varos_torlese_gomb);
            this.Városok.Controls.Add(this.varos_adat_modosit_gomb);
            this.Városok.Controls.Add(this.varos_lakosaga_bemenet);
            this.Városok.Controls.Add(this.Varos_Felvetel_gomb);
            this.Városok.Controls.Add(this.varos_neve);
            this.Városok.Location = new System.Drawing.Point(46, 12);
            this.Városok.Name = "Városok";
            this.Városok.Size = new System.Drawing.Size(200, 256);
            this.Városok.TabIndex = 2;
            this.Városok.TabStop = false;
            this.Városok.Text = "Városok";
            // 
            // varos_torlese_gomb
            // 
            this.varos_torlese_gomb.Location = new System.Drawing.Point(49, 202);
            this.varos_torlese_gomb.Name = "varos_torlese_gomb";
            this.varos_torlese_gomb.Size = new System.Drawing.Size(75, 23);
            this.varos_torlese_gomb.TabIndex = 8;
            this.varos_torlese_gomb.Text = "Törlés";
            this.varos_torlese_gomb.UseVisualStyleBackColor = true;
            this.varos_torlese_gomb.Visible = false;
            this.varos_torlese_gomb.Click += new System.EventHandler(this.varos_torlese_gomb_Click);
            // 
            // varos_adat_modosit_gomb
            // 
            this.varos_adat_modosit_gomb.Location = new System.Drawing.Point(7, 152);
            this.varos_adat_modosit_gomb.Name = "varos_adat_modosit_gomb";
            this.varos_adat_modosit_gomb.Size = new System.Drawing.Size(187, 23);
            this.varos_adat_modosit_gomb.TabIndex = 7;
            this.varos_adat_modosit_gomb.Text = "Modositás";
            this.varos_adat_modosit_gomb.UseVisualStyleBackColor = true;
            this.varos_adat_modosit_gomb.Visible = false;
            this.varos_adat_modosit_gomb.Click += new System.EventHandler(this.varos_adat_modosit_gomb_Click);
            // 
            // varos_lakosaga_bemenet
            // 
            this.varos_lakosaga_bemenet.Location = new System.Drawing.Point(0, 78);
            this.varos_lakosaga_bemenet.Maximum = new decimal(new int[] {
            30000000,
            0,
            0,
            0});
            this.varos_lakosaga_bemenet.Name = "varos_lakosaga_bemenet";
            this.varos_lakosaga_bemenet.Size = new System.Drawing.Size(200, 22);
            this.varos_lakosaga_bemenet.TabIndex = 6;
            this.varos_lakosaga_bemenet.ValueChanged += new System.EventHandler(this.varos_lakosaga_bemenet_ValueChanged_1);
            // 
            // Varos_Felvetel_gomb
            // 
            this.Varos_Felvetel_gomb.Enabled = false;
            this.Varos_Felvetel_gomb.Location = new System.Drawing.Point(6, 105);
            this.Varos_Felvetel_gomb.Name = "Varos_Felvetel_gomb";
            this.Varos_Felvetel_gomb.Size = new System.Drawing.Size(188, 23);
            this.Varos_Felvetel_gomb.TabIndex = 2;
            this.Varos_Felvetel_gomb.Text = "Felvétel";
            this.Varos_Felvetel_gomb.UseVisualStyleBackColor = true;
            this.Varos_Felvetel_gomb.Click += new System.EventHandler(this.Varos_Felvetel_gomb_Click);
            // 
            // Látványosságok
            // 
            this.Látványosságok.Controls.Add(this.label5);
            this.Látványosságok.Controls.Add(this.label4);
            this.Látványosságok.Controls.Add(this.label3);
            this.Látványosságok.Controls.Add(this.Latvanyossag_torlese_gomb);
            this.Látványosságok.Controls.Add(this.latvanyossagok_modositasa_gomb);
            this.Látványosságok.Controls.Add(this.latvanyossag_leirasa);
            this.Látványosságok.Controls.Add(this.latvanyossagok_felvetele_gomb);
            this.Látványosságok.Controls.Add(this.latvanyossag_nev);
            this.Látványosságok.Controls.Add(this.latvanyossag_ara);
            this.Látványosságok.Location = new System.Drawing.Point(295, 12);
            this.Látványosságok.Name = "Látványosságok";
            this.Látványosságok.Size = new System.Drawing.Size(290, 256);
            this.Látványosságok.TabIndex = 3;
            this.Látványosságok.TabStop = false;
            this.Látványosságok.Text = "Látványosságok";
            // 
            // Latvanyossag_torlese_gomb
            // 
            this.Latvanyossag_torlese_gomb.Location = new System.Drawing.Point(173, 191);
            this.Latvanyossag_torlese_gomb.Name = "Latvanyossag_torlese_gomb";
            this.Latvanyossag_torlese_gomb.Size = new System.Drawing.Size(75, 23);
            this.Latvanyossag_torlese_gomb.TabIndex = 10;
            this.Latvanyossag_torlese_gomb.Text = "Törlés";
            this.Latvanyossag_torlese_gomb.UseVisualStyleBackColor = true;
            this.Latvanyossag_torlese_gomb.Visible = false;
            this.Latvanyossag_torlese_gomb.Click += new System.EventHandler(this.Latvanyossag_torlese_gomb_Click);
            // 
            // latvanyossagok_modositasa_gomb
            // 
            this.latvanyossagok_modositasa_gomb.Enabled = false;
            this.latvanyossagok_modositasa_gomb.Location = new System.Drawing.Point(55, 191);
            this.latvanyossagok_modositasa_gomb.Name = "latvanyossagok_modositasa_gomb";
            this.latvanyossagok_modositasa_gomb.Size = new System.Drawing.Size(82, 23);
            this.latvanyossagok_modositasa_gomb.TabIndex = 9;
            this.latvanyossagok_modositasa_gomb.Text = "Modositás";
            this.latvanyossagok_modositasa_gomb.UseVisualStyleBackColor = true;
            this.latvanyossagok_modositasa_gomb.Visible = false;
            this.latvanyossagok_modositasa_gomb.Click += new System.EventHandler(this.latvanyossagok_modositasa_gomb_Click);
            // 
            // latvanyossag_leirasa
            // 
            this.latvanyossag_leirasa.Location = new System.Drawing.Point(37, 74);
            this.latvanyossag_leirasa.Name = "latvanyossag_leirasa";
            this.latvanyossag_leirasa.Size = new System.Drawing.Size(100, 22);
            this.latvanyossag_leirasa.TabIndex = 3;
            this.latvanyossag_leirasa.TextChanged += new System.EventHandler(this.latvanyossag_leirasa_TextChanged);
            // 
            // latvanyossagok_felvetele_gomb
            // 
            this.latvanyossagok_felvetele_gomb.Enabled = false;
            this.latvanyossagok_felvetele_gomb.Location = new System.Drawing.Point(6, 152);
            this.latvanyossagok_felvetele_gomb.Name = "latvanyossagok_felvetele_gomb";
            this.latvanyossagok_felvetele_gomb.Size = new System.Drawing.Size(188, 23);
            this.latvanyossagok_felvetele_gomb.TabIndex = 2;
            this.latvanyossagok_felvetele_gomb.Text = "Felvétel";
            this.latvanyossagok_felvetele_gomb.UseVisualStyleBackColor = true;
            this.latvanyossagok_felvetele_gomb.Click += new System.EventHandler(this.latvanyossagok_felvetele_gomb_Click);
            // 
            // latvanyossag_nev
            // 
            this.latvanyossag_nev.Location = new System.Drawing.Point(37, 33);
            this.latvanyossag_nev.Name = "latvanyossag_nev";
            this.latvanyossag_nev.Size = new System.Drawing.Size(100, 22);
            this.latvanyossag_nev.TabIndex = 0;
            this.latvanyossag_nev.TextChanged += new System.EventHandler(this.latvanyossag_nev_TextChanged);
            // 
            // latvanyossag_ara
            // 
            this.latvanyossag_ara.Location = new System.Drawing.Point(22, 112);
            this.latvanyossag_ara.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.latvanyossag_ara.Name = "latvanyossag_ara";
            this.latvanyossag_ara.Size = new System.Drawing.Size(148, 22);
            this.latvanyossag_ara.TabIndex = 1;
            this.latvanyossag_ara.ValueChanged += new System.EventHandler(this.latvanyossag_ara_ValueChanged);
            // 
            // varosok_lista_box
            // 
            this.varosok_lista_box.FormattingEnabled = true;
            this.varosok_lista_box.ItemHeight = 16;
            this.varosok_lista_box.Location = new System.Drawing.Point(12, 274);
            this.varosok_lista_box.Name = "varosok_lista_box";
            this.varosok_lista_box.Size = new System.Drawing.Size(277, 164);
            this.varosok_lista_box.TabIndex = 4;
            this.varosok_lista_box.SelectedIndexChanged += new System.EventHandler(this.varosok_lista_box_SelectedIndexChanged);
            // 
            // latvanyossagok_lista
            // 
            this.latvanyossagok_lista.FormattingEnabled = true;
            this.latvanyossagok_lista.ItemHeight = 16;
            this.latvanyossagok_lista.Location = new System.Drawing.Point(398, 274);
            this.latvanyossagok_lista.Name = "latvanyossagok_lista";
            this.latvanyossagok_lista.Size = new System.Drawing.Size(277, 164);
            this.latvanyossagok_lista.TabIndex = 5;
            this.latvanyossagok_lista.SelectedIndexChanged += new System.EventHandler(this.latvanyossagok_lista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Népesség";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Leirás";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ár";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Név";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.latvanyossagok_lista);
            this.Controls.Add(this.varosok_lista_box);
            this.Controls.Add(this.Látványosságok);
            this.Controls.Add(this.Városok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Városok.ResumeLayout(false);
            this.Városok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varos_lakosaga_bemenet)).EndInit();
            this.Látványosságok.ResumeLayout(false);
            this.Látványosságok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossag_ara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox varos_neve;
        private System.Windows.Forms.GroupBox Városok;
        private System.Windows.Forms.Button Varos_Felvetel_gomb;
        private System.Windows.Forms.GroupBox Látványosságok;
        private System.Windows.Forms.TextBox latvanyossag_leirasa;
        private System.Windows.Forms.Button latvanyossagok_felvetele_gomb;
        private System.Windows.Forms.TextBox latvanyossag_nev;
        private System.Windows.Forms.NumericUpDown latvanyossag_ara;
        private System.Windows.Forms.ListBox varosok_lista_box;
        private System.Windows.Forms.ListBox latvanyossagok_lista;
        private System.Windows.Forms.NumericUpDown varos_lakosaga_bemenet;
        private System.Windows.Forms.Button varos_adat_modosit_gomb;
        private System.Windows.Forms.Button varos_torlese_gomb;
        private System.Windows.Forms.Button latvanyossagok_modositasa_gomb;
        private System.Windows.Forms.Button Latvanyossag_torlese_gomb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

