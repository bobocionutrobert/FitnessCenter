using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    class ViewAntrenor
    {

        private Antrenor antrenori;

        private ControllerAntrenori controllerantrenori;
        private ControllerMembri controllermembri;
        private ControllerFitness controllerfitness;

        public ViewAntrenor(Antrenor antrenori)
        {
            this.antrenori = antrenori;
            controllerantrenori = new ControllerAntrenori();
            controllerfitness = new ControllerFitness();
            controllermembri = new ControllerMembri();


        }


        public void meniu()
        {
            Console.WriteLine("===================Meniu Antrenor================");
            Console.WriteLine($"Bun venit, {antrenori.getNumeantrenor()}");
            Console.WriteLine("Apasati tasta 1 pentru a vedea membrii inscrisi");
            Console.WriteLine("Apasati tasta 2 pentru a vedea clasele de fitness");
            Console.WriteLine(" Apasati tasta 3 pentru a aduga o clasa de fitness noua");
            Console.WriteLine("Apasati tasta 4 pentru a alege o clasa de fitness");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");



        }

        public void play()
        {

            bool running = true;
            while (running == true)
            {

                meniu();
                int alegere = Int32.Parse(Console.ReadLine());

                switch (alegere)
                {
                    case 1:
                        controllermembri.afisare();
                        break;
                    case 2:
                        controllerfitness.afisare();
                        break;
                    case 3:
                        adaugareClasaFitness();
                        break;

                    case 4:
                        
                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;

                }


            }

        }

        public void adaugareClasaFitness()
        {

            Console.WriteLine("Adaugati descrierea clasei de fitness pe care doriti sa o adaugati : ");

            string descriereclasanoua = Console.ReadLine();

            Console.WriteLine("Adaugati tipul clasei de fitness pe care doriti sa o adaugati :");

            string tipclasanoua = Console.ReadLine();

            Console.WriteLine("Adaugati numele clasei de fitness pe care doriti sa o adaugati : ");

            string numeclasanoua = Console.ReadLine();

            Random random = new Random();
            int idrandom = random.Next(100, 10000);

            Fitness clasafitness = new Fitness(idrandom, descriereclasanoua, tipclasanoua, numeclasanoua);

            controllerfitness.add(clasafitness);


        }


    }
}
