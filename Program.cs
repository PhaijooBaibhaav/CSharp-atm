using System;

class Program {
    static void Main(String[] args) {

        List<Account> accounts = FileManager.LoadData();
        ATM atm = new ATM(accounts);

        atm.SignUp();
        atm.Login();

        FileManager.SaveData(accounts);

    }
}
