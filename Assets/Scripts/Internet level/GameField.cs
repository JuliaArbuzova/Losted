using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Internet_level
{
    public class GameField
    {
        private const int SIZE = 36;
        public readonly List<Cell> Field;

        public GameField()
        {
            Field = new List<Cell>(SIZE);
            for (var i = 0; i < SIZE; ++i) Field.Add(new Cell());
        }

        public bool IsCorrect()
        {
            return Field.All(cell => cell.IsCorrectPosition());
        }

        public void Shuffle()
        {
            for (var i = 1; i < SIZE - 1; ++i) Field[i].Rotate(Random.Range(1, 4));
        }
    }
}