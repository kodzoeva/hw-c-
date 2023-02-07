//  Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл 
// пользователь.

int [] CreatArray(string message)
{
    System.Console.WriteLine(message + ">");
    int sizeMassiv = Convert.ToInt32(Console.ReadLine());
    int[] massiv = new int[sizeMassiv];
    return massiv;
}

int[] FillingArray (int[] baseArray, string message)
{
    for (int i = 0; i < baseArray.Length; i++)
    {
        System.Console.WriteLine(message + $">");
        baseArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return  baseArray;
}

void DisplayElements(int[] baseArray)
{
    System.Console.WriteLine("Введенные числа");
    for (int i = 0; i < baseArray.Length; i++)
    {
        System.Console.WriteLine($"{baseArray [i]}");
    }
}

void FindNum(int[] baseArray)
{
    int count = 0;
    for (int i = 0; i < baseArray.Length; i++)
    {
       if( baseArray[i] > 0) 
       {
        count ++;
       }
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine($"Количество значений больше нуля составляет {count}");
}

int[] baseArray = CreatArray("Введите количество чисел для ввода");
string message = $"Введите число";
FillingArray(baseArray,message);
DisplayElements(baseArray);
FindNum(baseArray);
