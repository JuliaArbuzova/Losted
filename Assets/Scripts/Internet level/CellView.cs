using UnityEngine;

namespace Internet_level
{
    public class CellView : MonoBehaviour
    {
        private Cell _cell;

        public void Init(Cell cell)
        {
            _cell = cell;
            _cell.OnRotation += Rotate;
        }

        private void Rotate(int position)
        {
            transform.eulerAngles = new Vector3(0, 0, -position * 90);
        }

        public void Rotate()
        {
            _cell.Rotate(1);
        }
    }
}