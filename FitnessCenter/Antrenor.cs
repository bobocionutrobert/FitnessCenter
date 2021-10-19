using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    public class Antrenor
    {

        private int idantrenor;
        private string numeantrenor;
        private int telefonantrenor;
        private string emailantrenor;
        private string adresa;
        private string username;
        private string parola;

        public Antrenor()
        {

        }

        public Antrenor(int idantrenor, string numeantrenor, int telefonantrenor, string emailantrenor, string adresa, string username, string parola)
        {
            this.idantrenor = idantrenor;
            this.numeantrenor = numeantrenor;
            this.telefonantrenor = telefonantrenor;
            this.emailantrenor = emailantrenor;
            this.adresa = adresa;
            this.username = username;
            this.parola = parola;

        }

        public int getIdantrenor()
        {
            return this.idantrenor;
        }

        public void setIdantrenor(int idantrenor)
        {
            this.idantrenor = idantrenor;
        }

        public string getNumeantrenor()
        {
            return this.numeantrenor;
        }

        public void setNumeantrenor(string numeantrenor)
        {
            this.numeantrenor = numeantrenor;
        }

        public int getTelefonantrenor()
        {
            return this.telefonantrenor;
        }

        public void setTelefonantrenor(int telefonantrenor)
        {
            this.telefonantrenor = telefonantrenor;
        }

        public string getEmailantrenor()
        {
            return this.emailantrenor;
        }

        public void setEmailantrenor(string emailantrenor)
        {
            this.emailantrenor = emailantrenor;
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
            text += "Id antrenor : " + idantrenor + "\n";
            text += "Nume antrenor : " + numeantrenor + "\n";
            text += "Telefon antrenor : " + telefonantrenor + "\n";
            text += "Adresa antrenor : " + adresa + "\n";
            text += "Email antrenor : " + emailantrenor + "\n";
            return text;
        }

        public string toSave()
        {
            return this.idantrenor + "," + this.numeantrenor + "," + this.telefonantrenor + "," + this.adresa + "," + this.emailantrenor + "," + this.username + "," + this.parola;
        }
    }
}
