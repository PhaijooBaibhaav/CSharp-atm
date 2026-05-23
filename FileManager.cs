using System;
using System.IO;
using System.Collections.Generic;

class FileManager {


    private static string path = "data/accounts.txt";

    public static void SaveData(List<Account> accounts) {

        StreamWriter writer = new StreamWriter(path);

            foreach (Account account in accounts)
            {
                writer.WriteLine(
                    $"{account.name},{account.pinCode},{account.GetBalance()}"
                );
            }
            
        writer.Close();
    }

    public static List<Account> LoadData() {

        List<Account> accounts = new List<Account>();
        if (!File.Exists(path)) {
            return accounts;
        }

        string[] lines = File.ReadAllLines(path);

        foreach (string line in lines) {
            string[] data = line.Split(',');

            Account account = new Account();

            account.name = data[0];
            account.pinCode = Convert.ToInt32(data[1]);
            double balance = Convert.ToDouble(data[2]);
            account.DepositMoney(balance);

            accounts.Add(account);
        }

        return accounts;
    }
}
