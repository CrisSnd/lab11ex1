using lab11ex1.Autovehicule.Interfete;

namespace lab11ex1.Autovehicule
{
    class AutovehiculGPL : Autovehicul, IGPL
    {
        public AutovehiculGPL(string name) : base(name)
        {

        }

        public void IncarcaGPL(int litri)
        {
            Console.WriteLine($"Am alimentat {litri}l GPL");
        }

      
     }
}
