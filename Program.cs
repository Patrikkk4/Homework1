﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        /// <summary>
        /// Главный метод выполнения Домашнего задания 1.1
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Создание базы данных из 20 сотрудников
            Repository repository = new Repository(20);

            // Печать в консоль всех сотрудников
            repository.Print("База данных до преобразования");

            Console.WriteLine("Нажмите любую клавишу для вывода сотрудников не попавших под увольнение после первой волны"); // Указания действия пользователя

            Console.WriteLine(""); // Пустая строка для более удобного визуального восприятия

            Console.ReadKey(); // ожидание действия пользователя

            // Увольнение всех работников с именем "Агата"
            repository.DeleteWorkerByName("Агата");

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после первого преобразования");

            // Увольнение всех работников с именем "Аделина"
            repository.DeleteWorkerByName("Аделина");

            Console.WriteLine("Нажмите любую клавишу для вывода сотрудников не попавших под увольнение после второй волны"); // Указания действия пользователя

            Console.WriteLine(""); // Пустая строка для более удобного визуального восприятия

            Console.ReadKey(); // ожидание действия пользователя

            // Печать в консоль сотрудников, которые не попали под увольнение
            repository.Print("База данных после второго преобразования");

            Console.WriteLine("Нажмите любую клавишу для выхода из приложения"); // Указания действия пользователя

            Console.ReadKey(); // ожидание действия пользователя

            
            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе болжно остаться не более 30 работников

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб



            #endregion

        }
    }
}
