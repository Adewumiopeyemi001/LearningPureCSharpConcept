// See https://aka.ms/new-console-template for more information


using LearningPureCSharpConcept.Concepts;
using Array = LearningPureCSharpConcept.Concepts.Array;


/*



Console.Write("Hello man \n");
Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to C#");


string name = "Yemi";
int age = 10;

Console.WriteLine("User name is {0} and Age is {1}", name, age);

Operators perform = new();
Console.WriteLine($"Sum: {Operators.Sum(23, 39)}");
Console.WriteLine($"Minus: {Operators.Min(40, 20)}");


// If else state
/*
IfElseStatement _ = new();
Console.WriteLine(IfElseStatement.Num(83));

Console.Write("Please enter your number: ");
int num = int.Parse(Console.ReadLine());

string result = IfElseStatement.Num(num);
Console.WriteLine(result);

*/

/*
Console.Write("Enter your percentage: ");
float percent = float.Parse(Console.ReadLine());

string results = IfElseStatement.Percentage(percent);
Console.WriteLine(results);



// Switch Statement
Console.Write("Enter a letter: ");

//Console.ReadKey()
char input = Console.ReadKey().KeyChar;
Console.WriteLine();

string result = SwitchStatement.Alphabeth(input);
Console.WriteLine(result);

//Loops
LoopsIteration.ForLoop();

//For Loop
ForLoops.ForLoop();

//While Loop
WhileLoop.WhileLoops();
WhileLoop.WhileLoop2();


//Do...While Loop
DoWhileLoops.While();

//Jump Statement
JumpStatement.Breaks();
JumpStatement.Continue();
JumpStatement.GoTo();
JumpStatement.Return();



//Practice Loop
PracticeLoops.LoopNum();
PracticeLoops.LoopNum2();

//Array
Array.Array1();
Array.Array2();
Array.Array3();
Array.Array4();
Array.Array5();


//Methods

Methods.Add(10, 20);
Console.WriteLine("Grade: {0}", Methods.GetGrade());
Console.WriteLine($"sum: {Methods.Addition(30, 50, 40)}");


//String
Console.WriteLine(Strings.StringPractice());
Console.WriteLine(Strings.StringPractice2());
Console.WriteLine(Strings.StringPractice3());
Console.WriteLine(Strings.StringPractice4());



Object Overlaoding
Length len1 = new(2, 8);
Length len2 = new(4, 5);
Length len3 = len2 + len1;
if (len1 > len2)
{
    Console.WriteLine("Len1 is greater");
}
else
    Console.WriteLine("Len1 is not greater");

    Console.WriteLine(len1.GetLength());
Console.WriteLine(len2.GetLength());
Console.WriteLine("Total : " + len3.GetLength());


//Properties
Accounts ac1 = new();
ac1.InitialAmount = 500;


//Indexer
Department dept = new();
Console.WriteLine(dept[101].EmpName);
Console.WriteLine(dept["Mathew"].Id);

//Inheritance
MyClass1 obj1 = new();
MyClass2 obj2 = new();
obj2.Method2();
obj2.Method1();

//Data Hiding or Shawoding
Employee1 emp1 = new();
Employee1.Work();

*/

//Method Overriding
Person1 p1 = new Student();
p1.Wor1k();
p1 = new Employee2();
p1.Wor1k();
p1 = new Person1();
p1.Wor1k();














//TYPE CASTING
//short num1 = 10;
//short num2 = 20;
//short sum = (short)(num1 + num2);
//Console.WriteLine("The sum is:", sum);




//string name2 = Console.ReadLine();
//int age2 = int.Parse(Console.ReadLine());


/*
Use start debugging or F5 to start the application in the main 
Clicking the Start button will first save the file and run the project

Console.WriteLine will print to the screen
Console.Write will also print to the screen but will not break the line
But you can use /n to break the line in Console.Write

*/




