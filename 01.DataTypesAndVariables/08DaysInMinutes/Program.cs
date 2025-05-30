using System.Numerics;

BigInteger days = BigInteger.Parse(Console.ReadLine()!);
BigInteger minutes = days * 24 * 60;

Console.WriteLine($"Minutes = {minutes}");