using System;
namespace BakeryCart131.Models
{
    public class Cake
    {


        public string CakeId { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public string Form { get; set; }

        public string Flavor { get; set; }

        public Role Role { get; set; }

        public void AddFlavor()
        {
            this.Flavor = "Chocolate";
            Console.WriteLine("You are adding a flavor, the flavor is Chocolate");

        }
        public void AddFlavor(string NewFlavor)
        {
            this.Flavor = "NewFlavor";



        }
    }
}


