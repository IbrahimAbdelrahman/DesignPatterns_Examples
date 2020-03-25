using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.VideoAudioLibrary
{
    // These are some of the classes of a complex 3rd-party video
    // conversion framework. We don't control that code, therefore
    // can't simplify it.
    public class VideoFile
    {
        private string fileName;

        public VideoFile(string fileName)
        {
            this.fileName = fileName;
        }
    }

    public class AudioFile
    {
        private string fileName;
            
        public AudioFile(string fileName)
        {
            this.fileName = fileName;
        }
    }
    public class OggCompressionCodec
    {

    }


    public class MPEG4CompressionCodec
    {

    }

    public class MP3CompressionCodec
    {

    }


    public class CodecFactory
    {
        public  static string Extract(VideoFile file)
        {
            return "your video binary source code";
        }
        public static string Extract(AudioFile file)
        {
            return "your audio binary source code";
        }

    }

    public class BitrateReader
    {
        public static string read(string filename, string sourceCodec)
        {
            return "return buffer with filename and sourceCode";
        }

        public static string convert(string buffer, object destinationCodec)
        {
            return "return new Audio/vido result  ";
        }
    }

    public class AudioMixer
    {
        public string fix(string result)
        {
            return "new fixed result";
        }
    }

    public class SourceCode
    {
    }
}
