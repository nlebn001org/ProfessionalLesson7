using System;
using System.Reflection;

namespace ProfessionalLesson7Task1
{

    //    Создайте пользовательский атрибут AccessLevelAttribute, позволяющий определить
    //уровень доступа пользователя к системе.Сформируйте состав сотрудников некоторой фирмы
    //в виде набора классов, например, Manager, Programmer, Director.При помощи атрибута
    //AccessLevelAttribute распределите уровни доступа персонала и отобразите на экране
    //реакцию системы на попытку каждого сотрудника получить доступ в защищенную секцию.

    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker(1, "Alex", "May");
            Manager m = new Manager(1, "Alex", "May");
            Programmer p = new Programmer(1, "Alex", "May");
            AuthorizationManager a = AuthorizationManager.GetAuthorizationManager();
            Console.WriteLine(a.HasAccess(w));
            Console.WriteLine(a.HasAccess(m));
            Console.WriteLine(a.HasAccess(p));
        }

    }
}
