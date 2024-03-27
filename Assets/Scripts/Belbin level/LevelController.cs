using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Belbin_level
{
  public class LevelController : MonoBehaviour
  {
    private Game _game;
    private int _emptyPositionIndex;
    private readonly List<GameObject> _texts = new(4);
    [SerializeField] private List<Vector3> _gamerRolesPosition;
    [SerializeField] private List<Vector3> _positions;
    [SerializeField] private List<GameObject> _roleNames;
    
    

    public void Init(User gamer)
    {
      _game = new Game();
      _game.InitGamer(gamer);
      _game.OnFullList += Check;

      Instantiate(_roleNames[(int)gamer.ActiveRole], _gamerRolesPosition[0], Quaternion.identity);
      Instantiate(_roleNames[(int)gamer.PassiveRole], _gamerRolesPosition[1], Quaternion.identity);

      foreach (PersonButton button in transform.GetComponentsInChildren<PersonButton>())
      {
        button.OnPressed += AddUser;
      }
    }

    private void AddUser(GameObject text, Role firstRole, Role secondRole)
    {
      _texts.Add(Instantiate(text, _positions[_emptyPositionIndex], Quaternion.identity));
      _emptyPositionIndex++;
      _game.AddMember(new User(firstRole, secondRole));
    }

    private void Check()
    {
      if (_game.CheckCommand())
      {
        SceneManager.LoadScene("Maze level");
      }
      else
      {
        _game.Restart();
        _emptyPositionIndex = 0;
        
        for (int i = 3; i >= 0; i--)
        {
          Destroy(_texts[i]);
        }
        _texts.Clear();
        for (int i = 0; i < transform.childCount; i++)
        {
          transform.GetChild(i).gameObject.SetActive(true);
        }
      }
    }
  }
}