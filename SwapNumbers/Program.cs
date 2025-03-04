Console.Write("Input the First Number: ");
string input1 = Console.ReadLine();
bool succes1 = int.TryParse(input1, out int firstNumber);

Console.Write("Input the Second number: ");
string input2 = Console.ReadLine();
bool succes2 = int.TryParse(input2, out int secondNumber);

if (succes1 && succes2)
{
    int temp;

    temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;

    Console.WriteLine("After swaping: ");
    Console.WriteLine("First Number: " + firstNumber);
    Console.WriteLine("Second Number: " + secondNumber);
}
else
{
    Console.WriteLine("Invalid input! Please enter a valid number!");
}