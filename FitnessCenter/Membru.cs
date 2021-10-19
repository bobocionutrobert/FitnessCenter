using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    public class Membru
    {

        private int idmembru;
        private string numemembru;
        private int telefonmembru;
        private string email;
        private string adresa;
        private string username;
        private string parola;

        

        public Membru()
        {

        }

        public Membru(int idmembru, string numemembru, int telefonmembru, string email,string adresa,string username,string parola)
        {
            this.idmembru = idmembru;
            this.numemembru = numemembru;
            this.telefonmembru = telefonmembru;
            this.email = email;
            this.adresa = adresa;
            this.username = username;
            this.parola = parola;
        }
        public int getIdmembru()
        {
            return this.idmembru;
        }

        public void setIdmembru(int idmembru)
        {
            this.idmembru = idmembru;
        }

        public string getNumemembru()
        {
            return this.numemembru;
        }

        public void setNumemembru(string numemembru)
        {
            this.numemembru = numemembru;
        }

        public int getTelefonmembru()
        {
            return this.telefonmembru;
        }

        public void setTelefonmembru(int telefonmembru)
        {
            this.telefonmembru = telefonmembru;
        }

        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getAdresa()
        {
            return this.adresa;
        }

        public void setAdresa(string adresa) 
        {
            this.adresa = adresa;
        }

        public string getUsername()
        {
            return this.username;
        }
        
        public void setUsername(string username)
        {
            this.username = username;
        }

        public string getParola()
        {
            return this.parola;
        }

        public void setParola(string parola)
        {
            this.parola = parola;
        }

        public string descriere()
        {
            string text = "";

            text += "Id membru : " + idmembru + "\n";
            text += "Nume membru : " + numemembru + "\n";
            text += "Telefon membru : " + telefonmembru + "\n";
            text += "Email membru : " + email + "\n";
            text += "Adresa membru : " + adresa + "\n";

            return text;
        }

        public string toSave()
        {
            return this.idmembru + "," + this.numemembru + "," + this.telefonmembru + "," + this.email + "," + this.adresa + "," + this.username + "," + this.parola;
        }
    }
}
