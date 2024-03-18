using System;

// клас паралелограм
class Parallelogram
{
    //сторона паралелограма
    public double side;
    //висота паралелограма
    public double height;
 
    // метод - Площа паралелограма
    public double Square()
    {
        // перемноження атрібутів між собою, щоб дістатися до атрібуту використовуємо this + крапка
        // викорисвуємо такий підхід, а не щось типу hero.Square() тому ща це опис класу, а не обʼєкт, 
        // тому замість herо. в описі буде this. - це 
        return this.side * this.height;
    }
}

// основна програма
public class Program
{
    static void Main()
    {
        // ініціалізаія обʼєкту, який має клас паралелограм
        Parallelogram myParallelogram = new Parallelogram();
        // завдання його атрибутів, тут вже працює аналог hero.findNearest(),
        // тому що myParallelogram - це вже обʼєкт
        myParallelogram.side = 3.5;
        myParallelogram.height = 1.88;
        // вивод на екран результату роботи методу площа
        Console.WriteLine($"The square of Parallelogram is {myParallelogram.Square()}!");
    }
}