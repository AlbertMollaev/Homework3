// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void GetPalindrom(int num) {
    int r = 0;
    int sum = 0; 
    int i = 0;
    if(num > 9999 && num < 100000) {
        for( i = num; num != 0; num = num / 10 ) {
        r=num % 10;
        sum=sum*10+r;}
            if(i==sum)
                Console.Write($"{i} является палиндромом.");
            else
                Console.Write($"{i} не является палиндромом.");
        }
    else Console.Write("Введите пятизначное число!");
}


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int num = GetInput("Введите пятизначное число для проверки на палиндром : ");
GetPalindrom(num);