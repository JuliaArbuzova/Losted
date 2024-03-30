using UnityEngine;
using UnityEngine.SceneManagement;

namespace Main_Menu
{
  public class MainMenu : MonoBehaviour
  {
    private void Awake()
    {
      if (!PlayerPrefs.HasKey("Sound")) PlayerPrefs.SetInt("Sound", 1);
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
  }
}