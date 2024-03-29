using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

namespace Dialogs
{
  public class DialogController : MonoBehaviour
  {
    [SerializeField] private string _dataFileName;
    [SerializeField] private int _nextScene; // Scene build index
    [SerializeField] private TextMeshProUGUI _role;
    [SerializeField] private TextMeshProUGUI _message;

    private bool _isMale;
    private DialogReader _dialogReader;

    private void Awake()
    {
      // _isMale = PlayerPrefs.GetInt("Sex") == 1; использовать потом для выбора картинки и мб цвета текста ждя роли
      _dialogReader = new DialogReader($@"Assets\Texts for dialogs\{_dataFileName}");
      _dialogReader.Open();
      NextMessage();
    }

    private void Update()
    {
      if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
      {
        if (!NextMessage())
        {
          _dialogReader.Close();
          // SceneManager.LoadScene(_nextScene);
          Debug.Log("End of Dialog");
        }
      }
    }

    private bool NextMessage()
    {
      (string, string) data = _dialogReader.GetPhrase();
      if (data.Item1 == null)
      {
        return false;
      }
      _role.text = data.Item1;
      _message.text = data.Item2;
      return true;
    }
  }
}