using lab11ex1.Autovehicule.Interfete;
using lab11ex1.Combustibili;


namespace lab11ex1.Autovehicule
{
    class AutovehiculBenzina : Autovehicul, IBenzina
    {
        public AutovehiculBenzina(string name) : base(name)
        {

        }

        public void IncarcaBenzina(int litri)
        {
            Console.WriteLine($"Am alimentat {litri}l benzina");
        }
    }
}