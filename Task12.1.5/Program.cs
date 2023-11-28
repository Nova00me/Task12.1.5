namespace Task12._1._5
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Users = new List<User>()
            {
                new User(){Login = "jane21", Name = "Jane", IsPremium = true },
                new User(){Login = "mark222", Name = "Mark", IsPremium = false },
                new User(){Login = "segei123", Name = "Gosha", IsPremium = true },
                new User(){Login = "kirill23", Name = "Kiril", IsPremium = false }
            };
            for(int i = 0; i < Users.Count; i++)
            {
                if (Users[i].IsPremium == true)
                {
                    Console.WriteLine($"У пользователя {Users[i].Login}, активен премиум\n");
                    
                }
                else
                {
                    Console.WriteLine($"Пользователю {Users[i].Login}, Будет показана реклама");
                    ShowAds();
                    Console.WriteLine();
                }
            }
        }
        private static void ShowAds()
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
}