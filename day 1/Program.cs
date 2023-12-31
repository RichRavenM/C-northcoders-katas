﻿using System.ComponentModel.DataAnnotations;
using System.Collections;
using System.Text.RegularExpressions;
using System;
using System.Linq;
using System.Collections.Generic;



/* Completed
1) int SumDigits(double number)
{
    string x = number.ToString();
    if (x.Contains("."))
    {
        x = x.Replace(".", String.Empty);
    }

    var y = x.ToCharArray().Select(s => Int32.Parse(s.ToString())).ToList().Sum();

    return y;
} 


2) Veggie[] veggies = { new Veggie("Parsnip", "root", 4), new Veggie("Broccoli", "brassica", 1), new Veggie("Carrot", "root", 5), new Veggie("Onion", "bulb", 3), new Veggie("Chard", "leaf", 3), new Veggie("Runner beans", "legume", 8) };

        int CountVeg(Veggie[] veg)
        {
            int sum = 0;
            foreach (Veggie i in veg)
            {
                if (i.type == "root")
                {
                    sum += i.quantity;
                }
            }
            return sum;
        }

        System.Console.WriteLine(CountVeg(veggies));

class Veggie
{
    public int quantity;
    public string type;
    public string name;

    public Veggie(string n, string t, int q)
    {
        quantity = q;
        type = t;
        name = n;
    }
}



3) string AlternateCase(string input)
        {
            bool upper = true;
            string output = "";

            foreach (var j in input)
            {
                string i = j.ToString();

                if (i == " ")
                    output += i;
                    
                
                else if(upper)
                {
                    output += i.ToUpper();
                    upper = false;
                }
                else
                {
                    output += i.ToLower();
                    upper = true;
                }
            }

            return output;
        }

        System.Console.WriteLine(AlternateCase("hello world"));

4)  System.Console.WriteLine(getCentury(1199));
        
        string getCentury(double year)
        {
            double century = Math.Floor(year / 100) + 1;
            switch(century)
            {
                case 11:
                return "11th";
                case 12:
                return "12th";
                case 13:
                return "13th";
                default:
                break;
            }

            double modTen = century % 10;

            switch(modTen)
            {
                case 1:
                return century + "st";
                case 2:
                return century + "nd";
                case 3:
                return century + "rd";
                default:
                return century + "th";
            }
        }

5) int[] numbers = new int[] { 1, 3, 5, 6, 7, 8, 9 };

        System.Console.WriteLine(AreOrdered(numbers));

        bool AreOrdered(int[] input)
        {
            if (input.Length == 0)
                return false;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] <= input[i - 1])
                    return false;
            }
            return true;
        }

6) string[] users = new string[]{"martin","xhazzi","nathan"};

        bool CheckUsernames(string[] usernames)
        {
            string pattern = @"[^a-z_0-9]";

            foreach (string user in usernames)
            {
                if (user.Length > 20 || user.Length < 5 || Regex.IsMatch(user,pattern))
                {
                    return false;
                }
            }
            return true;
        }

        System.Console.WriteLine(CheckUsernames(users));

7) int SumArgs(params int[] list)
        {
            int sum = 0;

            return sum + list.ToList().Sum();
        }

        System.Console.WriteLine(SumArgs(1, 3, 4));

8) int SumAscii(string input)
        {
            int sum = 0;
            input = input.ToLower();
            foreach (char i in input)
            {
                sum += i;
            }
            return sum;
        }
        System.Console.WriteLine(SumAscii("John"));

9)  double GetYearsOfGrowth(double start, double end, double percent, double migration)
        {
            double growthPercent = percent / 100 + 1;
            int years = 0;

            while(start < end)
            {
                start = (start * growthPercent) + migration;
                years++;
            }
            return years;
        }

        System.Console.WriteLine(GetYearsOfGrowth(1000, 2000, 2, 12));

10)   Veggie[] veggies = { new Veggie("Parsnip", "root", 4), new Veggie("Broccoli", "brassica", 1), new Veggie("Carrot", "root", 5), new Veggie("Onion", "bulb", 3), new Veggie("Chard", "leaf", 3), new Veggie("Runner beans", "legume", 8) };

        Veggie[] OrderVeg(Veggie[] veg)
        {
            return veg.ToList().OrderBy(x => x.quantity).ToArray();
        }

        var i = (OrderVeg(veggies));

        foreach(var j in i)
        {
            System.Console.WriteLine($"{j.name}\t{j.type}\t{j.quantity}");
        }
    

    class Veggie
        {
            public int quantity;
            public string type;
            public string name;

            public Veggie(string n, string t, int q)
            {
                quantity = q;
                type = t;
                name = n;
            }
        }
    }

11) Student[] coders = new Student[] { new Student("Ben", "October"), new Student("Amanda", "October"), new Student("Matt", "October") };

        bool CheckStudents(Student[] students, string month)
        {
            return !students.Any(x => x.cohort != month);
        }

        System.Console.WriteLine(CheckStudents(coders, "October"));
    public class Student
    {
        public string name;
        public string cohort;

        public Student(string n, string c)
        {
            name = n;
            cohort = c;
        }
    }

12) int[] Range(int length, int start = 0, int step = 1)
        {
            int[] output = new int[length];
            int startPoint = start;

            for (int i = 0; i < length; i++)
            {
                output[i] = startPoint;
                startPoint += step;
            }

            return output;
        }

        int[] result = Range(5, 2, 2);

        foreach (int i in result)
        {
            System.Console.WriteLine(i);
        }

13)  T[] RemoveDuplicates<T>(T[] input)
        {
            IEnumerable<T> x = input.ToList().Distinct();
            return x.ToArray();
        }

        var result = RemoveDuplicates(new string[] { "1", "beans", "2", "beans", "4", "4" });
        foreach (var i in result)
        {
            System.Console.WriteLine(i);
        }

14)  string GetDistinctLetters(string word1, string word2)
        {
            var x = word1.ToCharArray().ToList();
            var y = word2.ToCharArray().ToList();
            var z = x.Except(y).Concat(y.Except(x)).OrderBy(t => t).ToArray();
        
            return String.Join("", z);
        }

        System.Console.WriteLine(GetDistinctLetters("hello", "world"));

15)  Dictionary<char, int> GetFrequencies(string input)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            string pattern = @"[a-zA-Z0-9]";
            foreach (char i in input)
            {

                if (!Regex.IsMatch(i.ToString(), pattern))
                {
                    continue;
                }
                if (letters.ContainsKey(i))
                {
                    letters[i]++;
                }
                else
                {
                    letters.Add(i, 1);
                }
            }
            return letters;
        }

        Dictionary<char, int> result = GetFrequencies("hello world");

        foreach (KeyValuePair<char, int> i in result)
        {
            System.Console.WriteLine($"{i.Key} - {i.Value}");
        }
*/

internal class Program
{
    private static void Main(string[] args)
    {
       
    }

}