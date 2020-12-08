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
        List<latvanyossagok> latvanyossagokLista = new List<latvanyossagok>();

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
            try
            {
               
                conn.Open();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Sikertelen kapcsolódás az adatbázishoz!");
                Environment.Exit(0);
            }

            TablakElenorzese();

            this.FormClosed += (sender, args) => {
                if (conn != null)
                {
                    conn.Close();
                }
            };

            AdatBetoltes("ossz");
        }



        void TablakElenorzese()
        {
            var v = @"CREATE TABLE IF NOT EXISTS varosok (
                          id int(11) AUTO_INCREMENT,
                          nev text COLLATE utf8mb4_hungarian_ci NOT NULL,
                          lakossag int(11) NOT NULL,
                          PRIMARY KEY (id),
                          UNIQUE KEY nev (nev) USING HASH
                          )";

            var l = @"CREATE TABLE IF NOT EXISTS latvanyossagok (
                                   id int(11) NOT NULL AUTO_INCREMENT,
                                   nev text COLLATE utf8mb4_hungarian_ci NOT NULL,
                                   leiras text COLLATE utf8mb4_hungarian_ci NOT NULL,
                                   ar int(11)  DEFAULT NULL,
                                   varos_id int(11),
                                   PRIMARY KEY (id),
                                   FOREIGN KEY (varos_id) REFERENCES varosok(id) ON DELETE CASCADE ON UPDATE RESTRICT
                                   )";
            var vComm = this.conn.CreateCommand();
            var lComm = this.conn.CreateCommand();
            vComm.CommandText = v;
            lComm.CommandText = l;
            try
            {
                vComm.ExecuteNonQuery();
                lComm.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Nem létrehozható adatbázis");
                Environment.Exit(0);
            }
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
                varos_torlese_gomb.Visible = true;

                Lnev = "";
                Lleiras = "";
                Lar = 0;
                latvanyossag_nev.Text = "";
                latvanyossag_leirasa.Text = "";
                latvanyossag_ara.Value = 0;

                int index = varosok_lista_box.SelectedIndex;
                // MessageBox.Show((varosok[index].Nev + " " + varosok[index].Lakossag).ToString());
                LatvanyossagokListazasa();
            }
            else
            {
                varos_adat_modosit_gomb.Visible = false;
                varos_torlese_gomb.Visible = false;
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
            ladatEllenorzes();
        }

        private void latvanyossag_leirasa_TextChanged(object sender, EventArgs e)
        {
            Lleiras = latvanyossag_leirasa.Text;
            latvanyFgombELL();
            ladatEllenorzes();


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

            LatvanyossagokListazasa();

            Lnev = "";
            Lleiras = "";
            Lar = 0;
            latvanyossag_nev.Text = "";
            latvanyossag_leirasa.Text = "";
            latvanyossag_ara.Value = 0;



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

        private void varos_torlese_gomb_Click(object sender, EventArgs e)
        {
            latvanyT();

            int index = varosok_lista_box.SelectedIndex;
            int vid = varosok[index].Id;

            string sql = @"
DELETE FROM varosok
WHERE id=@id
";

            

            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;

            comm.Parameters.AddWithValue("@id", vid);
            comm.ExecuteNonQuery();


            varosok.Remove(varosok[index]);
            varosok_lista_box.Items.Remove(varosok_lista_box.Items[index]);

            latvanyossagokLista.Clear();
            latvanyossagok_lista.Items.Clear();


        }

        void latvanyT()
        {

            int index = varosok_lista_box.SelectedIndex;
            int vid = varosok[index].Id;

            string sql = @"
DELETE FROM latvanyossagok
WHERE varos_id=@id
";


            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;

            comm.Parameters.AddWithValue("@id", vid);
            comm.ExecuteNonQuery();





        }


       void LatvanyossagokListazasa()
        {
            latvanyossagokLista.Clear();
            latvanyossagok_lista.Items.Clear();

            int index = varosok_lista_box.SelectedIndex;
            int vid = varosok[index].Id;

            string sql;

           
                sql = @"
SELECT id,nev,leiras,ar,varos_id
FROM latvanyossagok
WHERE varos_id=@id
";
            
         

            var comm = this.conn.CreateCommand();
            comm.Parameters.AddWithValue("@id", vid);



            comm.CommandText = sql;
            using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {

                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");
                    string leirasa = reader.GetString("leiras");
                    int ar = reader.GetInt32("ar");
                    int v_id = reader.GetInt32("varos_id");

                    var latvany = new latvanyossagok(id,nev, leirasa, ar,v_id);
                    latvanyossagok_lista.Items.Add(latvany);
                    latvanyossagokLista.Add(latvany);


                }
            }

          
            
        }

        private void latvanyossagok_lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (latvanyossagok_lista.SelectedIndex!=-1)
            {
                latvanyVisszatoltese();
                latvanyossagok_modositasa_gomb.Visible = true;
                ladatEllenorzes();

                Latvanyossag_torlese_gomb.Visible = true;


            }
            else
            {
                latvanyossagok_modositasa_gomb.Visible = false;
                Latvanyossag_torlese_gomb.Visible = false;
            }
        }
        void ladatEllenorzes()
        {
            if (Lnev.Length>=4 && Lleiras.Length>=4)
            {
                latvanyossagok_modositasa_gomb.Enabled = true;
            }
            else
            {
                latvanyossagok_modositasa_gomb.Enabled = false;
            }
        }

       void latvanyVisszatoltese()
        {
            int index = latvanyossagok_lista.SelectedIndex;

             Lnev = latvanyossagokLista[index].Nev;
             Lleiras = latvanyossagokLista[index].Leiras;
             Lar = latvanyossagokLista[index].Ar;

            latvanyossag_nev.Text = Lnev;
            latvanyossag_leirasa.Text = Lleiras;
            latvanyossag_ara.Value = Lar;
        }

        private void latvanyossagok_modositasa_gomb_Click(object sender, EventArgs e)
        {
            int index = latvanyossagok_lista.SelectedIndex;
            int vid = latvanyossagokLista[index].V_id;
           
            string sql = @"
UPDATE latvanyossagok
SET nev = @nev, leiras = @leirasa,ar=@ara
WHERE varos_id = @id
";


            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;
            comm.Parameters.AddWithValue("@nev", Lnev);
            comm.Parameters.AddWithValue("@leirasa", Lleiras);
            comm.Parameters.AddWithValue("@ara", Lar);
            comm.Parameters.AddWithValue("@id", vid);
            comm.ExecuteNonQuery();

            //varosok[index].Nev = Vvarosnev;
           // varosok[index].Lakossag = Vlakossaga;

            var v = new latvanyossagok(vid,Lnev,Lleiras,Lar,vid);

            latvanyossagokLista[index] = v;
            latvanyossagok_lista.Items[index] = v;
        }

        private void Latvanyossag_torlese_gomb_Click(object sender, EventArgs e)
        {
            int index = latvanyossagok_lista.SelectedIndex;
            int vid = latvanyossagokLista[index].Id;

            string sql = @"
DELETE FROM latvanyossagok
WHERE id=@id
";


            var comm = this.conn.CreateCommand();
            comm.CommandText = sql;

            comm.Parameters.AddWithValue("@id", vid);
            comm.ExecuteNonQuery();

            latvanyossagokLista.Remove(latvanyossagokLista[index]);
            latvanyossagok_lista.Items.Remove(latvanyossagok_lista.Items[index]);


            Lnev = "";
            Lleiras = "";
            Lar = 0;
            latvanyossag_nev.Text = "";
            latvanyossag_leirasa.Text = "";
            latvanyossag_ara.Value = 0;

        }
    }
        }
    

