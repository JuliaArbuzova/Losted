using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Dialogs
{
  public class DialogController : MonoBehaviour
  {
    [SerializeField] private string _dataFileName;
    [SerializeField] private int _nextScene;
    [SerializeField] private TextMeshProUGUI _role;
    [SerializeField] private TextMeshProUGUI _message;

    [SerializeField] private GameObject _male;
    [SerializeField] private GameObject _female;
    [SerializeField] private Vector3 _studentCoordinates;
    [SerializeField] private Transform _canvasTransform;
    private DialogReader _dialogReader;

    private bool _isMale;

    private void Awake()
    {
      _isMale = PlayerPrefs.GetInt("Sex") == 1;
      Instantiate(_isMale ? _male : _female, _studentCoordinates, Quaternion.identity, _canvasTransform).transform
        .SetSiblingIndex(1);
      _dialogReader = new DialogReader($@"Texts for dialogs\{_dataFileName}");
      NextMessage();
    }

    private void Update()
    {
      if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        if (!NextMessage())
        {
          SceneManager.LoadScene(_nextScene);
        }
    }

    private bool NextMessage()
    {
      (string, string) data = _dialogReader.GetPhrase();
      if (data.Item1 == null) return false;
      _role.text = data.Item1.Length <= 3 ? PlayerPrefs.GetString("Name") : data.Item1;
      _message.text = data.Item2;
      return true;
    }
  }
}