using System;
using System.Collections.Generic;
using System.Linq;

namespace Belbin_level
{
  public class Game
  {
    private readonly List<User> _command = new(5);

    private readonly List<bool> _isRoleInCommandList = new(9);
    private User _gamer;

    private List<User> _users = new(13)
    {
      new User(Role.Analyst, Role.IdeaGenerator),
      new User(Role.TeamSoul, Role.Coordinator),
      new User(Role.Motivator, Role.Implementer),
      new User(Role.Investigator, Role.TeamSoul),
      new User(Role.Motivator, Role.Analyst),
      new User(Role.Specialist, Role.Analyst),
      new User(Role.Pedant, Role.Implementer),
      new User(Role.Pedant, Role.Coordinator),
      new User(Role.TeamSoul, Role.Implementer),
      new User(Role.Coordinator, Role.Pedant),
      new User(Role.IdeaGenerator, Role.Investigator),
      new User(Role.Implementer, Role.Motivator),
      new User(Role.Specialist, Role.IdeaGenerator)
    };

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

      return _isRoleInCommandList.All(status => status);
    }

    public void Restart()
    {
      for (int i = 0; i < _isRoleInCommandList.Count; i++) _isRoleInCommandList[i] = false;
      _command.Clear();
      _command.Add(_gamer);
    }
  }
}