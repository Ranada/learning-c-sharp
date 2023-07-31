namespace _10_142_polymorphism
{
    internal class Program
    {
        // Create a base class Car with two properties HP and Color
        // Create a Constructor setting those two properties
        // Create a Method called ShowDetails() which shows the HP and Color of the car on the console
        // Create a Repair Method which writes "Car was repaired!" onto the console
        // Create two deriving classes, BMW and Audi, which have their own constructor and have an additional property
        // called Model. Also a private member called brand. Brand should be different in each of the two classes.
        // Create the two methods ShowDetails() and Repair in them as well. Adjust those methods accordingly.


        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new BMW("800", "Blue", "Z4"),
                new Audi("500", "Silver", "A4"),            
            };
            
            foreach (Car car in cars)
            {
                car.ShowDetails();
                car.Repair();

                Random rnd = new Random();
                car.SetCarInfo(rnd.Next(0, 100), "Neil");
                car.DisplayInfo();
            }
        }
    }
}