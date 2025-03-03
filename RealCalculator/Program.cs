Console.Write("Enter your first number: ");
string input1 = Console.ReadLine();
bool succes1= float.TryParse(input1, out float firstNumber);

Console.Write("Enter your second number: ");
string input2 = Console.ReadLine();
bool succes2 = float.TryParse(input2, out float secondNumber);

Console.Write("Enter your operation: ");
string operation = Console.ReadLine();

float result;

switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        Console.WriteLine("The result is: " + result);
        break;
    case "-":
        result = firstNumber - secondNumber;
        Console.WriteLine("The result is: " + result);
        break;
    case "*":
        result = firstNumber * secondNumber;
        Console.WriteLine("The result is: " + result);
        break;
    case "/":
        result = firstNumber / secondNumber;
        Console.WriteLine("The result is: " + result);
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}

