using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    class ViewLogin
    {

        private ControllerMembri controlmembru;
        private ControllerAntrenori controlantrenori;

        public ViewLogin()
        {
            controlmembru = new ControllerMembri();
            controlantrenori = new ControllerAntrenori();
        }

        public void meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a va loga");

            Console.WriteLine("Apasati tasta 2 pentru a va inregistra ca membru");

            Console.WriteLine("Apasati tasta 3 a va inregitra ca antrenor");

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

                        Login();

                        break;
                    case 2:

                        RegistrareMembru();
                        break;

                    case 3:
                        RegistrareAntrenor();
                        break;



                }
            }
        }

        public void Login()
        {
            Console.WriteLine("Introduceti username-ul");
            string username = Console.ReadLine();

            Console.WriteLine("Introduceti parola");
            string password = Console.ReadLine();



            Membru p = controlmembru.returnMembru(username, password);
            Antrenor a = controlantrenori.returnAntrenor(username, password);

            if (p != null)
            {
                if (p.getUsername().Equals(username) == true)
                {
                    ViewMembru v = new ViewMembru(p);

                    v.play();

                    Console.WriteLine("autentificat ca membru");

                }
                else if (a.getUsername().Equals(username) == true)
                {
                    ViewAntrenor u = new ViewAntrenor(a);

                    u.play();

                    Console.WriteLine("autentificat ca antrenor");
                }
                else
                {
                    //registrare
                    Console.WriteLine("Userul nu exista");
                }
            }





        }

        public void RegistrareMembru()
        {
            //id,nume,telefon,email,adresa,username,parola


            Random random = new Random();
            int idrandom = random.Next(100, 10000);

            Console.WriteLine("Introduceti numele dumneaovastra : ");
            string nume = Console.ReadLine();

            Console.WriteLine("Introduceti numarul dumneaovastra de telefon : ");

            int nrtelefon = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti adresa dumneavoastra de email : ");

            string email = Console.ReadLine();

            Console.WriteLine("Introduceti adresa dumneavoastra : ");

            string adresa = Console.ReadLine();

            Console.WriteLine("Introduceti numele de utilizator pe care il doriti : ");

            string numeutilizator = Console.ReadLine();

            Console.WriteLine("Introduceti parola pentru utilizator");

            string parolautilizator = Console.ReadLine();



            Membru m = new Membru(idrandom, nume, nrtelefon, email, adresa, numeutilizator, parolautilizator);

            controlmembru.add(m);

            controlmembru.Save();




        }

        public void RegistrareAntrenor()
        {

            Random random = new Random();
            int idrandom = random.Next(100, 10000);

            Console.WriteLine("Introduceti numele dumneaovastra : ");
            string numeantrenor = Console.ReadLine();

            Console.WriteLine("Introduceti numarul dumneaovastra de telefon : ");

            int nrtelefonantrenor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti adresa dumneavoastra de email : ");

            string emailantrenor = Console.ReadLine();

            Console.WriteLine("Introduceti adresa dumneavoastra : ");

            string adresaantrenor = Console.ReadLine();

            Console.WriteLine("Introduceti numele de utilizator pe care il doriti : ");

            string usernameantrenor = Console.ReadLine();

            Console.WriteLine("Introduceti parola pentru utilizator");

            string parolaantrenor = Console.ReadLine();

            Antrenor a = new Antrenor(idrandom, numeantrenor, nrtelefonantrenor, emailantrenor, adresaantrenor, usernameantrenor, parolaantrenor);

            controlantrenori.add(a);

            controlantrenori.Save();

        }


    }
}

