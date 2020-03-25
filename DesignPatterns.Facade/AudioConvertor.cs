using DesignPatterns.Facade.VideoAudioLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class AudioConvertor
    {
        public AudioFile Convert(string fileName, string format)
        {
            var file = new AudioFile(fileName);
            var sourceCode = CodecFactory.Extract(file);
            Console.WriteLine(sourceCode);

            // you could implement switch case for different formats
            if (format == "mp3")
            {
                var destinationCodec = new MP3CompressionCodec();
                var buffer = BitrateReader.read(fileName, sourceCode);
                Console.WriteLine(buffer);
                var result = BitrateReader.convert(buffer, destinationCodec);
                Console.WriteLine(result);
                result = (new AudioMixer()).fix(result);
                Console.WriteLine(result);
                Console.WriteLine("finishing your Audio convertor");
                return new AudioFile(result);
            }
            Console.WriteLine("can't convert undefined format");
            return file;
        }

    }
}
