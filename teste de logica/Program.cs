using System;
using System.Linq;
class MainClass {
    public static string StringChallenge(string text) {

        Console.WriteLine($"Normal Text: {text}");
        string textInverted = new string(text.Reverse().ToArray());
        Console.WriteLine($"Inverted Text: {textInverted}");
        Console.ReadLine();
        return textInverted;
    }
    static void Main() {
        string text = Console.ReadLine();
        Console.WriteLine(StringChallenge(text));
    }
}