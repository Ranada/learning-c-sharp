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
        Balance -= withdrawAmt;

        if (Balance < 0)
        {
            Balance += withdrawAmt;
            Console.WriteLine("Denied: Cannot overdraw the account.");
        }
        else
        {
            CountWithdrawal();
        }
    }

    public override void CountWithdrawal()
    {
        WithdrawalCount++;

        if (WithdrawalCount % 3 == 0)
        {
            Balance -= 2.00m;
        }
    }



}