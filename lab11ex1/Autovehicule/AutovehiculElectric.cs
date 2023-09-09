using lab11ex1.Autovehicule.Interfete;

namespace lab11ex1.Autovehicule
{
    class AutovehiculElectric : Autovehicul, IElectric
    {
        public AutovehiculElectric(string name) : base(name)
        {

        }

        public void IncarcaElectric(int kwh)
        {
            Console.WriteLine($"Am alimentat {kwh} kwh");
        }
    }
}