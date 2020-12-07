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
            this.varos_lakosaga = new System.Windows.Forms.NumericUpDown();
            this.Városok = new System.Windows.Forms.GroupBox();
            this.Varos_Felvetel_gomb = new System.Windows.Forms.Button();
            this.Látványosságok = new System.Windows.Forms.GroupBox();
            this.latvanyossagok_felvetele_gomb = new System.Windows.Forms.Button();
            this.latvanyossag_nev = new System.Windows.Forms.TextBox();
            this.latvanyossag_ara = new System.Windows.Forms.NumericUpDown();
            this.latvanyossag_leirasa = new System.Windows.Forms.TextBox();
            this.varosok_lista = new System.Windows.Forms.ListBox();
            this.latvanyossagok_lista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.varos_lakosaga)).BeginInit();
            this.Városok.SuspendLayout();
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
            // 
            // varos_lakosaga
            // 
            this.varos_lakosaga.Location = new System.Drawing.Point(17, 61);
            this.varos_lakosaga.Name = "varos_lakosaga";
            this.varos_lakosaga.Size = new System.Drawing.Size(148, 22);
            this.varos_lakosaga.TabIndex = 1;
            // 
            // Városok
            // 
            this.Városok.Controls.Add(this.Varos_Felvetel_gomb);
            this.Városok.Controls.Add(this.varos_neve);
            this.Városok.Controls.Add(this.varos_lakosaga);
            this.Városok.Location = new System.Drawing.Point(46, 37);
            this.Városok.Name = "Városok";
            this.Városok.Size = new System.Drawing.Size(200, 134);
            this.Városok.TabIndex = 2;
            this.Városok.TabStop = false;
            this.Városok.Text = "Városok";
            // 
            // Varos_Felvetel_gomb
            // 
            this.Varos_Felvetel_gomb.Location = new System.Drawing.Point(6, 105);
            this.Varos_Felvetel_gomb.Name = "Varos_Felvetel_gomb";
            this.Varos_Felvetel_gomb.Size = new System.Drawing.Size(188, 23);
            this.Varos_Felvetel_gomb.TabIndex = 2;
            this.Varos_Felvetel_gomb.Text = "Felvétel";
            this.Varos_Felvetel_gomb.UseVisualStyleBackColor = true;
            // 
            // Látványosságok
            // 
            this.Látványosságok.Controls.Add(this.latvanyossag_leirasa);
            this.Látványosságok.Controls.Add(this.latvanyossagok_felvetele_gomb);
            this.Látványosságok.Controls.Add(this.latvanyossag_nev);
            this.Látványosságok.Controls.Add(this.latvanyossag_ara);
            this.Látványosságok.Location = new System.Drawing.Point(295, 37);
            this.Látványosságok.Name = "Látványosságok";
            this.Látványosságok.Size = new System.Drawing.Size(200, 181);
            this.Látványosságok.TabIndex = 3;
            this.Látványosságok.TabStop = false;
            this.Látványosságok.Text = "Látványosságok";
            // 
            // latvanyossagok_felvetele_gomb
            // 
            this.latvanyossagok_felvetele_gomb.Location = new System.Drawing.Point(6, 152);
            this.latvanyossagok_felvetele_gomb.Name = "latvanyossagok_felvetele_gomb";
            this.latvanyossagok_felvetele_gomb.Size = new System.Drawing.Size(188, 23);
            this.latvanyossagok_felvetele_gomb.TabIndex = 2;
            this.latvanyossagok_felvetele_gomb.Text = "Felvétel";
            this.latvanyossagok_felvetele_gomb.UseVisualStyleBackColor = true;
            // 
            // latvanyossag_nev
            // 
            this.latvanyossag_nev.Location = new System.Drawing.Point(37, 33);
            this.latvanyossag_nev.Name = "latvanyossag_nev";
            this.latvanyossag_nev.Size = new System.Drawing.Size(100, 22);
            this.latvanyossag_nev.TabIndex = 0;
            // 
            // latvanyossag_ara
            // 
            this.latvanyossag_ara.Location = new System.Drawing.Point(22, 112);
            this.latvanyossag_ara.Name = "latvanyossag_ara";
            this.latvanyossag_ara.Size = new System.Drawing.Size(148, 22);
            this.latvanyossag_ara.TabIndex = 1;
            // 
            // latvanyossag_leirasa
            // 
            this.latvanyossag_leirasa.Location = new System.Drawing.Point(37, 74);
            this.latvanyossag_leirasa.Name = "latvanyossag_leirasa";
            this.latvanyossag_leirasa.Size = new System.Drawing.Size(100, 22);
            this.latvanyossag_leirasa.TabIndex = 3;
            // 
            // varosok_lista
            // 
            this.varosok_lista.FormattingEnabled = true;
            this.varosok_lista.ItemHeight = 16;
            this.varosok_lista.Location = new System.Drawing.Point(46, 275);
            this.varosok_lista.Name = "varosok_lista";
            this.varosok_lista.Size = new System.Drawing.Size(165, 116);
            this.varosok_lista.TabIndex = 4;
            // 
            // latvanyossagok_lista
            // 
            this.latvanyossagok_lista.FormattingEnabled = true;
            this.latvanyossagok_lista.ItemHeight = 16;
            this.latvanyossagok_lista.Location = new System.Drawing.Point(317, 275);
            this.latvanyossagok_lista.Name = "latvanyossagok_lista";
            this.latvanyossagok_lista.Size = new System.Drawing.Size(165, 116);
            this.latvanyossagok_lista.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.latvanyossagok_lista);
            this.Controls.Add(this.varosok_lista);
            this.Controls.Add(this.Látványosságok);
            this.Controls.Add(this.Városok);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.varos_lakosaga)).EndInit();
            this.Városok.ResumeLayout(false);
            this.Városok.PerformLayout();
            this.Látványosságok.ResumeLayout(false);
            this.Látványosságok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latvanyossag_ara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox varos_neve;
        private System.Windows.Forms.NumericUpDown varos_lakosaga;
        private System.Windows.Forms.GroupBox Városok;
        private System.Windows.Forms.Button Varos_Felvetel_gomb;
        private System.Windows.Forms.GroupBox Látványosságok;
        private System.Windows.Forms.TextBox latvanyossag_leirasa;
        private System.Windows.Forms.Button latvanyossagok_felvetele_gomb;
        private System.Windows.Forms.TextBox latvanyossag_nev;
        private System.Windows.Forms.NumericUpDown latvanyossag_ara;
        private System.Windows.Forms.ListBox varosok_lista;
        private System.Windows.Forms.ListBox latvanyossagok_lista;
    }
}

