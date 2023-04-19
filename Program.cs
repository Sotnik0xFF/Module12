namespace Module12;

internal class Program
{
    static User[] users = new[]
    {
        new User(login: "User1", name: "UserName1", isPremium: true),
        new User(login: "User2", name: "UserName2", isPremium: false),
        new User(login: "User3", name: "UserName3", isPremium: true)
    };

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        for (int i = 0; i < users.Length; i++) 
        {
            Console.WriteLine($"Логин: {users[i].Login}");
            Console.WriteLine($"Привет {users[i].Name}!!!");
            if (!users[i].IsPremium)
            {
                ShowAds();
            }
            Console.WriteLine("*************");
        }
        Console.ReadKey();
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        // Остановка на 1 с
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        // Остановка на 2 с
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        // Остановка на 3 с
        Thread.Sleep(3000);
    }
}