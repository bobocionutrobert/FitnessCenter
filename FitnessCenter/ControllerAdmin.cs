using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FitnessCenter
{
    public class ControllerAdmin
    {
        private List<Admin> admini;

        public ControllerAdmin()
        {
            admini = new List<Admin>();

            load();
        }

        public void afisare()
        {
            for(int i = 0; i < admini.Count; i++)
            {
                Console.WriteLine(admini[i].descriereadmin());
            }
        }

        public int pozitiedupaid(int idadmin)
        {
            for(int i = 0; i < admini.Count; i++)
            {
                if(admini[i].getIdAdmin() == idadmin)
                {
                    return i;
                }
            }

            return -1;
        }

        public Admin admin(int idadmin)
        {
            for(int i = 0; i < admini.Count; i++)
            {
                if(admini[i].getIdAdmin() == idadmin)
                {
                    return admini[i];
                }
            }

            return null;
        }

        public Admin returnAdmin(string username,string parola)
        {
            for(int i = 0; i < admini.Count; i++)
            {
                if(admini[i].getUsername().Equals(username) == true && admini[i].getParola().Equals(parola) == true)
                {
                    return admini[i];
                }
            }
            return null;
        }

        public bool add(Admin admin)
        {
            int poz = pozitiedupaid(admin.getIdAdmin());

            if(poz != -1)
            {
                return false;
            }
            else
            {
                admini.Add(admin);
                return true;
            }
        }

        public bool delete(int idadmin)
        {
            int poz = pozitiedupaid(idadmin);

            if(poz == -1)
            {
                return false;
            }
            else
            {
                admini.RemoveAt(poz);
                return true;
            }
        }

        public bool updateNume(int idadmin,string numeNou)
        {
            int poz = pozitiedupaid(idadmin);

            if( poz == -1)
            {
                return false;
            }
            else
            {
                admini[poz].setNumeAdmin(numeNou);
                return true;
            }
        }

        public void load()
        {
            StreamReader read = new StreamReader(@"C:\Users\catas\Desktop\FullStackC#\Incapsularea\FitnessCenter\FitnessCenter\admini.txt");

            string line = "";

            while ((line = read.ReadLine()) != null)
            {
                string[] prop = line.Split(",");

                int idadmin = Int32.Parse(prop[0]);
                string numeadmin = prop[1];
                int telefonadmin = Int32.Parse(prop[2]);
                string username = prop[3];
                string parola = prop[4];
                bool admin = bool.Parse(prop[5]);

                Admin adminnou = new Admin(idadmin, numeadmin, telefonadmin, username, parola, admin);

                admini.Add(adminnou);


            }
            read.Close();

        }

        public string toSave()
        {
            string text = "";

            int i = 0;

            for (i = 0; i < admini.Count; i++)
            {
                text += admini[i].toSave() + "/n";
            }

            text += admini[i].toSave();
            return text;
        }

        public void Save()
        {
            StreamWriter write = new StreamWriter(@"C:\Users\catas\Desktop\FullStackC#\Incapsularea\FitnessCenter\FitnessCenter\admini.txt");

            write.Write(toSave());
            write.Close();
        }

    }
}
