// Ввод исходного массива строк с клавиатуры
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        // Формирование нового массива из строк, длина которых <= 3
        string[] newArray = FilterShortStrings(inputArray);

        // Вывод нового массива
        Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterShortStrings(string[] array)
        {
            // Определяем длину нового массива
            int count = 0;
            foreach (string str in array)
            {
                if (str.Length <= 3)
                {
                    count++;
                }
            }

            // Создаем новый массив нужной длины
            string[] newArray = new string[count];

            // Заполняем новый массив строками, длина которых <= 3
            int index = 0;
            foreach (string str in array)
            {
                if (str.Length <= 3)
                {
                    newArray[index] = str;
                    index++;
                }
            }

            return newArray;
}
}