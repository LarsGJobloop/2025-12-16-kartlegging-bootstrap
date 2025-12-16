public class Dial
{
  private int _numberOfPositions;
  public int CurrentPosition;
  public int TotalNull;

  public Dial(int numberOfPositions)
  {
    _numberOfPositions = numberOfPositions;
  }

  public void TurnLeftBy(int steps)
  {
    CurrentPosition = (CurrentPosition - steps) % _numberOfPositions;

    if (CurrentPosition == 0)
    {
      TotalNull = TotalNull + 1;
    }
  }

  public void TurnRightBy(int steps)
  {
    CurrentPosition = (CurrentPosition + steps) % _numberOfPositions;

    if (CurrentPosition == 0)
    {
      TotalNull = TotalNull + 1;
    }
  }
}
