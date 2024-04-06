using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Main_Menu
{
  public class MainMenu : MonoBehaviour
  {
    [SerializeField] private Button _continueButton;
    
    private void Awake()
    {
      if (!PlayerPrefs.HasKey("Sound")) PlayerPrefs.SetInt("Sound", 1);
      _continueButton.interactable = PlayerPrefs.HasKey("Scene") && PlayerPrefs.GetInt("Scene") != 0;
    }

    public void PlayGame()
    {
      SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
      Debug.Log("Game is closed");
      Application.Quit();
    }

    public void Continue()
    {
      SceneManager.LoadScene(PlayerPrefs.GetInt("Scene"));
    }
  }
}