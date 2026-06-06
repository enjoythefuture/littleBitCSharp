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
        private static void Main()
        {

            //  Константы для команд меню
            const string ExitComand = "0";
            const string FillDescriptionComand = "1";
            const string FillCharacteristicsComand = "2";
            const string ShowInfoComand = "3";
            const string RateUsComand = "4";
            const string PlayComand = "5";
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
            string race = "";
            int age = 0;
            int experience = 0;
            int level = 0;
            bool isMale = true;
            char skin = '@';

            //Характеристики персонажа
            int strength = 10;
            int agility = 12;
            int intelegence = 18;
            int charisma = 20;

            int maxPoints = 50;

            bool isWork = true;
            string input, sure;

            string[] commands = {$"{FillDescriptionComand}. Заполнить информацию о персонаже\n",
                   $"{FillCharacteristicsComand}. Распределить характеристик\n",
                   $"{ShowInfoComand}. Показать информацию\n",
                   $"{RateUsComand}. Оценить игру\n",
                   $"{PlayComand}. Играть\n",
                   $"{ExitComand}. Выход"
            };



            while (isWork)
            {
                Console.Clear(); // Очистка консоли
                Console.ForegroundColor = ConsoleColor.Green;

                ShowMenu(commands);

                Console.Write("Выберите пункт меню (введите номер команды) \n");
                input = Console.ReadLine();

                switch (input)
                {
                    case FillDescriptionComand:

                        FillCharacterDescription(out name, out age, out race, out experience, out level, out isMale);

                        break;

                    case FillCharacteristicsComand:

                        FillCharacteristic(out strength, out agility, out intelegence, out charisma);

                        break;

                    case ShowInfoComand:
                        string gender = isMale ? "Мужской" : "Женский";

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

                    case RateUsComand:

                        Console.WriteLine("Вы выбрали пункт 4: Оценить игру.");

                        break;

                    case PlayComand:

                        Play(skin);

                    break;

                    case ExitComand:
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

        private static void FillCharacterDescription(out string name, out int age, out string race, out int experience, out int level, out bool isMale)
        {
            int minNameLength = 3;

            name = ReadString("Введите имя персонажа: ", minNameLength);
            race = ReadString("Введите рассу персонажа: ");
            age = ReadInt("Ввведите возраст персонажа: ");
            experience = ReadInt("Введите опыт персонажа: ");
            level = ReadInt("Введите уровень персонажа: ");
            isMale = ReadGender("Введите пол персонажа: ");
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

        private static bool ReadGender(string message)
        {
            bool isParseSuccess = true;
            string maleGenderMark = "M";
            string femaleGenderMark = "F";
            string genderInput;

            do
            {
                Console.WriteLine($"Введите пол ({maleGenderMark}/{femaleGenderMark})");
                genderInput = Console.ReadLine().ToUpper();

                if (genderInput == maleGenderMark)
                    return true;

                else if (genderInput == femaleGenderMark)
                    return false;
                else
                {
                    isParseSuccess = false;
                    PrintWarinngInvalidInput();

                }
            } while (!isParseSuccess);
            return true;
        }

        private static void Play(char skin)
        {
            Console.CursorVisible = false;
            Console.Clear();

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

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                { 
                    Console.Write(map[i, j]); 
                } Console.WriteLine();      
            }

            Console.SetCursorPosition(playerPositionY, playerPositionX);
            Console.Write(skin);
            Console.SetCursorPosition(100, 0);
            Console.ReadLine();
            Console.CursorVisible = true;
        }
    }
}
