// See https://aka.ms/new-console-template for more information


using LearningPureCSharpConcept.Concepts;

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
*/


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




