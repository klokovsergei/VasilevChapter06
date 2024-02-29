// Напишите программу с классом, в котором есть два поля: символьное и текстовое. В классе должен быть
// перегруженный метод для присваива­ния значений полям. Если метод вызывается с символьным аргументом,
// то соответствующее значение присваивается символьному полю. Если метод вызывается с текстовым аргументом,
// то он определяет значение текстового поля. Методу аргументом также может передаваться сим­вольный массив.
// Если массив состоит из одного элемента, то он опре­деляет значение символьного поля. В противном случае
// (если в массиве больше одного элемента) из символов массива формируется текстовая строка и присваивается
// значением текстовому полю.

namespace Task07
{
    class MyClass
    {
        char symb;
        string text;

        public void SetVelue(char s)
        {
            symb = s;
        }
        public void SetVelue(string t)
        {
            text = t;
        }
        public void SetVelue(char[] symbs)
        {
            if (symbs.Length == 1) symb = symbs[0];
            else text = string.Join("", symbs);
        }

        public override string ToString()
        {
            string txt = "";
            txt += "Значение поля symb = \'" + symb + "\'.";
            txt += "\nЗначение поля text = \"" + text + "\".";
            return txt;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            Console.WriteLine(A);
            A.SetVelue('P');
            A.SetVelue("Hello!");
            Console.WriteLine(A);
            char[] charArray1 = { 'Z' };
            A.SetVelue(charArray1);
            Console.WriteLine(A);
            char[] charArray2 = { 'G', 'o', 'o', 'd', 'B', 'y', 'e', '!', 'K', 'i', 's', 's' };
            A.SetVelue(charArray2);
            Console.WriteLine(A);
        }
    }
}