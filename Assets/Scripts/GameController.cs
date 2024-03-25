using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameField _gameField;
    private bool _isGameActive = true;

    private void Start()
    {
        _gameField = new GameField();
        for (int i = 0; i < _gameField.Field.Count; ++i)
        {
            transform.GetChild(i).GetComponent<CellView>().Init(_gameField.Field[i]);
        }
        _gameField.Shuffle();
    }

    private void Update()
    {
        if (_isGameActive && _gameField.IsCorrect())
        {
            _isGameActive = false;
            foreach (CellView cellView in transform.GetComponentsInChildren<CellView>())
            {
                Destroy(cellView);
            }
        }
    }
}