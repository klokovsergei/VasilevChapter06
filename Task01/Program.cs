// Напишите программу с классом, в котором есть закрытое символь­ное поле и три открытых метода.
// Один из методов позволяет присво­ить значение полю. Еще один метод при вызове возвращает результатом код символа.
// Третий метод позволяет вывести в консольное окно символ (значение поля) и его код.

class Task01
{
    private static char symbol;

    public static void Set(char symb)
    {
        symbol = symb;
    }

    public static void ShowCodeAll()
    {
        Console.WriteLine($"Символ '{symbol}' имеет в таблицу UTF-8 код - {(int)symbol}.");
    }

    public static void ShowCode()
    {
        Console.WriteLine("Введенный вами символ имеет код - {0}.", (int)symbol);
    }
}

class IntAndChar
{
    static void Main()
    {
        Console.Write("Введите 1 символ: ");
        char userSymbol = char.Parse(Console.ReadLine()!);
        Task01.Set(userSymbol);
        Task01.ShowCode();
        Task01.ShowCodeAll();
    }
}