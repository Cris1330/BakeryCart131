using System;
using System.Collections.Generic;
using System.Linq;
using BakeryCart131.Models;

namespace BakeryCart131
{
    class Program
    {


        static void Main()
        {
            List<Cake> myList = new List<Cake>();

            Cake myFirstCake = new Cake();
            myFirstCake.CakeId = 1;
            myFirstCake.Flavor = "Chocolate";
            myFirstCake.Form = "Square";
            myFirstCake.Size = "Medium";
            myFirstCake.Type = "Wedding Cake";


            myList.Add(myFirstCake);

            Cake mySecondCake = new Cake();
            mySecondCake.CakeId = 1;
            mySecondCake.Flavor = "Vanilla";
            mySecondCake.Form = "Round";
            mySecondCake.Size = "Small";
            mySecondCake.Type = "Party Cake";


            myList.Add(mySecondCake);

            Cake myThirdCake = new Cake();
            myThirdCake.CakeId = 2;
            myThirdCake.Flavor = "Vanilla";
            myThirdCake.Form = "Square";
            myThirdCake.Size = "Large";
            myThirdCake.Type = "Graduation Cake";


            myList.Add(myThirdCake);



            List<Cake> result = myList.Where(cake => cake.CakeId == 2).ToList();


            foreach (var cake in result)
            {
                Console.WriteLine(cake.CakeId);
                Console.WriteLine(cake.Type);
            }
        }


    }
}
