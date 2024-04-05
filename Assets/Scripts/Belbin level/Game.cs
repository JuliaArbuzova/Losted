using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;

namespace Belbin_level
{
  public class Game
  {
    private readonly List<User> _command = new(5);
    private readonly List<bool> _isRoleInCommandList = new(9);
    private User _gamer;

    public Game()
    {
      for (int i = 0; i < 9; ++i) _isRoleInCommandList.Add(false);
    }

    public event Action OnFullList;

    public void InitGamer(User gamer)
    {
      _gamer = gamer;
      _command.Add(_gamer);
    }

    public void AddMember(User user)
    {
      _command.Add(user);
      if (_command.Count == 5) OnFullList?.Invoke();
    }

    public bool CheckCommand()
    {
      foreach (User user in _command)
      {
        _isRoleInCommandList[(int)user.ActiveRole] = true;
        _isRoleInCommandList[(int)user.PassiveRole] = true;
      }

      return _isRoleInCommandList.All(status => status)  && 
             (from user in _command.DistinctBy(user => user.ActiveRole) select user.ActiveRole).Count() == 5 &&
             (from user in _command.DistinctBy(user => user.PassiveRole) select user.PassiveRole).Count() == 5;
    }

    public void Restart()
    {
      for (int i = 0; i < _isRoleInCommandList.Count; i++) _isRoleInCommandList[i] = false;
      _command.Clear();
      _command.Add(_gamer);
    }
  }
}