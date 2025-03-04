using Klasy_i_metody_w_klasie;

string stringDate = GetStringDate("Podaj datę uruchomienia");

Console.WriteLine($"Data uruchomienia: {stringDate}\n" +
    $"");
Console.WriteLine("A teraz wprowadzamy w innej formi: RRRR-MM-DD\n" +
    "");
Thread.Sleep(1000);
Console.Clear();

string GetStringDate(string txt)
{
    string date = string.Empty;
    Console.WriteLine($"{txt}");
    string year = GetYear();
    string month = GetMonth();
    string day = GetDay(month);
    return date = $"{year}-{month}-{day}";
}
string GetYear()
{
    //Console.Clear();
    string year = string.Empty;
    Console.SetCursorPosition(0, 2);
    Console.WriteLine("Rok");
    string year1 = Console.ReadLine();
    int yearNumber = year1.Length;
    if (yearNumber == 4)
    { year = year1; }
    else
    {
        Console.WriteLine($"Nie poprawny format");
    }
    return year;
}
string GetMonth()
{
    string year = string.Empty;
    bool Down = true;
    while (Down)
    {
        Console.Clear();
        //Console.SetCursorPosition(0, 4);
        Console.WriteLine("miesiąc");
        string year1 = Console.ReadLine();
        int monthNumber = year1.Length;
        if ((monthNumber == 1 || monthNumber == 2) && int.TryParse(year1, out int month))
        {
            if (month >= 1 && month <= 12) { year = year1; Down = false; }
            else { Console.WriteLine($"Rok ma 12 miesięcy"); Thread.Sleep(1000); }
        }
        else
        {
            Console.WriteLine("Nie poprawny format");
        }
    }
    return year;
}
string GetDay(string month)
{
    string day = string.Empty;
    bool Down = true;
    while (Down)
    {
        Console.Clear();
        //Console.SetCursorPosition(0, 4);
        int monthNumber = int.Parse(month);

        Console.WriteLine($"dień {((Miesiące)monthNumber - 1).ToString()}");
        string day1 = Console.ReadLine();
        int dayNumber = day1.Length;
        if (dayNumber <= 2 && int.TryParse(day1, out int day2))
        {
            int dayValue = 0;
            int[] dayBoard = { 1, 3, 5, 7, 8, 10, 12 };
            int[] dayBoard2 = { 4, 6, 9, 11 };
            int dayBoard3 = 2;
            for (int i = 0; i <= dayBoard.Length - 1; i++)
            {
                if (dayBoard[i] == monthNumber)
                { dayValue = 31; }
            }

            for (int i = 0; i <= dayBoard2.Length - 1; i++)
            {
                if (dayBoard2[i] == monthNumber)
                { dayValue = 30; }
                else if (monthNumber == 2)
                { dayValue = 28; }
            }

            if (day2 <= dayValue) { day = day1; Down = false; }
            else { Console.WriteLine($"{((Miesiące)monthNumber - 1).ToString()} ma {dayValue}"); Thread.Sleep(1000); }
        }
        else
        {
            Console.WriteLine("Nie poprawny format");
            Thread.Sleep(1000);
        }
    }
    return day;
}
//User user1 = new User("Piotr");
//User user2 = new User("Adrzej");
//User user3 = new User("Krzysztof");
//User user4 = new User("Marta");


//user1.AddScore(5);
//Console.WriteLine("Podaj Ocenę Piotr ");
//string q = Console.ReadLine();
//int i;
//bool result = int.TryParse(q, out i);
//while (true)
//{
//    user1.AddScore(i);
//    Console.WriteLine("podaj wartość");
//    q = Console.ReadLine();
//    if (q =="q")
//    { break; }
//    result = int.TryParse(q, out i);

//}

//var suma = user1.Result;
//Console.WriteLine($"{user1.Login} {suma} ");
//user1.VueScore();
//Console.WriteLine(User.Pi);

