var welcomeMesssage = "Starting Program";
Console.WriteLine(welcomeMesssage);

var anonA = new Person("Jane", 32);
var anonADescription = anonA.Describe();
Console.WriteLine(anonADescription);

var anonB = new Person("Jack", 45);
var anonBDescription = anonB.Describe();
Console.WriteLine(anonBDescription);

var anonC = new Person("J", 20);
var anonCDescription = anonC.Describe();
Console.WriteLine(anonCDescription);
