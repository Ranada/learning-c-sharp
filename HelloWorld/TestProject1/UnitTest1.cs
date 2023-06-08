using BankyStuffLibrary;
using System.Security.Principal;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SuccesffullyWithdraw()
        {
            var account = new BankAccount("Neil", 100000000.00m);
            account.MakeWithdrawal(75000.00m, DateTime.Now, "Withdrawal attempt");
        }

        [Fact]
        public void IndicateOverDraw()
        {
            var account = new BankAccount("kendra", 1.00m);
            Assert.Throws<InvalidOperationException>(
                 () => account.MakeWithdrawal(75000.00m, DateTime.Now, "Withdrawal attempt")
            );
        }
    }
}