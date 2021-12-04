using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    public class Abonament
    {
        private int idabonament;
        private string numeclient;
        private string tipabonament;
        private int valabilitate;
        private int pret;
        private bool antrenorinclus;


        public Abonament(int idabonament,string numeclient,string tipabonament,int valabilitate,int pret, bool antrenorinclus)
        {
            this.idabonament = idabonament;
            this.numeclient = numeclient;
            this.tipabonament = tipabonament;
            this.valabilitate = valabilitate;
            this.pret = pret;
            this.antrenorinclus = antrenorinclus;
        }

        public string getNumeClient()
        {
            return this.numeclient;
        }

        public void setNumeClient(string numeclient)
        {
            this.numeclient = numeclient;
        }

        public string getTipAbonament()
        {
            return this.tipabonament;
        }

        public void setTipAbonament(string tipabonament)
        {
            this.tipabonament = tipabonament;
        }

        public int getValabilitate()
        {
            return this.valabilitate;
        }

        public void setValabilitate(int valabilitate)
        {
            this.valabilitate = valabilitate;
        }

        public int getPret()
        {
            return this.pret;

        }

        public void setPret(int pret)
        {
            this.pret = pret;
        }

        public bool getAntrenorInclus()
        {
            return this.antrenorinclus;
        }

        public void setAntrenorInclus(bool antrenorinclus)
        {
            this.antrenorinclus = antrenorinclus;
        }

        public int getIdAbonament()
        {
            return this.idabonament;
        }

        public void setIdAbonament(int idabonament)
        {
            this.idabonament = idabonament;
        }


        public string descriereabonament()
        {
            string text = "";

            text += "Numele clientului : " + numeclient + "\n";
            text += "Tipul de aobnament : " + tipabonament + "\n";
            text += "Valabilitate : " + valabilitate + "luni \n";
            text += "Pretul abonamentului : " + pret + "\n";
            text += "Antrenor inclus in pretul abonamentului ?" + antrenorinclus + "\n";

            return text;
        }

        public string toSave()
        {
            return this.idabonament+","+ this.numeclient + "," + this.tipabonament + "," + this.valabilitate + "," + this.pret + "," + this.antrenorinclus;

        }
    }
}
