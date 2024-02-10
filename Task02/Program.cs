// Напишите программу с классом, у которого есть два символьных поля и метод. Он не возвращает результат,
// и у него нет аргументов. При вы­зове метод выводит в консольное окно все символы из кодовой табли­цы,
// которые находятся "между" символами, являющимися значениями полей объекта (из которого вызывается метод).
// Например, если полям объекта присвоены значения ' А ' и ' D ' , то при вызове метода в консоль­ное окно
// должны выводиться все символы от ' А ' до ' D ' включительно.

namespace task2
{
    class ListTheChars
    {
        char firstChar;
        char secondChar;

        public ListTheChars(char fChar, char sChar)
        {
            firstChar = fChar;
            secondChar = sChar;
        }

        public void ShowListTheChars()
        {
            int i = 0;
            while((int)firstChar + i < (int)secondChar)
            {
                Console.Write($"{(char)(firstChar + i)}, ");
                i++;
            }
            Console.Write(secondChar);
        }
    }

    class Program
    {
        static void Main()
        {
            ListTheChars obj = new ListTheChars('A', 'D');
            obj.ShowListTheChars();
        }
    }
}
