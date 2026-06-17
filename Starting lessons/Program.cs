using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace Starting_lessons
{

    internal class Program
    {
        enum MainMenuCommand
        {
            Exit,
            FillDescription,
            FillCharacteristics,
            ShowInfo,
            RateUs,
            Play
        }

        enum MapField
        {
            Empty = ' ',
            Wall = '#',
            Coin = '$'
        }
        enum InventoryCell
        {
            Empty = '?',
            Coin = '$'
        }

        enum RateMenuCommand
        {
            Yes,
            No
        }

        enum Gender
        {
            Male = 1,
            Female = 2
        }

        enum Race
        {
            Human = 1,
            Elf,
            Orc,
            Robot,
            
        }
        private static void Main()
        {

            //  Константы для команд меню

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

            //Создаём меню для игры

            //Данные о персонаже
            string name = "";
            Race race = Race.Human;
            int age = 0;
            int experience = 0;
            int level = 0;
            Gender gender = Gender.Male;
            char skin = '@';

            //Характеристики персонажа
            int strength = 10;
            int agility = 12;
            int intelegence = 18;
            int charisma = 20;

            int maxPoints = 50;

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

            name = ReadString("Введите имя персонажа: ", minNameLength);
            race = ReadRace("Выберете рассу персонажа: ");
            age = ReadInt("Ввведите возраст персонажа: ");
            experience = ReadInt("Введите опыт персонажа: ");
            level = ReadInt("Введите уровень персонажа: ");
            gender = ReadGender("Введите пол персонажа: ");

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
                input = ReadInt("Введите номер команды ", -1);

                switch ((MainMenuCommand)input)
                {
                    case MainMenuCommand.FillDescription:

                        FillCharacterDescription(out name, out age, out race, out experience, out level, out gender);

                        break;

                    case MainMenuCommand.FillCharacteristics:

                        FillCharacteristic(out strength, out agility, out intelegence, out charisma);

                        break;

                    case MainMenuCommand.ShowInfo:

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Информация о персонаже:");
                        Console.WriteLine(
                            $"Имя: {name}\n" +
                            $"Возраст: {age}\n" +
                            $"Расса: {race}\n" +
                            $"Опыт: {experience}\n" +
                            $"Уровень: {level}\n" +
                            $"Пол: {gender}\n"

                        );

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Характеристики персонажа:");
                        Console.WriteLine($"Сила: {strength}\n" +
                            $"Ловкость: {agility}\n" +
                            $"Интеллект: {intelegence}\n" +
                            $"Харизма: {charisma}\n" +
                            $"Очки персонажа: {maxPoints}\n"
                        );
                        break;

                    case MainMenuCommand.RateUs:

                        Console.WriteLine("Вы выбрали пункт 4: Оценить игру.");

                        break;

                    case MainMenuCommand.Play:

                        Play(skin);

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

            #endregion
        }

        //Метод:
        //[модификаторы] тип_возвращаемого_значения название_метода([параметры])
        //{
        //    тело метода
        //}

        private static void FillCharacterDescription(out string name, out int age, out Race race, out int experience, out int level, out Gender gender)
        {
            int minNameLength = 3;
            string racesTitle = ;
            string genderTitle = ;

        }

        private static void FillCharacteristic(out int strength, out int agility, out int intelegence, out int charisma)
        {
            strength = ReadInt("Введите силу персонажа: ");
            agility = ReadInt("Введите ловкость персонажа: ");
            intelegence = ReadInt("Введите интеллект персонажа: ");
            charisma = ReadInt("Введите харизму персонажа: ");

        }

        private static void ShowMenu(string[] commands)
        {
            Console.WriteLine("Maim menu");
            foreach (string command in commands)
            {
                Console.WriteLine(command);
            }
        }

        private static string ReadString(string message, int minLength = 0)
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

        private static int ReadInt(string message, int minValue = 0)
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

        private static void PrintWarinngInvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Некорректный ввод");
            Console.ResetColor();
        }

        private static Gender ReadGender(string message)
        {
            bool isParseSuccess = true;
            Gender genderInput;

            do
            {
                genderInput = (Gender)ReadInt($"Введите пол ({(int)Gender.Male} - M/{(int)Gender.Female} - F )");

                isParseSuccess = genderInput == Gender.Male || genderInput == Gender.Female;

                if (!isParseSuccess)
                   PrintWarinngInvalidInput();

            } while (!isParseSuccess);
            return genderInput;
        }
        private static Race ReadRace(string message)
        {
            string[] raceNames = Enum.GetNames(typeof(Race));
            bool isParseSuccess = true;
            Race raceInput;

            do
            {
                for (int i = 0; i < raceNames.Length; i++)
                    Console.WriteLine($"{i + 1}. {raceNames[i]} ");

                raceInput = (Race)ReadInt($"{message} ");

                isParseSuccess = Enum.IsDefined(typeof(Race), raceInput);

                if (!isParseSuccess)
                    PrintWarinngInvalidInput();

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

        private static int GetCharCount(char[,] array, MapField field)
        {
            int coint = 0;
            char fieldChar = (char)field;

            for (int i = 0; i < array.GetLength(0); i++) 
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i, j] == fieldChar)
                        coint++;

            return coint;
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
}
