using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class ProgramUI
    {

        int playerOneScore = 0;
        int playerTwoScore = 0;
        int gameStart = 0;
        int firstRun = 0;
        string player1;
        string player2;
        private IConsole _console;

        public ProgramUI(IConsole console) { _console = console; }

        public void Run()
        {
            RunMenu();

        }
        public void RunMenu()
        {
            Repo repo = new Repo();
            _console.WriteLine(repo.Hangman6());



            _console.WriteLine("Would you like to play a game?\n" +
                "Press y or n");
            string x = _console.ReadLine().ToLower();
            _console.Clear();
            if (x == "y")
            {
                Hangman();
            }
            if (x == "n")
            {
                _console.Clear();
            }
            else
            {
                _console.WriteLine("Are you blind?  Y/N");
            }
        }
        public void Hangman()
        {
            Repo repo = new Repo();
            if (firstRun == 0)
            {
                _console.WriteLine(repo.Hangman6());
                player1 = Player1Name();
                _console.Clear();
                _console.WriteLine(repo.Hangman6());
                player2 = Player2Name();
                _console.Clear();
                firstRun++;
            }
            int indexone;
            int correctGuesses = 0;
            int lives = 6;
            string wordOriginal;
            string word;
            string innerWordOriginal;
            int guessCounter = 0;
            bool Win = true;
            string usedCharacters = "";
            
            if (gameStart == 0)
            {
                _console.WriteLine($"{player1} enter a word");
                _console.WriteLine(repo.Hangman6());
                word = PlayerInputWord();
                wordOriginal = word;
                word = UnderscoreReplacer(word);
                _console.Clear();
                gameStart += 1;
            }
            else
            {
                _console.WriteLine($"{player2} enter a word");
                _console.WriteLine(repo.Hangman6());
                word = PlayerInputWord();
                wordOriginal = word;
                word = UnderscoreReplacer(word);
                _console.Clear();
                gameStart -= 1;
            }
            
            while (lives >= 0 && word.Contains("_"))
            {

                
                switch (lives)
                {
                    case 6:
                    case 5:
                    case 4:
                    case 3:
                    case 2:
                    case 1:
                        _console.WriteLine("Please guess a letter");
                        if (guessCounter != 0)
                        {

                        _console.WriteLine($"you have used {usedCharacters}");
                        
                        }
                        string x = PlayerInputChar().ToString().ToLower();
                        guessCounter += 1;
                        usedCharacters+=x;
                        innerWordOriginal = wordOriginal.ToLower();
                        while (innerWordOriginal.Contains(x) && lives > -1)
                        {
                            indexone = innerWordOriginal.IndexOf(x);
                            word = word.Remove(indexone, 1).Insert(indexone, x);
                            innerWordOriginal = innerWordOriginal.Remove(indexone, 1).Insert(indexone, "_");
                            correctGuesses += 1;
                        }
                        _console.Clear();
                        if (correctGuesses > 0)
                        {
                            _console.WriteLine($"correct guess\n" +
                                $"{word}");
                            correctGuesses = 0;
                        }
                        else
                        {
                            lives -= 1;
                            _console.WriteLine($"Wrong answer, {lives} lives remaining.\n" +
                                $"{word}");
                            correctGuesses = 0;
                        }
                        switch (lives)
                        {
                            case 6:
                                _console.WriteLine(repo.Hangman6());
                                break;
                            case 5:
                                _console.WriteLine(repo.Hangman5());
                                break;
                            case 4:
                                _console.WriteLine(repo.Hangman4());
                                break;
                            case 3:
                                _console.WriteLine(repo.Hangman3());
                                break;
                            case 2:
                                _console.WriteLine(repo.Hangman2());
                                break;
                            case 1:
                                _console.WriteLine(repo.Hangman1());
                                break;

                        }
                        Win = true;
                        break;

                    case 0:
                        if (gameStart == 1)
                        {
                            
                            _console.WriteLine($"{player2} loses!");
                            lives -= 1;
                            
                        }
                        else
                        {
                            
                            _console.WriteLine($"{player1} loses!");
                            lives -= 1;
                            
                        }
                        Win = false;
                        break;

                    default:

                        break;
                }
            }
            if (gameStart > 0 && Win)
            {
                playerOneScore += 1;
            }
            else if (gameStart == 0 && Win)
            {
                playerTwoScore += 1;
            }
            else if (gameStart == 0 && !Win)
            {
                playerOneScore += 1;
            }
            else
            {
                playerTwoScore += 1;
            }

            _console.WriteLine(repo.Hangman0());
            _console.WriteLine(wordOriginal);
            _console.WriteLine($"The score is {playerTwoScore}-{playerOneScore}\n" +
                $"Press any key to continue.");
            guessCounter = 0;
            _console.ReadKey();
            _console.Clear();
            RunMenu();
        }

        public string Player1Name()
        {

            Console.WriteLine("Enter your name player 1");
            string x = Console.ReadLine();
            return x;
        }

        public string Player2Name()
        {
            Console.WriteLine("Enter your name player 2");
            string x = Console.ReadLine();
            return x;
        }

        public string UnderscoreReplacer(string stringyboi)
        {
            int x = 0;
            int y = stringyboi.Length;
            char[] z = stringyboi.ToCharArray();

            while (x < y)
            {
                if (Char.IsLetter(z[x]))
                {
                    z[x] = '_';
                    x += 1;
                }
                else
                {
                    x += 1;
                }
            }

            string zone = new string(z);
            return zone;
        }
        public string PlayerInputWord()
        {
            string x = Console.ReadLine().ToUpper();
            return x;
        }
        public char PlayerInputChar()
        {
            string x = Console.ReadLine();
            x = x.Trim(' ');
            if (x.Length == 1)
            {
                char y = Convert.ToChar(x);
                return y;
            }
            else
            {
                _console.WriteLine("Type a single character please");
                return ' ';
            }
        }

    }
}

