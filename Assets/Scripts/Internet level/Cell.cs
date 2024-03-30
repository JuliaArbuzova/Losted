using System;

namespace Internet_level
{
  public class Cell
  {
    private const int CORRECT_POSITION = 0;
    private int _position;

    public event Action<int> OnRotation;

    public bool IsCorrectPosition()
    {
      return CORRECT_POSITION == _position;
    }

    public void Rotate(int value)
    {
      _position = (_position + value) % 4;
      OnRotation?.Invoke(_position);
    }
  }
}