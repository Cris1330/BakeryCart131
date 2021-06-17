using System;
namespace BakeryCart131.Models
{
    public class WeddingCake : Cake 
    {
        public WeddingCake()
        {
            this.Flavor = "Whatever";

            
        }
        public virtual void AddFlavor()
        {

            this.Flavor = " Chocolate";

            Console.WriteLine("You are adding a flavor. the flavor is Chocolate");

        }
    }


}
