using UnityEngine;
using UnityEngine.SceneManagement;

namespace Main_Menu
{
    public class MainMenu : MonoBehaviour
    {
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
