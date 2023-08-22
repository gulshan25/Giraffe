// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

//String characterName = "Tom";
//int characterAge; 
//characterAge = 20;

//Console.WriteLine("My name is " + characterName);


//characterName = "village";
//Console.WriteLine("I live in " + characterName);
//Console.WriteLine("I am " + characterAge + " years old");


//String phrase = "Gulshan Rahman";
//Console.WriteLine(phrase);

//String word = "Gulshan Rahman" + " is fool";
//Console.WriteLine(word);


//Console.WriteLine("Gulshn Rahman \nTanny");

//Console.WriteLine("    /| ");
//Console.WriteLine("   / | ");
//Console.WriteLine("  /  | ");
//Console.WriteLine(" /___| ");

//String phrase = "Gulshan Rahman";
//Console.WriteLine(phrase.ToLower());

//String phrase = "Gulshan Rahman";
//Console.WriteLine(phrase.ToUpper());

//String phrase = "Gulshan Rahman";
//Console.WriteLine(phrase.Contains("Gulshan"));

//String phrase = "Gulshan Rahman";
//Console.WriteLine(phrase[0]);

//String phrase = "Gulshan Rahman";
//Console.WriteLine(phrase.IndexOf("R"));

//Console.WriteLine((5+7) * 8);


//int num = 6;

//Console.WriteLine(num);

//int num = 6;
//num++;
//Console.WriteLine(num);

//Console.WriteLine(Math.Pow(3.6,5));

//Console.Write("Enter your name: ");
//string name = Console.ReadLine();
//Console.WriteLine("Hello " + name);

//string sentence = "Gulshan Rahman";
//Console.WriteLine(sentence.ToUpper());


//Console.Write("Enter your name: ");
//string name = Console.ReadLine();
//Console.Write("Enter your age: ");
//string age = Console.ReadLine();
//Console.WriteLine("Hello " + name + " you are " + age);


//int num = Convert.ToInt32("45");
//Console.WriteLine(num + 6);


//Console.Write("Enter a number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter another number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(num1 + num2);

//Console.Write("Enter a number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Enter another number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.Write(num1 + num2);

//string color, pluralNoun, celebrity;

//Console.Write("Enter color: ");
//color = Console.ReadLine();

//Console.Write("Enter Plural Noun: ");
//pluralNoun = Console.ReadLine();

//Console.Write("Enter celebrity: ");
//celebrity = Console.ReadLine();

//Console.WriteLine("Roses are " + color);
//Console.WriteLine(pluralNoun + " are blue");
//Console.WriteLine("I love " +  celebrity);

//int[] luckynumbers = { 8, 4, 6, 9 };

//luckynumbers[1] = 7;

//Console.WriteLine(luckynumbers[1]);

//Console.ReadLine();

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 33);

            Console.ReadLine();
        }
  
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " His age is " + age + " years old");
        }
    }

}






