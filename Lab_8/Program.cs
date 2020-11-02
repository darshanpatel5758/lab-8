using System;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 0 - 19 or if your know the name then enter name ) : ");
            int userInputs = Convert.ToInt32(Console.ReadLine());

            string[] name = new string[20] { "Aniket", "Anand", "Pizza", "Darshan", "Anand", "Pani Puri", "Chirag", "Anand", "Pani Puri","Vipul", "Anand", "Pani Puri","Jackson", "Anand", "Pani Puri",
                                                  "Raj", "Anand", "Pani Puri",
                                                  "Kamini", "Anand"};

            string[] homeTown = new string[20] { "detroit", "Gujrat", "Ahmedabad", "Nadiyad", "Khanbhat", "Poor", "Khanbhaipura", "Balugam", "Up","Mp", "Karnataka", "Canton","Flint", "Grand Rapid", "Pooor",
                                                  "Raj", "Kanjji", "hjjsvh",
                                                  "BHani", "Khali"};

            string[] favoriteFood = new string[20] { "Aniket", "Anand", "Pizza", "Darshan", "Anand", "Pani Puri", "Chirag", "Anand", "Pani Puri","Vipul", "Anand", "Pani Puri","Jackson", "Anand", "Pani Puri",
                                                  "Raj", "Anand", "Pani Puri",
                                                  "Kamini", "Anand"};


            
                for (int i = 0; i < 20; i++)
                {
                    
                    if (i == userInputs)
                    {
                        Console.WriteLine($"Student {userInputs} is {name[i]}. What would you like to know about {name[i]}? (enter “hometown” or" +
                    "“favorite food”): ");
                        string userInput1 = Console.ReadLine();

                        if (userInput1.Equals("hometown", StringComparison.OrdinalIgnoreCase))
                        {
                        for (int j = i; j == i; j++)
                        {
                            Console.WriteLine($"{name[i]} is from {homeTown[i]}. Would you like to know more? (enter “yes” or “no”): ");
                            string userInput2 = Console.ReadLine();

                            if (userInput2.Equals("yes", StringComparison.OrdinalIgnoreCase))
                            {
                                 Console.WriteLine($"{name[i]} FavoriteFood is {favoriteFood[i]}");                                   
                            }
                            else
                            {
                                Console.WriteLine("Thank you!");

                                break;
                            }
                        }
                        }
                        else if (userInput1.Equals("favorite food", StringComparison.OrdinalIgnoreCase))
                        {

                            for (int j = i; j == i; j++)
                            {
                                Console.WriteLine($"Kim is from {favoriteFood[i]}. Would you like to know more? (enter “yes” or “no”): ");
                                string userInput3 = Console.ReadLine();
                            if (userInput3.Equals("yes", StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"{name[i]} FavoriteFood is {favoriteFood[i]}");
                            }
                            else
                            {
                                Console.WriteLine("Thank you!");

                                break;
                            }

                            }
                        }
                        else
                        {
                            Console.WriteLine("That data does not exist. Please try again");                          

                        }

                    }
                   
                }
           

            

            


        }
    }
}
