using System;

namespace _31._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playing = new Player();
            Console.Write("pop music:");
            playing.play();
            Console.Write("pop music:");
            playing.pause();
            Console.Write("pop music:");
            playing.stop();
            Console.Write("video:");
            playing.Record();
            Console.Write("video:");
            playing.Pause();
            Console.Write("video:");
            playing.Stop();
        }
      
    }    
        interface  IPlayable
        {
            void play();
            void pause();  
            void stop();

        }
        interface IRecodable
        {
           void Record();
           void Pause(); 
           void Stop();
        }
        class Player : IPlayable, IRecodable
        {
            public void play()
            {
                Console.WriteLine("Play");
            }
            public void pause()
            {
               Console.WriteLine("Pause");
            }
            public void stop()
            {
             Console.WriteLine("Stop");       
            }
            public void Record()
            {
              Console.WriteLine("Record");
            }
            public void Pause()
            {
               Console.WriteLine("Pause");
            }
            public void Stop()
            {
             Console.WriteLine("Stop");       
            }
            
        }
}
