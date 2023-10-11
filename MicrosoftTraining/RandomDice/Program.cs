// See https://aka.ms/new-console-template for more information


Random dice = new Random();

// Example of stateful (instance) method. Requires creating an instance of the class (ex. new Random())
int roll = dice.Next(1, 7);

// .WriteLine is a static method. Does not require creating an instance of a class
Console.WriteLine(roll);

// Will get a compilation error since a new object isn't created to access a stateful method
// int result = Random.Next();
