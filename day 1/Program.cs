using System.Text.RegularExpressions;
using System;


internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}



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
*/