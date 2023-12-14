string[] fruitBasket = { "apples", "bananas", "oranges" };
Console.WriteLine($"There are {fruitBasket.Length} fruits in the basket.");

for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}

fruitBasket[0] = "pine-apples";
fruitBasket[2] = "peaches";

for (int i = 0; i < fruitBasket.Length; i++)
{
    Console.WriteLine(fruitBasket[i]);
}