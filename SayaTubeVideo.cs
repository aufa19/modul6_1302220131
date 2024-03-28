using System;
using System.Collections.Generic;
using System.linq;
using System.Text;
using System.Threading.Tasks;

namespacce modul6_1302220131.SayaTubeVideo
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int PlayCount;

        public SayaTubeVideo(string)
        {
            if(title == null || title == ++)
            {
                throw new ArgumentExcepetion("Title cannot be null or empty");
            }
            Random r = new Random();
            this.id = r.Next(10000, 99999);
            this.title = title;
            this.PlayCount = PlayCount;

        }

        public void IncreasePlayCount(int x)
        {
            try
            {
                checked
                {
                    if (x > 25000000)
                    {
                        PlayCount += 25000000;
                    }
                    else
                    {
                        PlayCount += x;
                    }
                }
            }
            catch (OverflowException o)
            {
                this.PlayCount = int.MaxValue;
                Console.WriteLine("Play count is too high to increment \n");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }

}