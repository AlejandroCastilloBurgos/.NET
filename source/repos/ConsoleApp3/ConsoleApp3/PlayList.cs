using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{   public class PlayList<T, V, Z>
    {
        //una clase se puede sobrecargar con varios genericos como tupla
    }
    public class PlayList<T>
    {
         ArrayList list = new ArrayList();
        List<T> mediaList = new List<T>();
        public void Add(T media)
        {
            list.Add(media);
        }

        public void PlayAll()
        {
            foreach(T media in list)
            {
                Console.WriteLine(media);
            }
        }
        public void Preview()
        {
            if(mediaList.Count > 0)
            {
                Console.WriteLine(mediaList[0]);
            }
        }
    }

}
