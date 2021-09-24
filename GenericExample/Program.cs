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


            //create a new instance of KeyValuePair class
            KeyValuePair<int, String> kvp1 = new KeyValuePair<int, string>();

            //set the key
            kvp1.key = 1;

            //set the value
            kvp1.value = "Shihab";

            //print the set key value
            Console.WriteLine(kvp1.key + " " + kvp1.value);

            //create a another new instance of Keyvaluepair class
            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();

            //set key
            kvp2.key = "IT";

            //set value
            kvp2.value = "Programmer";

            //print the set key value
            Console.WriteLine(kvp2.key + " " + kvp2.value);

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