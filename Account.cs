using System; 
class Account {

    public double balance = 0;
    public string name {get; set;}
    public int pinCode {get; set;}

    public void withdrawmoney(double amount) {
        balance -= amount;
    }

    public void depositmoney(double amount) {
        balance += amount;
    }

    public double GetBalance() {
        return balance;
    }


}
