Random random = new Random();

string[] rndstrLang = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"};
//string[] rndstrSimv = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"};




Console.Write("Укажите кол-во букв в пароле: ");
int tryes = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < tryes; i++)
{
    int rndnumgen = random.Next(0, 25);
    string randmassive = rndstrLang[rndnumgen];
    
    Console.Write(randmassive);
}

