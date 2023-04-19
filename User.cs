namespace Module12;

internal class User
{
    public User() : this(
        login: String.Empty,
        name: String.Empty,
        isPremium: false)
    {
    }

    public User(string login, string name, bool isPremium)
    {
        Login = login;
        Name = name;
        IsPremium = isPremium;
    }

    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}
