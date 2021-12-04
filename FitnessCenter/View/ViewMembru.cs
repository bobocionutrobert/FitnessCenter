using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    public class ViewMembru
    {
        private Membru membri;

        private ControllerAntrenori controllerantrenori;
        private ControllerMembri controllermembri;
        private ControllerFitness controllerfitness;

        public ViewMembru(Membru membri)
        {
            this.membri = membri;
            controllerantrenori = new ControllerAntrenori();
            controllerfitness = new ControllerFitness();
            controllermembri = new ControllerMembri();

            
        }


        public void meniu()
        {
            Console.WriteLine("===================Meniu Membru================");
            Console.WriteLine($"Bun venit, {membri.getNumemembru()}");
            Console.WriteLine("Apasati tasta 1 pentru a vedea disponibili");
            Console.WriteLine("Apasati tasta 2 pentru a vedea clasele de fitness disponibile");
            Console.WriteLine(" Apasati tasta 3 pentru a alege un antrenor");
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
                        controllerantrenori.afisare();
                        break;
                    case 2:
                        controllerfitness.afisare();
                        break;
                    case 3:
                        alegereAntrenor();
                        break;
                        
                    case 4:
                        alegereClasaFitness();
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

        public void alegereAntrenor()
        {
            Console.WriteLine("Introduceti id-ul antrenorului pe care doriti sa il alegeti");

            int alegere = Int32.Parse(Console.ReadLine());

            Antrenor antrenor = controllerantrenori.antrenor(alegere);

            Console.WriteLine($"Ati apelat la serviciile anternorului {antrenor.getNumeantrenor()}");


        }

        public void alegereClasaFitness()
        {
            Console.WriteLine("Introduceti id-ul clasei de fitness la care doriti sa participati");

            int alegere = Int32.Parse(Console.ReadLine());

            Fitness clasafitness = controllerfitness.fitnesss(alegere);
            
            Console.WriteLine($"V-ati iregistrat pentru clasa de fitness {clasafitness.getNume()}");
        }

    }
}
