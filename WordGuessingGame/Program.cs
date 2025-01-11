//Word Guessing Game
//------------------------------------------------------------------------------------------
Console.WriteLine("Word Guessing Game...Enjoy!\n ");
Console.Write("what is your name? ");
string user_name = Console.ReadLine();
Console.WriteLine("Good Luck! " + user_name + "\n");
string[] words = { "PYTHON", "JAVA", "SWIFT", "PHP", "IOS", "ANDROID", "APPLE" };
Console.WriteLine("Guessing the characters. \n");
Random turn = new Random();
int computer = turn.Next(0, words.Length);
string the_word = words[computer];
string spaces = "";
for (int i = 0; i < the_word.Length; i++)
{
    spaces += '-';
}
int num_Guessing = 0;
if (the_word.Length <= 4)
{ num_Guessing = the_word.Length + 2; }
else if (the_word.Length <= 7)
{ num_Guessing = the_word.Length + 3; }
else if (the_word.Length >= 7)
{ num_Guessing = the_word.Length + 4; }
Console.WriteLine("\n" + spaces + "\n");
int conter_Gues = 0;
for (int Gues = 0; Gues < num_Guessing; Gues++)
{
    Console.Write("Guessing the character: ");
    char character = char.ToUpper(Console.ReadLine()[0]);
    string Guessing_char = "";
    for (int sp = 0; sp < spaces.Length; sp++)
    {
        if (the_word[sp] == character)
        {
            Guessing_char += the_word[sp];
        }
        else { Guessing_char += spaces[sp]; }
    }
    spaces = Guessing_char;
    Console.WriteLine(spaces);
    if (spaces == the_word)
    {
        Console.WriteLine("You Wins!!\n");
        Console.WriteLine("\n GOOD BYE..\n");
        break;
    }
    conter_Gues++;
}
if (conter_Gues == num_Guessing && spaces != the_word)
{
    Console.WriteLine("\n you lost... number of attempts has expired!. \n");
    Console.WriteLine("\n GOOD BYE..\n");
}