using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class latvanyossagok
    {
        int id;
        string nev;
        string leiras;
        int ar;
        int v_id;
        

        public latvanyossagok(int id, string nev, string leiras,int ar, int v_id)
        {
            this.id = id;
            this.nev = nev;
            this.leiras = leiras;
            this.ar = ar;
            this.v_id = v_id;
        }

        public int Id { get => id;  }
        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras; set => leiras = value; }

        public int Ar { get => ar; set => ar = value; }
        public int V_id { get => v_id; set => v_id = value; }
        

        public override string ToString()
        {
            if (ar==0)
            {
               
                return string.Format("Név: {0}-Ár: {1}", nev, "Ingyenes");
            }
            else
            {
                return string.Format("Név: {0}-Ár: {1}ft", nev, ar);
            }
           
        }
    }
}
