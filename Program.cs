using System.Text.RegularExpressions;

Console.WriteLine("Введите сообщение");
string text = Console.ReadLine();
text = text.ToLower();
Console.WriteLine("Введите слово");
string pattern = @Console.ReadLine();
pattern = pattern.ToLower();
Regex REX = new Regex(pattern, RegexOptions.IgnoreCase);
MatchCollection RTQ = REX.Matches(text);
Console.WriteLine("Количество слов в сообщении = " + RTQ.Count);
Console.ReadLine();