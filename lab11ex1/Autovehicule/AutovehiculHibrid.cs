
using lab11ex1.Autovehicule.Interfete;

namespace lab11ex1.Autovehicule
{
    class AutovehiculHibrid : AutovehiculBenzina, IElectric
    {
        public AutovehiculHibrid(string name) : base(name)
        {

        }
        public void IncarcaElectric(int kwh)
        {
            Console.WriteLine($"Am alimentat {kwh} kwh");
        }
    }
}