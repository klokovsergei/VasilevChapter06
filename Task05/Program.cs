// Напишите программу с классом, у которого есть закрытое целочис­ленное поле. Значение полю
// присваивается с помощью открытого мето­да. Методу аргументом может передаваться целое число,
// а также метод может вызываться без аргументов. Если метод вызывается без аргумен­тов, то поле получает
// нулевое значение. Если метод вызывается с цело­численным аргументом, то это значение присваивается полю.
// Однако если переданное аргументом методу значение превышает 1ОО , то значе­нием полю присваивается число 1ОО.
// Предусмотрите в классе конструк­тор, который работает по тому же принципу, что и метод для присваи­вания
// значения полю. Также в классе должен быть метод, позволяющий проверить значение поля.

namespace Task05
{
    class ValueTask
    {
        private int code;

        public ValueTask()
        {
            this.code = 0;
        }

        public ValueTask(int number)
        {
            this.code = (number <= 100) ? number : 100;
        }

        public void SetValue()
        {
            this.code = 0;
        }
        
        public void SetValue(int number)
        {
            this.code = (number <= 100) ? number : 100;
        }
        public void ShowValue()
        {
            Console.WriteLine("Приватное поле code равно: " + this.code);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ValueTask A = new ValueTask();
            A.ShowValue();
            ValueTask B = new ValueTask(1000);
            B.ShowValue();
            ValueTask C = new ValueTask(35);
            C.ShowValue();
            C.SetValue();
            C.ShowValue();
        }
    }
}