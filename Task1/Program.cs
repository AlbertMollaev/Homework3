// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


void ShowQuarter(int n)
{
    for (int i = 0; i < n; i++) {
        Console.Write(i*i*i + ", ");
    }
    Console.Write(n*n*n);

}


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int n = GetInput("Введите число N: ");
ShowQuarter(n);
