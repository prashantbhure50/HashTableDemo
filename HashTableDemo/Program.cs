﻿using System;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMap<string ,string> hash = new MyMap<string,string>(5);
            hash.Add("0","To");
            hash.Add("1","be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string result = hash.Get("0");
            Console.WriteLine(result);
        }
    }
}
