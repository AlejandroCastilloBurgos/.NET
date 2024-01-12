using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Song : Media
    {
        public long seconds { get; set; }
        public ShelvePosition position { get; set; }

        public override void play()
        {
            Console.WriteLine("Increase Volume");
            base.play();

        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return $"Title:{title} Duration: {seconds}";
        }
    }
}
