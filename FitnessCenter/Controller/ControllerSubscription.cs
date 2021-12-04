using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FitnessCenter
{
    public class ControllerAbonament
    {
        private List<Subscription> abonamente;

        public ControllerAbonament()
        {

            abonamente = new List<Subscription>();
            load();
            
        }

        public void afisare()
        {
            for(int i =0;i < abonamente.Count; i++)
            {
                Console.WriteLine(abonamente[i].descriereabonament());
            }
        }


        public int pozitie(int idabonament)
        {
            for (int i = 0; i < abonamente.Count; i++)
            {
                if (abonamente[i].getIdAbonament() == idabonament)
                {
                    return i;
                }
            }

            return -1;
        }

        public Subscription abonament(int idabonament)
        {
            for (int i = 0; i < abonamente.Count; i++)
            {
                if (abonamente[i].getIdAbonament() == idabonament)
                {
                    return abonamente[i];
                }
            }

            return null;
        }

        public bool add(Subscription abonament)
        {
            int poz = pozitie(abonament.getIdAbonament());

            if (poz != -1)
            {
                Console.WriteLine("Abonamentul exista in lista ");
                return false;
            }
            else
            {
                abonamente.Add(abonament);
                Console.WriteLine("Abonamentul a fost adaugata");
                return true;
            }
        }

        public bool delete(int idabonament)
        {
            int poz = pozitie(idabonament);

            if (poz == -1)
            {
                Console.WriteLine("Abonamentul nu exista in lista");
                return false;
            }
            else
            {
                abonamente.RemoveAt(poz);
                Console.WriteLine("Abonamentul a fost stearsa din lista");
                return true;
            }
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\catas\Desktop\FullStackC#\Incapsularea\FitnessCenter\FitnessCenter\Resources\abonamente.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                

                int idabonament = Int32.Parse(prop[0]);
                string numeclient = prop[1];
                string tipaboanment = prop[2];
                int valabilitate = Int32.Parse(prop[3]);
                int pret = Int32.Parse(prop[4]);
                bool antrenorinclus = bool.Parse(prop[5]);


                Subscription abonamentnou = new Subscription(idabonament,numeclient, tipaboanment, valabilitate, pret, antrenorinclus);

                abonamente.Add(abonamentnou);


            }

            read.Close();
        }

        public string toSave()
        {

            string text = "";

            int i = 0;


            for (i = 0; i < abonamente.Count - 1; i++)
            {

                text += abonamente[i].toSave() + "\n";

            }

            text += abonamente[i].toSave();

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\catas\Desktop\FullStackC#\Incapsularea\FitnessCenter\FitnessCenter\Resources\abonamente.txt");

            write.Write(toSave());

            write.Close();
        }
    }


}

