/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
Examople:
645 -> 5
78 -> третьей цифры нет
326792 -> 6
*/

Console.WriteLine("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = GetThirdDigit(number); //we are callign for a method that will get a value for our variable thirdDigit
if (thirdDigit == -1)
{
    Console.WriteLine("The third digit is missing.");
}
else
{
    Console.WriteLine($"The third digit is {thirdDigit}");
}


int GetThirdDigit(int number) //Defining the method
{
    int thirdDigit = (number / 100) % 10; //We devide to 100 to get rid off the last two numbers, and the reminder is devided to 10 to find its reminder 
if (thirdDigit == 0)
{
    return -1;
}
else
{
    return thirdDigit;
}
}

