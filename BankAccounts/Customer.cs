namespace BankAccounts;

public class Customer
{
    private string _firstName;
    private string _lastName;
    private decimal _balance;

    public Customer(string firstName, string lastName, decimal balance)
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

    public void Deposit(decimal depositAmt)
    {
        Balance += depositAmt;
    }

    public void Withdraw(decimal withdrawAmt)
    {
        Balance -= withdrawAmt;
    }

    public string InquireBalance()
    {
        return $"{Balance:C2}";
    }

    public string AccountOwner
    {
         get => $"{FirstName} {LastName}";
    }
}