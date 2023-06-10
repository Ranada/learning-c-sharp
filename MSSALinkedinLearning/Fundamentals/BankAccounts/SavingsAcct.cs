namespace BankAccounts;

public class SavingsAcct : Customer
{
    private decimal _interestRate;

    public SavingsAcct(string firstName, string lastName, decimal interestRate, decimal balance)
    : base(firstName, lastName, balance)
    {
        _interestRate = interestRate;
    }

    public decimal InterestRate
    {
        get => _interestRate;
        set => _interestRate = value;
    }

    public void ApplyInterest()
    {
        decimal interestAmt = Balance * InterestRate;
        Balance += interestAmt;
    }

    public override void Withdraw(decimal withdrawAmt)
    {
        if (withdrawAmt > Balance)
        {
            Console.WriteLine("Denied: Cannot overdraw the account.");
        }
        else
        {
            base.Withdraw(withdrawAmt);
        }
    }

    public override void CountWithdrawal()
    {
        WithdrawalCount++;

        if (WithdrawalCount % 3 == 0)
        {
            Console.WriteLine("More than 3 withdrawals. Charged $2.00 fee.");
            Balance -= 2.00m;
        }
    }



}