using System;

namespace cSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "Hello poc"  );
        }
       
        static void TRIAGLESQ()
        {
            Console.WriteLine("enter the Number AB");
            double ab = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the Number Ac");
            double ac = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the Number BC");
            double bc = double.Parse(Console.ReadLine());

            double p = (ab + bc + ac) / 2;
            double sq = Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));

            //Console.WriteLine(sq.);

        }
        static void Dfdfz()
        {
            Console.WriteLine("type in 2 integers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;

            Console.WriteLine(a);
            Console.WriteLine(c);

            Console.WriteLine("Type in 1 number");
           // int a = int.Parse(Console.ReadLine());
            //Console.WriteLine(a.ToString().Length);
        }

        static void IntroToArrays()
        {
            string s1 = "qwertyui";
            char first = s1[0];
            char last = s1[s1.Length - 1];
            Console.WriteLine($"first: {first}. Last: {last}");
        }
        static void Interpolirowanie()
        {
            Console.WriteLine("Name?");
            string name = Console.ReadLine();
            string sentence = $"your name is {name}";
            Console.WriteLine(sentence);

            Console.WriteLine("Age?");
            string input = Console.ReadLine();
            int age = int.Parse(input);
            string sentence1 = $"you are {age} years old";
            Console.WriteLine(sentence1);
        }
        static void StringFormat()
        {
            string name = "Max";
            int age = 30;
            string Max = string.Format("My name is {0} and i'm {1}", name, age);
            Console.WriteLine(Max);
        }
        static void StringModification()
        {
            string nameConcat = string.Concat("My ", "name ", "is ", "Max");
            Console.WriteLine(nameConcat);

            string Max = string.Join(" ", "My", "name", "is", "Max");
            Console.WriteLine(Max);
            Max = Max.Insert(0, "By the way, ");
            Console.WriteLine(Max);
        }
        static void Variables() 
        {
            int x = -1;
            int y;
            y = 2;
            char charecter = 'A';
            Console.WriteLine(x);
            Console.WriteLine(charecter);
        }


    }

}
