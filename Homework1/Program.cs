Console.WriteLine("Введите пятизначное число");
int value = int.Parse(Console.ReadLine());

int number5 = value%10;
int number51 = value/10;
int number4 = number51%10;
int number41 = number51/10;
int number3 = number41/10;
int number2 = number3%10;
int number21 = number3/10;
int number1 = number21%10;

if (number5 == number1 & number2 == number4) Console.Write(value + " -> да");

else
{
    Console.Write(value + " -> нет");
}