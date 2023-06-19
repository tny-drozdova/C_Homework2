/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Examples:
6 -> да 
7 -> да 
1 -> нет
*/


int ReadInt(string message)
{
    System.Console.Write(message);
    int day = Convert.ToInt32(Console.ReadLine()); //introdusing our variable "day"
    return day;
}

bool ValidateDay(int number)  
{
    if (number == 6 || number == 7)     // the OR operator confirms if the number is Saturday(6) OR Sunday(7)
    {
        return true;
    }
    System.Console.WriteLine("This is a WORKING day");  //This will be shown if the number is not weekend
    return false;
}

int day = ReadInt("Enter a number that represents a day of the week: ");
if (ValidateDay(day))
{
    System.Console.WriteLine($"The number {day} is a WEEKEND");
}