
string stroka = ReadStr("Введите массив строк через пробел: ");
string[] array1 = GenerateFirstArray(stroka);
ResultArray(array1);


string ReadStr(string text) // Ввод данных с клавиатуры
{
    Console.WriteLine(text);
    return Console.ReadLine();
}

string[] GenerateFirstArray(string str) // Преобразование строки в массив строк
{
    string[] arr = stroka.Split(' ');
    return arr;
}

void ResultArray(string[] arr) // Формирование финального массива из строк заданной длины
{
    string[] newArr = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[count] = array1[i];
            count++;
        }
    }
    System.Console.WriteLine("[" + string.Join(",", newArr) + "]");
}
