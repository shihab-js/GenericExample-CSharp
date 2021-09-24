using System;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //create instance of datastore class string type
            DataStore<string> strStore = new DataStore<string>();

            strStore.Data = "Hi, Everyone!";

            //strStrore.Data = 123; //compile time error

            //print the data
            Console.WriteLine(strStore.Data);


            //create instance of datastore class integer type
            DataStore<int> intStore = new DataStore<int>();

            intStore.Data = 123;
            //intStore.Data = "Hi, Everyone!"; //compile time error

            //print the data
            Console.WriteLine(intStore.Data);



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