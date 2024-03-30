using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace User_data_input
{
  public class InputController : MonoBehaviour
  {
    [SerializeField] private GameObject _male;
    [SerializeField] private GameObject _female;
    [SerializeField] private Vector3 _spawnCoordinates;

    [SerializeField] private TMP_InputField _inputField;
    private GameObject _activeImage;

    private void Awake()
    {
      PlayerPrefs.SetString("Name", "NULL");
      PlayerPrefs.SetInt("Sex", -1);
    }

    public void ChooseMale()
    {
      PlayerPrefs.SetInt("Sex", 1);
      if (_activeImage != null) Destroy(_activeImage);

      _activeImage = Instantiate(_male, _spawnCoordinates, Quaternion.identity, transform);
    }

    public void ChooseFemale()
    {
      PlayerPrefs.SetInt("Sex", 0);
      if (_activeImage != null) Destroy(_activeImage);

      _activeImage = Instantiate(_female, _spawnCoordinates, Quaternion.identity, transform);
    }

    public void Continue()
    {
      if (PlayerPrefs.GetInt("Sex") != -1 && PlayerPrefs.GetString("Name") != "NULL")
      {
        PlayerPrefs.Save();
        SceneManager.LoadScene(2);
      }
    }

    public void ChooseName(string _)
    {
      PlayerPrefs.SetString("Name", _inputField.text);
      Debug.Log($"name is {_inputField.text}");
    }
  }
}