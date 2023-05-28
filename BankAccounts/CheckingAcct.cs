namespace BankAccounts;
public class CheckingAcct : Customer
{
    public CheckingAcct(string firstName, string lastName, decimal balance)
    : base(firstName, lastName, balance) { }

    public override void Withdraw(decimal withdrawAmt)
    {
        Balance -= withdrawAmt;

        if (Balance < 0)
        {
            Balance -= 35.00m;
            Console.WriteLine("Overdrawing from account. You were charged a $35 fee.");
        }
        CountWithdrawal();

    }

}