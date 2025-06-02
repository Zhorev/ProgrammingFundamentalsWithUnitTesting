char letter = char.Parse(Console.ReadLine());

if ("aeiouAEIOU".IndexOf(letter) >= 0)
{
    Console.WriteLine("Vowel");
}
else if (char.IsLetter(letter))
{
    Console.WriteLine("Consonant");
}
