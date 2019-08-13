namespace petshop.Models
{
    //NOTE: Classes are blueprints for objects
    class Cat : Animal
    {
        //NOTE Private denotes only methods and properties inside the class have access to it.
        private int Age { get; set; }

        public int GetAge()
        {
            return Age;
        }


        //NOTE: VOID returns nothing, there is no return at all
        public void Feed(string food)
        {
            if (food == "fish")
            {
                Feed();
            }
            else
            {
                System.Console.WriteLine("YAK");
                Hungry = true;
            }
        }


        public Cat(string name, int age) : base(name, "mew")
        {
            Age = age;
        }





        //NOTE METHOD OVERLOADING allows for methods to have the same name and different signatures
        public int Add(int a, int b)
        {
            return a + b;
        }

        public float Add(float a, float b)
        {
            return a + b;
        }

        public string Add(string a, string b)
        {
            return a + " " + b;
        }


    }
}


