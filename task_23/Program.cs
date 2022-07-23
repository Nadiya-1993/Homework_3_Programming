// Напишите программу, которая принимает на вход число (N) и выдаёт
// таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int[] number)
{
    int count = 0;
    int lenght = number.Length;
    while (count < lenght){
        number[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}

void PrintArray(int[] coll){
    int counter = coll.Length;
    int index = 0;
    while (index < counter){
        Console.Write(coll[index]+ " ");
        index++;
    }
}

int[] array = new int[number+1];
Cube(array);
PrintArray(array);
