Console.WriteLine("Welcome To The Console Project (Calculator)");

Console.WriteLine("Input the first number");
var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);

Console.WriteLine("Input the second number");
var secondAsText = Console.ReadLine();
var number2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubstract numbers");
Console.WriteLine("[M]ultiply numbers"); 

var choice = Console.ReadLine();

if(EqualCaseInsensitive(choice, "A"))
{
    var sum = number1 + number2;
    PrintFinalEquation(number1, number2, sum, "+");
}

else if (EqualCaseInsensitive(choice, "S"))
{
    var difference = number1 - number2;
    PrintFinalEquation(number1, number2, difference, "-");
}

if (EqualCaseInsensitive(choice, "M"))
{
    var multiplied = number1 * number2;
    PrintFinalEquation(number1, number2, multiplied, "*");
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key close"); 
Console.ReadKey();

void PrintFinalEquation(int number1, int number2, int result, string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}

bool EqualCaseInsensitive(string left, string right)
{ 
return left.ToUpper().Equals(right.ToUpper());
}