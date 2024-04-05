using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dialogs
{
  public class DialogReader
  {
    private int _ind;
    private List<string> _data;

    public DialogReader(string pathToFile)
    {
      _data = new List<string>( Resources.Load<TextAsset>(pathToFile).text.Split('\n', StringSplitOptions.RemoveEmptyEntries));
    }

    public (string, string) GetPhrase()
    {
      if (_ind >= _data.Count) return (null, null);
      _ind += 2;
      return (_data[_ind - 2], _data[_ind - 1]);
    }
  }
}