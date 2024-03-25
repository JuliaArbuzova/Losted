using UnityEngine;

namespace Belbin_level
{
  public class LevelController : MonoBehaviour
  {
    private Game _game;

    public void Init(User gamer)
    {
      _game = new Game();
      _game.InitGamer(gamer);
    }
  }
}