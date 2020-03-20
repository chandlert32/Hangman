using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public interface IConsole
    {
        string ReadLine();
        void WriteLine(string output);
        void WriteLine(object obj);
        void Clear();
        ConsoleKeyInfo ReadKey();
        void Write(string str);
    }
}
