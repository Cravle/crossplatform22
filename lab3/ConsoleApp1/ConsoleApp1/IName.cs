using System;


namespace ConsoleApp1
{
    interface IName : IComparable
    {
        string Name { get; set; }
    }
    interface IName<T>: IComparable, IComparable<T>
    {
       T Name { get; set; }
    }
}
