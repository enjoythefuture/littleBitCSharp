﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starting_lessons
{
    internal class Program
    {
        static void Main(string[] args)
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


            //Продемонстрируем магию тернарного оператора
            int number = 3;

            // Переменная = условие? значение при истине : значение при лжи
            string result = number % 2 == 0 ? "Even" : "Odd";

            Console.WriteLine(result);
        }
    }
}
