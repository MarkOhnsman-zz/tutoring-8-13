using System.Collections.Generic;

namespace petshop.Models
{
    class Store
    {
        //NOTE Lists are classes and must be instatiated;
        public List<Cat> Cats { get; set; }

        public Dictionary<string, List<Cat>> Breeds { get; set; }

        public Store()
        {
            Cats = new List<Cat>();
            Breeds = new Dictionary<string, List<Cat>>(){
                {"tabby", new List<Cat>()},
                {"calico", new List<Cat>()},
                {"sphinx", new List<Cat>()}
            };
            //NOTE: This same structure builds a dictionary as follows 
            // Breeds = {
            //      tabby: [{CAT},{CAT},{CAT}],
            //      calico: [{CAT}],
            //      sphinx: [{CAT},{CAT}]
            // }
        }
    }
}
