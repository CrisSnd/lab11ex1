using lab11ex1.Autovehicule;
using lab11ex1.Autovehicule.Interfete;

namespace lab11ex1.Statii
{
     class StatieClasica
    {
        public void AlimenteazaBenzina(IBenzina autovehiculBenzina,int cantitate)
        {
            Console.WriteLine($"Alimentam cu benzina autovehicolul {autovehiculBenzina}.");
            autovehiculBenzina.IncarcaBenzina(cantitate);
        }

        public void AlimenteazaGPL(IGPL autovehiculGPL, int cantitate)
        {
            Console.WriteLine($"Alimentam cu GPL autovehicolul {autovehiculGPL}.");
            autovehiculGPL.IncarcaGPL(cantitate);
        }

        public void AlimenteazaDiesel(IDiesel autovehiculDiesel, int cantitate)
        {
            Console.WriteLine($"Alimentam cu diesel autovehicolul {autovehiculDiesel}.");
            autovehiculDiesel.IncarcaDiesel(cantitate);
        }
    }
}
