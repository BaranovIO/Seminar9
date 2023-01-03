/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/

/*
int GetSumOfDigits(int num)
{
    if(num != 0)
    {
        return GetSumOfDigits(num / 10) + num % 10;
    }
    return 0;
}

Console.WriteLine(GetSumOfDigits(1342));
*/

//Задайте значения М и N. Напишите программу, которая выведет все натураольные числа от M до N.
/*
void ShowNums(int num1, int num2)
{
    Console.Write(num1 + " ");

    if(num1 < num2) ShowNums(num1 + 1, num2);
    
    if(num1 > num2) ShowNums(num1 - 1, num2);
    
}

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
ShowNums(num1, num2);
*/

// Напишите программу, которая на вход принимает два числа А и В и возводит число А в целую степень В.

double Num(int a, int b)
{
    if(b > 0) return Num(a, b - 1) * a;
    if(b < 0) return Num(a, b + 1) / a;
    return 1;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
double result = Num(a, b);
Console.Write(result);