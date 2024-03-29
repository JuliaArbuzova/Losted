using System.IO;
using System.Text;

namespace Dialogs
{
  public class DialogReader
  {
    private string _pathToFile;
    private StreamReader _streamReader;

    public DialogReader(string pathToFile)
    {
      _pathToFile = pathToFile;
    }

    public void Open()
    {
      _streamReader = new StreamReader(_pathToFile);
    }

    public void Close()
    {
      _streamReader.Close();
    }

    public (string, string) GetPhrase()
    {
      string role = _streamReader.ReadLine();
      if (role == null)
      {
        return (null, null);
      }

      string text = _streamReader.ReadLine();
      return (role, text);
    }
  }
}