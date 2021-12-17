using System;

namespace ProfessionalLesson7Task2
{
    //    Задание 2
    //Создайте класс и примените к его методам атрибут Obsolete сначала в форме, просто
    //выводящей предупреждение, а затем в форме, препятствующей компиляции.
    //Продемонстрируйте работу атрибута на примере вызова данных методов.

    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.ObsoleteMehtodWarning();
            //m.ObsoleteMehtodError();
        }
    }
}
