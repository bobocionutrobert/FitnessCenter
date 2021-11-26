using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    class ViewAdmin
    {
        private Admin admin;

        private ControllerAntrenori controllerantrenori;
        private ControllerMembri controllermembri;
        private ControllerFitness controllerfitness;
        private ControllerAbonament controllerabonament;

        public ViewAdmin(Admin admin)
        {
            this.admin = admin;
            controllerantrenori = new ControllerAntrenori();
            controllermembri = new ControllerMembri();
            controllerfitness = new ControllerFitness();
            controllerabonament = new ControllerAbonament();
        }
        public void meniu()
        {
            Console.WriteLine("===================Meniu Admin================");
            Console.WriteLine($"Bun venit, {admin.getNumeAdmin()}");
            Console.WriteLine("Apasati tasta 1 pentru a adauga un membru nou ");
            Console.WriteLine("Apasati tasta 2 pentru a adauga un antrenor nou");
            Console.WriteLine(" Apasati tasta 3 pentru a adauga un abonament nou");
            Console.WriteLine("Apasati tasta 4 a sterge un abonament nou");
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
                        adaugareMembru();
                        break;
                    case 2:
                        adaugareAntrenor();
                        break;
                    case 3:
                        adaugareAbonamentnou();
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


        public void adaugareMembru()
        {

            Random rnd = new Random();
            int idmembrunou = rnd.Next();
            Console.WriteLine("Adaugati numele noului membru ");

            string numemembru = Console.ReadLine();

            Console.WriteLine("Introduceti numarul de telefon al noului membru : ");

            int nrtelefonmembrunou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("introduceti emailul noului membru :  ");

            string emailmembrunou = Console.ReadLine();

            Console.WriteLine("Introduceti adresa membrului nou ");

            string adresamembrunou = Console.ReadLine();

            Console.WriteLine("Adaugati un username pentru membrul nou : ");

            string usernamemembrunou = Console.ReadLine();

            Console.WriteLine("Adaugati o parola penru membrul nou");
            string parolamembrunou = Console.ReadLine();

            Membru membrunou = new Membru(idmembrunou, numemembru, nrtelefonmembrunou, emailmembrunou, adresamembrunou, usernamemembrunou, parolamembrunou);
        }

        public void adaugareAntrenor()
        {
            Random rnd = new Random();
            int idantrenonou = rnd.Next();

            Console.WriteLine("Adaugati numele noului antrenor : ");

            string numeantrenornou = Console.ReadLine();

            Console.WriteLine("Adaugati numarul de telefon al noului antrenor : ");
            int nrtelefonantrenornou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Adaugati emailul noului antrenor : ");

            string emailantrenornou = Console.ReadLine();

            Console.WriteLine("Adaugati adresa noului antrenor");

            string adresaantrenornou = Console.ReadLine();

            Console.WriteLine("Adaugati un username pentru noul antrenor : ");

            string usernameantrenornou = Console.ReadLine();

            Console.WriteLine("Adaugati o parola pentru noul antrenor : ");

            string parolaantrenornou = Console.ReadLine();

            Antrenor antrenornou = new Antrenor(idantrenonou, numeantrenornou, nrtelefonantrenornou, emailantrenornou, adresaantrenornou, usernameantrenornou, parolaantrenornou);

            controllerantrenori.add(antrenornou);
        }

        public void adaugareAbonamentnou()
        {
            Random rnd = new Random();
            int idabonamentnou = rnd.Next();

            Console.WriteLine("Introduceti numele clientului : ");

            string numeclient = Console.ReadLine();

            Console.WriteLine("Introduceti tipul de abonament ales de client : ");

            string tipabonament = Console.ReadLine();

            Console.WriteLine("Adaugati valabilitatea pentru abonamentul selectat : ");

            int valabilitate = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Adaugati pretul abonamentului ales : ");

            int pret = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Abonamentul include antrenor ? ");

            bool antrenorinclus = bool.Parse(Console.ReadLine());

            Abonament abonamentnou = new Abonament(idabonamentnou, numeclient, tipabonament, valabilitate, pret, antrenorinclus);

            controllerabonament.add(abonamentnou);

        }

        public void stergereAbonament()
        {

            Console.WriteLine("Introduceti id-ul abonamentului pe care  doriti sa il stergeti : ");

            int idabonament = Int32.Parse(Console.ReadLine());

            controllerabonament.delete(idabonament);

            
        }

    }


}

