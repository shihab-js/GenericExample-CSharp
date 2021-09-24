using System;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}

//new DataStore<T> class
class DataStore<T>
{
    public T Data { get; set; }
}