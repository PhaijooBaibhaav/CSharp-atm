using System; 
class Account {

    public double balance;
    public string name;
    public int pinCode;

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
