using System.IO;
using Microsoft.AspNetCore.Hosting;
using codenames.Models;

namespace codenames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck newDeck = new Deck("red");
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
