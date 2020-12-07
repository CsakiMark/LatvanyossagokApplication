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
            this.Varos_Felvetel_gomb = new System.Windows.Forms.Button();
            this.Látványosságok = new System.Windows.Forms.GroupBox();
            this.latvanyossag_leirasa = new System.Windows.Forms.TextBox();
            this.latvanyossagok_felvetele_gomb = new System.Windows.Forms.Button();
            this.latvanyossag_nev = new System.Windows.Forms.TextBox();
            this.latvanyossag_ara = new System.Windows.Forms.NumericUpDown();
            this.varosok_lista_box = new System.Windows.Forms.ListBox();
            this.latvanyossagok_lista = new System.Windows.Forms.ListBox();
            this.varos_lakosaga_bemenet = new System.Windows.Forms.NumericUpDown();
            this.varos_adat_modosit_gomb = new System.Windows.Forms.Button();
            this.varos_torlese_gomb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Városok.SuspendLayout();
            this.Látványosságok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossag_ara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varos_lakosaga_bemenet)).BeginInit();
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
            this.Városok.Controls.Add(this.varos_torlese_gomb);
            this.Városok.Controls.Add(this.varos_adat_modosit_gomb);
            this.Városok.Controls.Add(this.varos_lakosaga_bemenet);
            this.Városok.Controls.Add(this.Varos_Felvetel_gomb);
            this.Városok.Controls.Add(this.varos_neve);
            this.Városok.Location = new System.Drawing.Point(46, 37);
            this.Városok.Name = "Városok";
            this.Városok.Size = new System.Drawing.Size(200, 231);
            this.Városok.TabIndex = 2;
            this.Városok.TabStop = false;
            this.Városok.Text = "Városok";
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
            this.Látványosságok.Controls.Add(this.button2);
            this.Látványosságok.Controls.Add(this.latvanyossag_leirasa);
            this.Látványosságok.Controls.Add(this.latvanyossagok_felvetele_gomb);
            this.Látványosságok.Controls.Add(this.latvanyossag_nev);
            this.Látványosságok.Controls.Add(this.latvanyossag_ara);
            this.Látványosságok.Location = new System.Drawing.Point(295, 37);
            this.Látványosságok.Name = "Látványosságok";
            this.Látványosságok.Size = new System.Drawing.Size(200, 231);
            this.Látványosságok.TabIndex = 3;
            this.Látványosságok.TabStop = false;
            this.Látványosságok.Text = "Látványosságok";
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
            this.latvanyossagok_lista.Location = new System.Drawing.Point(409, 274);
            this.latvanyossagok_lista.Name = "latvanyossagok_lista";
            this.latvanyossagok_lista.Size = new System.Drawing.Size(277, 164);
            this.latvanyossagok_lista.TabIndex = 5;
            // 
            // varos_lakosaga_bemenet
            // 
            this.varos_lakosaga_bemenet.Location = new System.Drawing.Point(0, 74);
            this.varos_lakosaga_bemenet.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.varos_lakosaga_bemenet.Name = "varos_lakosaga_bemenet";
            this.varos_lakosaga_bemenet.Size = new System.Drawing.Size(200, 22);
            this.varos_lakosaga_bemenet.TabIndex = 6;
            this.varos_lakosaga_bemenet.ValueChanged += new System.EventHandler(this.varos_lakosaga_bemenet_ValueChanged_1);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            this.Látványosságok.ResumeLayout(false);
            this.Látványosságok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossag_ara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varos_lakosaga_bemenet)).EndInit();
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
        private System.Windows.Forms.Button button2;
    }
}

