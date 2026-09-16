using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyNotesApp.Services
{
    public class FileLoggerService : ILoggerService
    {
        private readonly string _path = "log.txt";

        public void Log(string message)
        {
            File.AppendAllText(_path, $"{DateTime.Now}: {message}{Environment.NewLine}");
        }
    }
}