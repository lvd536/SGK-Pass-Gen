Random random = new Random();

string[] rndstrLang = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"};
string[] rndstrSimv = new string[] { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "=", "+", "[", "]", ";", "'", ",", ".", "/", "|", "?"};

Console.Write("Выберите какой тип генерации вам подходит (1 - only Login | 2 - only Pass | 3 - All) : ");
int input = Convert.ToInt32(Console.ReadLine());

switch (input)
{
    case 1:
        
        Console.Write("Укажите кол-во букв в Логине: ");
        int tryesLog = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Использовать символы в генерации? Y - Yes | N - No");
        string symbols = Console.ReadLine();
        
        for (int i = 0; i < tryesLog; i++)
        {
            int rndnumgen = random.Next(0, 25);
            int rndsymbgen = random.Next(0, 21);
            string randmassiveLang = rndstrLang[rndnumgen];
            string randmassiveSymb = rndstrSimv[rndsymbgen];
    
            
            Console.Write(randmassiveLang);
            if (symbols == "Y")
            {
                Console.Write(randmassiveSymb);
            }
            else {}
        }
        
        break;
    
    case 2:
        
        Console.Write("Укажите кол-во букв в пароле: ");
        int tryesPass = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Использовать символы в генерации? Y - Yes | N - No");
        symbols = Console.ReadLine();

        for (int i = 0; i < tryesPass; i++)
        {
            int rndnumgen = random.Next(0, 25);
            int rndsymbgen = random.Next(0, 21);
            string randmassiveLang = rndstrLang[rndnumgen];
            string randmassiveSymb = rndstrSimv[rndsymbgen];
    
            Console.Write(randmassiveLang);
            if (symbols == "Y")
            {
                Console.Write(randmassiveSymb);
            }
            else {}
        }
        
        break;
    
    case 3:
        
        Console.Write("Укажите кол-во букв в Логине: ");
        tryesLog = Convert.ToInt32(Console.ReadLine());

        Console.Write("Укажите кол-во букв в пароле: ");
        tryesPass = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Использовать символы в генерации? Y - Yes | N - No");
        symbols = Console.ReadLine();
        
        Console.Write("Ваш Логин: ");
        for (int i = 0; i < tryesLog; i++)
        {
            int rndnumgen = random.Next(0, 25);
            int rndsymbgen = random.Next(0, 21);
            string randmassiveLang = rndstrLang[rndnumgen];
            string randmassiveSymb = rndstrSimv[rndsymbgen];
    
            
            Console.Write(randmassiveLang);
            if (symbols == "Y")
            {
                Console.Write(randmassiveSymb);
            }
            else {}
        }
        
        Console.Write("\nВаш Пароль: ");
        for (int i = 0; i < tryesPass; i++)
        {
            int rndnumgen = random.Next(0, 25);
            int rndsymbgen = random.Next(0, 21);
            string randmassiveLang = rndstrLang[rndnumgen];
            string randmassiveSymb = rndstrSimv[rndsymbgen];
    
            Console.Write(randmassiveLang);
            if (symbols == "Y")
            {
                Console.Write(randmassiveSymb);
            }
            else {}
        }
        
        break;
    
    default:
        Console.WriteLine("Вы ввели неверный символ.");
        break;
}