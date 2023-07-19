// This is the list that will be tested using fuzzing.
// This list uses fruit as an example for the fuzz test.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

List<string> fruits = new List<string>();

fruits.Add("Apples");
fruits.Add("Dragon Fruit");
fruits.Add("Kiwis");
fruits.Add("Oranges");
fruits.Add("Apricots");
fruits.Add("Mangos");
fruits.Add("Raspberries");

Console.WriteLine();

// The fuzz test

fruits.Reverse();
fruits.Reverse();
fruits.Reverse();

Debug.Assert(fruits.Count == 7);

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}



// The actual test class.
// Not recommended to use C# Unit Test package because we are conducting a dynamic test, not a static test.

namespace FruitFuzz
{

public class FruitFuzzing 
    {
        string fuzz = null;
        string tripleReverseTest = "A list reversed three times shall return the altered list";

    }

}
