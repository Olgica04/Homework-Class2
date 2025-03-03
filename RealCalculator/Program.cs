Console.Write("Enter your first number: ");
string input1 = Console.ReadLine();
//int firstNumber = Convert.ToInt32(input1);
bool succes1= int.TryParse(input1, out int firstNumber);

Console.Write("Enter your second number: ");
string input2 = Console.ReadLine();
//int secondnumber = Convert.ToInt32(input2);
bool succes2 = int.TryParse(input2, out int secondNumber);

Console.Write("Enter your operation: ");
string operation = Console.ReadLine();

int result;

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

