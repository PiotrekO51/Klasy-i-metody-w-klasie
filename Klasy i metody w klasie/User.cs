namespace Klasy_i_metody_w_klasie;

public class User
{
    public static double Pi = Math.PI;
    private List<int> score = new();

  
    public User(string login)
    {
        this.Login = login;
        
    }
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }

    public string Login { get; private set; }
    public string Password { get; private set; }

    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }



    public void AddScore(int number)
    {
        this.score.Add(number);
  
    }

    public void VueScore()
    {
        foreach (var scor in score)
        {
            Console.WriteLine(scor);
        }
    }
}
