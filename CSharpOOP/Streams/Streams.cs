using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP.Streams
{
  public static class Streams
  {

    public static void StreamWriterReader()
    {
      // Stream işlemleri GC tarafından direk olarak yönetilemediğinden disposable olarak tanımı olması sebebi ile using kod bloğu içerisine yazılır.

      try
      {
        using (var stream  = new StreamWriter("sample.txt"))
        {
          stream.WriteLine("Örnek Satır1");
          stream.WriteLine("Örnek Satır2");
        }

        using (var stream = new StreamReader("sample.txt"))
        {
          //string _data = "";

          //while(stream.ReadLine() != "")
          //{
          //  _data += stream.ReadLine();
          //}

          string data = stream.ReadToEnd();
        }

      }
      catch (Exception)
      {

        throw;
      }


    }


    // txt uzantılı dosya tipi dışındaki dosyaları audio,video,png,xls,word vs gibi dosya tiplerini okumak için ise FileStream sınıfı kullanılır.
    public static void FileStreamWriterReader()
    {
      try
      {
        using (var stream = new FileStream("dosya.bin", FileMode.Create, FileAccess.Write))
        {
          byte[] data = new byte[] { 0x48, 0x65, 0x6C, 0x6C, 0x6F };
          stream.Write(data, 0, data.Count()); // baştan sonra yazdır
        }

        using(var stream = new FileStream("dosya.bin", FileMode.Open, FileAccess.Read))
        {
          byte[] buffer = new byte[500];
          int bufferReads = stream.Read(buffer, 0, 500);

          while (bufferReads > 0)
          {
            string data = Encoding.UTF8.GetString(buffer,0, bufferReads);

          }
        }

      }
      catch (Exception)
      {

        throw;
      }

     

    }

  }
}
