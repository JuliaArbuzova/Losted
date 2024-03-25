using System;

namespace Internet_level
{
  public class Cell
  {
    private readonly int _correctPosition = 0;
    private int _position;

    public event Action<int> OnRotation;

    public bool IsCorrectPosition()
    {
      return _correctPosition == _position;
    }

    public void Rotate(int value)
    {
      _position = (_position + value) % 4;
      OnRotation?.Invoke(_position);
    }
  }
}