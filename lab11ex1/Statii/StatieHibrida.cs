using lab11ex1.Autovehicule;
using lab11ex1.Autovehicule.Interfete;

namespace lab11ex1.Statii
{
        class StatieHibrida : StatieClasica
        {
            public void AlimenteazaElectric(IElectric autovehiculElectric, int cantitate)
            {
                Console.WriteLine($"Alimentam cu energie electrica autovehicolul {autovehiculElectric}.");
                autovehiculElectric.IncarcaElectric(cantitate);
            }

        }
    }

