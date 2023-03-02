public class BankAccount {
    public string customerName = "Bob";
    private double balance = 0;    
    public string typeOfAccount = "";
    
    // default constructor 
//     public BankAccount() {
//         customerName = "Bob";
//         balance = 300;
//         // typeOfAccount = "checking";
        
//         if (typeOfAccount == "checking") {
//         //balance = balance + 100;
//         balance += 100;
// }
//     }
    public BankAccount(string newCustomerName, double newBalance) {
        customerName = newCustomerName;
        balance = newBalance;
        // typeOfAccount = "checking";
    }

    public void deposit(double amount){

        if(amount <= 0) {
           throw new Exception("No negative deposits allowed"); 
        }
        balance += amount;
    }

    public double getBalance() {
        return balance;
    }
}