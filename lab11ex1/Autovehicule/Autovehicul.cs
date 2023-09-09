using lab11ex1.Autovehicule.Interfete;


namespace lab11ex1.Autovehicule
{

    abstract class Autovehicul
    {
        private readonly Guid id = Guid.NewGuid();
      

        protected Autovehicul(string name)
        {
            this.Name = name;
        
        }

        public string Name { get; private set; }


        public override string ToString()
        {
            return $"Autovehicolul{Name}, id {id}.";
        }


    }
}