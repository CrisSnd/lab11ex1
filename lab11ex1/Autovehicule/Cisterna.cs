using lab11ex1.Autovehicule.Interfete;
using lab11ex1.Combustibili;

namespace lab11ex1.Autovehicule
{
    class Cisterna : IBenzina, IDiesel
    {
        private int stoc = 0;
        private Combustibil combustibilStoc = Combustibil.Benzina;


        public override string ToString()
        {
            return $"Cisterna combustibil{combustibilStoc} cantitate {stoc}";   
        }



        public void IncarcaBenzina(int litri)
        {
            IncarcaCombustibil(litri, Combustibil.Benzina);
        }


        public void IncarcaDiesel(int litri)
        {
            IncarcaCombustibil(litri, Combustibil.Diesel);

        }



         private void IncarcaCombustibil(int litri,Combustibil combustibilIncarcat)
        {
            if (combustibilStoc != combustibilIncarcat && stoc != 0)
            {
                Console.WriteLine("Combustibil incompatibil");
            }
            else
            {
                stoc += litri;
            }
        }





        public void AlimenteazaBenzina(IBenzina autovehiculBenzina, int cantitate)
        {
            if (ConfirmareAlimentare(cantitate, Combustibil.Benzina))

                Console.WriteLine($"Alimentam cu benzina autovehicolul {autovehiculBenzina}.");
            autovehiculBenzina.IncarcaBenzina(cantitate);
             stoc-= cantitate;
        }




        public void AlimenteazaDiesel(IDiesel autovehiculDiesel, int cantitate)
        {

            if (ConfirmareAlimentare(cantitate,Combustibil.Diesel))
           {
                Console.WriteLine($"Alimentam cu diesel autovehicolul {autovehiculDiesel}.");
                autovehiculDiesel.IncarcaDiesel(cantitate);
            }
          
        }



        private bool ConfirmareAlimentare(int cantitateaDorita, Combustibil combustibilDorit)
        {
            if (combustibilStoc != combustibilDorit)

            {
                Console.WriteLine("Cisterna nu are combustibilul dorit");
                return false;
            }

            if (stoc < cantitateaDorita)
            {
                Console.WriteLine("Cisterna nu are suficient combustibil");
                return false;
            }

           return true;

        }


    }

}

