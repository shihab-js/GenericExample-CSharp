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

//Another class KeyValuePair Class
class KeyValuePair<TKey, TValue>
{
    public TKey key { get; set; }
    public TValue value { get; set; }

}