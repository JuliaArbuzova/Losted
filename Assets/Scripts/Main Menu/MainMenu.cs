using UnityEngine;
using UnityEngine.SceneManagement;

namespace Main_Menu
{
    public class MainMenu : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //тут можно вызвать сцену по названию, наверное так и сделаем
        }

        public void ExitGame()
        {
            Debug.Log("Game is closed");
            Application.Quit();
        }
    }
}
