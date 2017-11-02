using Sillycore;
using Sillycore.Web;

namespace Joker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SillycoreAppBuilder.Instance
                .UseUtcTimes()
                .UseWebApi("Joker")
                .Build();
        }
    }
}
