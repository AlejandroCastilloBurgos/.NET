using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Media
    {
        private int parentRate;

        public string title { get; set; }

        public virtual void play()
        {
            Console.WriteLine($"Playing {title}");
        }

        protected bool ThisContentIsCorrectForThisAge(int age)
        {
            if (age >= parentRate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object obj)
        {
            var mediaObj = (Media)obj;

            if(mediaObj.title == this.title)
            {
                return true;
            }
            else
            {
                return false;         
            }
        }
    }
}
