using System;

namespace _31._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Play(player);
        }
        public static void Play(IpIr player)
        {
            player.play();
            player.pause();
            player.stop();
            player.record();
            player.pause2();
            player.stop2();

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
           void record();
           void pause2(); 
           void stop2();
        }
        interface IpIr : IPlayable, IRecodable
        {

        }
        class Player : IpIr
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
            public void record()
            {
              Console.WriteLine("Record");
            }
            public void pause2()
            {
               Console.WriteLine("Pause2");
            }
            public void stop2()
            {
             Console.WriteLine("Stop2");       
            }
            
        }
}
