// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowDistance(int ax , int ay , int az, int bx , int by, int bz)
{
    double distance = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by , 2) + Math.Pow(az - bz, 2));
    Console.WriteLine($"Разница между точками A: {ax}, {ay}, {az} и между точками B: {bx}, {by}, {bz} равна : {distance}");
}


int GetInput(string text)
{
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
}

int ax = GetInput("Введите координаты X: ");
int ay = GetInput("Введите координаты Y: ");
int az = GetInput("Введите координаты Z: ");
int bx = GetInput("Введите координаты X: ");
int by = GetInput("Введите координаты Y: ");
int bz = GetInput("Введите координаты Z: ");
ShowDistance(ax , ay, az, bx , by, bz);