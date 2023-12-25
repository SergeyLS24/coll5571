
//тип_данных имя_переменной = значение;
// camelCase: firstNumber, secondNumber

int number = 9; // number = 9
int result = number * number; //81 

// Console.ReadLine() - получить информацию из строчки

Console.Write("Введите число: "); //a
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: "); //b
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine("Да, " + firstNumber +"является кв. от числа" + secondNumber);
}
else 
{
    Console.WriteLine("Нeт, " + firstNumber +"не является кв. от числа" + secondNumber);
}