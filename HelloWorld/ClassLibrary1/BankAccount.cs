namespace BankyStuffLibrary
{
    public class BankAccount
    {
        private string _firstName;
        private decimal _balance;

        public BankAccount(string firstName = "Unknown", decimal balance = 0.00m) { 
            _firstName = firstName;
            _balance = balance;
        }

        public string FirstName {
            get => this._firstName;
            set => this._firstName = value;
        }

        public decimal Balance { 
            get => this._balance;
            set => this._balance = value;
        }

        public void MakeWithdrawal(decimal WithdrawalAmount, DateTime time, string message) {
            try {
                if (WithdrawalAmount > Balance)
                {
                    throw new InvalidOperationException("Not enough money to make withdrawal!");
                }

                Balance -= WithdrawalAmount;
                Console.WriteLine($"{time} {message}: {WithdrawalAmount:C2}");
            } catch (Exception e) {
                Console.WriteLine($"Opps! {e}");
                throw;
            }
            
        }

    }
}