using UnityEngine;
using UnityEngine.SceneManagement;

namespace Maze_level
{
    public class MazeController : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(-1 * Time.deltaTime, 0, 0);

            if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(1 * Time.deltaTime, 0, 0);

            if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(0, 1 * Time.deltaTime, 0);

            if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(0, -1 * Time.deltaTime, 0);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Walls"))
            {
                if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(3 * Time.deltaTime, 0, 0);

                if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(-3 * Time.deltaTime, 0, 0);

                if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(0, -3 * Time.deltaTime, 0);

                if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(0, 3 * Time.deltaTime, 0);
            }

            if (collision.gameObject.CompareTag("End")) SceneManager.LoadScene(11);
        }
    }
}