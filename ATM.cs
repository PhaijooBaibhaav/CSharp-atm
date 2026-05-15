using System;
using System.Collections.Generic;

class ATM {

    private List<Account> accounts = new List<Account>();

    int pin; 
    string name; 

    public void SignUp() {

        Console.WriteLine("Write your name: ");
        name = Console.ReadLine();

        Console.WriteLine("Write your pin code: ");
        pin = Convert.ToInt32(Console.ReadLine());

        Account account = new Account();

        account.name = name;
        account.pinCode = pin;

        accounts.Add(account);
    }

    public void Login() {

    }
}    
