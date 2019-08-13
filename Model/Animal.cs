namespace petshop.Models
{
    abstract class Animal
    {
        public string Name { get; set; }
        //NOTE protected allows only access from this class or derived (child) classes
        protected bool Hungry { get; set; }
        private string EatNoise { get; set; }

        public void Feed()
        {
            Hungry = false;
            System.Console.WriteLine(EatNoise);
        }

        public Animal(string name, string eatNoise)
        {
            Name = name;
            EatNoise = eatNoise;
            Hungry = true;
        }
    }
}