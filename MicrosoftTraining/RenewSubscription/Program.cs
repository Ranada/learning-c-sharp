var random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
string message;

if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    message = "within a day!";
    ExpirationMessage();
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    message = $"in {daysUntilExpiration} days!";
    ExpirationMessage();

}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}


void ExpirationMessage()
{
    Console.WriteLine("Your subscription expires {0}", message);
    Console.WriteLine("Renew now and save {0}%!", discountPercentage);
}