using UnityEngine;
using UnityEngine.SceneManagement;

namespace Internet_level
{
  public class GameController : MonoBehaviour
  {
    private GameField _gameField;
    private bool _isGameActive = true;

    private void Start()
    {
      _gameField = new GameField();
      for (int i = 1; i < _gameField.Field.Count - 1; ++i)
        transform.GetChild(i).GetComponent<CellView>().Init(_gameField.Field[i]);
      _gameField.Shuffle();
    }

    private void Update()
    {
      if (_isGameActive && _gameField.IsCorrect())
      {
        _isGameActive = false;
        for (int i = 1; i < _gameField.Field.Count - 1; ++i)
          Destroy(transform.GetChild(i).GetComponent<CellView>());
        SceneManager.LoadScene(8);
      }
    }
  }
}