using System;
using System.Collections.Generic;

class ATM {

    private List<Account> accounts = new List<Account>();
    
    public ATM(List<Account> accounts) {
        this.accounts = accounts;
    }

    int pin; 
    string name; 

    public void SignUp() {

        Console.WriteLine("Write your name: ");
        name = Console.ReadLine();

        Console.WriteLine("write your pin code: ");
        pin = Convert.ToInt32(Console.ReadLine());

        Account account = new Account();

        account.name = name;
        account.pinCode = pin;

        accounts.Add(account);
    }

    public void Login() {

        Console.WriteLine("Write your name: ");
        string name = Console.ReadLine(); 

        Console.WriteLine("Write your pin code: ");
        int pin = Convert.ToInt32(Console.ReadLine());


        foreach (Account account in accounts) {
            if (name == account.name && pin == account.pinCode) {
                Console.WriteLine($"Logged into {account.name}");
                AccountMenu(account);
                return;
            }
        }

        Console.WriteLine("Wrong name or pin");

    }

    public static void AccountMenu(Account account) {

        while (true) {

            Console.WriteLine("Write the operation to do\n1. Check Balance 2. Withdraw Money 3. Deposit Money 4. Exit");
            String choice = Console.ReadLine();

            switch (choice) {

                case "1":
                    Console.WriteLine($"Your balance is: {account.GetBalance()}");
                    break;

                case "2":
                    Console.WriteLine("Write the amount to withdraw: ");

                    if (double.TryParse(Console.ReadLine(), out double withdrawAmount)) {
                        account.WithdrawMoney(withdrawAmount);
                        Console.WriteLine($"${withdrawAmount} withdrawn.");
                    } else {
                        Console.WriteLine("Invalid Amount!");
                    }
                    break;

                case"3":
                    Console.WriteLine("Enter the amount to deposit:");

                    if (double.TryParse(Console.ReadLine(), out double depositAmount)) {
                        account.DepositMoney(depositAmount);
                        Console.WriteLine($"${depositAmount} deposited");
                    } else {
                        Console.WriteLine("Invalid Amount!");
                    }
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}    
