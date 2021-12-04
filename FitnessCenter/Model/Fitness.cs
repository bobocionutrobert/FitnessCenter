using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    public class Fitness
    {

        private int idfitness;
        private string descriere;
        private string tip;
        private string nume;

        public Fitness()
        {

        }

        public Fitness(int idfitness,string descriere, string tip,string nume)
        {
            this.idfitness = idfitness;
            this.descriere = descriere;
            this.tip = tip;
            this.nume = nume;
        }

        public int getIdfitness()
        {
            return this.idfitness;
        }

        public void setIdfitness(int idfitness)
        {
            this.idfitness = idfitness;
        }

        public string getDescriere()
        {
            return this.descriere;
        }

        public void setDescriere(string descriere)
        {
            this.descriere = descriere;
        }

        public string getTip()
        {
            return this.tip;
        }

        public void setTip(string tip)
        {
            this.tip = tip;
        }

        public string getNume()
        {
            return this.nume;
        }

        public void setNume(string nume)
        {
            this.nume = nume;
        }

        public string descriereclasa()
        {
            string text = "";

            text += "Id clasa fitness : " + idfitness + "\n";
            text += "Descrierea clasei : " + descriere + "\n";
            text += "Tipul Clasei : " + tip + "\n";
            text += "Numele Clasei : " + nume + "\n";

            return text;
        }

        public string toSave()
        {
            return this.idfitness + "," + this.descriere + "," + this.tip + "," + this.nume;
        }
    }
}
