
Console.WriteLine("Enter your firstname:");
string username = Console.ReadLine().Trim();

Console.WriteLine($"Your name has {username.Length} letters.");
Console.WriteLine($"The last letter in your name is: {username[username.Length - 1]}.");

//a- counter

int counter = 0;

for (int i = 0; i < username.Length; i++)
{
    if (username[i] =='a')
    {
        counter++;
    }
}

Console.WriteLine($"Your name has {counter} 'a'-letters.");

string updatedUserName = username.Replace('a','4').Replace('e','3');
Console.WriteLine($"The updated username is {updatedUserName}.");