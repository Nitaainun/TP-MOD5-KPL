using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302200019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo x = new SayaTubeVideo("JUDUL");
            Console.WriteLine("Tutorial Design By Contract – Nita Ainun Nisa");
            x.PrintVideoDetails();
            x.IncreasePlayCount(5);
            x.PrintVideoDetails();
        }

        class SayaTubeVideo
        {
            public int id;
            private static int playCount;
            public string title;
            public int playAcount = 0;
            private static int count;

            static SayaTubeVideo(string title)
            {
                Contract.Requires(title != null);
                Contract.Requires(title.Length < 100);

                SayaTubeVideo sayaTubeVideo = SayaTubeVideo;
                sayaTubeVideo.title = title;
                Random random = new Random();
                id = random.Next(0, 100000);
                playCount = 0;
            }

            public static void IncreasePlayCount(int playCount)
            {
               
            }

            public static string GetTitle()
            {
                return title;
            }

            public static void PrintVideoDetail(string title)
            {
                Console.WriteLine(id);
                Console.WriteLine(title);
                Console.WriteLine(playCount);
            }
        }
    }
}
