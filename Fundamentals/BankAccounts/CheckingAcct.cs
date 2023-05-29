namespace BankAccounts;

// [MemoryDiagnoser]
// [Orderer(SummaryOrderPolicy.FastestToSlowest)]
// [RankColumn]
public class CheckingAcct : Customer
{
    private const decimal OVERDRAW_CHARGE = 35.0m;
    public CheckingAcct(string firstName, string lastName, decimal balance)
    : base(firstName, lastName, balance) { }
    
    public override void Withdraw(decimal withdrawAmt)
    {
        if (withdrawAmt > Balance)
        {
            withdrawAmt += OVERDRAW_CHARGE;
            Console.WriteLine("Overdrawing from account. You were charged a $35 fee.");
        }
        base.Withdraw(withdrawAmt);
    }
}