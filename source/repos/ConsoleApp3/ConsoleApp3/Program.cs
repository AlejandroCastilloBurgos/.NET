using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Song song = new Song(); //1
            song.title = "dark side of moon";
            song.seconds = 500;
            song.position = new ShelvePosition(0,0);
            song.play();

            Song song2 = new Song(); //2
            song2.title = "Dark side of moon";
            song2.seconds = 200;
            song.position = new ShelvePosition(1, 0);

            PlayList<Song> playListSongs = new PlayList<Song>();

            playListSongs.Add(song);
            playListSongs.Add(song2);
            //no es necesario poner <song> por inferencia
            WriteLineSpecial<Song>(song, "Start with", "enjoy");

            ListExplanation();
            StackExplanation();
            QueueExplanation();

          Console.WriteLine(song2.ToString());



            Console.ReadKey();
        }

        private static void QueueExplanation()
        {
            Queue<int> queueNumbers = new Queue<int>();
            queueNumbers.Enqueue(1);
            int number = queueNumbers.Dequeue();
        }
        private static void DictionaryExplanation()
        {
            Dictionary<String, Client> clients = new Dictionary<string, Client>();

                            
            clients.Add("000000D", new Client() { name = "Jose Manuel" });


            if (!clients.ContainsKey("000000D") )
            {
                clients.Add("000000D", new Client() { name = "Jose Manuel" });

            }
            var elements = new List<KeyValuePair<String, Client>>();
            elements.Add(new KeyValuePair<string, Client>("001", new Client()));
            elements.Add(new KeyValuePair<string, Client>("002", new Client()));

            //Utils.AddRangeDictionary(clients, elements);
            clients.AddRange(elements);
        }

        private static void StackExplanation()
        {
            Stack<Song> salesSongs = new Stack<Song>();
            salesSongs.Push(new Song());
            salesSongs.Pop();
        }

        private static void ListExplanation()
        {
            List<int> numbers = new List<int>();

            numbers.Add(0);
            //numbers.count
        }

        static void WriteLineSpecial<T>(T data, string prefix, string suffix)
        {
            Console.WriteLine($"{prefix} {data} {suffix}"); 
        }
    }
}
