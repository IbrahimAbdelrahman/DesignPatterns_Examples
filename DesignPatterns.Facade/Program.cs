using System;

namespace DesignPatterns.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var vodioConvertor = new VideoConvertor();
            var mp4File =vodioConvertor.Convert("funny-cats-video.ogg", "mp4");
            Console.ReadLine();

            var audioConvertor = new AudioConvertor();
            var mp3File = audioConvertor.Convert("funny-cats-audio.vlc", "mp3");
            Console.ReadLine();
        }
    }
}
