using System;

namespace ATM
{
    class Program
    {
        public static void Main(string[] args)
        {
            void printOptions()
            {
                Console.WriteLine("PLEASE CHOOSE FROM ONE OF THE FOLLOWING OPTIONS");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
            }

            void deposit(CardHolder user)
            {
                try
                {
                    Console.WriteLine("Current Balance: " + user.getBalance());
                    Console.Write("How much money would you like to deposit: ");

                    double amount = Double.Parse(Console.ReadLine());
                    double currentBalance = user.getBalance();
                    double newBalance = currentBalance + amount;

                    user.setBalance(newBalance);
                    Console.WriteLine("New Balance: " + user.getBalance());
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }
            }

            void withdraw(CardHolder user)
            {
                try
                {
                    Console.WriteLine("Current Balance: " + user.getBalance());
                    Console.Write("How much money would you like to withdraw: ");

                    double amount = Double.Parse(Console.ReadLine());
                    double currentBalance = user.getBalance();

                    if (currentBalance < amount) 
                    {
                        Console.WriteLine("You don't have enough money!");
                    }

                    else
                    {
                        double newBalance = currentBalance - amount;
                        user.setBalance(newBalance);
                        Console.WriteLine("New Balance: " + user.getBalance());
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e);
                }
            }

            void balance(CardHolder user)
            {
                Console.WriteLine("Current Balance: " + user.getBalance());
            }


            List<CardHolder> cardHolders = new List<CardHolder>();
            cardHolders.Add(new CardHolder("Tony", "Stark", "5553 0422 4198 4105", 1234, 5000));
            cardHolders.Add(new CardHolder("Bruce", "Wayne", "5555 5537 5304 8194", 2468, 6000));
            cardHolders.Add(new CardHolder("Peter", "Parker", "5555 5555 5555 4444", 1357, 7000));
            cardHolders.Add(new CardHolder("Clark", "Kent", "4012 8888 8888 1881", 9876, 8000));

            Console.WriteLine("Welcome To ATM");
            
            // Card Number Check
            Console.Write("Please insert your debit card: ");
            string debitCardNumber = "";
            CardHolder currentUser;

            while (true)
            {
                try
                {
                    debitCardNumber = Console.ReadLine();
                    currentUser = cardHolders.FirstOrDefault(a => a.getCardNumber().Equals(debitCardNumber));

                    if (currentUser != null) 
                    {
                        Console.WriteLine("User Found");
                        break;
                    }

                    else 
                    {
                        Console.WriteLine("User Not Existed");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }

            // Pin Check
            Console.Write("Please enter your pin: ");
            int userPin = 0;
            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());

                    if (currentUser.getPin() == userPin)
                    {
                        Console.WriteLine("Pin Correct");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Pin Incorrect");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }

            Console.WriteLine("Welcome " + currentUser.getFirstName() + "!");

            int option = 0;

            do
            {
                printOptions();

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error:" + e);
                }

                if (option == 1)
                {
                    deposit(currentUser);
                }

                else if (option == 2)
                {
                    withdraw(currentUser);
                }

                else if (option == 3)
                {
                    balance(currentUser);
                }

                else if (option == 4)
                {
                    break;
                }

                else
                {
                    option = 0;
                }

            } while (option != 4);

            Console.WriteLine("Thank You!");
            Console.WriteLine("Have a Nice Day :)");
        }
    }
}