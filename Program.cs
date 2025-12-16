var welcomeMesssage = "Starting Program";
Console.WriteLine(welcomeMesssage);

var dial = new Dial(100);

// Read all commands from file
var instructions = new[]
{
  "L68",
  "L30",
  "R48",
  "L5",
  "R60",
  "L55",
  "L1",
  "L99",
  "R14",
  "L82",
};


foreach (var instruction in instructions)
{
  // Console.WriteLine(instruction);
  var direction = instruction.First();
  // Console.WriteLine(direction);
  int.TryParse(instruction.Substring(1), out int steps);
  // Console.WriteLine(steps);

  if (direction == 'L')
  {
    dial.TurnLeftBy(steps);
  }
  else if (direction == 'R')
  {
    dial.TurnRightBy(steps);
  }
  else
  {
    throw new Exception("Oh! Something went wrong");
  }
}

Console.WriteLine(dial.CurrentPosition);
Console.WriteLine(dial.TotalNull);
