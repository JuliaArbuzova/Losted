using System.IO;

namespace Dialogs
{
    public class DialogReader
    {
        private readonly string _pathToFile;
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
            var role = _streamReader.ReadLine();
            if (role == null) return (null, null);

            var text = _streamReader.ReadLine();
            return (role, text);
        }
    }
}