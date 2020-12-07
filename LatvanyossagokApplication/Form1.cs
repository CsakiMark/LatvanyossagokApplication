using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        List<varosok> varosok = new List<varosok>();

        string Vvarosnev = "";
        int Vlakossaga = 0;

        string Lnev="";
        string Lleiras="";
        int Lar=0;

        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=latvanyossagokdb; Uid=root; Pwd=;");
            conn.Open();

            this.FormClosed += (sender, args) => {
                if (conn != null)
                {
                    conn.Close();
                }
            };

            AdatBetoltes("ossz");
        }


        void VarosFEllenorzese()
        {
            if (Vvarosnev.Length>=4 && Vlakossaga>=1)
            {
                Varos_Felvetel_gomb.Enabled=true;
                varos_adat_modosit_gomb.Enabled = true;
            }
            else
            {
                Varos_Felvetel_gomb.Enabled = false;
                varos_adat_modosit_gomb.Enabled = false;
            }
        }


        void VarosEllAzAdatbazisban()
        {
            int VDB = 0;

            string sql = @"
SELECT COUNT(id) as Db
FROM varosok
WHERE nev LIKE @nev

";
            
            var comm = this.conn.CreateCommand();
            comm.Parameters.AddWithValue("@nev", Vvarosnev);
            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int darab = reader.GetInt32("Db");





                    VDB = darab;
                   // MessageBox.Show(VDB.ToString());
                }
            }

            if (VDB>0)
            {
                MessageBox.Show("A város név már foglalt az adatbázisban: "+Vvarosnev.ToString());
            }
            else
            {
                VarosFelvetele();
            }
        }

        void  VarosFelvetele()
        {
            string sql = @"
INSERT INTO `varosok`(`nev`, `lakossag`)
VALUES (@nev, @lakossag)
";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@nev", Vvarosnev);
            comm.Parameters.AddWithValue("@lakossag", Vlakossaga);
            comm.ExecuteNonQuery();

            AdatBetoltes("egy");
        }

       
        public  void AdatBetoltes(string db)
        {
            string sql;

            if (db=="ossz")
            {
                 sql = @"
SELECT id,nev,lakossag
FROM varosok
";
            }
            else 
            {
                 sql = @"
SELECT id,nev,lakossag
FROM varosok
WHERE nev LIKE @nev
";
            }

            var comm = this.conn.CreateCommand();

            if(db=="egy")
            comm.Parameters.AddWithValue("@nev", Vvarosnev);

            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {

                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    int lakossag = reader.GetInt32("lakossag");


                    var varos = new varosok(id, nev, lakossag);
                    varosok_lista_box.Items.Add(varos);
                    varosok.Add(varos);
                    

                }
            }

            ///////////////////
            ///
            Vvarosnev = "";
            Vlakossaga = 0;
            varos_neve.Text = "";
            varos_lakosaga_bemenet.Value = 0;
        }

        private void varosok_lista_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            latvanyFgombELL();
            if (varosok_lista_box.SelectedIndex!=-1)
            {
                Modositas();
                
                int index = varosok_lista_box.SelectedIndex;
                MessageBox.Show((varosok[index].Nev + " " + varosok[index].Lakossag).ToString());
            }
            else
            {
                varos_adat_modosit_gomb.Visible = false;
            }
            
        }

        void Modositas()
        {
            int index = varosok_lista_box.SelectedIndex;
            varos_adat_modosit_gomb.Visible = true;

            Vvarosnev = varosok[index].Nev;
            Vlakossaga = varosok[index].Lakossag;

            int id= varosok[index].Id;

            varos_neve.Text = varosok[index].Nev;
            varos_lakosaga_bemenet.Value = varosok[index].Lakossag;
        }

      

        private void varos_neve_TextChanged(object sender, EventArgs e)
        {
            Vvarosnev = varos_neve.Text;
            VarosFEllenorzese();
             
        }

        

        private void Varos_Felvetel_gomb_Click(object sender, EventArgs e)
        {

            VarosEllAzAdatbazisban();


        }

        private void varos_lakosaga_bemenet_ValueChanged_1(object sender, EventArgs e)
        {
            Vlakossaga = Convert.ToInt32(varos_lakosaga_bemenet.Value);
            VarosFEllenorzese();
        }

        private void latvanyossag_nev_TextChanged(object sender, EventArgs e)
        {
            Lnev = latvanyossag_nev.Text;
            latvanyFgombELL();
        }

        private void latvanyossag_leirasa_TextChanged(object sender, EventArgs e)
        {
            Lleiras = latvanyossag_leirasa.Text;
            latvanyFgombELL();


        }

        void latvanyFgombELL()
        {
            if (Lnev.Length >= 4 && Lleiras.Length>=4 && varosok_lista_box.SelectedIndex!=-1)
            {
                latvanyossagok_felvetele_gomb.Enabled = true;
            }
            else
            {
                latvanyossagok_felvetele_gomb.Enabled = false;
            }
        }

        private void latvanyossag_ara_ValueChanged(object sender, EventArgs e)
        {
          Lar=Convert.ToInt32(latvanyossag_ara.Value);
        }

        private void latvanyossagok_felvetele_gomb_Click(object sender, EventArgs e)
        {
            LatvanyFelvetele();
        }

        void LatvanyFelvetele()
        {
            int index = varosok_lista_box.SelectedIndex;
            int vid = varosok[index].Id;

            string sql = @"
INSERT INTO `latvanyossagok`(`nev`, `leiras`,`ar`,`varos_id`)
VALUES (@nev, @leiras,@ar,@id)
";
            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@nev", Lnev);
            comm.Parameters.AddWithValue("@leiras", Lleiras);
            comm.Parameters.AddWithValue("@ar", Lar);
            comm.Parameters.AddWithValue("@id",vid);
            comm.ExecuteNonQuery();

            
        }

        private void varos_adat_modosit_gomb_Click(object sender, EventArgs e)
        {

            int index = varosok_lista_box.SelectedIndex;
            int vid = varosok[index].Id;

            string sql = @"
UPDATE varosok
SET nev = @nev, lakossag = @lakos
WHERE id = @id
";


            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@nev", Vvarosnev);
            comm.Parameters.AddWithValue("@lakos", Vlakossaga);
            comm.Parameters.AddWithValue("@ar", Lar);
            comm.Parameters.AddWithValue("@id", vid);
            comm.ExecuteNonQuery();

            varosok[index].Nev = Vvarosnev;
            varosok[index].Lakossag = Vlakossaga;

            varosok v = new varosok(vid,Vvarosnev, Vlakossaga);

            varosok_lista_box.Items[index] = v;






        }
    }
        }
    

