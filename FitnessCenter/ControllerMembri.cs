using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FitnessCenter
{
    public class ControllerMembri
    {
        private List<Membru> membri;

        public ControllerMembri()
        {
            membri = new List<Membru>();

        }

        public void afisare()
        {
            for(int i = 0; i < membri.Count; i++)
            {
                Console.WriteLine(membri[i].descriere());
            }
        }

        public int pozitie(int id)
        {
            for(int i = 0; i < membri.Count; i++)
            {
                if(membri[i].getIdmembru() == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public Membru membru(int id)
        {
            for (int i = 0; i < membri.Count; i++)
            {
                if (membri[i].getIdmembru() == id)
                {
                    return membri[i];
                }
            }

            return null;
        }

        public bool add(Membru membru)
        {
            int poz = pozitie(membru.getIdmembru());

            if (poz != -1)
            {
                Console.WriteLine("Membrul exista in lista ");
                return false;
            }
            else
            {
                membri.Add(membru);
                Console.WriteLine("Membrul a fost adaugata");
                return true;
            }
        }

        public bool delete(int id)
        {
            int poz = pozitie(id);

            if (poz == -1)
            {
                Console.WriteLine("Membrul nu exista in lista");
                return false;
            }
            else
            {
                membri.RemoveAt(poz);
                Console.WriteLine("Membrul a fost stearsa din lista");
                return true;
            }
        }

        public bool updateNume(int id, string numenou)
        {
            int poz = pozitie(id);

            if (poz == -1)
            {
                return false;
            }
            else
            {
                membri[poz].setNumemembru(numenou);
                return true;
            }
        }

        public bool updateAdrsa(int id, string adresanoua)
        {
            int poz = pozitie(id);

            if (poz == -1)
            {
                return false;
            }
            else
            {
                membri[poz].setAdresa(adresanoua);
                return true;
            }
        }

        public bool updateEmail(int id, string emailnou)
        {
            int poz = pozitie(id);

            if (poz == -1)
            {
                return false;
            }
            else
            {
                membri[poz].setEmail(emailnou);
                return true;
            }
        }

        public bool updateId(int id, int idnou)
        {
            int poz = pozitie(id);

            if (poz == -1)
            {
                return false;
            }
            else
            {
                membri[poz].setIdmembru(idnou);
                return true;
            }
        }

        public bool updateParola(int id, string parolanoua)
        {
            int poz = pozitie(id);

            if (poz == -1)
            {
                return false;
            }
            else
            {
                membri[poz].setParola(parolanoua);
                return true;
            }
        }


        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\catas\Desktop\Full Stack C#\Incapsularea\FitnessCenter\FitnessCenter\membri.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");


                int idmembru = Int32.Parse(prop[0]);
                string numemembru = prop[1];
                int nrtelefonmembru = Int32.Parse(prop[2]);
                string emailmembru = prop[3];
                string adresamembru = prop[4];
                string usernamemembru = prop[5];
                string parolamembru = prop[6];


                Membru membru = new Membru(idmembru, numemembru, nrtelefonmembru, emailmembru, adresamembru, usernamemembru, parolamembru);

                membri.Add(membru);

            }

            read.Close();
        }

        public string toSave()
        {

            string text = "";

            int i = 0;


            for (i = 0; i < membri.Count - 1; i++)
            {

                text += membri[i].toSave() + "\n";

            }

            text += membri[i].toSave();

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\catas\Desktop\Full Stack C#\Incapsularea\FitnessCenter\FitnessCenter\membri.txt");

            write.Write(toSave());

            write.Close();
        }
    }

}

