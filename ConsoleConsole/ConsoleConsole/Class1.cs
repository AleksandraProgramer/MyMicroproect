using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConsole
{
    struct Chelovek
    {
        public string Fio;
        public string Adres;
        public int Vozrast;
        public int N_telefona;
        public string Mob_oper;

        public Chelovek(string fio, string adres, int vozrast, int n_telefona, string mob_oper)
        {
            Fio = fio;
            Adres = adres;
            Vozrast = vozrast;
            N_telefona = n_telefona;
            Mob_oper = mob_oper;
        }

        public string Get_fio() { return Fio; }
        public string Get_adres() { return Adres; }
        public int Get_vozrast() { return Vozrast; }
        public int Get_n_telefona() { return N_telefona; }
        public string Get_mob_oper() { return Mob_oper; }

          public void Set_fio(string Fios) { Fio = Fios; }
          public void Set_adres(string Adresse) { Adres = Adresse; }
          public void Set_vozrast(int Vozrasts) { Vozrast = Vozrasts; }
          public void Set_n_telefona(int n_telefonas) { N_telefona = n_telefonas; }
          public void Set_mob_oper(string mob_opers) { Mob_oper = mob_opers; }

         
    }

    class Class1
    {   
    }
}
