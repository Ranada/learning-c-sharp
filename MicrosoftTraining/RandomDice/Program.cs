// See https://aka.ms/new-console-template for more information


Random dice = new Random();

// Example of stateful (instance) method. Requires creating an instance of the class (ex. new Random())
// int roll = dice.Next(1, 7);

// .WriteLine is a static method. Does not require creating an instance of a class
// Console.WriteLine(roll);

// Will get a compilation error since a new object isn't created to access a stateful method
// int result = Random.Next();

// Method overload demo
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

dice.Next(6);