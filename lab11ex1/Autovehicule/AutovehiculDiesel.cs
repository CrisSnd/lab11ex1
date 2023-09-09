using lab11ex1.Autovehicule.Interfete;

namespace lab11ex1.Autovehicule
{
    class AutovehiculDiesel : Autovehicul, IDiesel
    {
        public AutovehiculDiesel(string name) : base(name)
        {

        }

        public void IncarcaDiesel(int litri)
        {
            Console.WriteLine($"Am alimentat {litri}l motorina");
        }
    }
}