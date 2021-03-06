﻿using System;
using AoC.Y2018.Days;
using AoC.Y2019.Days;
using AoC.Helpers.Utils;
using AoC.Helpers.Days;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AoC.Helpers.IntComputer;
using AoC.Helpers.Input;

namespace AoC.Runner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExecuteYears();
        }

        private static void ExecuteYears()
        {
            // ExecuteYear(2015);
            // ExecuteYear(2016);
            // ExecuteYear(2017);
            // ExecuteYear(2018);
            ExecuteYear(2019);
            //Play2019Day25();
        }

        private static void ExecuteYear(int year, int maxDays = 25)
        {
            var days = GetDays(year, maxDays);

            Console.WriteLine($"Advent of code {year}!");
            foreach (var day in days)
            {
                try { Console.WriteLine($"{day.ToString()} {day.Execute(Part.One)}"); }
                catch { }

                try { Console.WriteLine($"{day.ToString()} {day.Execute(Part.Two)}"); }
                catch { }
            }
        }

        private static void Play2019Day25()
        {
            var program = InputParser.GetInputList(2019, 25).Single();
            var android = new Computer(program);

            while (true)
            {
                android.Run();
                Console.WriteLine(android.GetAsciiOutputs());

                var command = Console.ReadLine();
                android.AddAsciiCommand(command);
            }
        }

        private static List<BaseDay> GetDays(int year, int maxDays)
        {
            var days = new List<BaseDay>();
            var assembly = Assembly.Load($"AoC.Y{year}");

            for (int dayNumber = 1; dayNumber <= maxDays; dayNumber++)
            {
                var dayType = GetDay(assembly, year, dayNumber);                
                var day = Activator.CreateInstance(dayType);
                days.Add((BaseDay)day);
            }

            return days;
        }

        private static Type GetDay(Assembly year, int yearNumber, int dayNumber) => year.GetType($"AoC.Y{yearNumber}.Days.Day{dayNumber.ToString("D2")}");
    }
}
