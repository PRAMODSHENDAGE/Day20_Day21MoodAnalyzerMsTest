// See https://aka.ms/new-console-template for more information

using Day20_MoodAnalyzer;

Console.WriteLine("Mood Analyser");
HappyOrSad happySad = new HappyOrSad("I am in Sad a Mood");
Console.WriteLine(happySad.AnalysingMood());

Console.WriteLine("------");

Console.WriteLine();
InvalidMood invalidMood = new InvalidMood(" ");
Console.WriteLine(invalidMood.AnalysingMood());
