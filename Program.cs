
using System.Runtime.CompilerServices;

String Svar1 = "";

int Poäng = 0;
Console.WriteLine("Välkommen till en enkel frågesport");
Console.WriteLine("Frågorna kommer vara baserad på skolan och länder");
Console.WriteLine("Goodluck!");
Console.WriteLine("Tryck på ENTER för att fortsätta");
Console.ReadLine();
Console.Clear();


Console.WriteLine("Startpoäng = 1");
Console.WriteLine("Vad är Sveriges Huvudstad?");
Console.WriteLine("A) Stockholm, B) Göteborg, C) Malmö");
Svar1 = Console.ReadLine();
if (Svar1.ToLower() == "a")
{
    Console.WriteLine("Du har rätt! +1 poäng");
    Poäng++;
}
else
{
    Console.WriteLine("Fel!");
}

Console.WriteLine("Tryck på ENTER för att fortsätta");
Console.ReadLine();
Console.Clear();
String Svar2 = "";

Console.WriteLine("Vilka länder ingår i Scandinavia?");
Console.WriteLine("A) Sverige, Danmark, Finland. B) Sverige, Finland, Norge. C) Svergie, Danmark, Norge");
Svar2 = Console.ReadLine();
if (Svar2.ToLower() == "c")
{
    Console.WriteLine("Du har rätt! +1 poäng");
    Poäng++;
}
else
{
    Console.WriteLine("Fel!");
}

Console.WriteLine("Tryck på ENTER för att fortsätta");
Console.ReadLine();
Console.Clear();
String Svar3 = "";

Console.WriteLine("Hur många är det som går i TE25C klassen?");
Console.WriteLine("A) 27. B) 28. C) 30.");
Svar3 = Console.ReadLine();
if (Svar3.ToLower() == "b")
{
    Console.WriteLine("Du har rätt! +1 poäng");
    Poäng++;
}
else
{
    Console.WriteLine("Fel!");
}


Console.WriteLine("Tryck på ENTER för att fortsätta");
Console.ReadLine();
Console.Clear();


String Svar4 = "";

Console.WriteLine("Vilket land har längst kustlinje?");
Console.WriteLine("A) Ryssland B) Chile C) Canada");
Svar4 = Console.ReadLine();
if (Svar4.ToLower() == "c")
{
    Console.WriteLine("Du har rätt! +1 poäng");
    Poäng++;
}
else
{
    Console.WriteLine("Fel!");
}

if (Poäng <= 1) {
    Console.WriteLine("Oj, Det ser ut som du inte har någon kunskap. Eftersom du fick", Poäng, "poäng");
}
else if (Poäng == 2) {
    Console.WriteLine("Du fick hälften rätt! Du har 2 poäng!");
}
else if (Poäng == 3) {
    Console.WriteLine("Så nära att få alla rätt, försök igen så kommer du få alla rätt! Du har", Poäng, "poäng");
}
else {
    Console.WriteLine("Du är väldigt smart, Du fick all rätt! Du fick", Poäng, "poäng");
}
    

Console.ReadLine();
 
 

