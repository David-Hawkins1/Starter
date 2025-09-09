
// Section 1 : Introduction
Console.WriteLine("I like pizza!");
Console.WriteLine("It's really good!");
// Section 2 : Output
Console.Write("Hey!");
Console.WriteLine("Hello!");
// The difference between Write and WriteLine : WriteLine 'hits the enter key' after output whereas Write does not.
Console.WriteLine(); // to type this quickly type cw and hit tab
                     // This is a comment. (// at the start.)
/*
* This is a multiline comment
* performed by starting with /*
* This can be finished by doing
*/
/* \t does a tab effect (moves forward by 4 spaces.)
* \b does a backspace where placed
* \n puts the text after on a new line
*/

// Section 3 : Variables
int x; // Declaration : Declare what data type the variable is using and the identifier.
/* Data types : 
 * int = Integer (Whole number) e.g. 6
 * double = Floating point number e.g. 5.9
 * char = Single character e.g. b
 * bool = Boolean e.g. True, False
 * string = String e.g. Hello World!
 */
x = 123; // Initialisation : Assign the variable a value.
int y = 321; // This is a combination of both.
int z = x + y;


Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);

int age = 15;
Console.WriteLine("Your age is " + age); //concatenation

// Section 4 : Constants : Immutable values which are known at compile time and do not change throughout the program
const double pi = 3.14159;
// To declare a constant use the const keyword before declaration.
Console.WriteLine(pi);

// Section 5 : Type casting : Converting a variable to a different data type.
double a = 3.14;
int b = Convert.ToInt32(a); // Use the convert function to type cast

int c = 123;
double d = Convert.ToDouble(c);


Console.WriteLine(b);
Console.WriteLine(d);
Console.WriteLine(a.GetType()); // Use.GetType() to obtain the data type of a variable

// Section 6 : User Input
Console.Write("What's your name? ");
var name = Console.ReadLine();

Console.WriteLine("Hello "+name);

// Section 6 : If Statements

if (name == "David") // Similar statement to python expect you need brackets around the comparison
{ // These Curly braces identify a block of code that belongs to the statement
    Console.WriteLine("My name is the same lols :).");  // The terminating semicolon goes here
}
else if (name == "Zach") // Unlike Python u seperate the words else and if The same brackets seperate the comparison 
{
    Console.WriteLine("My friend is called Zach, are you my friend???");
}
else // else statements don't need a comparison
{
    Console.WriteLine("Thats a cool name!");
}
/* If statements do a comparison to check a variable and then perform a 'block' of code depending on the result
 * Else If statements are like if statements excpet they are checked if the if statement appears false
 * Else statements run if the if and else if statments all return false
 */
Console.WriteLine("Select a day of the week (Number)");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break; // a break is needed at the end of each block of code to separate the different blocks of code.
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default: // a default is used if the value is not found in one of the cases
        Console.WriteLine("There are only seven days of the week");
        break;
}
// Outputs "Thursday" (day 4)
/* The switch statement first inputs a variable
 * You then have multiple different blocks of code starting with case and then a value
 * Whichever value matches the variable that block of code will run
 */

// Section 7 : Arrays

// The format for arrays is type[] arrayName;
//e.g.
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// The array is surrounded by curly brackets not square brackets like Python

// Section 8 : for/for each Statements
for (int i = 0; i < 3; i++)
{
    Console.Write(i);
}
// Output: 012
/* The formatting for a for statement
 * after the key word for you have brackets to seperate the statement that controls the for loop
 * You then set a variable that controls the loop in this case i which is set as an integer to 0
 * You then give the limiting factor which tells the loop when to stop repeating
 * Then you give the iterative statement on what to do to the variable after the loop has finished
 * Each part is seperated by a semicolon
 * The variable is checked at the start of the loop after the iterative statement is performed
 */ 
Console.ReadKey(); //It stops the terminal from closing before the user has a chance to read. Should always be at the end.