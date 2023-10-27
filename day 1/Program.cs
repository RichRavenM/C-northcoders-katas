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
*/