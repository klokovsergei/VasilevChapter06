// Напишите программу с классом, в котором есть два закрытых цело­численных поля (назовем их max и min).
// Значение поля max не может быть меньше значения поля min. Значения полям присваиваются с по­мощью открытого метода.
// Метод может вызываться с одним или двумя целочисленными аргументами. При вызове метода значения полям
// при­сваиваются так: сравниваются текущие значения полей и значения аргу­мента или аргументов, переданных методу.
// Самое большое из значений присваивается полю max, а самое маленькое из значений присваивает­ся полю min.
// Предусмотрите конструктор, который работает по тому же принципу, что и метод для присваивания значений полям.
// В классе так­ же должен быть метод, отображающий в консольном окне значения по­лей объекта.

namespace task06
{
    class MyClass
    {
        int max;
        int min;
        
         public MyClass(int num)
        {
            if (num > 0) this.max = num;
            else this.min = num;
        }
        public MyClass(int newMin, int newMax)
        {
            this.max = (newMax > newMin) ? newMax : newMin;
            this.min = (newMin < newMax) ? newMin : newMax;
        }       
        public void SetVelue(int newMin, int newMax)
        {
            if (newMin > newMax)
            {
                int temp;
                temp = newMin;
                newMin = newMax;
                newMax = temp;
            }
            this.max = (this.max > newMax) ? this.max : newMax;
            this.min = (this.min < newMin) ? this.min : newMin;
        }
        public void SetVelue(int newNum)
        {
            this.max = (this.max > newNum) ? this.max : newNum;
            this.min = (this.min < newNum) ? this.min : newNum;
        }

        public override string ToString()
        {
            string txt = "";
            txt += "Поле min у данного объекта = " + this.min;
            txt += "\nПоле max у данного объекта = " + this.max;
            return txt;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass(-3);
            A.SetVelue(6, 10);
            Console.WriteLine(A);
            A.SetVelue(100);
            Console.WriteLine(A);
            A.SetVelue(-100);
            Console.WriteLine(A);
            A.SetVelue(358, -120);
            Console.WriteLine(A);
        }
    }
}