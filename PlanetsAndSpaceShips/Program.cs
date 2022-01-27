// See https://aka.ms/new-console-template for more information

List<string> planetList = new List<string>() { "Mercury", "Mars" };

planetList.Add("Jupiter");
planetList.Add("Saturn");

List<string> planetList2 = new List<string>() { "Uranus", "Neptune" };

planetList.AddRange(planetList2);

planetList.Insert(1, "Venus");
planetList.Insert(2, "Earth");
planetList.Add("Pluto");

var rockyPlanets = planetList.GetRange(0,4);

planetList.Remove("Pluto");

Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

List<string> messenger = new List<string>();

messenger.Add("Mercury");
messenger.Add("Venus");
messenger.Add("Earth");

List<string> voyager2 = new List<string>();

voyager2.Add("Jupiter");
voyager2.Add("Saturn");
voyager2.Add("Uranus");
voyager2.Add("Neptune");

List<string> pioneer11 = new List<string>();

pioneer11.Add("Jupiter");
pioneer11.Add("Saturn");

dictionary.Add("Messenger", messenger);
dictionary.Add("Voyager 2", voyager2);
dictionary.Add("Pioneer 11", pioneer11);

//Iterate over your list of planets from above, and inside that loop,
//iterate over the dictionary. Write to the console, for each planet,
//which satellites have visited which planet.

foreach (var planet in rockyPlanets)
{
 
    foreach (var item in dictionary)
    {
        Console.WriteLine($"{planet}: {item.Key}");
    }
}

Console.WriteLine("__________________");

foreach (var planet in planetList)
{
    foreach (var item in dictionary)
    {
        Console.WriteLine($"{planet}: {item.Key}");
    }
}