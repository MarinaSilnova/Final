//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Console.WriteLine("ВВедите кол-ва строк");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string [n];
for (int i = 0; i < array.Length; i++)
        array [i] = Console.ReadLine();
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
string[] result_array = new string[array.Length];
int m = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
    result_array[m] = array[i];
    m++;
    }
   
}
Array.Resize(ref result_array, m);
void PrintArray(string[] array)
{
   Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
   Console.WriteLine();
}
PrintArray(result_array);