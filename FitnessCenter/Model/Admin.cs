using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    public class Admin
    {
        private int idadmin;
        private string numeadmin;
        private int telefonadmin;
        private string username;
        private string parola;
        private bool admin;

        public Admin(int idadmin,string numeadmin,int telefonadmin,string username,string parola,bool admin)
        {
            this.idadmin = idadmin;
            this.numeadmin = numeadmin;
            this.telefonadmin = telefonadmin;
            this.username = username;
            this.parola = parola;
            this.admin = true;
        }

        public int getIdAdmin()
        {
            return this.idadmin;
        }

        public void setIdAdmin(int idadmin)
        {
            this.idadmin = idadmin;
        }

        public string getNumeAdmin()
        {
            return this.numeadmin;
        }

        public void setNumeAdmin(string numeadmin)
        {
            this.numeadmin = numeadmin;
        }

        public int getNrTelefonAdmin()
        {
            return this.telefonadmin;
        }

        public void setNrTelefonAdmin(int telefonadmin)
        {
            this.telefonadmin = telefonadmin;
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

        public string descriereadmin()
        {
            string text = "";

            text += "Id Admin : " + idadmin + "/n";
            text += "Nume Admin : " + numeadmin + "/n";
            text += "Numar telefon admin : " + telefonadmin + "/n";

            return text;
        }

        public string toSave()
        {
            return this.idadmin + "," + this.numeadmin + "," + this.telefonadmin + "," + this.username + "," + this.parola + "," + this.admin;
        }
    }
}
