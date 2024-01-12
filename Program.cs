using System;

class User
{

    public string UserName
    {
        get { return userName; }
        set { userName = value; }
    }

    public int UserId
    {
        get { return userId; }
        set { userId = value; }
    }

    public string UseColor
    {
        get { return useColor; }
        set { userColor = color1; }
    }

    private string userName;
    private int userId;
    private string userColor;


    public User(string name1, int
    Id1, string color1)
    {
        userName = name1;
        userId = Id1;
        userColor = color1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("ella", 234, "white");
        Console.WriteLine(user1.userColor);
    }


}
