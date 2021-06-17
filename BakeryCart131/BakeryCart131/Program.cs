﻿using System;
using System.Collections.Generic;
using System.Linq;
using BakeryCart131.Models;

namespace BakeryCart131
{
    class Program
    {

        static void Main()
        {
            string response = "";
            List<User> userList = new List<User>();
            List<Comment> commentList = new List<Comment>();

            while (response != "5")
            {
                Console.WriteLine("1.Creat a User");
                Console.WriteLine("2.Creat a Comment");
                Console.WriteLine("3.Print the List of Users");
                Console.WriteLine("4.Print the List of Comments");
                Console.WriteLine("5.Exit");


                Console.WriteLine("");
                Console.WriteLine("Please select an option");
                response = Console.ReadLine();

                switch (response)
                {
                    case "1":
                        User user = new User();
                        user.Email = "myemail@somewhere.com";
                        user.Password = "password";
                        user.UserId = 1;
                        user.UserName = "Cristal";

                        userList.Add(user);

                        Console.WriteLine("You have created a user");
                        break;

                    case "2":
                        Comment myComment = new Comment();
                        myComment.CommentId = 1;
                        myComment.TheComment = "Hello";
                       


                        commentList.Add(myComment);

                        Console.WriteLine("1You have created a comment");
                        break;

                    case "3":
                        Console.WriteLine("These is the list of users created");

                        foreach (var insideUser in userList)
                        {
                            Console.WriteLine("The user email is " + insideUser.Email);
                            Console.WriteLine("The user password is " + insideUser.Password);
                            Console.WriteLine("The user id is " + insideUser.UserId);
                            Console.WriteLine("The user name is " + insideUser.UserName);

                        }
                        break;
                    case "4":
                        Console.WriteLine("These is the list of comments created");

                        foreach (var insideComment in commentList)
                        {
                            Console.WriteLine("The comment id is " + insideComment.CommentId);
                            Console.WriteLine("The actual comment is " + insideComment.TheComment);
                           

                        }
                        break;

                }
            }





        }
    }
}

