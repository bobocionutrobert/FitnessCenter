using System;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {

            Membru membru = new Membru(1,"nume",293120,"email","adresa","username","parola");
            ViewMembru view = new ViewMembru(membru);

            view.play();
        }
    }
}
