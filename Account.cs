using System; 

class Account {

    double balance;
    string name;
    int pinCode;

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
