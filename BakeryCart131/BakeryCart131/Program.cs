using System;
using BakeryCart131.Models;
using BakeryCart131.DTOS;

namespace BakeryShoppingCart
{
    class Program
    {
        private static object myBekeryCart;

        static void Main()
        {
            string response = "";

            ShoppingCart myShoppingCart = new ShoppingCart();

            while (response != "5")
            {
                myShoppingCart.PrintMenu();

                response = myShoppingCart.CaptureResponse();

                switch (response)
                {
                    case "1":
                        myBakeryCart.CreateUser();
                        break;
                    case "2":
                        myBakeryCart.CreateCakeReview();
                        break;
                    case "3":
                        myBekeryCart.ShowAllExistingUsers();
                        break;
                    case "4":
                        myBekeryCart.ShowAllExistingCakeReviews();
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
