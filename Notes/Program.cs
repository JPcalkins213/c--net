using System;
using System.Collections.Generic;

// namespace Notes
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }


// if and elseif statements
// int numRings = 5;
// if(numRings>=5)
// {
//     Console.WriteLine("You are welcome to join the party");
// }
// else if
// {
//     Console.WriteLine($"Decent...but {numRings} rings aren't enough")
// }
// else
// {
//     Console.WriteLine("Go win some more rings")
// }

//loop from 1 to 5 including 5

// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine(i);
// }

// //loop from 1 to 5 excluding 5 

// for (int i = 1; i < 5; i++)
// {
//     Console.WriteLine(i);
// }

//while loops

// int i = 1;
// while(i<6)
// {
//     Console.WriteLine(i);
//     i = i+1;
// }

//Generating random values
//first create a randome object

// Random rand = new Random();
//to generate 10 random numbers between 8 and 2 we call .Next(2,8) in a for loop
// for (int val = 0; val < 10; val++)
// {
//     Console.WriteLine(rand.Next(2,8));
// }

//ITERATING THROUGH ARRAYS

// string[] myCars = new string[]{"chavy c10", "mitsubishi eclipse", "chevy malibu", "ford mustang", "chevy impala"};

// for (int i = 0; i < myCars.Length; i++)
// {
//     Console.WriteLine($"I own a {myCars[i]}");
// }

//FOREACH LOOP
//this just needs a variable to temp hold each value in the array and it will continue to loop from there

// string[] myCars = new string[]{"chavy c10", "mitsubishi eclipse", "chevy malibu", "ford mustang", "chevy impala"};
// foreach(string car in myCars)
// {
//     Console.WriteLine($"I own a {car}");
// }

//LISTS
// to use lists we have to add the "using System.Collections.Generic" Library at the top
//from there we can instantiate and then add to the list

//initializing an empty list of Mototcycle manufactures
// List<string> bikes = new List<string>();
// //using the add function in a similar fashion to push in js
// bikes.Add("kawasaki");
// bikes.Add("triumph");
// bikes.Add("BMW");
// bikes.Add("moto guzzi");
// bikes.Add("harley");
// bikes.Add("suzuki");
//accessing certain parts of the list is no different than you would an array in py or js

// Console.WriteLine(bikes[2]);
// Console.WriteLine($"we currently know of {bikes.Count} motorcycle manufacterers.");

//ITTERATING THROOGH A LIST
//no different than how you would iterate through an array

// Console.WriteLine("the current manufactures weve seen are");
// for(var i = 0; i< bikes.Count; i++)
// {
//     Console.WriteLine("-" + bikes[i]);
// }
// //adding to the list
// bikes.Insert(2, "Yamaha");
// //removing from the list
// bikes.Remove("suzuki");
// bikes.Remove("Yamaha");
// Console.WriteLine("list of non japanese manufactures");
// foreach(string manu in bikes)
// {
//     Console.WriteLine("-" + manu);
// }

Dictionary<string, string> profile = new Dictionary<string, string>();
profile.Add("name", "speros");
profile.Add("language", "cSharp");
profile.Add("Location","Texas");
Console.WriteLine("instructor Profile");
Console.WriteLine("name -" + profile["name"]);
Console.WriteLine("from - " + profile["Location"]);
Console.WriteLine("favorite language - " + profile["language"]);

//ITERATING THROUGH A DICTIONARY WITH FOREACH
//this must be changed a little because of how a dictionary is layed out with key value pairs so the temp variable that holds the value must me changed slightly 

foreach(KeyValuePair<string, string> entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}

//another way of doing this

foreach(var entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}

//saves time but reduces clarity
// to only be used sparingly when the type of variable can easily be deduced