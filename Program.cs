using System;

class Program {
    static void Main(String[] args) {

        List<Account> accounts = FileManager.LoadData();
        ATM atm = new ATM(accounts);

        bool running = true;

        while (running) {

            String choice; 
            Console.WriteLine("Write your choice: ");
            Console.WriteLine("1. Sign Up");
            Console.WriteLine("2. Log In");
            Console.WriteLine("3. Exit");
            choice = Console.ReadLine();

            switch (choice) {

                case "1":
                    atm.SignUp();
                    break;

                case "2": 
                    atm.Login();
                    break;

                case "3": 
                    Console.WriteLine("Bye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid input, try again.");
                    break;
            }

        }

        FileManager.SaveData(accounts);
        Console.WriteLine("Bye!");

    }
}
