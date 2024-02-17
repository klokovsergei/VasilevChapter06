// Напишите программу с классом, у которого есть два целочисленных поля.
// В классе должны быть описаны конструкторы, позволяющие соз­давать объекты без передачи аргументов,
// с передачей одного аргумента и с передачей двух аргументов.

namespace task03
{
class TwoBox
{
    int firstBox;
    int secondBox;

    public TwoBox()
    {
        this.firstBox = 0;
        this.secondBox = 0;
    }

    public TwoBox(int a)
    {
        this.firstBox = a;
        this.secondBox = firstBox * 2;
    }

    public TwoBox(int a, int b)
    {
        this.firstBox = a;
        this.secondBox = b;
    }

    public void ShowObject()
    {
        Console.WriteLine($"Первое поле объекта равно: {this.firstBox}.");
        Console.WriteLine($"Второе поле объекта равно: {this.secondBox}.");
    }
}

class Program

{
    static void Main(string[] args)
    {
        
    
    TwoBox A = new TwoBox();
    TwoBox B = new TwoBox(8, 4);
    TwoBox C = new TwoBox(9);
    A.ShowObject();
    B.ShowObject();
    C.ShowObject();
    }
}

}