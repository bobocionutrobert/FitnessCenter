using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FitnessCenter
{
    public class ControllerFitness
    {
        private List<Fitness> fitness;

        public ControllerFitness()
        {
            fitness = new List<Fitness>();

            load();
        }

        public void afisare()
        {


            for (int i = 0; i < fitness.Count; i++)
            {

                Console.WriteLine(fitness[i].descriereclasa());
            }
        }

        public int pozitie(int id)
        {


            for (int i = 0; i < fitness.Count; i++)
            {

                if (fitness[i].getIdfitness() == id)
                {

                    return i;
                }
            }


            return -1;



        }

        public Fitness fitnesss(int id)
        {
            for (int i = 0; i < fitness.Count; i++)
            {
                if (fitness[i].getIdfitness() == id)
                {
                    return fitness[i];
                }

            }
            return null;
        }

        public bool add(Fitness fitnesss)
        {



            int poz = pozitie(fitnesss.getIdfitness());

            if (poz != -1)
            {

                Console.WriteLine($" Clasa de fitness exista in lista ");

                return false;

            }
            else
            {

                fitness.Add(fitnesss);


                Console.WriteLine("Clasa de fitness a fost adaugat");


                return true;

            }

        }

        public bool delete(int id)
        {
            int poz = pozitie(id);

            if (poz == -1)
            {
                Console.WriteLine($"Clasa de fitness nu exista");
                return false;

            }
            else
            {
                fitness.RemoveAt(poz);

                Console.WriteLine("Clasa de fitness a fost sters din lista");

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

                fitness[poz].setNume(numeNou);
                return true;
            }

        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\catas\Desktop\FullStackC#\Incapsularea\FitnessCenter\FitnessCenter\Resources\clasefitness.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");


                int idclasa = Int32.Parse(prop[0]);
                string descriereaclasei = prop[1];
                string tipulclasei = prop[2];
                string numeleclasei = prop[3];



                Fitness fitnesss = new Fitness(idclasa, descriereaclasei, tipulclasei, numeleclasei);

                fitness.Add(fitnesss);

            }

            read.Close();
        }

        public string toSave()
        {

            string text = "";

            int i = 0;


            for (i = 0; i < fitness.Count - 1; i++)
            {

                text += fitness[i].toSave() + "\n";

            }

            text += fitness[i].toSave();

            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\catas\Desktop\FullStackC#\Incapsularea\FitnessCenter\FitnessCenter\Resources\clasefitness.txt");

            write.Write(toSave());

            write.Close();
        }
    }
}
