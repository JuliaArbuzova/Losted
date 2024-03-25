using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class GameField
{
    private const int SIZE = 36;
    public readonly List<Cell> Field;

    public GameField()
    {
        Field = new List<Cell>(SIZE);
        for (int i = 0; i < SIZE; ++i)
        {
            Field.Add(new Cell());
        }
    }

    public bool IsCorrect()
    {
        return Field.All(cell => cell.IsCorrectPosition());
    }

    public void Shuffle()
    {
        foreach (Cell cell in Field) 
        {
            cell.Rotate(Random.Range(1, 4));
        }
    }
}