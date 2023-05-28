namespace BankAccounts;

public class Customer
{
    private string _firstName;
    private string _lastName;
    private decimal _balance;
    private int _withdrawalCount = 0;

    public Customer(string firstName, string lastName, decimal balance=0.0m)
    {
        _firstName = firstName;
        _lastName = lastName;
        _balance = balance;
    }

    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;

    }
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public decimal Balance
    {
        get => _balance;
        set => _balance = value;
    }
    public int WithdrawalCount
    {
        get => _withdrawalCount;
        set => _withdrawalCount = value;
    }

    public void Deposit(decimal depositAmt)
    {
        Balance += depositAmt;
    }

    public virtual void Withdraw(decimal withdrawAmt)
    {
        Balance -= withdrawAmt;
        CountWithdrawal();
    }

    public string InquireBalance()
    {
        return $"{Balance:C2}";
    }

    public string AccountOwner
    {
        get => $"{FirstName} {LastName}";
    }

    public virtual void CountWithdrawal()
    {
        WithdrawalCount++;
    }
}