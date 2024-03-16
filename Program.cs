using System;

namespace exerciseOne
{
    class Program
    {
        // Declaring the delegate
        public delegate void SongDelegate();

        // Class containing the song methods
        public class HereComesTheSun
        {
            public static void Chorus()
            {
                Console.Write("Here comes the sun, doo-doo-doo-doo\r\n");
                Console.WriteLine("Here comes the sun, and I say\r\nIt's alright");
                Console.WriteLine();
            }

            public static void Chorus2()
            {
                Console.WriteLine("Here comes the sun\r\nHere comes the sun, and I say\r\nIt's alright");
                Console.WriteLine();
                Console.Write("Sun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\n");
                Console.Write("Sun, sun, sun, here it comes\r\nSun, sun, sun, here it comes\r\n");
                Console.WriteLine("Sun, sun, sun, here it comes");
                Console.WriteLine();
            }

            public static void Verse1()
            {
                Console.Write("Little darlin', it's been a long, cold, lonely winter\r\n");
                Console.WriteLine("Little darlin', it feels like years since it's been here");
                Console.WriteLine();
            }

            public static void Verse2()
            {
                Console.Write("Little darlin', the smile's returning to their faces\r\n");
                Console.WriteLine("Little darlin', it seems like years since it's been here");
                Console.WriteLine();
            }

            public static void Verse3()
            {
                Console.Write("Little darlin', I feel that ice is slowly melting\r\n");
                Console.WriteLine("Little darlin', it seems like years since it's been clear");
                Console.WriteLine();
            }

            public static void End()
            {
                Console.WriteLine("It's alright");
            }
        }

        static void Main(string[] args)
        {
            // Instantiate the delegate
            SongDelegate songDelegate = HereComesTheSun.Chorus;
            songDelegate += HereComesTheSun.Verse1;
            songDelegate += HereComesTheSun.Chorus;
            songDelegate += HereComesTheSun.Verse2;
            songDelegate += HereComesTheSun.Chorus2;
            songDelegate += HereComesTheSun.Verse3;
            songDelegate += HereComesTheSun.Chorus;
            songDelegate += HereComesTheSun.Chorus;
            songDelegate += HereComesTheSun.End;

            // Invoke the multicast delegate
            songDelegate();
        }
    }
}
