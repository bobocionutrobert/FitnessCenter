using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FitnessCenter
{
    public class ControllerAntrenori
    {

        private List<Antrenor> antrenori;

        public ControllerAntrenori()
        {
            antrenori = new List<Antrenor>();

            load(); 
        }

        public void afisare()
        {


            for (int i = 0; i < antrenori.Count; i++)
            {

                Console.WriteLine(antrenori[i].descriere());
            }
        }

        public int pozitie(int id)
        {


            for (int i = 0; i < antrenori.Count; i++)
            {

                if (antrenori[i].getIdantrenor() == id)
                {

                    return i;
                }
            }


            return -1;



        }

        public Antrenor antrenor(int id)
        {
            for (int i = 0; i < antrenori.Count; i++)
            {
                if (antrenori[i].getIdantrenor() == id)
                {
                    return antrenori[i];
                }

            }
            return null;
        }

        public bool add(Antrenor antrenor)
        {



            int poz = pozitie(antrenor.getIdantrenor());

            if (poz != -1)
            {

                Console.WriteLine($" Antrenorul exista in lista ");

                return false;

            }
            else
            {

                antrenori.Add(antrenor);


                Console.WriteLine("Antrenorul a fost adaugat");


                return true;
               
            }

        }

        public bool delete(int id)
        {
            int poz = pozitie(id);

            if (poz == -1)
            {
                Console.WriteLine($"Antrenorul nu exista");
                return false;

            }
            else
            {
                antrenori.RemoveAt(poz);

                Console.WriteLine("Antrenorul a fost sters");

                return true;
            }
        }

        public bool updateNume(int id, string numeNou)
        {
            int poz = pozitie(id);

            if (poz == -1)
            {



                return false;
            }
            else
            {

                antrenori[poz].setNumeantrenor(numeNou);
                return true;
            }

        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\catas\Desktop\FullStackC#\Incapsularea\FitnessCenter\FitnessCenter\antrenori.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");


                int idantrenor = Int32.Parse(prop[0]);
                string numeantrenor = prop[1];
                int nrtelefon = Int32.Parse(prop[2]);
                string emailantrenor = prop[3];
                string adresa = prop[4];
                string username = prop[5];
                string parola = prop[6];
                

                Antrenor antrenor = new Antrenor(idantrenor, numeantrenor, nrtelefon, emailantrenor, adresa, username, parola);

                antrenori.Add(antrenor);

            }

            read.Close();
        }

        public string toSave()
        {

            string text = "";

            int i = 0;


            for (i = 0; i < antrenori.Count - 1; i++)
            {

                text += antrenori[i].toSave() + "\n";

            }

            text += antrenori[i].toSave();

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\catas\Desktop\Full Stack C#\Incapsularea\FitnessCenter\FitnessCenter\antrenori.txt");

            write.Write(toSave());

            write.Close();
        }
    }
}

