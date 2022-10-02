using System;

namespace ATM___A_Program_without_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string accountNumber = "758938", pinNumber = "3845", askAccountNumber, askPinNumber;
                int accountAmount = 0, deposit, withdraw;
                //confirm Account Number
                Console.WriteLine("Please enter your account number:");
                askAccountNumber = Console.ReadLine();


                if (askAccountNumber == accountNumber)
                {
                    Console.WriteLine("Please enter pin number.");
                    askPinNumber = Console.ReadLine();
                    if (askPinNumber == pinNumber)
                    {

                        bool loopContinue = true;
                        while (loopContinue)
                        {

                            Console.WriteLine("Please select an option from the following menu:");
                            Console.WriteLine("1) Show Balance");
                            Console.WriteLine("2) Deposit");
                            Console.WriteLine("3) Withdraw");
                            Console.WriteLine("4) Exit");
                            Console.WriteLine("Enter 1,2,3 or 4");
                            int inputOption = int.Parse(Console.ReadLine());


                            switch (inputOption)

                            {
                                case 1:
                                    Console.WriteLine("The current balance is" + " " + accountAmount);
                                    loopContinue = true;
                                    break;

                                case 2:
                                    Console.WriteLine("Enter deposit amount:");
                                    deposit = int.Parse(Console.ReadLine());
                                    accountAmount = accountAmount + deposit;
                                    Console.WriteLine("The current balance after deposit is" + " " + "$" + accountAmount);
                                    loopContinue = true;
                                    break;
                                case 3:
                                    Console.WriteLine("Enter withdrawl amount:");
                                    withdraw = int.Parse(Console.ReadLine());

                                    if (withdraw > accountAmount)
                                    {
                                        Console.WriteLine("Insufficient funds.");
                                    }
                                    else if (withdraw < 0)
                                    {
                                        Console.WriteLine("Please enter a positive dollar amount.");
                                    }
                                    else
                                    {
                                        accountAmount = accountAmount - withdraw;
                                        Console.WriteLine("Please collect amount." + " " + withdraw);
                                        Console.WriteLine("The current balance after withdrawl is" + " " + accountAmount);
                                    }
                                    loopContinue = true;
                                    break;

                                case 4:
                                    //Console.WriteLine("Thank you for using VU Bank ATM.");
                                    loopContinue = false;
                                    break;

                                default:
                                    throw new ArgumentOutOfRangeException("Please pick an option 1-4.");

                            }

                        }

                    }
                    else
                        Console.WriteLine("Invalid. Please enter valid pin number.");
                }
                else
                    Console.WriteLine("Please enter valid account number.");

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
                //result = 1;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Unexpected error:  {exception}");
                //result = 1;
            }
            finally
            {
                Console.WriteLine($"Thank you for choosing VU Bank ATM!");
            }


        }
    }
}
