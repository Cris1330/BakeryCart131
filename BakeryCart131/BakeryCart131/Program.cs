using System;
using System.Collections.Generic;
using System.Linq;
using BakeryCart131;

namespace BakeryCart131
{
    class Program
    {
        static void Main()
        {
            public void ExecuteMainMenu()
            {
                string response = "";

                while (response != "7")
                {
                    PrintMenu();

                    response = CaptureResponse();

                    switch (response)
                    {
                        case "1":
                            CreateUser();
                            break;
                        case "2":
                            CreateCakeReview();
                            break;
                        case "3":
                            ShowAllExistingUsers();
                            break;
                        case "4":
                            ShowAllExistingCakeReviews();
                            break;
                        case "5":
                            LookForAUser();
                            break;
                        case "6":
                            LookForACakeReview();
                            break;
                    }
                }
            }
        }

    }
}
