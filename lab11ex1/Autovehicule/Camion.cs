using System;
using lab11ex1.Autovehicule;

namespace lab11ex1.Autovehicule
{
    class Camion : AutovehiculDiesel
    {
        public Camion(string nume) : base(nume)
        {
            Cisterna = new Cisterna();
        }

        public Cisterna Cisterna { get; private set; }

    }

}

