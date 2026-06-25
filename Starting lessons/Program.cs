using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Starting_lessons
{
    public enum MainMenuCommand
    {
        Exit,
        FillDescription,
        FillCharacteristics,
        ShowInfo,
        RateUs,
        Play
    }

    public enum MapField
    {
        Empty = ' ',
        Wall = '#',
        Coin = '$'
    }
    public enum InventoryCell
    {
        Empty = '?',
        Coin = '$'
    }

    public enum RateMenuCommand
    {
        Yes,
        No
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }

    public enum Race
    {
        Human = 1,
        Elf,
        Orc,
        Robot,

    }

    internal class Program
    {
        private static void Main()
        {

            #region Hello world
            // Программа 1 - Привет МИР    

            //void HelloCSharpWorld()
            //{
            //    Console.WriteLine("Hello C# World!");
            //}

            //HelloCSharpWorld();
            #endregion

            #region Data type
            //// Программа 2 - Типы данных. 
            //// Создадим функцию по выводу информации о персонаже, используя основные типы данных
            //void characterInfo(){
            //    int posNumber; //выделение памяти 
            //    posNumber = 3; //присвоение значения
            //    float experience = 17.8f; //инициализация
            //    string name = "WR";
            //    bool isBanned = false;
            //    char skin = '@';
            //    Console.WriteLine("Enter the float number");
            //    float keyboardFloat;
            //    float.TryParse(Console.ReadLine(), out keyboardFloat);
            //    Console.WriteLine($"Position number: {posNumber}\nExperience: {experience}\nName: {name}\nBanned? {isBanned}\nSobaka? {skin} \nYour random float number: {keyboardFloat}"); //Это - интерполяция. "name: " + name - конкатенация
            //}
            //characterInfo();
            #endregion

            #region Math, if
            ////Программа 3. Математические операторы, условные ветвления
            ////Опишем функцию, считающую, верно ли заполнил игрок очки умения
            //bool CheckPoints()
            //{
            //    int maxPoints = 50;

            //    Console.Write("Enter character's strength: ");
            //    int strength = int.Parse(Console.ReadLine());

            //    Console.Write("Enter character's agility: ");
            //    int agility = int.Parse(Console.ReadLine());

            //    Console.Write("Enter character's intelegence: ");
            //    int intelegece = int.Parse(Console.ReadLine());

            //    Console.Write("Enter character's charisma: ");
            //    int charisma = int.Parse(Console.ReadLine());

            //    Console.Write("Enter character's spell skill: ");
            //    int spellSkill = int.Parse(Console.ReadLine());

            //    int totalPoints = strength + agility + intelegece + charisma + spellSkill;

            //    if (totalPoints > maxPoints)
            //    {
            //        Console.WriteLine("You did it tooo much");
            //        return false;
            //    }
            //    else if (totalPoints < maxPoints)
            //    {
            //        Console.WriteLine("It would be a hard battle for you");
            //        return true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Perfect math skills");
            //        return true;
            //    }
            //}
            //CheckPoints();
            #endregion

            #region Ternary operator
            /*//Продемонстрируем магию тернарного оператора
            int number = 3;

            // Переменная = условие? значение при истине : значение при лжи
            string result = number % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine(result);
            Console.ReadKey();*/
            #endregion

            #region Console customization
            //// Делаем консоль красивой  

            //// Добавляем кодировку UTF8, чтобы отображались все символы

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("Проверка на четность с помощью тернарного оператора");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Введите целое число с клавиатуры");
            //int number = int.Parse(Console.ReadLine());

            //Console.ForegroundColor = ConsoleColor.Yellow;

            //// Переменная = условие? значение при истине : значение при лжи
            //string result = number % 2 == 0 ? "Even" : "Odd";

            //if (result == "Even"){
            //    Console.ForegroundColor = ConsoleColor.DarkCyan;
            //    Console.WriteLine(result);
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //    Console.WriteLine(result);
            //    Console.ReadKey();
            //}

            ////Console.WriteLine(result);
            ////Console.ReadKey();

            #endregion

            #region Loops   

            //While - папа всех циклов

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            //bool isExit = false;

            //while (!isExit)
            //{
            //    Console.WriteLine("Ты нашёл выход? ");
            //    string answer = Console.ReadLine().ToLower();

            //    if (answer == "выход")
            //    {
            //        isExit = true;
            //        Console.WriteLine("Поздравляю! Ты нашёл выход!");
            //        Console.ReadKey();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Продолжай искать...");
            //    }
            //}
            #endregion

            Player player = new Player();
            InputReader inputReader = new InputReader();

            bool isWork = true;
            string sure;
            int input;

            Dictionary<Race, string> racesTitles = new Dictionary<Race, string>
            {
                [Race.Human] = "Человек",
                [Race.Elf] = "Эльф",
                [Race.Orc] = "Орк",
                [Race.Robot] = "Робот"
            };

            Dictionary<Gender, string> genderTitles = new Dictionary<Gender, string>
            {
                [Gender.Male] = "Man",
                [Gender.Female] = "Woman"
            };

            string[] commands = 
                  {$"{(int)MainMenuCommand.FillDescription}. Заполнить информацию о персонаже\n",
                   $"{(int)MainMenuCommand.FillCharacteristics}. Распределить характеристик\n",
                   $"{(int)MainMenuCommand.ShowInfo}. Показать информацию\n",
                   $"{(int)MainMenuCommand.RateUs}. Оценить игру\n",
                   $"{(int)MainMenuCommand.Play}. Играть\n",
                   $"{(int)MainMenuCommand.Exit}. Выход"
            };

            while (isWork)
            {

                Console.Clear(); // Очистка консоли
                Console.ForegroundColor = ConsoleColor.Green;

                ShowMenu(commands);

                Console.Write("Выберите пункт меню (введите номер команды) \n");
                input = inputReader.ReadInt("Введите номер команды ", -1);

                switch ((MainMenuCommand)input)
                {
                    case MainMenuCommand.FillDescription:

                        FillCharacterDescription(player, inputReader, racesTitles, genderTitles);

                        break;

                    case MainMenuCommand.FillCharacteristics:

                        FillCharacteristic(player, inputReader);

                        break;

                    case MainMenuCommand.ShowInfo:

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Информация о персонаже:");
                        Console.WriteLine(
                            $"Имя: {player.Name}\n" +
                            $"Возраст: {player.Age}\n" +
                            $"Расса: {player.Race}\n" +
                            $"Опыт: {player.Experience}\n" +
                            $"Уровень: {player.Level}\n" +
                            $"Пол: {player.Gender}\n"

                        );

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Характеристики персонажа:");
                        Console.WriteLine($"Сила: {player.Strength}\n" +
                            $"Ловкость: {player.Agility}\n" +
                            $"Интеллект: {player.Intelegence}\n" +
                            $"Харизма: {player.Charisma}\n" +
                            $"Очки персонажа: {player.MaxPoints}\n"
                        );
                        break;

                    case MainMenuCommand.RateUs:

                        Console.WriteLine("Вы выбрали пункт 4: Оценить игру.");

                        break;

                    case MainMenuCommand.Play:

                        Play(player.Skin);

                    break;

                    case MainMenuCommand.Exit:
                        Console.WriteLine("Вы уверены, что хотите выйти? y/n ");
                        sure = Console.ReadLine().ToLower();
                        if (sure == "y" || sure == "yes")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Спасибо за игру! До свидания...");

                            isWork = false;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Вы остаетесь в игре. Выберите пункт меню...\n");
                            break;
                        }
                    default:
                        Console.WriteLine("Неизвестная команда. Пожалуйста, выберите пункт меню.");
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Переход в меню...\n");
                Console.ReadKey();
            }

            // Мне показалось, что нет смысла переписывать урок по оставшимся циклам Do While и For, поэтому просто запишу в коммент краткое описание каждого из них.
            // Do { } while (условие) - выполняет тело цикла хотя бы один раз, а потом проверяет условие. Если условие истинно, то выполняется снова и так до тех пор, пока условие не станет ложным
            // for (инициализация; условие; итерация) { тело цикла } - выполняет тело цикла, пока условие истинно. Инициализация выполняется один раз в начале, итерация выполняется после каждого выполнения тела цикла. Чаще всего используется для перебора элементов массива или коллекции
            // Пока не добавляю использование for, практика будет в массивах. На данный момент перехожу в "методы"

        }

        //Метод:
        //[модификаторы] тип_возвращаемого_значения название_метода([параметры])
        //{
        //    тело метода
        //}

        private static void FillCharacterDescription(Player player, InputReader inputReader, Dictionary<Race, string> racesTitles, Dictionary<Gender, string> genderTitles)
        {
            int minNameLength = 3;
            int tempMenuIndex = 0;
            string[] racesMenu = new string[racesTitles.Count];
            string[] gendersMenu = new string[genderTitles.Count];

            foreach (var racePair in racesTitles)
                racesMenu[tempMenuIndex++] = $"{(int)racePair.Key} - {racePair.Value}";

            tempMenuIndex = 0;

            foreach (var genderPair in genderTitles)
                gendersMenu[tempMenuIndex++] = $"{(int)genderPair.Key} - {genderPair.Value}";

            player.Name = inputReader.ReadString("Введите имя персонажа: ", minNameLength);
            player.Race = ReadRace("Выберете рассу персонажа: ", inputReader);
            player.Age = inputReader.ReadInt("Ввведите возраст персонажа: ");
            player.Experience = inputReader.ReadInt("Введите опыт персонажа: ");
            player.Level = inputReader.ReadInt("Введите уровень персонажа: ");
            player.Gender = ReadGender("Введите пол персонажа: ", inputReader );


        }

        private static void FillCharacteristic(Player player, InputReader inputReader)
        {
            player.Strength = inputReader.ReadInt("Введите силу персонажа: ");
            player.Agility = inputReader.ReadInt("Введите ловкость персонажа: ");
            player.Intelegence = inputReader.ReadInt("Введите интеллект персонажа: ");
            player.Charisma = inputReader.ReadInt("Введите харизму персонажа: ");

        }

        private static void ShowMenu(string[] commands)
        {
            Console.WriteLine("Maim menu");
            foreach (string command in commands)
            {
                Console.WriteLine(command);
            }
        }

        private static Gender ReadGender(string message, InputReader inputReader)
        {
            bool isParseSuccess = true;
            Gender genderInput;

            do
            {
                genderInput = (Gender)inputReader.ReadInt($"Введите пол ({(int)Gender.Male} - M/{(int)Gender.Female} - F )");

                isParseSuccess = genderInput == Gender.Male || genderInput == Gender.Female;

                if (!isParseSuccess)
                   inputReader.PrintWarinngInvalidInput();

            } while (!isParseSuccess);
            return genderInput;
        }
        private static Race ReadRace(string message, InputReader inputReader)
        {
            string[] raceNames = Enum.GetNames(typeof(Race));
            bool isParseSuccess = true;
            Race raceInput;

            do
            {
                for (int i = 0; i < raceNames.Length; i++)
                    Console.WriteLine($"{i + 1}. {raceNames[i]} ");

                raceInput = (Race)inputReader.ReadInt($"{message} ");

                isParseSuccess = Enum.IsDefined(typeof(Race), raceInput);

                if (!isParseSuccess)
                    inputReader.PrintWarinngInvalidInput();

            } while (!isParseSuccess);
            return raceInput;
        }

        private static void Play(char skin)
        {
            Console.CursorVisible = false;
            Console.Clear();

            bool isRun = true;

            int directionX;
            int directionY;

            int playerPositionX = 1;
            int playerPositionY = 1;

            char[,] map = new char[20, 25]
            {
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                { '#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#'},
                { '#',' ',' ','$',' ','#',' ',' ','$',' ',' ',' ','#',' ','$',' ',' ',' ',' ',' ','#',' ','$',' ','#'},
                { '#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','$',' ','#'},
                { '#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','$',' ','#'},
                { '#','#',' ',' ',' ','#',' ','$',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#','$','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#','#'},
                { '#',' ',' ',' ',' ',' ',' ','#','#','#','#','#','#','#',' ',' ',' ',' ','#',' ',' ',' ','#',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ','#',' ','#'},
                { '#',' ',' ','#','#','#','#','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','#',' ',' ','$',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#','#','#','#',' ',' ','#'},
                { '#',' ',' ',' ',' ','$',' ','#',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ','#',' ','#','#','#','#',' ',' ',' ',' ',' ','#'},
                { '#',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#','$','$','$',' ',' ','#'},
                { '#',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','$','#',' ',' ',' ',' ',' ','#'},
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            };


            int inventoryPositionY = map.GetLength(0) + 2;
            List<char> inventory = new List<char>();
           
            DrawMap(map);

            while (isRun)
            {
                DrawSymbol(skin, playerPositionX, playerPositionY);

                DrawInventory(inventory, inventoryPositionY);

                GetDirection(out directionX, out directionY);

                DrawSymbol(map[playerPositionY, playerPositionX], playerPositionX, playerPositionY);

                TryMove(map, directionX, directionY, ref playerPositionX, ref playerPositionY);

                TryCollect(map, playerPositionX, playerPositionY, MapField.Coin, inventory);
            }

            Console.ReadLine();
            Console.CursorVisible = true;

        }

        private static void TryCollect(char[,] map, int playerPositionX, int playerPositionY, MapField collectableSkin, List<char> inventory)
        {
            if (map[playerPositionY, playerPositionX] == (char)collectableSkin)
            {           
                map[playerPositionY, playerPositionX] = (char)MapField.Empty;
                inventory.Add((char)(InventoryCell)collectableSkin);
            }

        }

        private static void DrawInventory(List<char> inventory, int inventoryPositionY)
        {
            Console.SetCursorPosition(0, inventoryPositionY);

            foreach(char item in inventory)
            {
                Console.WriteLine(item + " ");
            }
        }
        private static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void DrawSymbol(char symbol, int positionX, int positionY)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
            Console.SetCursorPosition(Console.WindowWidth - 1, 0);
        }

        private static void TryMove(char[,] map, int directionX, int directionY, ref int playerPositionX, ref int playerPositionY)
        {
            if (map[playerPositionY + directionY, playerPositionX + directionX] != (char)MapField.Wall)
            {
                playerPositionX += directionX;
                playerPositionY += directionY;
            }
        }

        private static void GetDirection(out int directionX, out int directionY)
        {
            directionX = 0;
            directionY = 0;

            ConsoleKey input = Console.ReadKey().Key;

            switch (input)
            {
                case ConsoleKey.DownArrow:
                    directionY = 1;
                break;

                case ConsoleKey.UpArrow:
                    directionY = -1;
                break;

                case ConsoleKey.LeftArrow:
                    directionX = -1;
                break;

                case ConsoleKey.RightArrow:
                    directionX = 1;
                break;
            }
        }

    }

    class Player
    {
        public string Name = "";
        public Race Race = Race.Human;
        public int Age = 0;
        public int Experience = 0;
        public int Level = 0;
        public Gender Gender = Gender.Male;
        public char Skin = '@';
        public int Strength = 10;
        public int Agility = 12;
        public int Intelegence = 18;
        public int Charisma = 20;
        public int MaxPoints = 50;
    }

    class InputReader
    {
        public string ReadString(string message, int minLength = 0)
        {
            string value;
            bool isParseSuccess;

            do
            {
                Console.Write(message);
                value = Console.ReadLine();
                isParseSuccess = string.IsNullOrWhiteSpace(value) == false && value.Length >= minLength;

                if (!isParseSuccess)
                    PrintWarinngInvalidInput();
            } while (!isParseSuccess);

            return value;
        }

        public int ReadInt(string message, int minValue = 0)
        {
            int value;
            bool isParseSuccess;

            do
            {
                Console.Write(message);
                isParseSuccess = int.TryParse(Console.ReadLine(), out value) && value > minValue;

                if (!isParseSuccess)
                {
                    PrintWarinngInvalidInput();
                }
            } while (!isParseSuccess);

            return value;
        }

        public void PrintWarinngInvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Некорректный ввод");
            Console.ResetColor();
        }
    }
}
