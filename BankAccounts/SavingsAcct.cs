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

}