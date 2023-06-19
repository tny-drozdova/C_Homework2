/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. Не использовать строки для расчета.
Examples: 
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = GetSecondDigit(number); //we are callign for a method that will get a value for our variable secondDigit

int GetSecondDigit(int number)
{ //Defining the method
    int secondDigit = (number / 10) % 10; //We devide to 10 to get rid off the last number, and then we get the reminder from devidinng to 10 again 
    return secondDigit;
}
Console.WriteLine($"The second digit of the {number} is: {secondDigit}");