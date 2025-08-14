// This is a simple C# program to demonstrate equality checks
using System.Threading;

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Now demonstrating inequality checks

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

// string myValue = "a";
Console.WriteLine(myValue != "a");
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

// comparison operators

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

// Contiditional Operators
// The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false. The conditional operator is commonly referred to as the ternary conditional operator.

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Console.Clear();
Random coinFlip = new Random();
int flip = coinFlip.Next(2);
Console.WriteLine($"Coin flip : {(flip == 0 ? "Head" : "Tail")}");


string permission = "Admin|Manager";
int level = coinFlip.Next(1,100);

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}



// switch statement

// A switch statement evaluates a variable or expression and executes code based on the value of that variable or expression. It is often used as an alternative to multiple if-else statements when you have many conditions to check against a single variable.

// eg.
Console.Clear();

Random idx = new Random();
int index = idx.Next(0, 3);

string[] fruits = ["Apple", "Banana", "Cherry"];
string fruit = fruits[index];

switch (fruit)
{
    case "Apple":
        Console.WriteLine("You selected an Apple.");
        break;
    case "Banana":
        Console.WriteLine("You selected a Banana.");
        break;
    case "Cherry":
        Console.WriteLine("You selected a Cherry.");
        break;
    default:
        Console.WriteLine("Unknown fruit selected.");
        break;
}


int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

// example of switch expression

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");

// now in switch expression format

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");


// for loop 

// The for statement iterates through a code block a specific number of times. This level of control makes the for statement unique among the other iteration statements. The foreach statement iterates through a block of code once for each item in a sequence of data like an array or collection. The while statement iterates through a block of code until a condition is met.

// the fizz buzz problem
// The FizzBuzz problem is a common programming challenge that requires printing numbers from 1 to 100, but with a twist: for multiples of 3, print "Fizz" instead of the number; for multiples of 5, print "Buzz"; and for numbers that are multiples of both 3 and 5, print "FizzBuzz".

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}

Thread.Sleep(10000); // Sleep for 1 second to see the output clearly

// Console.Clear();

// do-while loop 

Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/



// Code challenge - write code to implement the game rules
// Here are the rules for the battle game that you need to implement in your code project:

// You must use either the do-while statement or the while statement as an outer game loop.
// The hero and the monster start with 10 health points.
// All attacks are a value between 1 and 10.
// The hero attacks first.
// Print the amount of health the monster lost and their remaining health.
// If the monster's health is greater than 0, it can attack the hero.
// Print the amount of health the hero lost and their remaining health.
// Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
// Print the winner.

int heroHealth = 10;
int monsterHealth = 10;

do
{
    int heroAttack = random.Next(1, 11);
    monsterHealth -= heroAttack;
    Console.WriteLine($"Hero attacks! Monster loses {heroAttack} health. Monster's remaining health: {monsterHealth}");
    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }
    int monsterAttack = random.Next(1, 11);
    heroHealth -= monsterAttack;
    Console.WriteLine($"Monster attacks! Hero loses {monsterAttack} health. Hero's remaining health: {heroHealth}");
    if (heroHealth <= 0)
    {
        Console.WriteLine("Monster wins!");
        break;
    }
} while (heroHealth > 0 && monsterHealth > 0);

// The code above implements a simple battle game where a hero and a monster take turns attacking each other until one of them runs out of health.


string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);


// Program 1 Write code that validates integer input 
// string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();

// Program 2 Write code that validates string input 

string roleName = "";
validEntry = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();

// Program 3 processing strings content


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}


